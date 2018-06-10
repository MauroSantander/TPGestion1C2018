/*SELECT * FROM gd_esquema.Maestra*/
CREATE TABLE [PISOS_PICADOS].Rol
(
idRol INT PRIMARY KEY IDENTITY,
nombreRol VARCHAR(255),
estado BIT DEFAULT 1
)

CREATE TABLE [PISOS_PICADOS].Pais
(
idPais INT PRIMARY KEY IDENTITY,
nombrePais VARCHAR(255)
)

CREATE TABLE [PISOS_PICADOS].Usuario
(
idUsuario INT PRIMARY KEY IDENTITY,
nombre VARCHAR(255),
apellido VARCHAR(255),
mail VARCHAR(255),
telefono VARCHAR(255) DEFAULT NULL,
calle VARCHAR(255),
nroCalle INT,
localidad VARCHAR(255) DEFAULT NULL,
pais INT REFERENCES [PISOS_PICADOS].Pais,
tipoIdentificacion VARCHAR(255) DEFAULT 'Pasaporte',
numeroIdentificacion INT,
fechaNacimiento DATE,
estado BIT DEFAULT 1
)

CREATE TABLE [PISOS_PICADOS].Cliente
(
idUsuario INT PRIMARY KEY REFERENCES [PISOS_PICADOS].Usuario(idUsuario),
nacionalidad VARCHAR(255) DEFAULT 'ARGENTINO'
)

CREATE TABLE [PISOS_PICADOS].Empleado
(
idUsuario INT PRIMARY KEY REFERENCES [PISOS_PICADOS].Usuario(idUsuario),
usuario VARCHAR(255),
contraseña VARCHAR(255)
)

CREATE TABLE [PISOS_PICADOS].Hotel
(
idHotel INT PRIMARY KEY IDENTITY,
nombre VARCHAR(255) DEFAULT NULL,
mail VARCHAR(255) DEFAULT NULL,
telefono VARCHAR(255) DEFAULT NULL,
calle VARCHAR(255),
nroCalle INT,
ciudad VARCHAR(255),
pais INT REFERENCES [PISOS_PICADOS].Pais DEFAULT NULL,
fechaCreacion DATE DEFAULT NULL,
estrellas INT
)

CREATE TABLE [PISOS_PICADOS].EmpleadoxHotel
(
idUsuario INT REFERENCES [PISOS_PICADOS].Empleado,
idHotel INT REFERENCES [PISOS_PICADOS].Hotel
PRIMARY KEY (idUsuario, idHotel)
)

CREATE TABLE [PISOS_PICADOS].Regimen
(
codigoRegimen INT PRIMARY KEY IDENTITY,
nombre VARCHAR(255) DEFAULT NULL,
descripcion VARCHAR(255),
precioBase NUMERIC(6,2),
estado BIT DEFAULT 1
)

CREATE TABLE [PISOS_PICADOS].RegimenxHotel
(
codigoRegimen INT REFERENCES [PISOS_PICADOS].Regimen,
idHotel INT REFERENCES [PISOS_PICADOS].Hotel
PRIMARY KEY (codigoRegimen, idHotel)
)

CREATE TABLE [PISOS_PICADOS].Tipo
(
idTipo INT PRIMARY KEY IDENTITY,
tipoCamas VARCHAR(255),
porcentual NUMERIC(3,2)
)

CREATE TABLE [PISOS_PICADOS].Habitacion

(
numero INT,
idHotel INT,
frente CHAR(1),
tipo INT REFERENCES [PISOS_PICADOS].Tipo,
descripcion VARCHAR(255) DEFAULT NULL,
piso INT,
habilitada BIT DEFAULT 1,
PRIMARY KEY (numero, idHotel)
)

CREATE TABLE [PISOS_PICADOS].BajaHabitacion
(
idBaja INT PRIMARY KEY IDENTITY,
numero INT,
idHotel INT REFERENCES [PISOS_PICADOS].Hotel,
fechaIncio DATE,
fechaFin DATE,
FOREIGN KEY (numero, idHotel) REFERENCES [PISOS_PICADOS].Habitacion(numero, idHotel)
)

