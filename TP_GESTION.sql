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
usuario VARCHAR(255) UNIQUE,
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
idHabitacion INT PRIMARY KEY IDENTITY,
numero INT,
idHotel INT,
frente CHAR(1),
tipo INT REFERENCES [PISOS_PICADOS].Tipo,
descripcion VARCHAR(255) DEFAULT NULL,
piso INT,
habilitada BIT DEFAULT 1,
)

CREATE TABLE [PISOS_PICADOS].BajaHabitacion
(
idBaja INT PRIMARY KEY IDENTITY,
idHabitacion INT REFERENCES[PISOS_PICADOS].Habitacion ,
fechaIncio DATE,
fechaFin DATE,
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
estadoReserva INT REFERENCES [PISOS_PICADOS].Estado,
descripcion VARCHAR(255),
usuario INT REFERENCES [PISOS_PICADOS].Usuario,
fecha DATE
)

CREATE TABLE [PISOS_PICADOS].HabitacionxReserva
(
idHabitacion INT REFERENCES  [PISOS_PICADOS].Habitacion,
codigoReserva INT REFERENCES [PISOS_PICADOS].Reserva,
PRIMARY KEY (idHabitacion, codigoReserva)
)

/*CREATE TABLE [PISOS_PICADOS].CheckIn
(
idCheckIn INT PRIMARY KEY IDENTITY,
fecha DATE,
usuarioEncargado INT REFERENCES [PISOS_PICADOS].Usuario DEFAULT NULL 
)

CREATE TABLE [PISOS_PICADOS].CheckOut
(
idCheckOut INT PRIMARY KEY IDENTITY,
fecha DATE,
usuarioEncargado INT REFERENCES [PISOS_PICADOS].Usuario DEFAULT NULL
) */

