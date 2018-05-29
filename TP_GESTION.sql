/*SELECT * FROM gd_esquema.Maestra*/
CREATE TABLE [PISOS_PICADOS].Rol
(
idRol INT PRIMARY KEY IDENTITY,
nombreRol VARCHAR(255),
estado BIT
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
telefono VARCHAR(255),
calle VARCHAR(255),
localidad VARCHAR(255),
pais INT REFERENCES [PISOS_PICADOS].Pais,
tipoIdentificacion VARCHAR(255),
numeroIdentificacion INT,
fechaNacimiento DATE,
estado BIT
)

CREATE TABLE [PISOS_PICADOS].Cliente
(
idUsuario INT PRIMARY KEY REFERENCES [PISOS_PICADOS].Usuario(idUsuario),
nacionalidad VARCHAR(255),
)

CREATE TABLE [PISOS_PICADOS].Empleado
(
idUsuario INT PRIMARY KEY REFERENCES [PISOS_PICADOS].Usuario(idUsuario),
usuario VARCHAR(255),
contraseña VARCHAR(255),
)

CREATE TABLE [PISOS_PICADOS].Hotel
(
idHotel INT PRIMARY KEY IDENTITY,
nombre VARCHAR(255),
mail VARCHAR(255),
telefono VARCHAR(255),
calle VARCHAR(255),
ciudad VARCHAR(255),
pais INT REFERENCES [PISOS_PICADOS].Pais,
fechaCreacion DATE,
estrellas INT
)

CREATE TABLE [PISOS_PICADOS].UsuarioxHotel
(
idUsuario INT REFERENCES [PISOS_PICADOS].Usuario,
idHotel INT REFERENCES [PISOS_PICADOS].Hotel
PRIMARY KEY (idUsuario, idHotel)
)

CREATE TABLE [PISOS_PICADOS].Regimen
(
codigoRegimen INT PRIMARY KEY IDENTITY,
nombre VARCHAR(255),
descripcion VARCHAR(255),
precioBase NUMERIC(6,2),
estado BIT
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
tipoCamas VARCHAR(255)
)

CREATE TABLE [PISOS_PICADOS].Habitacion
(
numero INT,
idHotel INT,
ubicacion CHAR(1),
tipo INT REFERENCES [PISOS_PICADOS].Tipo,
descripcion VARCHAR(255),
piso INT,
habilitada BIT,
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

CREATE TABLE [PISOS_PICADOS].Reserva
(
codigoReserva INT PRIMARY KEY IDENTITY,
fechaRealizacion DATE,
fechaInicio DATE,
fechaFin DATE,
cantidadHuespedes INT,
codigoRegimen INT REFERENCES [PISOS_PICADOS].Regimen,
estado BIT,
idCliente INT REFERENCES [PISOS_PICADOS].Cliente
)

CREATE TABLE [PISOS_PICADOS].Estado
(
idEstado INT PRIMARY KEY IDENTITY,
descripcion VARCHAR(255)
)

CREATE TABLE [PISOS_PICADOS].Modificacion
(
codigoModificacion INT PRIMARY KEY IDENTITY,
estado INT REFERENCES [PISOS_PICADOS].Estado,
descripcion VARCHAR(255),
usuario INT REFERENCES [PISOS_PICADOS].Empleado,
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
idConsumible INT PRIMARY KEY IDENTITY,
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
numeroFactura INT PRIMARY KEY IDENTITY,
formaDePago INT REFERENCES [PISOS_PICADOS].FormaDePago,
cliente INT REFERENCES [PISOS_PICADOS].Cliente,
total NUMERIC(8,2)
)

CREATE TABLE [PISOS_PICADOS].RenglonFactura
(
numeroRenglon INT,
numeroFactura INT,
consumible INT REFERENCES [PISOS_PICADOS].Consumible,
cantidad INT,
precio NUMERIC(6,2),
total NUMERIC (8,2),
estadia INT REFERENCES [PISOS_PICADOS].Estadia,
PRIMARY KEY (numeroRenglon, numeroFactura)
)