CREATE TABLE [PISOS_PICADOS].Funcionalidad
(
idFuncionalidad INT PRIMARY KEY IDENTITY,
descripcion VARCHAR(255)
)

CREATE TABLE [PISOS_PICADOS].RolxFuncionalidad
(
idRol INT REFERENCES [PISOS_PICADOS].Rol,
idFuncionalidad INT REFERENCES [PISOS_PICADOS].Funcionalidad,
PRIMARY KEY (idRol, idFuncionalidad)
)

CREATE TABLE [PISOS_PICADOS].RolxUsuario
(
idRol INT REFERENCES [PISOS_PICADOS].Rol,
idUsuario INT REFERENCES [PISOS_PICADOS].Usuario,
PRIMARY KEY (idRol, idUsuario)
)

CREATE TABLE [PISOS_PICADOS].Estado
(
idEstado INT PRIMARY KEY IDENTITY,
descripcion VARCHAR(255) DEFAULT NULL
)

CREATE TABLE [PISOS_PICADOS].Reserva
(
codigoReserva INT PRIMARY KEY IDENTITY(10001,1),
fechaRealizacion DATE DEFAULT NULL,
fechaInicio DATE,
fechaFin DATE DEFAULT NULL,
cantidadHuespedes INT DEFAULT NULL,
codigoRegimen INT REFERENCES [PISOS_PICADOS].Regimen,
estado INT REFERENCES [PISOS_PICADOS].Estado DEFAULT NULL,
idCliente INT REFERENCES [PISOS_PICADOS].Cliente
)

CREATE TABLE [PISOS_PICADOS].Modificacion
(
codigoModificacion INT PRIMARY KEY IDENTITY,
reserva INT REFERENCES [PISOS_PICADOS].Reserva,
descripcion VARCHAR(255),
usuario INT REFERENCES [PISOS_PICADOS].Usuario,
fecha DATE
)

CREATE TABLE [PISOS_PICADOS].HabitacionxReserva
(
numero INT,
idHotel INT,
codigoReserva INT REFERENCES [PISOS_PICADOS].Reserva,
FOREIGN KEY (numero, idHotel) REFERENCES [PISOS_PICADOS].Habitacion(numero, idHotel),
PRIMARY KEY (numero, idHotel, codigoReserva)
)

CREATE TABLE [PISOS_PICADOS].CheckIn
(
idCheckIn INT PRIMARY KEY IDENTITY,
fecha DATE,
usuarioEncargado INT REFERENCES [PISOS_PICADOS].Usuario
)

CREATE TABLE [PISOS_PICADOS].CheckOut
(
idCheckOut INT PRIMARY KEY IDENTITY,
fecha DATE,
usuarioEncargado INT REFERENCES [PISOS_PICADOS].Usuario
)

CREATE TABLE [PISOS_PICADOS].Estadia
(
idEstadia INT PRIMARY KEY IDENTITY,
codigoReserva INT REFERENCES [PISOS_PICADOS].Reserva,
idCheckIn INT REFERENCES [PISOS_PICADOS].CheckIn,
idCheckOut INT REFERENCES [PISOS_PICADOS].CheckOut
)

CREATE TABLE [PISOS_PICADOS].Consumible
(
idConsumible INT PRIMARY KEY IDENTITY(2324,1),
precio NUMERIC(6,2),
descripcion VARCHAR(255)
)

CREATE TABLE [PISOS_PICADOS].EstadiaxConsumible
(
idEstadia INT REFERENCES [PISOS_PICADOS].Estadia,
idConsumible INT REFERENCES [PISOS_PICADOS].Consumible,
PRIMARY KEY (idEstadia, idConsumible)
)

CREATE TABLE [PISOS_PICADOS].FormaDePago
(
idFormaDePago INT PRIMARY KEY IDENTITY,
descripcion VARCHAR(255),
numeroTarjeta INT
)

CREATE TABLE [PISOS_PICADOS].Factura
(
numeroFactura INT PRIMARY KEY IDENTITY(2396745,1),
formaDePago INT REFERENCES [PISOS_PICADOS].FormaDePago,
cliente INT REFERENCES [PISOS_PICADOS].Cliente,
total NUMERIC(8,2)
)