CREATE TABLE [PISOS_PICADOS].Estadia
(
idEstadia INT PRIMARY KEY IDENTITY,
codigoReserva INT REFERENCES [PISOS_PICADOS].Reserva,
fechaCheckIn DATE,
encargadoCheckIn INT REFERENCES [PISOS_PICADOS].Empleado DEFAULT NULL,
fechaCheckOut DATE DEFAULT NULL,
encargadoCheckOut INT REFERENCES [PISOS_PICADOS].Empleado DEFAULT NULL
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
cantidad INT,
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
formaDePago INT REFERENCES [PISOS_PICADOS].FormaDePago DEFAULT NULL,
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

CREATE TABLE [PISOS_PICADOS].BajaHotel
(
idBaja INT PRIMARY KEY,
idHotel INT REFERENCES [PISOS_PICADOS].Hotel,
fechaInicio DATE,
fechaFin DATE,
razon VARCHAR(255)
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

INSERT INTO [PISOS_PICADOS].Reserva (codigoReserva, fechaInicio, fechaFin, codigoRegimen, idCliente)
SELECT DISTINCT Reserva_Codigo, Reserva_Fecha_Inicio, dateadd(day, Reserva_Cant_Noches, Reserva_Fecha_Inicio), 
Regimen.codigoRegimen, idUsuario
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

INSERT INTO [PISOS_PICADOS].HabitacionxReserva (idHabitacion, codigoReserva)
SELECT DISTINCT idHabitacion, Reserva.codigoReserva
FROM [gd_esquema].Maestra, [PISOS_PICADOS].Habitacion, [PISOS_PICADOS].Reserva
WHERE Reserva.codigoReserva = Reserva_Codigo AND idHabitacion = 
(Select distinct a.idHabitacion FROM [PISOS_PICADOS].Habitacion AS a where a.numero = Habitacion_Numero and
a.idHotel = (SELECT b.idHotel FROM [PISOS_PICADOS].Hotel AS b 
WHERE b.ciudad = Hotel_Ciudad AND b.calle = Hotel_Calle)) 

INSERT INTO [PISOS_PICADOS].Estadia (codigoReserva, fechaCheckIn, fechaCheckOut)
SELECT codigoReserva, fechaInicio, fechaFin
FROM [PISOS_PICADOS].Reserva JOIN [gd_esquema].Maestra on codigoReserva = Reserva_Codigo
WHERE Factura_Nro IS NOT NULL
GROUP BY Factura_Nro, codigoReserva, fechaInicio, fechaFin

INSERT INTO [PISOS_PICADOS].EstadiaxConsumible
SELECT idEstadia, Consumible_Codigo, count(*)
FROM [PISOS_PICADOS].Estadia JOIN [gd_esquema].Maestra on codigoReserva = Reserva_Codigo
WHERE Consumible_Codigo IS NOT NULL
GROUP BY idEstadia, Consumible_Codigo

SET IDENTITY_INSERT [PISOS_PICADOS].Factura ON

INSERT INTO [PISOS_PICADOS].Factura (numeroFactura ,cliente, total)
SELECT Factura_Nro ,idUsuario, Factura_Total
FROM [PISOS_PICADOS].Usuario, [gd_esquema].Maestra
WHERE Cliente_Apellido + Cliente_Nombre = apellido + nombre and
Cliente_Pasaporte_Nro = numeroIdentificacion and 
Factura_Total IS NOT NULL
GROUP BY Factura_Nro ,idUsuario, Factura_Total

SET IDENTITY_INSERT [PISOS_PICADOS].Factura OFF

INSERT INTO [PISOS_PICADOS].RenglonFactura (numeroRenglon, numeroFactura, consumible, cantidad, precio, total, estadia)
SELECT ROW_NUMBER() OVER(PARTITION BY Factura_Nro ORDER BY Consumible_Codigo) , Factura_Nro, Consumible_Codigo, count(*) ,Consumible_Precio,count(*) * Consumible_Precio, idEstadia
FROM [PISOS_PICADOS].Estadia JOIN [gd_esquema].Maestra on codigoReserva = Reserva_Codigo
WHERE Factura_Nro IS NOT NULL and Consumible_Codigo IS NOT NULL
GROUP BY Factura_Nro, Consumible_Codigo, Consumible_Precio, idEstadia

GO

/*Migracion FIN-------------------------------------------------------------------*/
/* FUNCIONES ---------------------------------------------------------------------*/

CREATE FUNCTION [PISOS_PICADOS].obtenerIDUsuario (@nombre VARCHAR(255), @apellido VARCHAR(255), @numeroIdentificacion INT)
RETURNS INT
AS
BEGIN
RETURN (SELECT idUsuario 
FROM [PISOS_PICADOS].Usuario 
WHERE nombre = @nombre and apellido = @apellido and numeroIdentificacion = @numeroIdentificacion)
END
GO

CREATE FUNCTION [PISOS_PICADOS].esAdmin(@idUsuario INT)
RETURNS BIT
AS
BEGIN
IF ((SELECT idRol FROM [PISOS_PICADOS].Rol WHERE nombreRol = 'Administrador') IN (SELECT p.idRol FROM [PISOS_PICADOS].RolxUsuario as p WHERE idUsuario = @idUsuario))
RETURN 1;
RETURN 0;
END
GO

CREATE FUNCTION [PISOS_PICADOS].obtenerIDPais(@nombre VARCHAR(255))
RETURNS INT
AS 
BEGIN
RETURN (SELECT idPais FROM [PISOS_PICADOS].Pais WHERE nombrePais = @nombre)
END
GO

CREATE FUNCTION [PISOS_PICADOS].obtenerIDHotel(@ciudad VARCHAR(255),@calle VARCHAR(255),@nroCalle VARCHAR (255))
RETURNS INT
AS 
BEGIN
RETURN (SELECT idHotel FROM [PISOS_PICADOS].Hotel
 WHERE calle = @calle and ciudad=@ciudad and nroCalle= nroCalle)
END
GO

CREATE FUNCTION [PISOS_PICADOS].existeEnHotel(@idHotel INT,@numero INT)
RETURNS INT
AS 
BEGIN
if ( @numero IN (SELECT numero FROM [PISOS_PICADOS].Habitacion WHERE idHotel = @idHotel))
RETURN 1;
RETURN 0;
END
GO

CREATE FUNCTION [PISOS_PICADOS].existeEmpleado(@usuario VARCHAR(255),@contraseña VARCHAR(255))
RETURNS INT
AS 
BEGIN
if ( @usuario IN (SELECT usuario FROM [PISOS_PICADOS].Empleado WHERE usuario = @usuario))
if ( @contraseña IN (SELECT contraseña FROM [PISOS_PICADOS].Empleado WHERE usuario = @usuario))
RETURN 1;
RETURN 0;
END
GO

CREATE FUNCTION [PISOS_PICADOS].usuarioValido(@usuario VARCHAR(255),@contraseña VARCHAR(255))
RETURNS INT
AS 
BEGIN
if ( @usuario IN (SELECT usuario FROM [PISOS_PICADOS].Empleado WHERE usuario = @usuario))
if ( @contraseña IN (SELECT contraseña FROM [PISOS_PICADOS].Empleado WHERE usuario = @usuario))
RETURN 1;
RETURN 0;
END
GO

CREATE FUNCTION [PISOS_PICADOS].obtenerIDUsuarioEmpleado(@usuario VARCHAR(255),@contraseña VARCHAR(255))
RETURNS INT
AS 
BEGIN
RETURN (SELECT idUsuario FROM [PISOS_PICADOS].Empleado
WHERE  usuario = @usuario and contraseña=@contraseña )
END
GO

CREATE FUNCTION [PISOS_PICADOS].obtenerRolEmpleado(@usuario VARCHAR(255),@contraseña VARCHAR(255))
RETURNS INT
AS 
BEGIN
RETURN (SELECT idRol FROM [PISOS_PICADOS].RolxUsuario
WHERE  idUsuario = [PISOS_PICADOS].obtenerIDUsuarioEmpleado(@usuario , @contraseña) )
END
GO

CREATE FUNCTION [PISOS_PICADOS].HotelTieneReservas(@idHotel INT, @fechaInicio DATE, @fechaFin DATE)
RETURNS BIT
AS
BEGIN
IF		EXISTS (SELECT IdHabitacion, codigoReserva
		FROM [PISOS_PICADOS].HabitacionxReserva as p
		WHERE p.idHabitacion IN (SELECT idHabitacion FROM [PISOS_PICADOS].Habitacion WHERE idHotel = @idHotel) and
		EXISTS (SELECT fechaInicio, fechaFin FROM [PISOS_PICADOS].Reserva WHERE p.codigoReserva = codigoReserva and
		(@fechaInicio BETWEEN fechaInicio AND fechaFin or @fechaFin <> fechaInicio))) RETURN 1;
RETURN 0;
END
GO

CREATE FUNCTION [PISOS_PICADOS].habilitadoHotel(@idHotel INT,@fechaReserva DATE)
RETURNS INT
AS 
BEGIN
if ( @idHotel IN (SELECT idHotel  FROM [PISOS_PICADOS].BajaHotel 
WHERE @fechaReserva BETWEEN fechaInicio AND fechaFin ))
RETURN 1;
RETURN 0;
END
GO

/* Crea funcion que a partir de usuario y contra me da idUsuario */
/* otra que a partir de id de usuario te de el string rol */


/* STORED PROCEDURES ------------------------------------------------------*/

CREATE PROCEDURE [PISOS_PICADOS].altaRol @nombre VARCHAR(255), @estado BIT
AS
BEGIN
INSERT INTO [PISOS_PICADOS].Rol VALUES(@nombre, @estado);
END;
GO

CREATE PROCEDURE [PISOS_PICADOS].agregarFuncionalidad @nombre VARCHAR(255),  @funcionalidad VARCHAR(255)
AS
BEGIN
INSERT INTO [PISOS_PICADOS].RolxFuncionalidad
SELECT idRol, idFuncionalidad
FROM [PISOS_PICADOS].Rol, [PISOS_PICADOS].Funcionalidad
WHERE idRol = (SELECT p.idRol FROM [PISOS_PICADOS].Rol as p WHERE p.nombreRol = @nombre) and
idFuncionalidad = (SELECT e.idFuncionalidad FROM [PISOS_PICADOS].Funcionalidad as e WHERE e.descripcion = @funcionalidad)
END
GO

CREATE PROCEDURE [PISOS_PICADOS].bajaRol @nombreRol VARCHAR(255)
AS
BEGIN
UPDATE [PISOS_PICADOS].Rol SET estado = 0
WHERE idRol = (SELECT p.idRol FROM [PISOS_PICADOS].Rol as p WHERE nombreRol = @nombreRol)
END;
GO

CREATE PROCEDURE [PISOS_PICADOS].modificarRol @idRol INT, @nombreRol VARCHAR(255), @estado BIT
AS
BEGIN
IF @nombreRol IS NOT NULL UPDATE [PISOS_PICADOS].Rol SET nombreRol = @nombreRol
IF @estado IS NOT NULL UPDATE [PISOS_PICADOS].Rol SET estado = @estado
END;
GO

CREATE PROCEDURE [PISOS_PICADOS].quitarFuncionalidad @nombreRol VARCHAR(255), @funcionalidad VARCHAR(255)
AS
BEGIN
DELETE FROM [PISOS_PICADOS].RolxFuncionalidad
WHERE idRol = (SELECT p.idRol FROM [PISOS_PICADOS].Rol as p WHERE p.nombreRol = @nombreRol) and
idFuncionalidad = (SELECT e.idFuncionalidad FROM [PISOS_PICADOS].Funcionalidad as e WHERE e.descripcion = @funcionalidad)
END;
GO

CREATE PROCEDURE [PISOS_PICADOS].altaEmpleado
@username VARCHAR(255), @password VARCHAR(255), @rol VARCHAR(255), @nombre VARCHAR(255), @apellido VARCHAR(255),
@mail VARCHAR(255), @telefono VARCHAR(255), @calle VARCHAR(255), @numeroCalle INT, @localidad VARCHAR(255),
@pais VARCHAR(255), @tipoDocumento VARCHAR(255), @numeroDocumento INT, @fechaNacimiento DATE, @estado BIT
AS
BEGIN
INSERT INTO [PISOS_PICADOS].Usuario VALUES(@nombre, @apellido, @mail, @telefono, @calle, @numeroCalle, @localidad,
(SELECT idPais FROM [PISOS_PICADOS].Pais WHERE nombrePais = @pais), @tipoDocumento, @numeroDocumento, @fechaNacimiento, @estado);
INSERT INTO [PISOS_PICADOS].Empleado (idUsuario, usuario, contraseña)
VALUES ([PISOS_PICADOS].obtenerIDUsuario(@nombre,@apellido,@numeroDocumento), @username, HASHBYTES('SHA2_256', @password));
INSERT INTO [PISOS_PICADOS].RolxUsuario VALUES((SELECT idRol FROM [PISOS_PICADOS].Rol WHERE nombreRol = @rol), (SELECT idUsuario FROM [PISOS_PICADOS].Usuario as p WHERE p.numeroIdentificacion = @numeroDocumento and
p.apellido = @apellido and p.nombre = @nombre))
END;
GO

CREATE PROCEDURE [PISOS_PICADOS].modificarEmpleado
@idAutor INT, @idUsuario INT, @username VARCHAR(255), @password VARCHAR(255), @nombre VARCHAR(255), @apellido VARCHAR(255),
@mail VARCHAR(255), @telefono VARCHAR(255), @calle VARCHAR(255), @numeroCalle INT, @localidad VARCHAR(255),
@pais VARCHAR(255), @tipoDocumento VARCHAR(255), @numeroDocumento INT, @fechaNacimiento DATE
AS
BEGIN
IF ([PISOS_PICADOS].esAdmin(@idAutor) = 1)
IF @password IS NOT NULL UPDATE [PISOS_PICADOS].Empleado set contraseña = @password
WHERE @idUsuario = idUsuario
IF @nombre IS NOT NULL UPDATE [PISOS_PICADOS].Usuario set nombre = @nombre
WHERE @idUsuario = idUsuario
IF @apellido IS NOT NULL UPDATE [PISOS_PICADOS].Usuario set apellido = @apellido
WHERE @idUsuario = idUsuario
IF @mail IS NOT NULL UPDATE [PISOS_PICADOS].Usuario set mail = @mail
WHERE @idUsuario = idUsuario
IF @telefono IS NOT NULL UPDATE [PISOS_PICADOS].Usuario set telefono = @telefono
WHERE @idUsuario = idUsuario
IF @calle IS NOT NULL UPDATE [PISOS_PICADOS].Usuario set calle = @calle
WHERE @idUsuario = idUsuario
IF @numeroCalle IS NOT NULL UPDATE [PISOS_PICADOS].Usuario set nroCalle = @numeroCalle
WHERE @idUsuario = idUsuario
IF @localidad IS NOT NULL UPDATE [PISOS_PICADOS].Usuario set localidad = @localidad
WHERE @idUsuario = idUsuario
IF @pais IS NOT NULL UPDATE [PISOS_PICADOS].Usuario set pais = (SELECT idPais FROM [PISOS_PICADOS].Pais WHERE nombrePais = @pais)
WHERE @idUsuario = idUsuario
IF @tipoDocumento IS NOT NULL UPDATE [PISOS_PICADOS].Usuario set tipoIdentificacion = @tipoDocumento
WHERE @idUsuario = idUsuario
IF @numeroDocumento IS NOT NULL UPDATE [PISOS_PICADOS].Usuario set numeroIdentificacion = @numeroDocumento
WHERE @idUsuario = idUsuario
IF @fechaNacimiento IS NOT NULL UPDATE [PISOS_PICADOS].Usuario set fechaNacimiento = @fechaNacimiento
WHERE @idUsuario = idUsuario
END;
GO

CREATE PROCEDURE [PISOS_PICADOS].quitarRolAUsuario @idUsuario INT, @nombreRol VARCHAR(255)
AS
BEGIN
DELETE FROM [PISOS_PICADOS].RolxUsuario 
WHERE idUsuario = @idUsuario and
idRol = (SELECT p.idRol FROM [PISOS_PICADOS].Rol as p WHERE nombreRol = @nombreRol)
END;
GO

CREATE PROCEDURE [PISOS_PICADOS].agregarRolAUsuario @idUsuario INT, @nombreRol VARCHAR(255)
AS
BEGIN
INSERT INTO [PISOS_PICADOS].RolxUsuario VALUES (@idUsuario, (SELECT idRol FROM [PISOS_PICADOS].Rol WHERE nombreRol = @nombreRol))
END;
GO

CREATE PROCEDURE [PISOS_PICADOS].bajaUsuario @idAutor INT, @idUsuario INT
AS
BEGIN
IF ([PISOS_PICADOS].esAdmin(@idAutor) = 1)
UPDATE [PISOS_PICADOS].Usuario SET estado = 0 WHERE idUsuario = @idUsuario
END;
GO

/* ABM CLIENTE */

/* ALTA CLIENTE*/

CREATE PROCEDURE [PISOS_PICADOS].SPAltaCliente @nombre VARCHAR(255), @apellido VARCHAR(255),@tipo VARCHAR(255),
@numeroI INT, @mail VARCHAR(255), @telefono VARCHAR(255), @calle VARCHAR(255),@numeroC INT,
@localidad VARCHAR(255),@pais VARCHAR(255) ,@nacionalidad VARCHAR(255),@fechaNacimiento DATE

AS
BEGIN 

INSERT INTO [PISOS_PICADOS].Usuario(nombre,apellido,mail,telefono,calle,nroCalle,localidad,pais,
tipoIdentificacion,numeroIdentificacion,fechaNacimiento,estado)
values (@nombre,@apellido,@mail,@telefono,@calle,@numeroC,@localidad, [PISOS_PICADOS].obtenerIDPais(@pais) ,
@tipo,@numeroI,@fechaNacimiento,1);

INSERT INTO [PISOS_PICADOS].Cliente
VALUES ( [PISOS_PICADOS].obtenerIDUsuario(@nombre,@apellido,@numeroI) , @nacionalidad);

INSERT INTO [PISOS_PICADOS].RolxUsuario
VALUES (3, [PISOS_PICADOS].obtenerIDUsuario(@nombre,@apellido,@numeroI));
END;
GO

/* MODIFICACION CLIENTE */ 

CREATE PROCEDURE [PISOS_PICADOS].SPModificarCliente @idUsuario INT,@nombre VARCHAR(255), @apellido VARCHAR(255),@tipo VARCHAR(255),
@numeroI INT, @mail VARCHAR(255), @telefono VARCHAR(255), @calle VARCHAR(255),@numeroC INT, 
@localidad VARCHAR(255), @pais VARCHAR(255) ,@nacionalidad VARCHAR(255),@fechaNacimiento DATE, 
@estado BIT

AS
BEGIN 

IF @nombre IS NOT NULL UPDATE [PISOS_PICADOS].Usuario set nombre = @nombre
WHERE @idUsuario = idUsuario
IF @apellido IS NOT NULL UPDATE [PISOS_PICADOS].Usuario set apellido = @apellido
WHERE @idUsuario = idUsuario
IF @mail IS NOT NULL UPDATE [PISOS_PICADOS].Usuario set mail = @mail
WHERE @idUsuario = idUsuario
IF @telefono IS NOT NULL UPDATE [PISOS_PICADOS].Usuario set telefono = @telefono
WHERE @idUsuario = idUsuario
IF @calle IS NOT NULL UPDATE [PISOS_PICADOS].Usuario set calle = @calle
WHERE @idUsuario = idUsuario
IF @numeroC IS NOT NULL UPDATE [PISOS_PICADOS].Usuario set nroCalle = @numeroC
WHERE @idUsuario = idUsuario
IF @localidad IS NOT NULL UPDATE [PISOS_PICADOS].Usuario set localidad = @localidad
WHERE @idUsuario = idUsuario
IF @pais IS NOT NULL UPDATE [PISOS_PICADOS].Usuario set pais = [PISOS_PICADOS].obtenerIDPais(@pais)
WHERE @idUsuario = idUsuario
IF @tipo IS NOT NULL UPDATE [PISOS_PICADOS].Usuario set tipoIdentificacion = @tipo
WHERE @idUsuario = idUsuario
IF @numeroI IS NOT NULL UPDATE [PISOS_PICADOS].Usuario set numeroIdentificacion = @numeroI
WHERE @idUsuario = idUsuario
IF @fechaNacimiento IS NOT NULL UPDATE [PISOS_PICADOS].Usuario set fechaNacimiento = @fechaNacimiento
WHERE @idUsuario = idUsuario
IF @nacionalidad IS NOT NULL UPDATE [PISOS_PICADOS].Cliente set nacionalidad = @nacionalidad
WHERE @idUsuario = idUsuario

END;
GO

/* MODIFICAR ESTADO CLIENTE */

CREATE PROCEDURE [PISOS_PICADOS].SPEstadoCliente @idUsuario INT, @Estado BIT
AS 
BEGIN
UPDATE [PISOS_PICADOS].Usuario set estado = @Estado
WHERE @idUsuario = idUsuario
END;
GO

/* ABM HABITACION */

/* ALTA HABITACION (EL numero de habitacion no puede repetirse en un mismo hotel*/


CREATE PROCEDURE [PISOS_PICADOS].SPAltaHabitacion @numero INT,@IDhotel INT ,@frente CHAR(1),@tipo INT, 
@descripcion VARCHAR(255), @piso INT, @habilitado BIT

AS
BEGIN 

SELECT * FROM PISOS_PICADOS.Tipo

INSERT INTO [PISOS_PICADOS].Habitacion(numero,idHotel,frente,tipo,descripcion,piso,habilitada)
VALUES (@numero,@IDhotel,@frente,@tipo,@descripcion,@piso,@habilitado)

END;
GO

/* MODIFICACION HABITACION (VERIFICAR QUE EL NUMERO DE HABITACION NO SE REPITA EN EL HOTEL) */

CREATE PROCEDURE [PISOS_PICADOS].SPModificarHabitacion @idHabitacion INT,@numeroH INT,@frente CHAR(1), 
@descripcion VARCHAR(255), @piso INT, @habilitado BIT

AS
BEGIN 

IF @numeroH IS NOT NULL UPDATE [PISOS_PICADOS].Habitacion set numero = @numeroH
WHERE  idHabitacion = @idHabitacion
IF @frente IS NOT NULL UPDATE [PISOS_PICADOS].Habitacion set frente = @frente
WHERE  idHabitacion = @idHabitacion
IF @descripcion IS NOT NULL UPDATE [PISOS_PICADOS].Habitacion set descripcion = @descripcion
WHERE  idHabitacion = @idHabitacion
IF @piso IS NOT NULL UPDATE [PISOS_PICADOS].Habitacion set piso = @piso
WHERE  idHabitacion = @idHabitacion
IF @habilitado IS NOT NULL UPDATE [PISOS_PICADOS].Habitacion set habilitada = @habilitado
WHERE  idHabitacion = @idHabitacion

END;
GO

/* BAJA HABITACION   */

CREATE PROCEDURE [PISOS_PICADOS].SPEstadoHabitacion @idHabitacion INT, @habilitado BIT,
 @fechaInicio DATE , @fechaFin DATE
AS
BEGIN 

UPDATE [PISOS_PICADOS].Habitacion set habilitada = @habilitado
WHERE idHabitacion = @idHabitacion

INSERT INTO [PISOS_PICADOS].BajaHabitacion(idHabitacion,fechaIncio,fechaFin)
VALUES (@idHabitacion,@fechaInicio,@fechaFin)


END;
GO

CREATE PROCEDURE [PISOS_PICADOS].crearHotel @nombre VARCHAR(255), @mail VARCHAR(255), @telefono VARCHAR(255),
@calle VARCHAR(255), @nroCalle VARCHAR(255), @direccion VARCHAR(255), @estrellas INT, @ciudad VARCHAR(255), @pais INT,
@fechaCreacion DATE, @autorId INT
AS
BEGIN
INSERT INTO [PISOS_PICADOS].Hotel (nombre, mail, telefono, calle, nroCalle, ciudad, pais, fechaCreacion, estrellas)
VALUES (@nombre, @mail, @telefono, @calle, @nroCalle, @ciudad, @pais, @fechaCreacion, @estrellas)
INSERT INTO [PISOS_PICADOS].EmpleadoxHotel (idUsuario, idHotel) 
VALUES (@autorId, [PISOS_PICADOS].obtenerIDHotel(@ciudad, @calle, @nroCalle))
END
GO

CREATE PROCEDURE [PISOS_PICADOS].agregarRegimen @idHotel INT, @idRegimen INT
AS
BEGIN
INSERT INTO [PISOS_PICADOS].RegimenxHotel (codigoRegimen, idHotel) VALUES (@idRegimen, @idHotel)
END
GO

CREATE PROCEDURE [PISOS_PICADOS].quitarRegimen @idHotel INT, @idRegimen INT
AS
BEGIN
IF NOT EXISTS (SELECT codigoReserva FROM [PISOS_PICADOS].Reservas WHERE Reservas.codigoRegimen = @idRegimen and
(fechaInicio > GetDate() or GetDate() BETWEEN fechaInicio AND fechaFin))
DELETE FROM [PISOS_PICADOS].RegimenxHotel WHERE idHotel = @idHotel and codigoRegimen = @idRegimen
END
GO

CREATE PROCEDURE [PISOS_PICADOS].modificarHotel @nombre VARCHAR(255), @mail VARCHAR(255), @telefono VARCHAR(255),
@calle VARCHAR(255), @nroCalle VARCHAR(255), @estrellas INT, @ciudad VARCHAR(255), @idPais INT,
@fechaCreacion DATE
AS
BEGIN
IF @nombre IS NOT NULL UPDATE [PISOS_PICADOS].Hotel SET nombre = @nombre
IF @mail IS NOT NULL UPDATE [PISOS_PICADOS].Hotel SET mail = @mail
IF @telefono IS NOT NULL UPDATE [PISOS_PICADOS].Hotel SET telefono = @telefono
IF @calle IS NOT NULL UPDATE [PISOS_PICADOS].Hotel SET calle = @calle
IF @nroCalle IS NOT NULL UPDATE [PISOS_PICADOS].Hotel SET nroCalle = @nroCalle
IF @estrellas IS NOT NULL UPDATE [PISOS_PICADOS].Hotel SET estrellas = @estrellas
IF @ciudad IS NOT NULL UPDATE [PISOS_PICADOS].Hotel SET ciudad = @ciudad
IF @idPais IS NOT NULL UPDATE [PISOS_PICADOS].Hotel SET pais = @idPais
IF @fechaCreacion IS NOT NULL UPDATE [PISOS_PICADOS].Hotel SET fechaCreacion = @fechaCreacion
END
GO

CREATE PROCEDURE [PISOS_PICADOS].agregarEncargado @idHotel INT, @idEncargado INT
AS
BEGIN
INSERT INTO [PISOS_PICADOS].EmpleadoxHotel (idHotel, idUsuario) VALUES (@idHotel, @idEncargado)
END
GO

CREATE PROCEDURE [PISOS_PICADOS].quitarEncargado @idHotel INT, @idEncargado INT
AS
BEGIN
DELETE FROM [PISOS_PICADOS].EmpleadoxHotel WHERE idHotel = @idHotel and idUsuario = @idEncargado
END
GO

CREATE PROCEDURE [PISOS_PICADOS].bajaDeHotel @idHotel INT, @fechaInicio DATE, @fechaFin DATE, @razon VARCHAR(255)
AS
BEGIN
IF [PISOS_PICADOS].HotelTieneReservas(@idHotel, @fechaInicio, @fechaFin) = 0
INSERT INTO [PISOS_PICADOS].BajaHotel (idHotel, fechaInicio, fechaFin, razon)
VALUES (@idHotel, @fechaInicio, @fechaFin, @razon)
END
GO

CREATE PROCEDURE [PISOS_PICADOS].cancelarReserva @codigoReserva INT, @motivo VARCHAR(255), @fecha DATE, @idUsuario INT
AS
BEGIN
IF @fecha < (SELECT fechaInicio FROM [PISOS_PICADOS].Reserva where codigoReserva = @codigoReserva)
INSERT INTO [PISOS_PICADOS].Estado VALUES ('Cancelada')
DECLARE @idEstado INT = SCOPE_IDENTITY();
UPDATE [PISOS_PICADOS].Reserva SET estado = @idEstado WHERE codigoReserva = @codigoReserva;
INSERT INTO [PISOS_PICADOS].Modificacion (estadoReserva, descripcion, usuario, fecha)
VALUES (@idEstado, @motivo, @idUsuario, @fecha)
END
GO

CREATE PROCEDURE [PISOS_PICADOS].agregarConsumible @idEstadia INT, @idConsumible INT, @cantidad INT
AS
BEGIN
INSERT INTO [PISOS_PICADOS].EstadiaxConsumible (idEstadia, idConsumible, cantidad)
VALUES (@idEstadia, @idConsumible, @cantidad)
END
GO

CREATE PROCEDURE [PISOS_PICADOS].quitarConsumible @idEstadia INT, @idConsumible INT
AS
BEGIN
DELETE FROM [PISOS_PICADOS].EstadiaxConsumible WHERE idEstadia = @idEstadia and idConsumible = @idConsumible
END
GO