CREATE TABLE [PISOS_PICADOS].RenglonFactura
(
numeroRenglon INT,
numeroFactura INT REFERENCES [PISOS_PICADOS].Factura,
consumible INT REFERENCES [PISOS_PICADOS].Consumible,
cantidad INT,
precio NUMERIC(6,2),
total NUMERIC (8,2),
estadia INT REFERENCES [PISOS_PICADOS].Estadia,
PRIMARY KEY (numeroRenglon, numeroFactura)
)

INSERT INTO [PISOS_PICADOS].Pais VALUES('Afganistán');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Islas Gland');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Albania');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Alemania');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Andorra');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Angola');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Anguilla');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Antártida');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Antigua y Barbuda');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Antillas Holandesas');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Arabia Saudí');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Argelia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Argentina');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Armenia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Aruba');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Australia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Austria');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Azerbaiyán');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Bahamas');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Bahréin');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Bangladesh');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Barbados');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Bielorrusia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Bélgica');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Belice');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Benin');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Bermudas');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Bhután');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Bolivia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Bosnia y Herzegovina');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Botsuana');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Isla Bouvet');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Brasil');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Brunéi');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Bulgaria');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Burkina Faso');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Burundi');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Cabo Verde');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Islas Caimán');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Camboya');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Camerún');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Canadá');
INSERT INTO [PISOS_PICADOS].Pais VALUES('República Centroafricana');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Chad');
INSERT INTO [PISOS_PICADOS].Pais VALUES('República Checa');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Chile');
INSERT INTO [PISOS_PICADOS].Pais VALUES('China');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Chipre');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Isla de Navidad');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Ciudad del Vaticano');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Islas Cocos');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Colombia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Comoras');
INSERT INTO [PISOS_PICADOS].Pais VALUES('República Democrática del Congo');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Congo');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Islas Cook');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Corea del Norte');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Corea del Sur');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Costa de Marfil');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Costa Rica');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Croacia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Cuba');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Dinamarca');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Dominica');
INSERT INTO [PISOS_PICADOS].Pais VALUES('República Dominicana');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Ecuador');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Egipto');
INSERT INTO [PISOS_PICADOS].Pais VALUES('El Salvador');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Emiratos Árabes Unidos');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Eritrea');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Eslovaquia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Eslovenia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('España');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Islas ultramarinas de Estados Unidos');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Estados Unidos');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Estonia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Etiopía');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Islas Feroe');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Filipinas');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Finlandia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Fiyi');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Francia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Gabón');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Gambia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Georgia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Islas Georgias del Sur y Sandwich del Sur');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Ghana');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Gibraltar');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Granada');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Grecia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Groenlandia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Guadalupe');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Guam');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Guatemala');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Guayana Francesa');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Guinea');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Guinea Ecuatorial');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Guinea-Bissau');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Guyana');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Haití');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Islas Heard y McDonald');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Honduras');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Hong Kong');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Hungría');
INSERT INTO [PISOS_PICADOS].Pais VALUES('India');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Indonesia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Irán');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Iraq');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Irlanda');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Islandia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Israel');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Italia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Jamaica');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Japón');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Jordania');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Kazajstán');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Kenia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Kirguistán');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Kiribati');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Kuwait');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Laos');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Lesotho');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Letonia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Líbano');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Liberia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Libia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Liechtenstein');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Lituania');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Luxemburgo');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Macao');
INSERT INTO [PISOS_PICADOS].Pais VALUES('ARY Macedonia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Madagascar');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Malasia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Malawi');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Maldivas');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Malí');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Malta');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Islas Malvinas');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Islas Marianas del Norte');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Marruecos');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Islas Marshall');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Martinica');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Mauricio');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Mauritania');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Mayotte');
INSERT INTO [PISOS_PICADOS].Pais VALUES('México');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Micronesia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Moldavia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Mónaco');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Mongolia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Montserrat');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Mozambique');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Myanmar');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Namibia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Nauru');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Nepal');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Nicaragua');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Níger');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Nigeria');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Niue');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Isla Norfolk');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Noruega');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Nueva Caledonia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Nueva Zelanda');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Omán');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Países Bajos');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Pakistán');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Palau');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Palestina');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Panamá');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Papúa Nueva Guinea');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Paraguay');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Perú');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Islas Pitcairn');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Polinesia Francesa');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Polonia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Portugal');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Puerto Rico');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Qatar');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Reino Unido');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Reunión');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Ruanda');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Rumania');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Rusia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Sahara Occidental');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Islas Salomón');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Samoa');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Samoa Americana');
INSERT INTO [PISOS_PICADOS].Pais VALUES('San Cristóbal y Nevis');
INSERT INTO [PISOS_PICADOS].Pais VALUES('San Marino');
INSERT INTO [PISOS_PICADOS].Pais VALUES('San Pedro y Miquelón');
INSERT INTO [PISOS_PICADOS].Pais VALUES('San Vicente y las Granadinas');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Santa Helena');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Santa Lucía');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Santo Tomé y Príncipe');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Senegal');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Serbia y Montenegro');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Seychelles');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Sierra Leona');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Singapur');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Siria');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Somalia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Sri Lanka');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Suazilandia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Sudáfrica');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Sudán');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Suecia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Suiza');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Surinam');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Svalbard y Jan Mayen');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Tailandia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Taiwán');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Tanzania');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Tayikistán');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Territorio Británico del Océano Índico');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Territorios Australes Franceses');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Timor Oriental');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Togo');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Tokelau');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Tonga');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Trinidad y Tobago');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Túnez');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Islas Turcas y Caicos');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Turkmenistán');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Turquía');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Tuvalu');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Ucrania');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Uganda');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Uruguay');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Uzbekistán');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Vanuatu');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Venezuela');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Vietnam');
INSERT INTO [PISOS_PICADOS].Pais VALUES('slas Vírgenes Británicas');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Islas Vírgenes de los Estados Unidos');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Wallis y Futuna');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Yemen');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Yibuti');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Zambia');
INSERT INTO [PISOS_PICADOS].Pais VALUES('Zimbabue');

INSERT INTO [PISOS_PICADOS].Rol VALUES('Administrador', 1);
INSERT INTO [PISOS_PICADOS].Rol VALUES('Recepcionista', 1);
INSERT INTO [PISOS_PICADOS].Rol VALUES('Guest', 1);

INSERT INTO [PISOS_PICADOS].Funcionalidad VALUES('ABM_ROL');
INSERT INTO [PISOS_PICADOS].Funcionalidad VALUES('ABM_USUARIO');
INSERT INTO [PISOS_PICADOS].Funcionalidad VALUES('ABM_CLIENTE');
INSERT INTO [PISOS_PICADOS].Funcionalidad VALUES('ABM_HOTEL');
INSERT INTO [PISOS_PICADOS].Funcionalidad VALUES('ABM_HABITACION');
INSERT INTO [PISOS_PICADOS].Funcionalidad VALUES('ABM_REGIMEN_ESTADIA');
INSERT INTO [PISOS_PICADOS].Funcionalidad VALUES('GENERAR_RESERVA');
INSERT INTO [PISOS_PICADOS].Funcionalidad VALUES('MODIFICAR_RESERVA');
INSERT INTO [PISOS_PICADOS].Funcionalidad VALUES('CANCELAR_RESERVA');
INSERT INTO [PISOS_PICADOS].Funcionalidad VALUES('REGISTRAR_ESTADIA');
INSERT INTO [PISOS_PICADOS].Funcionalidad VALUES('REGISTRAR_CONSUMIBLES');
INSERT INTO [PISOS_PICADOS].Funcionalidad VALUES('FACTURAR_ESTADIA');
INSERT INTO [PISOS_PICADOS].Funcionalidad VALUES('LISTADO_ESTADISTICO');

SET IDENTITY_INSERT [PISOS_PICADOS].Usuario ON

INSERT INTO [PISOS_PICADOS].Usuario (idUsuario, nombre, apellido, mail, calle, nroCalle, pais, numeroIdentificacion, fechaNacimiento) 
VALUES (96945,'admin','admin','admin@gmail.com','admincalle',123,13,12345678,'1997-05-01');

SET IDENTITY_INSERT [PISOS_PICADOS].Usuario OFF

INSERT INTO [PISOS_PICADOS].Empleado (idUsuario, usuario, contraseña) VALUES (96945,'admin','admin');

SET IDENTITY_INSERT [PISOS_PICADOS].Consumible ON

INSERT INTO [PISOS_PICADOS].Consumible (idConsumible, precio, descripcion)
SELECT DISTINCT Consumible_Codigo, Consumible_Precio, Consumible_Descripcion
FROM [gd_esquema].Maestra 
WHERE Consumible_Codigo IS NOT NULL
order by Consumible_Codigo;

SET IDENTITY_INSERT [PISOS_PICADOS].Consumible OFF

INSERT INTO [PISOS_PICADOS].Regimen(descripcion, precioBase)
SELECT DISTINCT Regimen_Descripcion,Regimen_Precio 
FROM [gd_esquema].Maestra;

INSERT INTO [PISOS_PICADOS].Tipo 
SELECT DISTINCT Habitacion_Tipo_Descripcion , Habitacion_Tipo_Porcentual 
FROM [gd_esquema].Maestra;

INSERT INTO [PISOS_PICADOS].Usuario 
(nombre, apellido, mail, calle, numeroIdentificacion, fechaNacimiento)
SELECT DISTINCT
Cliente_Nombre, Cliente_Apellido, Cliente_Mail, Cliente_Dom_Calle,
Cliente_Pasaporte_Nro, Cliente_Fecha_Nac
FROM [gd_esquema].Maestra;

UPDATE [PISOS_PICADOS].Usuario SET pais = 13
WHERE pais IS NULL;

INSERT INTO [PISOS_PICADOS].Cliente 
SELECT DISTINCT Usuario.idUsuario, Cliente_Nacionalidad
FROM [gd_esquema].Maestra, [PISOS_PICADOS].Usuario
WHERE Usuario.numeroIdentificacion = Cliente_Pasaporte_Nro;

INSERT INTO [PISOS_PICADOS].Hotel (calle, nroCalle, ciudad, estrellas)
SELECT DISTINCT Hotel_Calle, Hotel_Nro_Calle, Hotel_Ciudad, Hotel_CantEstrella
FROM [gd_esquema].Maestra;

UPDATE [PISOS_PICADOS].Hotel SET pais = 13
WHERE pais IS NULL;

INSERT INTO [PISOS_PICADOS].Habitacion (numero, idHotel, frente, tipo, piso)
SELECT DISTINCT Habitacion_Numero, [PISOS_PICADOS].Hotel.idHotel,
Habitacion_Frente, idTipo, Habitacion_Piso
FROM [gd_esquema].Maestra, [PISOS_PICADOS].Hotel, [PISOS_PICADOS].Tipo
WHERE ciudad + calle = Hotel_Ciudad + Hotel_Calle and Habitacion_Tipo_Descripcion = tipoCamas;

SET IDENTITY_INSERT [PISOS_PICADOS].Reserva ON

INSERT INTO [PISOS_PICADOS].Reserva (codigoReserva, fechaInicio, codigoRegimen, idCliente)
SELECT DISTINCT Reserva_Codigo, Reserva_Fecha_Inicio, Regimen.codigoRegimen, idUsuario
FROM [gd_esquema].Maestra, [PISOS_PICADOS].Usuario, [PISOS_PICADOS].Regimen
WHERE Usuario.numeroIdentificacion = Cliente_Pasaporte_Nro 
and Usuario.apellido + Usuario.nombre = Cliente_Apellido + Cliente_Nombre
and Regimen.descripcion = Regimen_Descripcion;

SET IDENTITY_INSERT [PISOS_PICADOS].Reserva OFF

INSERT INTO [PISOS_PICADOS].Estado (descripcion) VALUES('Reserva correcta');
INSERT INTO [PISOS_PICADOS].Estado (descripcion) VALUES('Reserva modificada');
INSERT INTO [PISOS_PICADOS].Estado (descripcion) VALUES('Reserva cancelada por recepción');
INSERT INTO [PISOS_PICADOS].Estado (descripcion) VALUES('Reserva modificada por cliente');
INSERT INTO [PISOS_PICADOS].Estado (descripcion) VALUES('Reserva cancelada por No-Show');
INSERT INTO [PISOS_PICADOS].Estado (descripcion) VALUES('Reserva efectivizada');

INSERT INTO [PISOS_PICADOS].EmpleadoxHotel (idUsuario, idHotel) 
SELECT idUsuario, idHotel FROM PISOS_PICADOS.Hotel, PISOS_PICADOS.Empleado

INSERT INTO [PISOS_PICADOS].RegimenxHotel (codigoRegimen, idHotel)
SELECT DISTINCT codigoRegimen, idHotel
FROM [gd_esquema].Maestra, [PISOS_PICADOS].Hotel, [PISOS_PICADOS].Regimen
WHERE descripcion = Regimen_Descripcion and Hotel_Calle + Hotel_Ciudad = calle + ciudad

INSERT INTO [PISOS_PICADOS].RolxFuncionalidad
SELECT idRol, idFuncionalidad
FROM [PISOS_PICADOS].Rol, [PISOS_PICADOS].Funcionalidad
WHERE nombreRol = 'Guest' and 
(Funcionalidad.descripcion = 'GENERAR_RESERVA' or 
Funcionalidad.descripcion = 'MODIFICAR_RESERVA' or 
Funcionalidad.descripcion = 'CANCELAR_RESERVA')

INSERT INTO [PISOS_PICADOS].RolxFuncionalidad
SELECT idRol, idFuncionalidad
FROM [PISOS_PICADOS].Rol, [PISOS_PICADOS].Funcionalidad
WHERE nombreRol = 'Recepcionista' and 
(Funcionalidad.descripcion = 'GENERAR_RESERVA' or 
Funcionalidad.descripcion = 'MODIFICAR_RESERVA' or 
Funcionalidad.descripcion = 'CANCELAR_RESERVA' or
Funcionalidad.descripcion = 'REGISTRAR_ESTADIA' or 
Funcionalidad.descripcion = 'REGISTRAR_CONSUMIBLES' or 
Funcionalidad.descripcion = 'FACTURAR_ESTADIA')

INSERT INTO [PISOS_PICADOS].RolxFuncionalidad
SELECT idRol, idFuncionalidad
FROM [PISOS_PICADOS].Rol, [PISOS_PICADOS].Funcionalidad
WHERE nombreRol = 'Administrador' and 
(Funcionalidad.descripcion = 'ABM_ROL' or 
Funcionalidad.descripcion = 'ABM_USUARIO' or 
Funcionalidad.descripcion = 'ABM_CLIENTE' or 
Funcionalidad.descripcion = 'ABM_HOTEL' or 
Funcionalidad.descripcion = 'ABM_HABITACION' or
Funcionalidad.descripcion = 'ABM_REGIMEN_ESTADIA' or  
Funcionalidad.descripcion = 'GENERAR_RESERVA' or 
Funcionalidad.descripcion = 'MODIFICAR_RESERVA' or 
Funcionalidad.descripcion = 'CANCELAR_RESERVA' or
Funcionalidad.descripcion = 'REGISTRAR_ESTADIA' or 
Funcionalidad.descripcion = 'REGISTRAR_CONSUMIBLES' or 
Funcionalidad.descripcion = 'FACTURAR_ESTADIA' or
Funcionalidad.descripcion = 'LISTADO_ESTADISTICO')

INSERT INTO [PISOS_PICADOS].RolxUsuario (idRol, idUsuario)
SELECT DISTINCT 3, idUsuario
FROM [PISOS_PICADOS].Usuario, [PISOS_PICADOS].Rol
WHERE usuario.nombre <> 'admin' and usuario.apellido <> 'admin'

INSERT INTO [PISOS_PICADOS].RolxUsuario (idRol, idUsuario)
SELECT DISTINCT 1, idUsuario
FROM [PISOS_PICADOS].Usuario, [PISOS_PICADOS].Rol
WHERE usuario.nombre = 'admin' and usuario.apellido = 'admin'