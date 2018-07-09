/* Borrado */
/*Tablas*/
IF OBJECT_ID(N'[PISOS_PICADOS].EstadiaxConsumible', N'U') IS NOT NULL
	DROP TABLE [PISOS_PICADOS].EstadiaxConsumible

IF OBJECT_ID(N'[PISOS_PICADOS].HabitacionxReserva', N'U') IS NOT NULL
	DROP TABLE [PISOS_PICADOS].HabitacionxReserva

IF OBJECT_ID(N'[PISOS_PICADOS].Modificacion', N'U') IS NOT NULL
	DROP TABLE [PISOS_PICADOS].Modificacion

IF OBJECT_ID(N'[PISOS_PICADOS].RegimenxHotel', N'U') IS NOT NULL
	DROP TABLE [PISOS_PICADOS].RegimenxHotel

IF OBJECT_ID(N'[PISOS_PICADOS].RenglonFactura', N'U') IS NOT NULL
	DROP TABLE [PISOS_PICADOS].RenglonFactura

IF OBJECT_ID(N'[PISOS_PICADOS].RolxFuncionalidad', N'U') IS NOT NULL
	DROP TABLE [PISOS_PICADOS].RolxFuncionalidad

IF OBJECT_ID(N'[PISOS_PICADOS].RolxUsuario', N'U') IS NOT NULL
	DROP TABLE [PISOS_PICADOS].RolxUsuario

IF OBJECT_ID(N'[PISOS_PICADOS].EmpleadoxHotel', N'U') IS NOT NULL
	DROP TABLE [PISOS_PICADOS].EmpleadoxHotel

IF OBJECT_ID(N'[PISOS_PICADOS].Consumible', N'U') IS NOT NULL
	DROP TABLE [PISOS_PICADOS].Consumible

IF OBJECT_ID(N'[PISOS_PICADOS].Factura', N'U') IS NOT NULL
	DROP TABLE [PISOS_PICADOS].Factura

IF OBJECT_ID(N'[PISOS_PICADOS].Estadia', N'U') IS NOT NULL
	DROP TABLE [PISOS_PICADOS].Estadia

IF OBJECT_ID(N'[PISOS_PICADOS].FormaDePago', N'U') IS NOT NULL
	DROP TABLE [PISOS_PICADOS].FormaDePago

IF OBJECT_ID(N'[PISOS_PICADOS].Funcionalidad', N'U') IS NOT NULL
	DROP TABLE [PISOS_PICADOS].Funcionalidad

IF OBJECT_ID(N'[PISOS_PICADOS].Habitacion', N'U') IS NOT NULL
	DROP TABLE [PISOS_PICADOS].Habitacion

IF OBJECT_ID(N'[PISOS_PICADOS].BajaHotel', N'U') IS NOT NULL
	DROP TABLE [PISOS_PICADOS].BajaHotel

IF OBJECT_ID(N'[PISOS_PICADOS].Hotel', N'U') IS NOT NULL
	DROP TABLE [PISOS_PICADOS].Hotel

IF OBJECT_ID(N'[PISOS_PICADOS].Reserva', N'U') IS NOT NULL
	DROP TABLE [PISOS_PICADOS].Reserva

IF OBJECT_ID(N'[PISOS_PICADOS].Rol', N'U') IS NOT NULL
	DROP TABLE [PISOS_PICADOS].Rol

IF OBJECT_ID(N'[PISOS_PICADOS].Tipo', N'U') IS NOT NULL
	DROP TABLE [PISOS_PICADOS].Tipo

IF OBJECT_ID(N'[PISOS_PICADOS].Cliente', N'U') IS NOT NULL
	DROP TABLE [PISOS_PICADOS].Cliente

IF OBJECT_ID(N'[PISOS_PICADOS].Estado', N'U') IS NOT NULL
	DROP TABLE [PISOS_PICADOS].Estado

IF OBJECT_ID(N'[PISOS_PICADOS].Regimen', N'U') IS NOT NULL
	DROP TABLE [PISOS_PICADOS].Regimen

IF OBJECT_ID(N'[PISOS_PICADOS].Empleado', N'U') IS NOT NULL
	DROP TABLE [PISOS_PICADOS].Empleado

IF OBJECT_ID(N'[PISOS_PICADOS].Usuario', N'U') IS NOT NULL
	DROP TABLE [PISOS_PICADOS].Usuario

IF OBJECT_ID(N'[PISOS_PICADOS].Empleado', N'U') IS NOT NULL
	DROP TABLE [PISOS_PICADOS].Empleado

IF OBJECT_ID(N'[PISOS_PICADOS].Pais', N'U') IS NOT NULL
	DROP TABLE [PISOS_PICADOS].Pais

IF OBJECT_ID(N'[PISOS_PICADOS].EstadoUsuario', N'U') IS NOT NULL
	DROP TABLE [PISOS_PICADOS].EstadoUsuario

/*Funciones*/
IF OBJECT_ID(N'[PISOS_PICADOS].obtenerIDHotel', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].obtenerIDHotel;

IF OBJECT_ID(N'[PISOS_PICADOS].obtenerIDPais', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].obtenerIDPais;

IF OBJECT_ID(N'[PISOS_PICADOS].esAdmin', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].esAdmin;

IF OBJECT_ID(N'[PISOS_PICADOS].existeNumEnHotel', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].existeNumEnHotel;

IF OBJECT_ID(N'[PISOS_PICADOS].usuarioValido', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].usuarioValido;

IF OBJECT_ID(N'[PISOS_PICADOS].obtenerIDUsuarioEmpleado', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].obtenerIDUsuarioEmpleado;

IF OBJECT_ID(N'[PISOS_PICADOS].hotelTieneReservas', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].hotelTieneReservas;

IF OBJECT_ID(N'[PISOS_PICADOS].habilitadoHotel', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].habilitadoHotel;

IF OBJECT_ID(N'[PISOS_PICADOS].netearConsumibles', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].netearConsumibles;

IF OBJECT_ID(N'[PISOS_PICADOS].incrementoHotel', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].incrementoHotel;

IF OBJECT_ID(N'[PISOS_PICADOS].precioRegimen', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].precioRegimen;

IF OBJECT_ID(N'[PISOS_PICADOS].precioHabitacion', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].precioHabitacion;

IF OBJECT_ID(N'[PISOS_PICADOS].hotelCumple', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].hotelCumple;

IF OBJECT_ID(N'[PISOS_PICADOS].habitacionQueCumple', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].habitacionQueCumple;

IF OBJECT_ID(N'[PISOS_PICADOS].obtenerHotelDeHabitacion', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].obtenerHotelDeHabitacion;

IF OBJECT_ID(N'[PISOS_PICADOS].consultarRegimen', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].consultarRegimen;

IF OBJECT_ID(N'[PISOS_PICADOS].habilitadoCLiente', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].habilitadoCLiente;

IF OBJECT_ID(N'[PISOS_PICADOS].precioReserva', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].precioReserva;

IF OBJECT_ID(N'[PISOS_PICADOS].obtenerEstadoUsuario', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].obtenerEstadoUsuario;

IF OBJECT_ID(N'[PISOS_PICADOS].existeUsuario', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].existeUsuario;

IF OBJECT_ID(N'[PISOS_PICADOS].calcularPrecioRenglones', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].calcularPrecioRenglones;

IF OBJECT_ID(N'[PISOS_PICADOS].calcularPrecioPorDiasHospedados', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].calcularPrecioPorDiasHospedados;

IF OBJECT_ID(N'[PISOS_PICADOS].precioPorDia', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].precioPorDia;

IF OBJECT_ID(N'[PISOS_PICADOS].calcularPrecioPorDiasNoHospedados', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].calcularPrecioPorDiasNoHospedados;

IF OBJECT_ID(N'[PISOS_PICADOS].precioConsumible', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].precioConsumible;

IF OBJECT_ID(N'[PISOS_PICADOS].estaRepetido', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].estaRepetido;

IF OBJECT_ID(N'[PISOS_PICADOS].filtroClientes', N'IF') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].filtroClientes;

IF OBJECT_ID(N'[PISOS_PICADOS].listadoHabitaciones', N'IF') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].listadoHabitaciones;

IF OBJECT_ID(N'[PISOS_PICADOS].existeRol', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].existeRol;

IF OBJECT_ID(N'[PISOS_PICADOS].estaRepetidoMail', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].estaRepetidoMail;

IF OBJECT_ID(N'[PISOS_PICADOS].contrasenaValida', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].contrasenaValida;

IF OBJECT_ID(N'[PISOS_PICADOS].cantidadIntentosFallidos', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].cantidadIntentosFallidos;

IF OBJECT_ID(N'[PISOS_PICADOS].intentosRestantes', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].intentosRestantes;

IF OBJECT_ID(N'[PISOS_PICADOS].empleadoDeshabilitado', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].empleadoDeshabilitado;

IF OBJECT_ID(N'[PISOS_PICADOS].tieneUnSoloRol', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].tieneUnSoloRol;

IF OBJECT_ID(N'[PISOS_PICADOS].obtenerRol', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].obtenerRol;

IF OBJECT_ID(N'[PISOS_PICADOS].obtenerIDUsuario', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].obtenerIDUsuario;

IF OBJECT_ID(N'[PISOS_PICADOS].hotelesConMasCancelaciones', N'IF') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].hotelesConMasCancelaciones;

IF OBJECT_ID(N'[PISOS_PICADOS].hotelesConMasConsumiblesFacturados', N'IF') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].hotelesConMasConsumiblesFacturados;

IF OBJECT_ID(N'[PISOS_PICADOS].hotelesConMasDiasDeBaja', N'IF') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].hotelesConMasDiasDeBaja;

IF OBJECT_ID(N'[PISOS_PICADOS].topHabitacionesOcupadasVeces', N'IF') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].topHabitacionesOcupadasVeces;

IF OBJECT_ID(N'[PISOS_PICADOS].topHabitacionesOcupadasDias', N'IF') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].topHabitacionesOcupadasDias;

IF OBJECT_ID(N'[PISOS_PICADOS].topClientesPorPuntos', N'IF') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].topClientesPorPuntos;

IF OBJECT_ID(N'[PISOS_PICADOS].obtenerNacionalidadCliente', N'FN') IS NOT NULL
	DROP FUNCTION [PISOS_PICADOS].obtenerNacionalidadCliente;


/* Procedures*/
IF OBJECT_ID(N'[PISOS_PICADOS].altaRol', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].altaRol;

IF OBJECT_ID(N'[PISOS_PICADOS].altaEmpleado', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].altaEmpleado;

IF OBJECT_ID(N'[PISOS_PICADOS].agregarFuncionalidad', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].agregarFuncionalidad;

IF OBJECT_ID(N'[PISOS_PICADOS].bajaRol', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].bajaRol;

IF OBJECT_ID(N'[PISOS_PICADOS].modificarRol', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].modificarRol;

IF OBJECT_ID(N'[PISOS_PICADOS].quitarFuncionalidad', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].quitarFuncionalidad;

IF OBJECT_ID(N'[PISOS_PICADOS].agregarRolAUsuario', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].agregarRolAUsuario;

IF OBJECT_ID(N'[PISOS_PICADOS].quitarRolAUsuario', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].quitarRolAUsuario;

IF OBJECT_ID(N'[PISOS_PICADOS].modificarEmpleado', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].modificarEmpleado;

IF OBJECT_ID(N'[PISOS_PICADOS].bajaUsuario', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].bajaUsuario;

IF OBJECT_ID(N'[PISOS_PICADOS].SPEstadoHabitacion', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].SPEstadoHabitacion;

IF OBJECT_ID(N'[PISOS_PICADOS].SPModificarHabitacion', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].SPModificarHabitacion;

IF OBJECT_ID(N'[PISOS_PICADOS].SPAltaHabitacion', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].SPAltaHabitacion;

IF OBJECT_ID(N'[PISOS_PICADOS].SPEstadoCliente', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].SPEstadoCliente;

IF OBJECT_ID(N'[PISOS_PICADOS].SPModificarCliente', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].SPModificarCliente;

IF OBJECT_ID(N'[PISOS_PICADOS].SPAltaCliente', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].SPAltaCliente;

IF OBJECT_ID(N'[PISOS_PICADOS].bajaDeHotel', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].bajaDeHotel;

IF OBJECT_ID(N'[PISOS_PICADOS].quitarEncargado', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].quitarEncargado;

IF OBJECT_ID(N'[PISOS_PICADOS].agregarEncargado', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].agregarEncargado;

IF OBJECT_ID(N'[PISOS_PICADOS].modificarHotel', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].modificarHotel;

IF OBJECT_ID(N'[PISOS_PICADOS].agregarRegimen', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].agregarRegimen;

IF OBJECT_ID(N'[PISOS_PICADOS].quitarRegimen', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].quitarRegimen;

IF OBJECT_ID(N'[PISOS_PICADOS].crearHotel', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].crearHotel;

IF OBJECT_ID(N'[PISOS_PICADOS].cancelarReserva', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].cancelarReserva;

IF OBJECT_ID(N'[PISOS_PICADOS].agregarConsumible', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].agregarConsumible;

IF OBJECT_ID(N'[PISOS_PICADOS].quitarConsumible', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].quitarConsumible;

IF OBJECT_ID(N'[PISOS_PICADOS].registrarReserva', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].registrarReserva;

IF OBJECT_ID(N'[PISOS_PICADOS].EliminarReservasNoEfectivizada', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].EliminarReservasNoEfectivizada;

IF OBJECT_ID(N'[PISOS_PICADOS].registrarCheckIn', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].registrarCheckIn;

IF OBJECT_ID(N'[PISOS_PICADOS].registrarCheckOut', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].registrarCheckOut;

IF OBJECT_ID(N'[PISOS_PICADOS].modificarReserva', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].modificarReserva;

IF OBJECT_ID(N'[PISOS_PICADOS].facturarReserva', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].facturarReserva;

IF OBJECT_ID(N'[PISOS_PICADOS].corregirUsuarios', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].corregirUsuarios;

IF OBJECT_ID(N'[PISOS_PICADOS].sumarIntento', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].sumarIntento;

IF OBJECT_ID(N'[PISOS_PICADOS].resetearIntentos', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].resetearIntentos;

IF OBJECT_ID(N'[PISOS_PICADOS].deshabilitarUsuario', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].deshabilitarUsuario;

IF OBJECT_ID(N'[PISOS_PICADOS].agregarHotelAUsuario', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].agregarHotelAUsuario;

IF OBJECT_ID(N'[PISOS_PICADOS].darNombreAHoteles', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].darNombreAHoteles;

IF OBJECT_ID(N'[PISOS_PICADOS].quitarHotelAUsuario', N'P') IS NOT NULL
	DROP PROCEDURE [PISOS_PICADOS].quitarHotelAUsuario;

/* Creacion De Tablas */
CREATE TABLE [PISOS_PICADOS].Rol (
	idRol INT PRIMARY KEY IDENTITY
	,nombreRol VARCHAR(255)
	,estado BIT DEFAULT 1
	)

CREATE TABLE [PISOS_PICADOS].Pais (
	idPais INT PRIMARY KEY IDENTITY
	,nombrePais VARCHAR(255)
	)

CREATE TABLE [PISOS_PICADOS].EstadoUsuario (
	idEstado INT PRIMARY KEY IDENTITY
	,detalleEstado VARCHAR(255)
	)

CREATE TABLE [PISOS_PICADOS].Usuario (
	idUsuario INT PRIMARY KEY IDENTITY
	,nombre VARCHAR(255)
	,apellido VARCHAR(255)
	,mail VARCHAR(255)
	,telefono VARCHAR(255) DEFAULT NULL
	,calle VARCHAR(255)
	,nroCalle INT
	,localidad VARCHAR(255) DEFAULT NULL
	,pais INT REFERENCES [PISOS_PICADOS].Pais
	,tipoIdentificacion VARCHAR(255) DEFAULT 'Pasaporte'
	,numeroIdentificacion INT
	,fechaNacimiento DATE
	,estado INT REFERENCES [PISOS_PICADOS].EstadoUsuario
	)

CREATE TABLE [PISOS_PICADOS].Cliente (
	idUsuario INT PRIMARY KEY REFERENCES [PISOS_PICADOS].Usuario(idUsuario)
	,nacionalidad VARCHAR(255) DEFAULT 'ARGENTINO'
	)

CREATE TABLE [PISOS_PICADOS].Empleado (
	idUsuario INT PRIMARY KEY REFERENCES [PISOS_PICADOS].Usuario(idUsuario)
	,usuario VARCHAR(255) UNIQUE
	,contrasena VARCHAR(255)
	,intentos INT DEFAULT 0
	)

CREATE TABLE [PISOS_PICADOS].Hotel (
	idHotel INT PRIMARY KEY IDENTITY
	,nombre VARCHAR(255) DEFAULT NULL
	,mail VARCHAR(255) DEFAULT NULL
	,telefono VARCHAR(255) DEFAULT NULL
	,calle VARCHAR(255)
	,nroCalle INT
	,ciudad VARCHAR(255)
	,pais INT REFERENCES [PISOS_PICADOS].Pais DEFAULT NULL
	,fechaCreacion DATE DEFAULT NULL
	,estrellas INT
	)

CREATE TABLE [PISOS_PICADOS].EmpleadoxHotel (
	idUsuario INT REFERENCES [PISOS_PICADOS].Empleado
	,idHotel INT REFERENCES [PISOS_PICADOS].Hotel PRIMARY KEY (
		idUsuario
		,idHotel
		)
	)

CREATE TABLE [PISOS_PICADOS].Regimen (
	codigoRegimen INT PRIMARY KEY IDENTITY
	,nombre VARCHAR(255) DEFAULT NULL
	,descripcion VARCHAR(255)
	,precioBase NUMERIC(6, 2)
	,estado BIT DEFAULT 1
	)

CREATE TABLE [PISOS_PICADOS].RegimenxHotel (
	codigoRegimen INT REFERENCES [PISOS_PICADOS].Regimen
	,idHotel INT REFERENCES [PISOS_PICADOS].Hotel PRIMARY KEY (
		codigoRegimen
		,idHotel
		)
	)

CREATE TABLE [PISOS_PICADOS].Tipo (
	idTipo INT PRIMARY KEY IDENTITY
	,tipoCamas VARCHAR(255)
	,porcentual NUMERIC(3, 2)
	)

CREATE TABLE [PISOS_PICADOS].Habitacion (
	idHabitacion INT PRIMARY KEY IDENTITY
	,numero INT
	,idHotel INT
	,frente CHAR(1)
	,tipo INT REFERENCES [PISOS_PICADOS].Tipo
	,descripcion VARCHAR(255) DEFAULT NULL
	,piso INT
	,habilitada BIT DEFAULT 1
	,
	)

CREATE TABLE [PISOS_PICADOS].Funcionalidad (
	idFuncionalidad INT PRIMARY KEY IDENTITY
	,descripcion VARCHAR(255)
	)

CREATE TABLE [PISOS_PICADOS].RolxFuncionalidad (
	idRol INT REFERENCES [PISOS_PICADOS].Rol
	,idFuncionalidad INT REFERENCES [PISOS_PICADOS].Funcionalidad
	,PRIMARY KEY (
		idRol
		,idFuncionalidad
		)
	)

CREATE TABLE [PISOS_PICADOS].RolxUsuario (
	idRol INT REFERENCES [PISOS_PICADOS].Rol
	,idUsuario INT REFERENCES [PISOS_PICADOS].Usuario
	,PRIMARY KEY (
		idRol
		,idUsuario
		)
	)

CREATE TABLE [PISOS_PICADOS].Estado (
	idEstado INT PRIMARY KEY IDENTITY
	,descripcion VARCHAR(255) DEFAULT NULL
	)

CREATE TABLE [PISOS_PICADOS].Reserva (
	codigoReserva INT PRIMARY KEY IDENTITY(10001, 1)
	,fechaRealizacion DATE DEFAULT NULL
	,fechaInicio DATE
	,fechaFin DATE DEFAULT NULL
	,cantidadHuespedes INT DEFAULT NULL
	,codigoRegimen INT REFERENCES [PISOS_PICADOS].Regimen
	,estado INT REFERENCES [PISOS_PICADOS].Estado DEFAULT NULL
	,idCliente INT REFERENCES [PISOS_PICADOS].Cliente
	,precioTotal INT DEFAULT NULL
	)

CREATE TABLE [PISOS_PICADOS].Modificacion (
	codigoModificacion INT PRIMARY KEY IDENTITY
	,estadoReserva INT REFERENCES [PISOS_PICADOS].Estado
	,descripcion VARCHAR(255)
	,usuario INT REFERENCES [PISOS_PICADOS].Usuario
	,fecha DATE
	)

CREATE TABLE [PISOS_PICADOS].HabitacionxReserva (
	idHabitacion INT REFERENCES [PISOS_PICADOS].Habitacion
	,codigoReserva INT REFERENCES [PISOS_PICADOS].Reserva
	,PRIMARY KEY (
		idHabitacion
		,codigoReserva
		)
	)

CREATE TABLE [PISOS_PICADOS].Estadia (
	idEstadia INT PRIMARY KEY IDENTITY
	,codigoReserva INT REFERENCES [PISOS_PICADOS].Reserva
	,fechaCheckIn DATE DEFAULT NULL
	,encargadoCheckIn INT REFERENCES [PISOS_PICADOS].Empleado DEFAULT NULL
	,fechaCheckOut DATE DEFAULT NULL
	,encargadoCheckOut INT REFERENCES [PISOS_PICADOS].Empleado DEFAULT NULL
	,diasReserva INT
	,diasEstadia INT
	,estado INT DEFAULT 1
	)

CREATE TABLE [PISOS_PICADOS].Consumible (
	idConsumible INT PRIMARY KEY IDENTITY(2324, 1)
	,precio NUMERIC(6, 2)
	,descripcion VARCHAR(255)
	)

CREATE TABLE [PISOS_PICADOS].EstadiaxConsumible (
	idEstadia INT REFERENCES [PISOS_PICADOS].Estadia
	,idConsumible INT REFERENCES [PISOS_PICADOS].Consumible
	,cantidad INT
	,PRIMARY KEY (
		idEstadia
		,idConsumible
		)
	)

CREATE TABLE [PISOS_PICADOS].FormaDePago (
	idFormaDePago INT PRIMARY KEY IDENTITY
	,descripcion VARCHAR(255)
	,numeroTarjeta INT
	)

CREATE TABLE [PISOS_PICADOS].Factura (
	numeroFactura INT PRIMARY KEY IDENTITY(2396745, 1)
	,fecha DATE
	,idEstadia INT REFERENCES [PISOS_PICADOS].Estadia
	,formaDePago INT REFERENCES [PISOS_PICADOS].FormaDePago DEFAULT NULL
	,cliente INT REFERENCES [PISOS_PICADOS].Cliente
	,total NUMERIC(8, 2)
	)

CREATE TABLE [PISOS_PICADOS].RenglonFactura (
	numeroRenglon INT
	,numeroFactura INT REFERENCES [PISOS_PICADOS].Factura
	,consumible INT REFERENCES [PISOS_PICADOS].Consumible
	,cantidad INT
	,precio NUMERIC(6, 2)
	,total NUMERIC(8, 2)
	,estadia INT REFERENCES [PISOS_PICADOS].Estadia
	,PRIMARY KEY (
		numeroRenglon
		,numeroFactura
		)
	)

CREATE TABLE [PISOS_PICADOS].BajaHotel (
	idBaja INT PRIMARY KEY
	,idHotel INT REFERENCES [PISOS_PICADOS].Hotel
	,fechaInicio DATE
	,fechaFin DATE
	,razon VARCHAR(255)
	)

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Afganistán');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Islas Gland');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Albania');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Alemania');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Andorra');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Angola');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Anguilla');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Antártida');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Antigua y Barbuda');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Antillas Holandesas');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Arabia Saudí');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Argelia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Argentina');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Armenia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Aruba');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Australia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Austria');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Azerbaiyán');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Bahamas');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Bahréin');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Bangladesh');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Barbados');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Bielorrusia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Bélgica');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Belice');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Benin');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Bermudas');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Bhután');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Bolivia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Bosnia y Herzegovina');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Botsuana');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Isla Bouvet');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Brasil');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Brunéi');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Bulgaria');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Burkina Faso');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Burundi');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Cabo Verde');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Islas Caimán');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Camboya');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Camerún');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Canadá');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('República Centroafricana');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Chad');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('República Checa');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Chile');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('China');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Chipre');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Isla de Navidad');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Ciudad del Vaticano');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Islas Cocos');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Colombia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Comoras');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('República Democrática del Congo');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Congo');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Islas Cook');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Corea del Norte');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Corea del Sur');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Costa de Marfil');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Costa Rica');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Croacia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Cuba');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Dinamarca');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Dominica');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('República Dominicana');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Ecuador');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Egipto');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('El Salvador');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Emiratos Árabes Unidos');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Eritrea');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Eslovaquia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Eslovenia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('España');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Islas ultramarinas de Estados Unidos');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Estados Unidos');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Estonia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Etiopía');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Islas Feroe');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Filipinas');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Finlandia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Fiyi');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Francia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Gabón');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Gambia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Georgia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Islas Georgias del Sur y Sandwich del Sur');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Ghana');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Gibraltar');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Granada');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Grecia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Groenlandia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Guadalupe');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Guam');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Guatemala');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Guayana Francesa');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Guinea');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Guinea Ecuatorial');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Guinea-Bissau');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Guyana');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Haití');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Islas Heard y McDonald');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Honduras');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Hong Kong');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Hungría');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('India');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Indonesia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Irán');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Iraq');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Irlanda');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Islandia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Israel');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Italia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Jamaica');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Japón');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Jordania');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Kazajstán');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Kenia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Kirguistán');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Kiribati');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Kuwait');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Laos');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Lesotho');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Letonia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Líbano');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Liberia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Libia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Liechtenstein');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Lituania');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Luxemburgo');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Macao');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('ARY Macedonia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Madagascar');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Malasia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Malawi');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Maldivas');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Malí');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Malta');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Islas Malvinas');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Islas Marianas del Norte');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Marruecos');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Islas Marshall');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Martinica');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Mauricio');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Mauritania');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Mayotte');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('México');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Micronesia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Moldavia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Mónaco');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Mongolia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Montserrat');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Mozambique');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Myanmar');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Namibia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Nauru');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Nepal');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Nicaragua');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Níger');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Nigeria');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Niue');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Isla Norfolk');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Noruega');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Nueva Caledonia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Nueva Zelanda');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Omán');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Países Bajos');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Pakistán');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Palau');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Palestina');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Panamá');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Papúa Nueva Guinea');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Paraguay');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Perú');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Islas Pitcairn');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Polinesia Francesa');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Polonia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Portugal');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Puerto Rico');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Qatar');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Reino Unido');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Reunión');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Ruanda');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Rumania');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Rusia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Sahara Occidental');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Islas Salomón');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Samoa');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Samoa Americana');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('San Cristóbal y Nevis');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('San Marino');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('San Pedro y Miquelón');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('San Vicente y las Granadinas');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Santa Helena');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Santa Lucía');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Santo Tomé y Príncipe');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Senegal');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Serbia y Montenegro');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Seychelles');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Sierra Leona');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Singapur');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Siria');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Somalia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Sri Lanka');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Suazilandia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Sudáfrica');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Sudán');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Suecia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Suiza');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Surinam');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Svalbard y Jan Mayen');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Tailandia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Taiwán');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Tanzania');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Tayikistán');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Territorio Británico del Océano Índico');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Territorios Australes Franceses');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Timor Oriental');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Togo');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Tokelau');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Tonga');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Trinidad y Tobago');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Túnez');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Islas Turcas y Caicos');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Turkmenistán');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Turquía');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Tuvalu');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Ucrania');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Uganda');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Uruguay');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Uzbekistán');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Vanuatu');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Venezuela');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Vietnam');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('slas Vírgenes Británicas');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Islas Vírgenes de los Estados Unidos');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Wallis y Futuna');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Yemen');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Yibuti');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Zambia');

INSERT INTO [PISOS_PICADOS].Pais
VALUES ('Zimbabue');

INSERT INTO [PISOS_PICADOS].Rol
VALUES (
	'Administrador'
	,1
	);

INSERT INTO [PISOS_PICADOS].Rol
VALUES (
	'Recepcionista'
	,1
	);

INSERT INTO [PISOS_PICADOS].Rol
VALUES (
	'Guest'
	,1
	);

INSERT INTO [PISOS_PICADOS].Funcionalidad
VALUES ('ABM_ROL');

INSERT INTO [PISOS_PICADOS].Funcionalidad
VALUES ('ABM_USUARIO');

INSERT INTO [PISOS_PICADOS].Funcionalidad
VALUES ('ABM_CLIENTE');

INSERT INTO [PISOS_PICADOS].Funcionalidad
VALUES ('ABM_HOTEL');

INSERT INTO [PISOS_PICADOS].Funcionalidad
VALUES ('ABM_HABITACION');

INSERT INTO [PISOS_PICADOS].Funcionalidad
VALUES ('ABM_REGIMEN_ESTADIA');

INSERT INTO [PISOS_PICADOS].Funcionalidad
VALUES ('GENERAR_RESERVA');

INSERT INTO [PISOS_PICADOS].Funcionalidad
VALUES ('MODIFICAR_RESERVA');

INSERT INTO [PISOS_PICADOS].Funcionalidad
VALUES ('CANCELAR_RESERVA');

INSERT INTO [PISOS_PICADOS].Funcionalidad
VALUES ('REGISTRAR_ESTADIA');

INSERT INTO [PISOS_PICADOS].Funcionalidad
VALUES ('REGISTRAR_CONSUMIBLES');

INSERT INTO [PISOS_PICADOS].Funcionalidad
VALUES ('FACTURAR_ESTADIA');

INSERT INTO [PISOS_PICADOS].Funcionalidad
VALUES ('LISTADO_ESTADISTICO');

INSERT INTO [PISOS_PICADOS].EstadoUsuario
VALUES ('Habilitado')

INSERT INTO [PISOS_PICADOS].EstadoUsuario
VALUES ('Deshabilitado')

INSERT INTO [PISOS_PICADOS].EstadoUsuario
VALUES ('Pasaporte Repetido')

INSERT INTO [PISOS_PICADOS].EstadoUsuario
VALUES ('Mail Repetido')

SET IDENTITY_INSERT [PISOS_PICADOS].Usuario ON

INSERT INTO [PISOS_PICADOS].Usuario (
	idUsuario
	,nombre
	,apellido
	,mail
	,calle
	,nroCalle
	,pais
	,numeroIdentificacion
	,fechaNacimiento
	)
VALUES (
	96945
	,'admin'
	,'admin'
	,'admin@gmail.com'
	,'admincalle'
	,123
	,13
	,12345678
	,'1997-05-01'
	);

SET IDENTITY_INSERT [PISOS_PICADOS].Usuario OFF

INSERT INTO [PISOS_PICADOS].Empleado (
	idUsuario
	,usuario
	,contrasena
	)
VALUES (
	96945
	,'admin'
	,HASHBYTES('SHA2_256', 'w23e')
	);

SET IDENTITY_INSERT [PISOS_PICADOS].Consumible ON

INSERT INTO [PISOS_PICADOS].Consumible (
	idConsumible
	,precio
	,descripcion
	)
SELECT DISTINCT Consumible_Codigo
	,Consumible_Precio
	,Consumible_Descripcion
FROM [gd_esquema].Maestra
WHERE Consumible_Codigo IS NOT NULL
ORDER BY Consumible_Codigo;

SET IDENTITY_INSERT [PISOS_PICADOS].Consumible OFF

INSERT INTO [PISOS_PICADOS].Regimen (
	descripcion
	,precioBase
	)
SELECT DISTINCT Regimen_Descripcion
	,Regimen_Precio
FROM [gd_esquema].Maestra;

INSERT INTO [PISOS_PICADOS].Tipo
SELECT DISTINCT Habitacion_Tipo_Descripcion
	,Habitacion_Tipo_Porcentual
FROM [gd_esquema].Maestra
ORDER BY Habitacion_Tipo_Porcentual;

INSERT INTO [PISOS_PICADOS].Usuario (
	nombre
	,apellido
	,mail
	,calle
	,numeroIdentificacion
	,fechaNacimiento
	)
SELECT DISTINCT Cliente_Nombre
	,Cliente_Apellido
	,Cliente_Mail
	,Cliente_Dom_Calle
	,Cliente_Pasaporte_Nro
	,Cliente_Fecha_Nac
FROM [gd_esquema].Maestra;

UPDATE [PISOS_PICADOS].Usuario
SET pais = 13
WHERE pais IS NULL;

INSERT INTO [PISOS_PICADOS].Cliente
SELECT DISTINCT Usuario.idUsuario
	,Cliente_Nacionalidad
FROM [gd_esquema].Maestra
	,[PISOS_PICADOS].Usuario
WHERE Usuario.numeroIdentificacion = Cliente_Pasaporte_Nro;

INSERT INTO [PISOS_PICADOS].Hotel (
	calle
	,nroCalle
	,ciudad
	,estrellas
	)
SELECT DISTINCT Hotel_Calle
	,Hotel_Nro_Calle
	,Hotel_Ciudad
	,Hotel_CantEstrella
FROM [gd_esquema].Maestra;

UPDATE [PISOS_PICADOS].Hotel
SET pais = 13
WHERE pais IS NULL;

INSERT INTO [PISOS_PICADOS].Habitacion (
	numero
	,idHotel
	,frente
	,tipo
	,piso
	)
SELECT DISTINCT Habitacion_Numero
	,[PISOS_PICADOS].Hotel.idHotel
	,Habitacion_Frente
	,idTipo
	,Habitacion_Piso
FROM [gd_esquema].Maestra
	,[PISOS_PICADOS].Hotel
	,[PISOS_PICADOS].Tipo
WHERE ciudad + calle = Hotel_Ciudad + Hotel_Calle
	AND Habitacion_Tipo_Descripcion = tipoCamas;

SET IDENTITY_INSERT [PISOS_PICADOS].Reserva ON

INSERT INTO [PISOS_PICADOS].Reserva (
	codigoReserva
	,fechaInicio
	,fechaFin
	,codigoRegimen
	,idCliente
	)
SELECT DISTINCT Reserva_Codigo
	,Reserva_Fecha_Inicio
	,dateadd(day, Reserva_Cant_Noches, Reserva_Fecha_Inicio)
	,Regimen.codigoRegimen
	,idUsuario
FROM [gd_esquema].Maestra
	,[PISOS_PICADOS].Usuario
	,[PISOS_PICADOS].Regimen
WHERE Usuario.numeroIdentificacion = Cliente_Pasaporte_Nro
	AND Usuario.apellido + Usuario.nombre = Cliente_Apellido + Cliente_Nombre
	AND Regimen.descripcion = Regimen_Descripcion;

SET IDENTITY_INSERT [PISOS_PICADOS].Reserva OFF

INSERT INTO [PISOS_PICADOS].Estado (descripcion)
VALUES ('Reserva correcta');

INSERT INTO [PISOS_PICADOS].Estado (descripcion)
VALUES ('Reserva modificada');

INSERT INTO [PISOS_PICADOS].Estado (descripcion)
VALUES ('Reserva cancelada por recepción');

INSERT INTO [PISOS_PICADOS].Estado (descripcion)
VALUES ('Reserva cancelada por cliente');

INSERT INTO [PISOS_PICADOS].Estado (descripcion)
VALUES ('Reserva cancelada por No-Show');

INSERT INTO [PISOS_PICADOS].Estado (descripcion)
VALUES ('Reserva efectivizada');

INSERT INTO [PISOS_PICADOS].EmpleadoxHotel (
	idUsuario
	,idHotel
	)
SELECT idUsuario
	,idHotel
FROM PISOS_PICADOS.Hotel
	,PISOS_PICADOS.Empleado

INSERT INTO [PISOS_PICADOS].RegimenxHotel (
	codigoRegimen
	,idHotel
	)
SELECT DISTINCT codigoRegimen
	,idHotel
FROM [gd_esquema].Maestra
	,[PISOS_PICADOS].Hotel
	,[PISOS_PICADOS].Regimen
WHERE descripcion = Regimen_Descripcion
	AND Hotel_Calle + Hotel_Ciudad = calle + ciudad

INSERT INTO [PISOS_PICADOS].RolxFuncionalidad
SELECT idRol
	,idFuncionalidad
FROM [PISOS_PICADOS].Rol
	,[PISOS_PICADOS].Funcionalidad
WHERE nombreRol = 'Guest'
	AND (
		Funcionalidad.descripcion = 'GENERAR_RESERVA'
		OR Funcionalidad.descripcion = 'MODIFICAR_RESERVA'
		OR Funcionalidad.descripcion = 'CANCELAR_RESERVA'
		)

INSERT INTO [PISOS_PICADOS].RolxFuncionalidad
SELECT idRol
	,idFuncionalidad
FROM [PISOS_PICADOS].Rol
	,[PISOS_PICADOS].Funcionalidad
WHERE nombreRol = 'Recepcionista'
	AND (
		Funcionalidad.descripcion = 'GENERAR_RESERVA'
		OR Funcionalidad.descripcion = 'MODIFICAR_RESERVA'
		OR Funcionalidad.descripcion = 'CANCELAR_RESERVA'
		OR Funcionalidad.descripcion = 'REGISTRAR_ESTADIA'
		OR Funcionalidad.descripcion = 'REGISTRAR_CONSUMIBLES'
		OR Funcionalidad.descripcion = 'FACTURAR_ESTADIA'
		)

INSERT INTO [PISOS_PICADOS].RolxFuncionalidad
SELECT idRol
	,idFuncionalidad
FROM [PISOS_PICADOS].Rol
	,[PISOS_PICADOS].Funcionalidad
WHERE nombreRol = 'Administrador'
	AND (
		Funcionalidad.descripcion = 'ABM_ROL'
		OR Funcionalidad.descripcion = 'ABM_USUARIO'
		OR Funcionalidad.descripcion = 'ABM_CLIENTE'
		OR Funcionalidad.descripcion = 'ABM_HOTEL'
		OR Funcionalidad.descripcion = 'ABM_HABITACION'
		OR Funcionalidad.descripcion = 'ABM_REGIMEN_ESTADIA'
		OR Funcionalidad.descripcion = 'GENERAR_RESERVA'
		OR Funcionalidad.descripcion = 'MODIFICAR_RESERVA'
		OR Funcionalidad.descripcion = 'CANCELAR_RESERVA'
		OR Funcionalidad.descripcion = 'REGISTRAR_ESTADIA'
		OR Funcionalidad.descripcion = 'REGISTRAR_CONSUMIBLES'
		OR Funcionalidad.descripcion = 'FACTURAR_ESTADIA'
		OR Funcionalidad.descripcion = 'LISTADO_ESTADISTICO'
		)

INSERT INTO [PISOS_PICADOS].RolxUsuario (
	idRol
	,idUsuario
	)
SELECT DISTINCT 3
	,idUsuario
FROM [PISOS_PICADOS].Usuario
	,[PISOS_PICADOS].Rol
WHERE usuario.nombre <> 'admin'
	AND usuario.apellido <> 'admin'

INSERT INTO [PISOS_PICADOS].RolxUsuario (
	idRol
	,idUsuario
	)
SELECT DISTINCT 1
	,idUsuario
FROM [PISOS_PICADOS].Usuario
	,[PISOS_PICADOS].Rol
WHERE usuario.nombre = 'admin'
	AND usuario.apellido = 'admin'

INSERT INTO [PISOS_PICADOS].HabitacionxReserva (
	idHabitacion
	,codigoReserva
	)
SELECT DISTINCT idHabitacion
	,Reserva.codigoReserva
FROM [gd_esquema].Maestra
	,[PISOS_PICADOS].Habitacion
	,[PISOS_PICADOS].Reserva
WHERE Reserva.codigoReserva = Reserva_Codigo
	AND idHabitacion = (
		SELECT DISTINCT a.idHabitacion
		FROM [PISOS_PICADOS].Habitacion AS a
		WHERE a.numero = Habitacion_Numero
			AND a.idHotel = (
				SELECT b.idHotel
				FROM [PISOS_PICADOS].Hotel AS b
				WHERE b.ciudad = Hotel_Ciudad
					AND b.calle = Hotel_Calle
				)
		)

INSERT INTO [PISOS_PICADOS].Estadia (
	codigoReserva
	,fechaCheckIn
	,fechaCheckOut
	)
SELECT codigoReserva
	,fechaInicio
	,fechaFin
FROM [PISOS_PICADOS].Reserva
INNER JOIN [gd_esquema].Maestra ON codigoReserva = Reserva_Codigo
WHERE Factura_Nro IS NOT NULL
GROUP BY Factura_Nro
	,codigoReserva
	,fechaInicio
	,fechaFin

INSERT INTO [PISOS_PICADOS].EstadiaxConsumible
SELECT idEstadia
	,Consumible_Codigo
	,count(*)
FROM [PISOS_PICADOS].Estadia
INNER JOIN [gd_esquema].Maestra ON codigoReserva = Reserva_Codigo
WHERE Consumible_Codigo IS NOT NULL
GROUP BY idEstadia
	,Consumible_Codigo

SET IDENTITY_INSERT [PISOS_PICADOS].Factura ON

INSERT INTO [PISOS_PICADOS].Factura (
	numeroFactura
	,cliente
	,total
	,idEstadia
	,fecha
	)
SELECT Factura_Nro
	,idUsuario
	,Factura_Total
	,idEstadia
	,Factura_Fecha
FROM [PISOS_PICADOS].Usuario
	,[gd_esquema].Maestra
	,[PISOS_PICADOS].Estadia AS es
WHERE Cliente_Apellido + Cliente_Nombre = apellido + nombre
	AND Cliente_Pasaporte_Nro = numeroIdentificacion
	AND Factura_Total IS NOT NULL
	AND es.codigoReserva = Reserva_Codigo
GROUP BY Factura_Nro
	,idUsuario
	,Factura_Total
	,idEstadia
	,Factura_Fecha

SET IDENTITY_INSERT [PISOS_PICADOS].Factura OFF

INSERT INTO [PISOS_PICADOS].RenglonFactura (
	numeroRenglon
	,numeroFactura
	,consumible
	,cantidad
	,precio
	,total
	,estadia
	)
SELECT ROW_NUMBER() OVER (
		PARTITION BY Factura_Nro ORDER BY Consumible_Codigo
		)
	,Factura_Nro
	,Consumible_Codigo
	,count(*)
	,Consumible_Precio
	,count(*) * Consumible_Precio
	,idEstadia
FROM [PISOS_PICADOS].Estadia
INNER JOIN [gd_esquema].Maestra ON codigoReserva = Reserva_Codigo
WHERE Factura_Nro IS NOT NULL
	AND Consumible_Codigo IS NOT NULL
GROUP BY Factura_Nro
	,Consumible_Codigo
	,Consumible_Precio
	,idEstadia
GO

/*Migracion FIN-------------------------------------------------------------------*/
/* FUNCIONES ---------------------------------------------------------------------*/
/* Dado un nombre apellido y pasaporte informa el id de usuario correspondiente    */
CREATE FUNCTION [PISOS_PICADOS].obtenerIDUsuario (
	@nombre VARCHAR(255)
	,@apellido VARCHAR(255)
	,@numeroIdentificacion INT
	)
RETURNS INT
AS
BEGIN
	RETURN (
			SELECT idUsuario
			FROM [PISOS_PICADOS].Usuario
			WHERE nombre = @nombre
				AND apellido = @apellido
				AND numeroIdentificacion = @numeroIdentificacion
			)
END
GO

/* Dado un nombre apellido y num de identificacion informa de la existencia de un id de usuario que se
 corresponda con esos datos*/
CREATE FUNCTION [PISOS_PICADOS].existeUsuario (
	@nombre VARCHAR(255)
	,@apellido VARCHAR(255)
	,@numeroIdentificacion INT
	)
RETURNS INT
AS
BEGIN
	IF EXISTS (
			SELECT idUsuario
			FROM [PISOS_PICADOS].Usuario
			WHERE nombre = @nombre
				AND apellido = @apellido
				AND numeroIdentificacion = @numeroIdentificacion
			)
		RETURN 1

	RETURN 0
END
GO

/* Dado un id de usuario informa el estado correspondiente al usuario. 1 habilitado , 2 inhabilitado , 3 
pasaporteRepetido, 4 MailRepetido */
CREATE FUNCTION [PISOS_PICADOS].obtenerEstadoUsuario (@idUsuario INT)
RETURNS INT
AS
BEGIN
	RETURN (
			SELECT u.estado
			FROM [PISOS_PICADOS].Usuario AS u
			WHERE u.idUsuario = @idUsuario
			)
END
GO

/* dado un id de usuario informa un 1 si este es admin y 0 si no lo es */
CREATE FUNCTION [PISOS_PICADOS].esAdmin (@idUsuario INT)
RETURNS BIT
AS
BEGIN
	IF (
			(
				SELECT idRol
				FROM [PISOS_PICADOS].Rol
				WHERE nombreRol = 'Administrador'
				) IN (
				SELECT p.idRol
				FROM [PISOS_PICADOS].RolxUsuario AS p
				WHERE idUsuario = @idUsuario
				)
			)
		RETURN 1;

	RETURN 0;
END
GO

/* Devuelve el numero de intentos realizados para ingresar al sistema correspondientes a el nombre de 
usuario que se recibe de parametro*/
CREATE FUNCTION [PISOS_PICADOS].intentosRestantes (@usuario VARCHAR(255))
RETURNS INT
AS
BEGIN
	RETURN (
			SELECT e.intentos
			FROM [PISOS_PICADOS].Empleado AS e
			WHERE e.usuario = @usuario
			)
END
GO

/*Verifica si el estado de un empleado es deshabilitado, es decir 0 */
CREATE FUNCTION [PISOS_PICADOS].empleadoDeshabilitado (@usuario VARCHAR(255))
RETURNS INT
AS
BEGIN
	IF (
			2 = (
				SELECT u.estado
				FROM [PISOS_PICADOS].Empleado AS e
				INNER JOIN [PISOS_PICADOS].Usuario AS u ON e.idUsuario = u.idUsuario
				WHERE e.usuario = @usuario
				)
			)
		RETURN 1;

	RETURN 0;
END
GO

/* Verifica que el usuario y contraseña ingresados correspondan algun empleado registrado en la base, 
devuelve 1 si existe  */
CREATE FUNCTION [PISOS_PICADOS].usuarioValido (@usuario VARCHAR(255))
RETURNS INT
AS
BEGIN
	IF (
			@usuario IN (
				SELECT usuario
				FROM [PISOS_PICADOS].Empleado
				)
			)
		RETURN 1;

	RETURN 0;
END
GO

/* Devuelve 1 si la contraseña es correcta para un usuario*/
CREATE FUNCTION [PISOS_PICADOS].contrasenaValida (
	@usuario VARCHAR(255)
	,@contrasena VARCHAR(255)
	)
RETURNS INT
AS
BEGIN
	IF (
			HASHBYTES('SHA2_256', @contrasena) IN (
				SELECT contrasena
				FROM [PISOS_PICADOS].Empleado AS e
				WHERE e.usuario = @usuario
				)
			)
		RETURN 1;

	RETURN 0;
END
GO

/*Devuelve la cantidad de intentos de inicio de sesion para un usuario */
CREATE FUNCTION [PISOS_PICADOS].cantidadIntentosFallidos (@usuario VARCHAR(255))
RETURNS INT
AS
BEGIN
	RETURN (
			SELECT intentos
			FROM [PISOS_PICADOS].Empleado
			WHERE usuario = @usuario
			)
END
GO

/* Dado un usuario revuelve 1 si este tiene un solo rol */
CREATE FUNCTION [PISOS_PICADOS].tieneUnSoloRol (@usuario VARCHAR(255))
RETURNS INT
AS
BEGIN
	IF (
			(
				SELECT COUNT(DISTINCT rxu.idRol)
				FROM [PISOS_PICADOS].Empleado AS e
				INNER JOIN [PISOS_PICADOS].Usuario AS u ON e.idUsuario = u.idUsuario
				INNER JOIN [PISOS_PICADOS].RolxUsuario AS rxu ON u.idUsuario = rxu.idUsuario
				WHERE e.usuario = @usuario
				GROUP BY e.idUsuario
				) > 1
			)
		RETURN 0

	RETURN 1
END
GO

/* Dado un el usuario de un empleado devuelve su rol */
CREATE FUNCTION [PISOS_PICADOS].obtenerRol (@usuario VARCHAR(255))
RETURNS INT
AS
BEGIN
	RETURN (
			(
				SELECT rxu.idRol
				FROM [PISOS_PICADOS].Empleado AS e
				INNER JOIN [PISOS_PICADOS].Usuario AS u ON e.idUsuario = u.idUsuario
				INNER JOIN [PISOS_PICADOS].RolxUsuario AS rxu ON u.idUsuario = rxu.idUsuario
				WHERE e.usuario = @usuario
				)
			)

	RETURN 0

	RETURN 1
END
GO

/* Dada el usuario y contraseña correspondiete, se devuelve el id de usuario al cual pertenece */
CREATE FUNCTION [PISOS_PICADOS].obtenerIDUsuarioEmpleado (
	@usuario VARCHAR(255)
	,@contrasena VARCHAR(255)
	)
RETURNS INT
AS
BEGIN
	RETURN (
			SELECT idUsuario
			FROM [PISOS_PICADOS].Empleado
			WHERE usuario = @usuario
				AND contrasena = HASHBYTES('SHA2_256', @contrasena)
			)
END
GO

/* Verifica que un numero de identificacion de un determinado tipo dado no se encuentra ya 
registrado en la base de datos*/
CREATE FUNCTION [PISOS_PICADOS].estaRepetido (
	@tipo VARCHAR(255)
	,@numero INT
	)
RETURNS INT
AS
BEGIN
	IF (
			@numero IN (
				SELECT u.numeroIdentificacion
				FROM [PISOS_PICADOS].Usuario AS u
				WHERE u.tipoIdentificacion = @tipo
				GROUP BY u.numeroIdentificacion
				HAVING COUNT(DISTINCT (u.nombre + u.apellido)) >= 1
				)
			)
		RETURN 1;

	RETURN 0;
END
GO

/* Verifica que un mail dado no se encuentre registrado en la base de datos */
CREATE FUNCTION [PISOS_PICADOS].estaRepetidoMail (@mail VARCHAR(255))
RETURNS INT
AS
BEGIN
	IF (
			@mail IN (
				SELECT u.mail
				FROM [PISOS_PICADOS].Usuario AS u
				GROUP BY u.mail
				HAVING COUNT(DISTINCT (u.numeroIdentificacion)) >= 1
				)
			)
		RETURN 1;

	RETURN 0;
END
GO

/* Crear un filtro de los clientes por 5 parametros. pueden estar los 5 filtros o un subconjunto del mismo */
CREATE FUNCTION [PISOS_PICADOS].filtroClientes (
	@nombre VARCHAR(255)
	,@apellido VARCHAR(255)
	,@tipoIden VARCHAR(255)
	,@numIdem INT
	,@mail VARCHAR(255)
	)
RETURNS TABLE
AS
RETURN (
		SELECT u.idUsuario
			,u.nombre
			,u.apellido
			,u.mail
			,u.telefono
			,u.calle
			,u.nroCalle
			,u.localidad
			,u.pais
			,u.tipoIdentificacion
			,u.numeroIdentificacion
			,u.fechaNacimiento
			,u.estado
			,c.nacionalidad
		FROM [PISOS_PICADOS].Usuario AS u
		INNER JOIN [PISOS_PICADOS].Cliente AS c ON u.idUsuario = c.idUsuario
		WHERE (
				(
					u.nombre = @nombre
					OR @nombre IS NULL
					)
				AND (
					u.apellido = @apellido
					OR @apellido IS NULL
					)
				AND (
					u.tipoIdentificacion = @tipoIden
					OR @tipoIden IS NULL
					)
				AND (
					u.numeroIdentificacion = @numIdem
					OR @numIdem IS NULL
					)
				AND (
					u.mail = @mail
					OR @mail IS NULL
					)
				)
		)
GO

/* Dado un nombre de rol verifica si este exite en la base de datos, si es asi devuelve 1 */
CREATE FUNCTION [PISOS_PICADOS].existeRol (@nombreRol VARCHAR(255))
RETURNS INT
AS
BEGIN
	IF (
			@nombreRol IN (
				SELECT nombreRol
				FROM [PISOS_PICADOS].Rol
				)
			)
		RETURN 1;

	RETURN 0;
END
GO

/* Dado un nombre de pais informa su id Correspondiente*/
CREATE FUNCTION [PISOS_PICADOS].obtenerIDPais (@nombre VARCHAR(255))
RETURNS INT
AS
BEGIN
	RETURN (
			SELECT idPais
			FROM [PISOS_PICADOS].Pais
			WHERE nombrePais = @nombre
			)
END
GO

/* Dada una ciudad calle y nroCalle devuelve el id de hotel correspondiente */
CREATE FUNCTION [PISOS_PICADOS].obtenerIDHotel (
	@ciudad VARCHAR(255)
	,@calle VARCHAR(255)
	,@nroCalle VARCHAR(255)
	)
RETURNS INT
AS
BEGIN
	RETURN (
			SELECT idHotel
			FROM [PISOS_PICADOS].Hotel
			WHERE calle = @calle
				AND ciudad = @ciudad
				AND nroCalle = nroCalle
			)
END
GO

/*Verifica dado un numero de habitacion y un id de hotel, si ese numero de habitacion pertenece a ese hotel
Devuelve 1 si pertenece y 0 si no lo hace*/
CREATE FUNCTION [PISOS_PICADOS].existeNumEnHotel (
	@idHotel INT
	,@numero INT
	)
RETURNS INT
AS
BEGIN
	IF (
			@numero IN (
				SELECT numero
				FROM [PISOS_PICADOS].Habitacion
				WHERE idHotel = @idHotel
				)
			)
		RETURN 1;

	RETURN 0;
END
GO

/*Devuelvo 1 si un hotel tiene una reserva para el periodo de inicio y fin dados por parametro. utilizado para saber si
se puede dar de baja el hotel en tal fecha*/
CREATE FUNCTION [PISOS_PICADOS].hotelTieneReservas (
	@idHotel INT
	,@fechaInicio DATE
	,@fechaFin DATE
	)
RETURNS BIT
AS
BEGIN
	IF EXISTS (
			SELECT IdHabitacion
				,codigoReserva
			FROM [PISOS_PICADOS].HabitacionxReserva AS p
			WHERE p.idHabitacion IN (
					SELECT idHabitacion
					FROM [PISOS_PICADOS].Habitacion
					WHERE idHotel = @idHotel
					)
				AND EXISTS (
					SELECT fechaInicio
						,fechaFin
					FROM [PISOS_PICADOS].Reserva
					WHERE p.codigoReserva = codigoReserva
						AND (
							@fechaInicio BETWEEN fechaInicio
								AND fechaFin
							OR @fechaFin BETWEEN fechaInicio
								AND fechaFin
							)
					)
			)
		RETURN 1;

	RETURN 0;
END
GO
/*Permite saber si un id de hotel se encuentra dado de baja(devuelve 1) en una determinada fecha 
para saber si le se puede asignar o no una reserva  */
CREATE FUNCTION [PISOS_PICADOS].habilitadoHotel (
	@idHotel INT
	,@fechaReserva DATE
	)
RETURNS INT
AS
BEGIN
	IF (
			@idHotel IN (
				SELECT idHotel
				FROM [PISOS_PICADOS].BajaHotel
				WHERE @fechaReserva BETWEEN fechaInicio
						AND fechaFin
				)
			)
		RETURN 1;

	RETURN 0;
END
GO

/*Dado un id de reserva permite conocer su regimen */
CREATE FUNCTION [PISOS_PICADOS].consultarRegimen (@idReserva INT)
RETURNS VARCHAR(255)
AS
BEGIN
	RETURN (
			SELECT descripcion
			FROM [PISOS_PICADOS].Regimen AS r
			JOIN [PISOS_PICADOS].Reserva AS re ON
			r.codigoRegimen = re.codigoRegimen
			WHERE re.codigoReserva = @idReserva
			)
END
GO

/*Dado una estadia devuelve el valor total para todos los consumibles*/
CREATE FUNCTION [PISOS_PICADOS].netearConsumibles (@idEstadia INT)
RETURNS NUMERIC(9, 2)
AS
BEGIN
	RETURN (
			SELECT SUM(cantidad * precio)
			FROM [PISOS_PICADOS].EstadiaxConsumible
				,[PISOS_PICADOS].Consumible
			WHERE idEstadia = @idEstadia
				AND Consumible.idConsumible = EstadiaxConsumible.idConsumible
			)
END
GO

/*Dado un id de habitacion devuelve el id del hotel al que pertenece*/
CREATE FUNCTION [PISOS_PICADOS].obtenerHotelDeHabitacion (@idHabitacion INT)
RETURNS INT
AS
BEGIN
	RETURN (
			SELECT idHotel
			FROM [PISOS_PICADOS].Habitacion
			WHERE idHabitacion = @idHabitacion
			)
END
GO

/*Dado un id de hotel devuelve el incremento por las estrellas del mismo*/
CREATE FUNCTION [PISOS_PICADOS].incrementoHotel (@idHotelActual INT)
RETURNS INT
AS
BEGIN
	RETURN (
			10 * (
				SELECT estrellas
				FROM [PISOS_PICADOS].Hotel
				WHERE idHotel = @idHotelActual
				)
			)
END
GO

/*Dado un codigo de régimen devuelve su precio*/
CREATE FUNCTION [PISOS_PICADOS].precioRegimen (@codigoRegimen INT)
RETURNS INT
AS
BEGIN
	RETURN (
			SELECT precioBase
			FROM [PISOS_PICADOS].Regimen
			WHERE codigoRegimen = @codigoRegimen
			);
END
GO

/*Dado un tipo de habitacion, el regimen elegido y el id del hotel devuelve el total por dia de la habitacio */
CREATE FUNCTION [PISOS_PICADOS].precioHabitacion (
	@idTipo INT
	,@idRegimen INT
	,@idHotel INT
	)
RETURNS INT
AS
BEGIN
	RETURN (@idTipo * [PISOS_PICADOS].precioRegimen(@idRegimen) * [PISOS_PICADOS].incrementoHotel(@idHotel));
END
GO

/*Dada una fecha un hotel y una determinada cant de habitaciones de un tipo verifica si el hotel 
puede cumplir la demanda en la fecha dada*/
CREATE FUNCTION [PISOS_PICADOS].hotelCumple (
	@cantHabitaciones INT
	,@tipo INT
	,@idHotel INT
	,@fechaReserva DATE
	)
RETURNS INT
AS
BEGIN
	IF (
			@cantHabitaciones = (
				SELECT COUNT(*)
				FROM [PISOS_PICADOS].Habitacion
				WHERE tipo = @tipo
					AND idHotel = @idHotel
					AND habilitada = 1
					AND idHabitacion NOT IN (
						SELECT p.idHabitacion
						FROM [PISOS_PICADOS].Reserva AS q
						INNER JOIN [PISOS_PICADOS].HabitacionxReserva AS p ON q.codigoReserva = p.codigoReserva
						WHERE @fechaReserva  BETWEEN fechaInicio
								AND fechaFin
						)
				)
			)
		RETURN 1;
	RETURN 0;
END
GO

/*Dado un hotel un tipo de habitacion y una fecha de reserva devuelve el id de la primera habiatcion 
disponible del hotel con esas caracteristicas */
CREATE FUNCTION [PISOS_PICADOS].habitacionQueCumple (
	@tipo INT
	,@idHotel INT
	,@fechaReserva DATE
	)
RETURNS INT
AS
BEGIN
	RETURN (
			SELECT TOP 1 idHabitacion
			FROM [PISOS_PICADOS].Habitacion
			WHERE tipo = @tipo
				AND idHotel = @idHotel
				AND habilitada = 1
				AND idHabitacion NOT IN (
					SELECT p.idHabitacion
					FROM [PISOS_PICADOS].Reserva AS q
					INNER JOIN [PISOS_PICADOS].HabitacionxReserva AS p ON q.codigoReserva = p.codigoReserva
					WHERE @fechaReserva NOT BETWEEN fechaInicio
							AND fechaFin
					)
			);
END
GO

CREATE FUNCTION [PISOS_PICADOS].habilitadoCLiente (
	@nombre VARCHAR(255)
	,@apellido VARCHAR(255)
	,@numeroIdentificacion INT
	)
RETURNS INT
AS
BEGIN
	DECLARE @id INT;

	SET @id = [PISOS_PICADOS].obtenerIDUsuario(@nombre, @apellido, @numeroIdentificacion)

	IF (
			1 = (
				SELECT estado
				FROM [PISOS_PICADOS].Usuario
				WHERE idUsuario = @id
				)
			)
		RETURN 1

	RETURN 0
END
GO

CREATE FUNCTION [PISOS_PICADOS].precioReserva (
	@cantSimple INT
	,@cantDoble INT
	,@cantTriple INT
	,@cantCuadru INT
	,@cantKing INT
	,@codRegimen INT
	,@idHotel INT
	)
RETURNS INT
AS
BEGIN
	DECLARE @resultado INT

	SET @resultado = (@cantSimple * [PISOS_PICADOS].precioHabitacion(1, @codRegimen, @idHotel) + @cantDoble * [PISOS_PICADOS].precioHabitacion(2, @codRegimen, @idHotel) + @cantTriple * [PISOS_PICADOS].precioHabitacion(3, @codRegimen, @idHotel) + @cantCuadru * [PISOS_PICADOS].precioHabitacion(4, @codRegimen, @idHotel) + @cantKing * [PISOS_PICADOS].precioHabitacion(5, @codRegimen, @idHotel))

	RETURN @resultado
END
GO

CREATE FUNCTION [PISOS_PICADOS].calcularPrecioRenglones (@idEstadia INT)
RETURNS INT
AS
BEGIN
	DECLARE @total INT

	SELECT @total = SUM(ec.cantidad * c.precio)
	FROM [PISOS_PICADOS].EstadiaxConsumible AS ec
	INNER JOIN Consumible AS c ON ec.idConsumible = c.idConsumible
	WHERE ec.idEstadia = @idEstadia
	GROUP BY ec.idEstadia

	RETURN @total
END
GO

CREATE FUNCTION [PISOS_PICADOS].precioPorDia (@codReserva INT)
RETURNS INT
AS
BEGIN
	RETURN (
			SELECT r.precioTotal / DATEDIFF(DAY, r.fechaInicio, r.fechaFin)
			FROM [PISOS_PICADOS].Reserva AS r
			WHERE r.codigoReserva = @codReserva
			)
END
GO

CREATE FUNCTION [PISOS_PICADOS].calcularPrecioPorDiasHospedados (@idEstadia INT)
RETURNS INT
AS
BEGIN
	DECLARE @resultado INT

	SELECT @resultado = ISNULL(DATEDIFF(DAY, e.fechaCheckIn, e.fechaCheckOut), 0) * [PISOS_PICADOS].precioPorDia(e.codigoReserva)
	FROM [PISOS_PICADOS].Estadia AS e
	WHERE e.idEstadia = @idEstadia

	RETURN @resultado
END
GO

CREATE FUNCTION [PISOS_PICADOS].calcularPrecioPorDiasNoHospedados (@idEstadia INT)
RETURNS INT
AS
BEGIN
	DECLARE @resultado INT

	SELECT @resultado = ISNULL(DATEDIFF(DAY, e.fechaCheckOut, r.fechaRealizacion), 0) * [PISOS_PICADOS].precioPorDia(e.codigoReserva)
	FROM [PISOS_PICADOS].Estadia AS e
	INNER JOIN [PISOS_PICADOS].Reserva AS r ON e.codigoReserva = r.codigoReserva
	WHERE e.idEstadia = @idEstadia

	RETURN @resultado
END
GO

CREATE FUNCTION [PISOS_PICADOS].precioConsumible (@idCons INT)
RETURNS INT
AS
BEGIN
	RETURN (
			SELECT precio
			FROM [PISOS_PICADOS].Consumible
			WHERE idConsumible = @idCons
			)
END
GO

CREATE FUNCTION [PISOS_PICADOS].listadoHabitaciones ()
RETURNS TABLE
AS
RETURN (
		SELECT hb.idHabitacion AS idHabitacion
			,ht.idHotel AS idHotel
			,ht.nombre AS Hotel
			,hb.piso AS Piso
			,hb.numero AS Numero
			,(
				SELECT T.tipoCamas
				FROM [PISOS_PICADOS].Tipo AS t
				WHERE T.idTipo = hb.tipo
				) AS Tipo
			,hb.frente AS Frente
			,hb.descripcion AS Descripcion
			,hb.habilitada AS Habilitada
		FROM [PISOS_PICADOS].Habitacion AS hb
		INNER JOIN [PISOS_PICADOS].Hotel AS ht ON hb.idHotel = ht.idHotel
		)
GO

CREATE FUNCTION [PISOS_PICADOS].hotelesConMasCancelaciones (@anio INT
	,@trimestre INT)
RETURNS TABLE
AS
	RETURN(SELECT TOP 5 ho.idHotel
		,count(*) AS cantidad
	FROM [PISOS_PICADOS].HabitacionxReserva AS hr
	INNER JOIN [PISOS_PICADOS].Habitacion AS ha ON hr.idHabitacion = ha.idHabitacion
	INNER JOIN [PISOS_PICADOS].Hotel AS ho ON ho.idHotel = ha.idHotel
		,[PISOS_PICADOS].Reserva AS re
	INNER JOIN [PISOS_PICADOS].Estado AS es ON re.estado = es.idEstado
	INNER JOIN [PISOS_PICADOS].Modificacion AS mo ON es.idEstado = mo.estadoReserva
	WHERE re.codigoReserva = hr.codigoReserva
		AND es.descripcion = 'Cancelada'
		AND DATEPART(QUARTER, mo.fecha) = @trimestre
		AND DATEPART(YEAR, mo.fecha) = @anio
	GROUP BY ho.idHotel
	ORDER BY cantidad DESC)
GO

CREATE FUNCTION [PISOS_PICADOS].hotelesConMasConsumiblesFacturados (@anio INT
	,@trimestre INT)
RETURNS TABLE
AS
	RETURN (SELECT TOP 5 hab.idHotel
		,SUM(re.cantidad) AS consumibles
	FROM [PISOS_PICADOS].RenglonFactura AS re
	INNER JOIN [PISOS_PICADOS].Factura AS fa ON fa.numeroFactura = re.numeroFactura
	INNER JOIN [PISOS_PICADOS].Estadia AS es ON fa.idEstadia = es.idEstadia
	INNER JOIN [PISOS_PICADOS].Reserva AS res ON es.codigoReserva = res.codigoReserva
		,[PISOS_PICADOS].HabitacionxReserva AS hr
	INNER JOIN [PISOS_PICADOS].Habitacion AS hab ON hr.idHabitacion = hab.idHabitacion
	WHERE res.codigoReserva = hr.codigoReserva
		AND DATEPART(QUARTER, fa.fecha) = @trimestre
		AND DATEPART(YEAR, fa.fecha) = @anio
	GROUP BY hab.idHotel
	ORDER BY consumibles DESC)
GO

CREATE FUNCTION [PISOS_PICADOS].hotelesConMasDiasDeBaja (@anio INT
	,@trimestre INT
	,@fechaActual DATE)
	RETURNS TABLE
AS
	RETURN(SELECT TOP 5 bh.idHotel
		,SUM(CASE 
				WHEN DATEPART(QUARTER, fechaInicio) = DATEPART(QUARTER, fechaFin)
					THEN DATEDIFF(DAY, fechaInicio, fechaFin)
				WHEN DATEPART(QUARTER, fechaInicio) < DATEPART(QUARTER, fechaFin)
					AND DATEPART(QUARTER, fechaInicio) < @trimestre
					THEN DATEDIFF(DAY, DATEADD(qq, DATEDIFF(qq, 0, @fechaActual), 0), fechaFin)
				WHEN DATEPART(QUARTER, fechaInicio) < DATEPART(QUARTER, fechaFin)
					AND DATEPART(QUARTER, fechaFin) > @trimestre
					THEN DATEDIFF(DAY, fechaInicio, DATEADD(dd, - 1, DATEADD(qq, DATEDIFF(qq, 0, @fechaActual) + 1, 0)))
				END) AS diasbaja
	FROM [PISOS_PICADOS].BajaHotel AS bh
	WHERE (
			DATEPART(QUARTER, bh.fechaInicio) = @trimestre
			AND DATEPART(YEAR, bh.fechaInicio) = @anio
			)
		OR (
			DATEPART(QUARTER, bh.fechaFin) = @trimestre
			AND DATEPART(YEAR, bh.fechaFin) = @anio
			)
	GROUP BY bh.idHotel
	ORDER BY diasbaja DESC)
GO

CREATE FUNCTION [PISOS_PICADOS].topHabitacionesOcupadasVeces (@anio INT
	,@trimestre INT)
	RETURNS TABLE
AS
	RETURN(SELECT TOP 5 ha.idHotel
		,ha.idHabitacion
		,count(*) AS veces
	FROM [PISOS_PICADOS].Habitacion AS ha
	INNER JOIN [PISOS_PICADOS].HabitacionxReserva AS hr ON hr.idHabitacion = ha.idHabitacion
		,[PISOS_PICADOS].Reserva AS re
	WHERE re.codigoReserva = hr.codigoReserva
		AND (
			(
				DATEPART(YEAR, re.fechaInicio) = @anio
				AND (DATEPART(QUARTER, re.fechaInicio) = @trimestre)
				OR (
					DATEPART(YEAR, re.fechaFin) = @anio
					AND DATEPART(QUARTER, re.fechaFin) = @trimestre
					)
				)
			)
	GROUP BY ha.idHotel
		,ha.idHabitacion
	ORDER BY veces DESC)
GO

CREATE FUNCTION [PISOS_PICADOS].topHabitacionesOcupadasDias (@anio INT
	,@trimestre INT
	,@fechaActual DATE)
	RETURNS TABLE
AS
	RETURN (SELECT TOP 5 ha.idHotel
		,ha.idHabitacion
		,SUM(CASE 
				WHEN DATEPART(QUARTER, fechaInicio) = DATEPART(QUARTER, fechaFin)
					THEN DATEDIFF(DAY, fechaInicio, fechaFin)
				WHEN DATEPART(QUARTER, fechaInicio) < DATEPART(QUARTER, fechaFin)
					AND DATEPART(QUARTER, fechaInicio) < @trimestre
					THEN DATEDIFF(DAY, DATEADD(qq, DATEDIFF(qq, 0, @fechaActual), 0), fechaFin)
				WHEN DATEPART(QUARTER, fechaInicio) < DATEPART(QUARTER, fechaFin)
					AND DATEPART(QUARTER, fechaFin) > @trimestre
					THEN DATEDIFF(DAY, fechaInicio, DATEADD(dd, - 1, DATEADD(qq, DATEDIFF(qq, 0, @fechaActual) + 1, 0)))
				END) AS dias
	FROM [PISOS_PICADOS].Habitacion AS ha
	INNER JOIN [PISOS_PICADOS].HabitacionxReserva AS hr ON hr.idHabitacion = ha.idHabitacion
		,[PISOS_PICADOS].Reserva AS re
	WHERE re.codigoReserva = hr.codigoReserva
		AND (
			(
				DATEPART(YEAR, re.fechaInicio) = @anio
				AND (DATEPART(QUARTER, re.fechaInicio) = @trimestre)
				OR (
					DATEPART(YEAR, re.fechaFin) = @anio
					AND DATEPART(QUARTER, re.fechaFin) = @trimestre
					)
				)
			)
	GROUP BY ha.idHotel
		,ha.idHabitacion
	ORDER BY dias DESC)
GO

CREATE FUNCTION [PISOS_PICADOS].topClientesPorPuntos (@anio INT
	,@trimestre INT
	,@fechaActual DATE)
	RETURNS TABLE
AS
	RETURN (SELECT TOP 5 fact.cliente
		,CAST((
				SUM(reng.total) / 10 + SUM(CASE 
						WHEN DATEPART(QUARTER, fechaCheckIn) = DATEPART(QUARTER, fechaCheckOut)
							THEN (DATEDIFF(DAY, es.fechaCheckIn, es.fechaCheckOut)) * [PISOS_PICADOS].precioRegimen(re.codigoRegimen) / 20
						WHEN DATEPART(QUARTER, fechaCheckIn) < DATEPART(QUARTER, fechaCheckOut)
							AND DATEPART(QUARTER, fechaCheckIn) < @trimestre
							THEN DATEDIFF(DAY, DATEADD(qq, DATEDIFF(qq, 0, @fechaActual), 0), fechaCheckOut)
						WHEN DATEPART(QUARTER, fechaCheckIn) < DATEPART(QUARTER, fechaCheckOut)
							AND DATEPART(QUARTER, fechaCheckOut) > @trimestre
							THEN DATEDIFF(DAY, fechaCheckIn, DATEADD(dd, - 1, DATEADD(qq, DATEDIFF(qq, 0, @fechaActual) + 1, 0)))
						END)
				) AS BIGINT) AS puntos
	FROM [PISOS_PICADOS].Factura AS fact
	INNER JOIN [PISOS_PICADOS].RenglonFactura AS reng ON fact.numeroFactura = reng.numeroFactura
		,[PISOS_PICADOS].Estadia AS es
		,[PISOS_PICADOS].Reserva AS re
	WHERE re.codigoReserva = es.codigoReserva
		AND re.idCliente = fact.cliente
		AND (
			DATEPART(YEAR, fact.fecha) = @anio
			AND DATEPART(QUARTER, fact.fecha) = @trimestre
			)
	GROUP BY fact.cliente
	ORDER BY puntos DESC)
GO

/*Dado un id de cliente devuelve su nacionalidad*/
CREATE FUNCTION [PISOS_PICADOS].obtenerNacionalidadCliente(@idCliente INT)
RETURNS VARCHAR(255)
AS
BEGIN
RETURN (SELECT c.nacionalidad FROM [PISOS_PICADOS].Cliente AS c WHERE c.idUsuario = @idCliente )
END
GO


/* STORED PROCEDURES ------------------------------------------------------*/
CREATE PROCEDURE [PISOS_PICADOS].altaRol @nombre VARCHAR(255)
	,@estado BIT
AS
BEGIN
	IF @nombre NOT IN (
			SELECT nombreRol
			FROM [PISOS_PICADOS].Rol
			WHERE nombreRol = @nombre
			)
	BEGIN
		INSERT INTO [PISOS_PICADOS].Rol
		VALUES (
			@nombre
			,@estado
			);
	END
	ELSE
		UPDATE [PISOS_PICADOS].Rol
		SET estado = 1
		WHERE nombreRol = @nombre
END;
GO

CREATE PROCEDURE [PISOS_PICADOS].agregarFuncionalidad @nombre VARCHAR(255)
	,@funcionalidad VARCHAR(255)
AS
BEGIN
	INSERT INTO [PISOS_PICADOS].RolxFuncionalidad
	SELECT idRol
		,idFuncionalidad
	FROM [PISOS_PICADOS].Rol
		,[PISOS_PICADOS].Funcionalidad
	WHERE nombreRol = @nombre
		AND descripcion = @funcionalidad
END
GO

CREATE PROCEDURE [PISOS_PICADOS].bajaRol @nombreRol VARCHAR(255)
AS
BEGIN
	UPDATE [PISOS_PICADOS].Rol
	SET estado = 0
	WHERE idRol = (
			SELECT TOP 1 p.idRol
			FROM [PISOS_PICADOS].Rol AS p
			WHERE nombreRol = @nombreRol
			)
END;
GO

CREATE PROCEDURE [PISOS_PICADOS].modificarRol @nombreRolViejo VARCHAR(255)
	,@nombreRol VARCHAR(255)
	,@estado BIT
AS
BEGIN
	IF @nombreRol IS NOT NULL
		UPDATE [PISOS_PICADOS].Rol
		SET nombreRol = @nombreRol
		WHERE nombreRol = @nombreRolViejo

	IF @estado IS NOT NULL
		UPDATE [PISOS_PICADOS].Rol
		SET estado = @estado
		WHERE nombreRol = @nombreRol
END;
GO

CREATE PROCEDURE [PISOS_PICADOS].quitarFuncionalidad @nombreRol VARCHAR(255)
AS
BEGIN
	DELETE
	FROM [PISOS_PICADOS].RolxFuncionalidad
	WHERE idRol = (
			SELECT p.idRol
			FROM [PISOS_PICADOS].Rol AS p
			WHERE p.nombreRol = @nombreRol
			)
END;
GO

CREATE PROCEDURE [PISOS_PICADOS].altaEmpleado @username VARCHAR(255)
	,@password VARCHAR(255)
	,@rol VARCHAR(255)
	,@nombre VARCHAR(255)
	,@apellido VARCHAR(255)
	,@mail VARCHAR(255)
	,@telefono VARCHAR(255)
	,@calle VARCHAR(255)
	,@numeroCalle INT
	,@localidad VARCHAR(255)
	,@pais VARCHAR(255)
	,@tipoDocumento VARCHAR(255)
	,@numeroDocumento INT
	,@fechaNacimiento DATE
	,@estado BIT
AS
BEGIN
	INSERT INTO [PISOS_PICADOS].Usuario
	VALUES (
		@nombre
		,@apellido
		,@mail
		,@telefono
		,@calle
		,@numeroCalle
		,@localidad
		,(
			SELECT idPais
			FROM [PISOS_PICADOS].Pais
			WHERE nombrePais = @pais
			)
		,@tipoDocumento
		,@numeroDocumento
		,@fechaNacimiento
		,@estado
		);

	INSERT INTO [PISOS_PICADOS].Empleado (
		idUsuario
		,usuario
		,contrasena
		)
	VALUES (
		[PISOS_PICADOS].obtenerIDUsuario(@nombre, @apellido, @numeroDocumento)
		,@username
		,HASHBYTES('SHA2_256', @password)
		);

	INSERT INTO [PISOS_PICADOS].RolxUsuario
	VALUES (
		(
			SELECT idRol
			FROM [PISOS_PICADOS].Rol
			WHERE nombreRol = @rol
			)
		,(
			SELECT idUsuario
			FROM [PISOS_PICADOS].Usuario AS p
			WHERE p.numeroIdentificacion = @numeroDocumento
				AND p.apellido = @apellido
				AND p.nombre = @nombre
			)
		)
END;
GO

CREATE PROCEDURE [PISOS_PICADOS].modificarEmpleado @idAutor INT
	,@idUsuario INT
	,@username VARCHAR(255)
	,@password VARCHAR(255)
	,@nombre VARCHAR(255)
	,@apellido VARCHAR(255)
	,@mail VARCHAR(255)
	,@telefono VARCHAR(255)
	,@calle VARCHAR(255)
	,@numeroCalle INT
	,@localidad VARCHAR(255)
	,@pais VARCHAR(255)
	,@tipoDocumento VARCHAR(255)
	,@numeroDocumento INT
	,@fechaNacimiento DATE
AS
BEGIN
	IF ([PISOS_PICADOS].esAdmin(@idAutor) = 1)
		IF @password IS NOT NULL
			UPDATE [PISOS_PICADOS].Empleado
			SET contrasena = @password
			WHERE @idUsuario = idUsuario

	IF @nombre IS NOT NULL
		UPDATE [PISOS_PICADOS].Usuario
		SET nombre = @nombre
		WHERE @idUsuario = idUsuario

	IF @apellido IS NOT NULL
		UPDATE [PISOS_PICADOS].Usuario
		SET apellido = @apellido
		WHERE @idUsuario = idUsuario

	IF @mail IS NOT NULL
		UPDATE [PISOS_PICADOS].Usuario
		SET mail = @mail
		WHERE @idUsuario = idUsuario

	IF @telefono IS NOT NULL
		UPDATE [PISOS_PICADOS].Usuario
		SET telefono = @telefono
		WHERE @idUsuario = idUsuario

	IF @calle IS NOT NULL
		UPDATE [PISOS_PICADOS].Usuario
		SET calle = @calle
		WHERE @idUsuario = idUsuario

	IF @numeroCalle IS NOT NULL
		UPDATE [PISOS_PICADOS].Usuario
		SET nroCalle = @numeroCalle
		WHERE @idUsuario = idUsuario

	IF @localidad IS NOT NULL
		UPDATE [PISOS_PICADOS].Usuario
		SET localidad = @localidad
		WHERE @idUsuario = idUsuario

	IF @pais IS NOT NULL
		UPDATE [PISOS_PICADOS].Usuario
		SET pais = (
				SELECT idPais
				FROM [PISOS_PICADOS].Pais
				WHERE nombrePais = @pais
				)
		WHERE @idUsuario = idUsuario

	IF @tipoDocumento IS NOT NULL
		UPDATE [PISOS_PICADOS].Usuario
		SET tipoIdentificacion = @tipoDocumento
		WHERE @idUsuario = idUsuario

	IF @numeroDocumento IS NOT NULL
		UPDATE [PISOS_PICADOS].Usuario
		SET numeroIdentificacion = @numeroDocumento
		WHERE @idUsuario = idUsuario

	IF @fechaNacimiento IS NOT NULL
		UPDATE [PISOS_PICADOS].Usuario
		SET fechaNacimiento = @fechaNacimiento
		WHERE @idUsuario = idUsuario
END;
GO

CREATE PROCEDURE [PISOS_PICADOS].quitarRolAUsuario @idUsuario INT
	,@nombreRol VARCHAR(255)
AS
BEGIN
	DELETE
	FROM [PISOS_PICADOS].RolxUsuario
	WHERE idUsuario = @idUsuario
		AND idRol = (
			SELECT p.idRol
			FROM [PISOS_PICADOS].Rol AS p
			WHERE nombreRol = @nombreRol
			)
END;
GO

CREATE PROCEDURE [PISOS_PICADOS].quitarHotelAUsuario @idUsuario INT
	,@nombreHotel VARCHAR(255)
AS
BEGIN
	DELETE
	FROM [PISOS_PICADOS].EmpleadoxHotel
	WHERE idUsuario = @idUsuario
		AND idHotel = (
			SELECT h.idHotel
			FROM [PISOS_PICADOS].Hotel AS h
			WHERE nombre = @nombreHotel
			)
END;
GO


CREATE PROCEDURE [PISOS_PICADOS].agregarRolAUsuario @idUsuario INT
	,@nombreRol VARCHAR(255)
AS
BEGIN
	INSERT INTO [PISOS_PICADOS].RolxUsuario
	VALUES (
		@idUsuario
		,(
			SELECT idRol
			FROM [PISOS_PICADOS].Rol
			WHERE nombreRol = @nombreRol
			)
		)
END;
GO

CREATE PROCEDURE [PISOS_PICADOS].agregarHotelAUsuario @idUsuario INT
	,@nombreHotel VARCHAR(255)
AS
BEGIN
	INSERT INTO [PISOS_PICADOS].EmpleadoxHotel
	VALUES (
		@idUsuario
		,(
			SELECT idHotel
			FROM [PISOS_PICADOS].Hotel
			WHERE nombre = @nombreHotel
			)
		)
END;
GO

CREATE PROCEDURE [PISOS_PICADOS].deshabilitarUsuario @usuario VARCHAR(255)
AS
BEGIN
	UPDATE u
	SET u.estado = 2
	FROM [PISOS_PICADOS].Usuario AS u
	INNER JOIN [PISOS_PICADOS].Empleado AS e ON u.idUsuario = e.idUsuario
	WHERE e.usuario = @usuario
END;
GO

CREATE PROCEDURE [PISOS_PICADOS].bajaUsuario @idUsuario INT
AS
BEGIN
	UPDATE [PISOS_PICADOS].Usuario
	SET estado = 2
	WHERE idUsuario = @idUsuario
END;
GO

CREATE PROCEDURE [PISOS_PICADOS].SPAltaCliente @nombre VARCHAR(255)
	,@apellido VARCHAR(255)
	,@tipo VARCHAR(255)
	,@numeroI INT
	,@mail VARCHAR(255)
	,@telefono VARCHAR(255)
	,@calle VARCHAR(255)
	,@numeroC INT
	,@localidad VARCHAR(255)
	,@pais VARCHAR(255)
	,@nacionalidad VARCHAR(255)
	,@fechaNacimiento DATE
AS
BEGIN
	INSERT INTO [PISOS_PICADOS].Usuario (
		nombre
		,apellido
		,mail
		,telefono
		,calle
		,nroCalle
		,localidad
		,pais
		,tipoIdentificacion
		,numeroIdentificacion
		,fechaNacimiento
		,estado
		)
	VALUES (
		@nombre
		,@apellido
		,@mail
		,@telefono
		,@calle
		,@numeroC
		,@localidad
		,[PISOS_PICADOS].obtenerIDPais(@pais)
		,@tipo
		,@numeroI
		,@fechaNacimiento
		,1
		);

	DECLARE @idusuario INT = SCOPE_IDENTITY();

	INSERT INTO [PISOS_PICADOS].Cliente
	VALUES (
		@idusuario
		,@nacionalidad
		);

	INSERT INTO [PISOS_PICADOS].RolxUsuario
	VALUES (
		3
		,@idusuario
		);
END;
GO

CREATE PROCEDURE [PISOS_PICADOS].SPModificarCliente @idUsuario INT
	,@nombre VARCHAR(255)
	,@apellido VARCHAR(255)
	,@tipo VARCHAR(255)
	,@numeroI INT
	,@mail VARCHAR(255)
	,@telefono VARCHAR(255)
	,@calle VARCHAR(255)
	,@numeroC INT
	,@localidad VARCHAR(255)
	,@pais VARCHAR(255)
	,@nacionalidad VARCHAR(255)
	,@fechaNacimiento DATE
	,@estado BIT
AS
BEGIN
	IF @nombre IS NOT NULL
		UPDATE [PISOS_PICADOS].Usuario
		SET nombre = @nombre
		WHERE @idUsuario = idUsuario

	IF @apellido IS NOT NULL
		UPDATE [PISOS_PICADOS].Usuario
		SET apellido = @apellido
		WHERE @idUsuario = idUsuario

	IF @mail IS NOT NULL
		UPDATE [PISOS_PICADOS].Usuario
		SET mail = @mail
		WHERE @idUsuario = idUsuario

	IF @telefono IS NOT NULL
		UPDATE [PISOS_PICADOS].Usuario
		SET telefono = @telefono
		WHERE @idUsuario = idUsuario

	IF @calle IS NOT NULL
		UPDATE [PISOS_PICADOS].Usuario
		SET calle = @calle
		WHERE @idUsuario = idUsuario

	IF @numeroC IS NOT NULL
		UPDATE [PISOS_PICADOS].Usuario
		SET nroCalle = @numeroC
		WHERE @idUsuario = idUsuario

	IF @localidad IS NOT NULL
		UPDATE [PISOS_PICADOS].Usuario
		SET localidad = @localidad
		WHERE @idUsuario = idUsuario

	IF @pais IS NOT NULL
		UPDATE [PISOS_PICADOS].Usuario
		SET pais = [PISOS_PICADOS].obtenerIDPais(@pais)
		WHERE @idUsuario = idUsuario

	IF @tipo IS NOT NULL
		UPDATE [PISOS_PICADOS].Usuario
		SET tipoIdentificacion = @tipo
		WHERE @idUsuario = idUsuario

	IF @numeroI IS NOT NULL
		UPDATE [PISOS_PICADOS].Usuario
		SET numeroIdentificacion = @numeroI
		WHERE @idUsuario = idUsuario

	IF @fechaNacimiento IS NOT NULL
		UPDATE [PISOS_PICADOS].Usuario
		SET fechaNacimiento = @fechaNacimiento
		WHERE @idUsuario = idUsuario

	IF @nacionalidad IS NOT NULL
		UPDATE [PISOS_PICADOS].Cliente
		SET nacionalidad = @nacionalidad
		WHERE @idUsuario = idUsuario
END;
GO

CREATE PROCEDURE [PISOS_PICADOS].SPEstadoCliente @idUsuario INT
	,@Estado BIT
AS
BEGIN
	UPDATE [PISOS_PICADOS].Usuario
	SET estado = @Estado
	WHERE @idUsuario = idUsuario
END;
GO

CREATE PROCEDURE [PISOS_PICADOS].SPAltaHabitacion @numero INT
	,@IDhotel INT
	,@frente CHAR(1)
	,@tipo INT
	,@descripcion VARCHAR(255)
	,@piso INT
	,@habilitado BIT
AS
BEGIN
	SELECT *
	FROM [PISOS_PICADOS].Tipo

	INSERT INTO [PISOS_PICADOS].Habitacion (
		numero
		,idHotel
		,frente
		,tipo
		,descripcion
		,piso
		,habilitada
		)
	VALUES (
		@numero
		,@IDhotel
		,@frente
		,@tipo
		,@descripcion
		,@piso
		,@habilitado
		)
END;
GO

CREATE PROCEDURE [PISOS_PICADOS].SPModificarHabitacion @idHabitacion INT
	,@numeroH INT
	,@frente CHAR(1)
	,@descripcion VARCHAR(255)
	,@piso INT
	,@habilitado BIT
AS
BEGIN
	IF @numeroH IS NOT NULL
		UPDATE [PISOS_PICADOS].Habitacion
		SET numero = @numeroH
		WHERE idHabitacion = @idHabitacion

	IF @frente IS NOT NULL
		UPDATE [PISOS_PICADOS].Habitacion
		SET frente = @frente
		WHERE idHabitacion = @idHabitacion

	IF @descripcion IS NOT NULL
		UPDATE [PISOS_PICADOS].Habitacion
		SET descripcion = @descripcion
		WHERE idHabitacion = @idHabitacion

	IF @piso IS NOT NULL
		UPDATE [PISOS_PICADOS].Habitacion
		SET piso = @piso
		WHERE idHabitacion = @idHabitacion

	IF @habilitado IS NOT NULL
		UPDATE [PISOS_PICADOS].Habitacion
		SET habilitada = @habilitado
		WHERE idHabitacion = @idHabitacion
END;
GO

CREATE PROCEDURE [PISOS_PICADOS].SPEstadoHabitacion @idHabitacion INT
	,@habilitado BIT
AS
BEGIN
	UPDATE [PISOS_PICADOS].Habitacion
	SET habilitada = @habilitado
	WHERE idHabitacion = @idHabitacion
END;
GO

CREATE PROCEDURE [PISOS_PICADOS].crearHotel @nombre VARCHAR(255)
	,@mail VARCHAR(255)
	,@telefono VARCHAR(255)
	,@calle VARCHAR(255)
	,@nroCalle VARCHAR(255)
	,@direccion VARCHAR(255)
	,@estrellas INT
	,@ciudad VARCHAR(255)
	,@pais INT
	,@fechaCreacion DATE
	,@autorId INT
AS
BEGIN
	INSERT INTO [PISOS_PICADOS].Hotel (
		nombre
		,mail
		,telefono
		,calle
		,nroCalle
		,ciudad
		,pais
		,fechaCreacion
		,estrellas
		)
	VALUES (
		@nombre
		,@mail
		,@telefono
		,@calle
		,@nroCalle
		,@ciudad
		,@pais
		,@fechaCreacion
		,@estrellas
		)

	INSERT INTO [PISOS_PICADOS].EmpleadoxHotel (
		idUsuario
		,idHotel
		)
	VALUES (
		@autorId
		,[PISOS_PICADOS].obtenerIDHotel(@ciudad, @calle, @nroCalle)
		)
END
GO

CREATE PROCEDURE [PISOS_PICADOS].agregarRegimen @idHotel INT
	,@idRegimen INT
AS
BEGIN
	INSERT INTO [PISOS_PICADOS].RegimenxHotel (
		codigoRegimen
		,idHotel
		)
	VALUES (
		@idRegimen
		,@idHotel
		)
END
GO

CREATE PROCEDURE [PISOS_PICADOS].quitarRegimen @idHotel INT
	,@idRegimen INT
	,@fecha DATE
AS
BEGIN
	IF NOT EXISTS (
			SELECT codigoReserva
			FROM [PISOS_PICADOS].Reserva
			WHERE codigoRegimen = @idRegimen
				AND (
					fechaInicio > @fecha
					OR @fecha BETWEEN fechaInicio
						AND fechaFin
					)
			)
		DELETE
		FROM [PISOS_PICADOS].RegimenxHotel
		WHERE idHotel = @idHotel
			AND codigoRegimen = @idRegimen
END
GO

CREATE PROCEDURE [PISOS_PICADOS].modificarHotel @nombre VARCHAR(255)
	,@mail VARCHAR(255)
	,@telefono VARCHAR(255)
	,@calle VARCHAR(255)
	,@nroCalle VARCHAR(255)
	,@estrellas INT
	,@ciudad VARCHAR(255)
	,@idPais INT
	,@fechaCreacion DATE
AS
BEGIN
	IF @nombre IS NOT NULL
		UPDATE [PISOS_PICADOS].Hotel
		SET nombre = @nombre

	IF @mail IS NOT NULL
		UPDATE [PISOS_PICADOS].Hotel
		SET mail = @mail

	IF @telefono IS NOT NULL
		UPDATE [PISOS_PICADOS].Hotel
		SET telefono = @telefono

	IF @calle IS NOT NULL
		UPDATE [PISOS_PICADOS].Hotel
		SET calle = @calle

	IF @nroCalle IS NOT NULL
		UPDATE [PISOS_PICADOS].Hotel
		SET nroCalle = @nroCalle

	IF @estrellas IS NOT NULL
		UPDATE [PISOS_PICADOS].Hotel
		SET estrellas = @estrellas

	IF @ciudad IS NOT NULL
		UPDATE [PISOS_PICADOS].Hotel
		SET ciudad = @ciudad

	IF @idPais IS NOT NULL
		UPDATE [PISOS_PICADOS].Hotel
		SET pais = @idPais

	IF @fechaCreacion IS NOT NULL
		UPDATE [PISOS_PICADOS].Hotel
		SET fechaCreacion = @fechaCreacion
END
GO

CREATE PROCEDURE [PISOS_PICADOS].agregarEncargado @idHotel INT
	,@idEncargado INT
AS
BEGIN
	INSERT INTO [PISOS_PICADOS].EmpleadoxHotel (
		idHotel
		,idUsuario
		)
	VALUES (
		@idHotel
		,@idEncargado
		)
END
GO

CREATE PROCEDURE [PISOS_PICADOS].quitarEncargado @idHotel INT
	,@idEncargado INT
AS
BEGIN
	DELETE
	FROM [PISOS_PICADOS].EmpleadoxHotel
	WHERE idHotel = @idHotel
		AND idUsuario = @idEncargado
END
GO

CREATE PROCEDURE [PISOS_PICADOS].bajaDeHotel @idHotel INT
	,@fechaInicio DATE
	,@fechaFin DATE
	,@razon VARCHAR(255)
AS
BEGIN
	IF [PISOS_PICADOS].HotelTieneReservas(@idHotel, @fechaInicio, @fechaFin) = 0
		INSERT INTO [PISOS_PICADOS].BajaHotel (
			idHotel
			,fechaInicio
			,fechaFin
			,razon
			)
		VALUES (
			@idHotel
			,@fechaInicio
			,@fechaFin
			,@razon
			)
END
GO

CREATE PROCEDURE [PISOS_PICADOS].cancelarReserva @codigoReserva INT
	,@motivo VARCHAR(255)
	,@fecha DATE
	,@idUsuario INT
AS
BEGIN
	IF @fecha < (
			SELECT fechaInicio
			FROM [PISOS_PICADOS].Reserva
			WHERE codigoReserva = @codigoReserva
			)
		INSERT INTO [PISOS_PICADOS].Estado
		VALUES ('Cancelada')

	DECLARE @idEstado INT = SCOPE_IDENTITY();

	UPDATE [PISOS_PICADOS].Reserva
	SET estado = @idEstado
	WHERE codigoReserva = @codigoReserva;

	INSERT INTO [PISOS_PICADOS].Modificacion (
		estadoReserva
		,descripcion
		,usuario
		,fecha
		)
	VALUES (
		@idEstado
		,@motivo
		,@idUsuario
		,@fecha
		)
END
GO

CREATE PROCEDURE [PISOS_PICADOS].agregarConsumible @idEstadia INT
	,@idConsumible INT
	,@cantidad INT
AS
BEGIN
	INSERT INTO [PISOS_PICADOS].EstadiaxConsumible (
		idEstadia
		,idConsumible
		,cantidad
		)
	VALUES (
		@idEstadia
		,@idConsumible
		,@cantidad
		)
END
GO

CREATE PROCEDURE [PISOS_PICADOS].quitarConsumible @idEstadia INT
	,@idConsumible INT
AS
BEGIN
	DELETE
	FROM [PISOS_PICADOS].EstadiaxConsumible
	WHERE idEstadia = @idEstadia
		AND idConsumible = @idConsumible
END
GO

CREATE PROCEDURE [PISOS_PICADOS].registrarReserva @fechaReserva DATE
	,@fechaInicio DATE
	,@fechaFin DATE
	,@cantHuespedes INT
	,@codRegimen INT
	,@idCliente INT
	,@idHotel INT
	,@cantSimple INT
	,@cantDoble INT
	,@cantTriple INT
	,@cantCuadru INT
	,@cantKing INT
AS
BEGIN
	INSERT INTO [PISOS_PICADOS].Reserva (
		fechaRealizacion
		,fechaInicio
		,fechaFin
		,cantidadHuespedes
		,codigoRegimen
		,estado
		,idCliente
		,precioTotal
		)
	VALUES (
		@fechaReserva
		,@fechaInicio
		,@fechaFin
		,@cantHuespedes
		,@codRegimen
		,1
		,@idCliente
		,((DATEDIFF(day, @fechaInicio, @fechaFIN)) * [PISOS_PICADOS].precioReserva(@cantSimple, @cantDoble, @cantTriple, @cantCuadru, @cantKing, @codRegimen, @idHotel))
		);

	DECLARE @idReserva INT = SCOPE_IDENTITY();
	DECLARE @cont INT;

	SET @cont = 0

	INSERT INTO [PISOS_PICADOS].Estadia (
		codigoReserva
		,diasReserva
		)
	VALUES (
		@idReserva
		,DATEDIFF(DAY, @fechaFin, @fechaFin)
		);

	WHILE (@cont < @cantSimple)
	BEGIN
		INSERT INTO [PISOS_PICADOS].HabitacionxReserva
		VALUES (
			(
				SELECT idHabitacion
				FROM [PISOS_PICADOS].Habitacion
				WHERE idHabitacion = [PISOS_PICADOS].habitacionQueCumple(1, @idHotel, @fechaInicio)
				)
			,@idReserva
			);

		SET @cont = @cont + 1
	END

	SET @cont = 0

	WHILE (@cont < @cantDoble)
	BEGIN
		INSERT INTO [PISOS_PICADOS].HabitacionxReserva
		VALUES (
			(
				SELECT idHabitacion
				FROM [PISOS_PICADOS].Habitacion
				WHERE idHabitacion = [PISOS_PICADOS].habitacionQueCumple(2, @idHotel, @fechaInicio)
				)
			,@idReserva
			);

		SET @cont = @cont + 1
	END

	SET @cont = 0

	WHILE (@cont < @cantTriple)
	BEGIN
		INSERT INTO [PISOS_PICADOS].HabitacionxReserva
		VALUES (
			(
				SELECT idHabitacion
				FROM [PISOS_PICADOS].Habitacion
				WHERE idHabitacion = [PISOS_PICADOS].habitacionQueCumple(3, @idHotel, @fechaInicio)
				)
			,@idReserva
			);

		SET @cont = @cont + 1
	END

	SET @cont = 0

	WHILE (@cont < @cantCuadru)
	BEGIN
		INSERT INTO [PISOS_PICADOS].HabitacionxReserva
		VALUES (
			(
				SELECT idHabitacion
				FROM [PISOS_PICADOS].Habitacion
				WHERE idHabitacion = [PISOS_PICADOS].habitacionQueCumple(4, @idHotel, @fechaInicio)
				)
			,@idReserva
			);

		SET @cont = @cont + 1
	END

	SET @cont = 0

	WHILE (@cont < @cantKing)
	BEGIN
		INSERT INTO [PISOS_PICADOS].HabitacionxReserva
		VALUES (
			(
				SELECT idHabitacion
				FROM [PISOS_PICADOS].Habitacion
				WHERE idHabitacion = [PISOS_PICADOS].habitacionQueCumple(5, @idHotel, @fechaInicio)
				)
			,@idReserva
			);

		SET @cont = @cont + 1
	END
END;
GO

CREATE PROCEDURE [PISOS_PICADOS].EliminarReservasNoEfectivizada @fechaActual DATE
AS
BEGIN
	UPDATE es
	SET es.estado = 0
	FROM [PISOS_PICADOS].Estadia AS es
	INNER JOIN [PISOS_PICADOS].Reserva AS re ON es.codigoReserva = re.codigoReserva
	WHERE re.fechaInicio < @fechaActual;

	UPDATE re
	SET re.estado = 5
	FROM [PISOS_PICADOS].Reserva AS re
	INNER JOIN [PISOS_PICADOS].Estadia AS es ON re.codigoReserva = es.codigoReserva
	WHERE es.estado = 0;

	DELETE hr
	FROM [PISOS_PICADOS].HabitacionxReserva AS hr
	INNER JOIN [PISOS_PICADOS].Reserva AS re ON hr.codigoReserva = re.codigoReserva
	WHERE re.estado = 5
END
GO

CREATE PROCEDURE [PISOS_PICADOS].registrarCheckIn @fechaIngreso DATE
	,@idEncargado INT
	,@codReserva INT
AS
BEGIN
	UPDATE PISOS_PICADOS.Estadia
	SET encargadoCheckIn = @idEncargado
		,fechaCheckIn = @fechaIngreso
	WHERE codigoReserva = @codReserva
END
GO

CREATE PROCEDURE [PISOS_PICADOS].registrarCheckOut @fechaEgreso DATE
	,@idEncargado INT
	,@codReserva INT
AS
BEGIN
	UPDATE PISOS_PICADOS.Estadia
	SET encargadoCheckOut = @idEncargado
		,fechaCheckOut = @fechaEgreso
	WHERE codigoReserva = @codReserva

	UPDATE PISOS_PICADOS.Estadia
	SET diasEstadia = DATEDIFF(DAY, fechaCheckIn, fechaCheckOut)
	WHERE codigoReserva = @codReserva
END
GO

CREATE PROCEDURE [PISOS_PICADOS].modificarReserva @fechaInicio DATE
	,@fechaFin DATE
	,@cantHuespedes INT
	,@codRegimen INT
	,@idReserva INT
	,@cantSimple INT
	,@cantDoble INT
	,@cantTriple INT
	,@cantCuadru INT
	,@cantKing INT
AS
BEGIN
	DECLARE @idHotel INT

	SET @idHotel = [PISOS_PICADOS].obtenerHotelDeHabitacion((
				SELECT TOP 1 idHabitacion
				FROM [PISOS_PICADOS].HabitacionxReserva
				WHERE codigoReserva = @idReserva
				))

	BEGIN TRANSACTION TREliminacionHotelesReserva

	DELETE
	FROM HabitacionxReserva
	WHERE codigoReserva = @idReserva

	IF ([PISOS_PICADOS].hotelCumple(@cantSimple, 1, @idHotel, @fechaInicio) = 1)
		IF ([PISOS_PICADOS].hotelCumple(@cantDoble, 2, @idHotel, @fechaInicio) = 1)
			IF ([PISOS_PICADOS].hotelCumple(@cantTriple, 3, @idHotel, @fechaInicio) = 1)
				IF ([PISOS_PICADOS].hotelCumple(@cantCuadru, 4, @idHotel, @fechaInicio) = 1)
					IF ([PISOS_PICADOS].hotelCumple(@cantKing, 5, @idHotel, @fechaInicio) = 1)
						COMMIT TRANSACTION TREliminacionHotelesReserva;
					ELSE
						ROLLBACK TRANSACTION TREliminacionHotelesReserva;

	UPDATE [PISOS_PICADOS].Reserva
	SET fechaInicio = @fechaInicio
		,fechaFin = @fechaFin
		,cantidadHuespedes = @cantHuespedes
		,codigoRegimen = @codRegimen
		,estado = 2
		,precioTotal = ((DATEDIFF(day, @fechaInicio, @fechaFIN)) * [PISOS_PICADOS].precioReserva(@cantSimple, @cantDoble, @cantTriple, @cantCuadru, @cantKing, @codRegimen, @idHotel))
	WHERE codigoReserva = @idReserva

	DECLARE @cont INT;

	SET @cont = 0

	WHILE (@cont < @cantSimple)
	BEGIN
		INSERT INTO [PISOS_PICADOS].HabitacionxReserva
		VALUES (
			(
				SELECT idHabitacion
				FROM [PISOS_PICADOS].Habitacion
				WHERE idHabitacion = [PISOS_PICADOS].habitacionQueCumple(1, @idHotel, @fechaInicio)
				)
			,@idReserva
			);

		SET @cont = @cont + 1
	END

	SET @cont = 0

	WHILE (@cont < @cantDoble)
	BEGIN
		INSERT INTO [PISOS_PICADOS].HabitacionxReserva
		VALUES (
			(
				SELECT idHabitacion
				FROM [PISOS_PICADOS].Habitacion
				WHERE idHabitacion = [PISOS_PICADOS].habitacionQueCumple(2, @idHotel, @fechaInicio)
				)
			,@idReserva
			);

		SET @cont = @cont + 1
	END

	SET @cont = 0

	WHILE (@cont < @cantTriple)
	BEGIN
		INSERT INTO [PISOS_PICADOS].HabitacionxReserva
		VALUES (
			(
				SELECT idHabitacion
				FROM [PISOS_PICADOS].Habitacion
				WHERE idHabitacion = [PISOS_PICADOS].habitacionQueCumple(3, @idHotel, @fechaInicio)
				)
			,@idReserva
			);

		SET @cont = @cont + 1
	END

	SET @cont = 0

	WHILE (@cont < @cantCuadru)
	BEGIN
		INSERT INTO [PISOS_PICADOS].HabitacionxReserva
		VALUES (
			(
				SELECT idHabitacion
				FROM [PISOS_PICADOS].Habitacion
				WHERE idHabitacion = [PISOS_PICADOS].habitacionQueCumple(4, @idHotel, @fechaInicio)
				)
			,@idReserva
			);

		SET @cont = @cont + 1
	END

	SET @cont = 0

	WHILE (@cont < @cantKing)
	BEGIN
		INSERT INTO [PISOS_PICADOS].HabitacionxReserva
		VALUES (
			(
				SELECT idHabitacion
				FROM [PISOS_PICADOS].Habitacion
				WHERE idHabitacion = [PISOS_PICADOS].habitacionQueCumple(5, @idHotel, @fechaInicio)
				)
			,@idReserva
			);

		SET @cont = @cont + 1
	END
END
GO

CREATE PROCEDURE [PISOS_PICADOS].FacturarReserva @idEstadia INT
	,@fecha DATE
	,@cliente INT
	,@tipoPago VARCHAR(255)
AS
BEGIN
	INSERT INTO [PISOS_PICADOS].Factura (
		fecha
		,idEstadia
		,formaDePago
		,cliente
		,total
		)
	VALUES (
		@fecha
		,@idEstadia
		,(
			SELECT idFormaDePago
			FROM [PISOS_PICADOS].FormaDePago
			WHERE descripcion = @tipoPago
			)
		,@cliente
		,[PISOS_PICADOS].calcularPrecioRenglones(@idEstadia) + [PISOS_PICADOS].calcularPrecioPorDiasHospedados(@idEstadia) + [PISOS_PICADOS].calcularPrecioPorDiasNoHospedados(@idEstadia)
		)

	DECLARE @numFactura INT = SCOPE_IDENTITY();
	DECLARE @idConsumible INT
		,@cant INT
		,@precio INT
		,@total INT

	DECLARE c1 CURSOR
	FOR
	SELECT exc.idConsumible
		,SUM(exc.cantidad)
		,[PISOS_PICADOS].precioConsumible(exc.idConsumible)
		,(SUM(exc.cantidad) * [PISOS_PICADOS].precioConsumible(exc.idConsumible))
	FROM [PISOS_PICADOS].EstadiaxConsumible AS exc
	WHERE exc.idEstadia = @idEstadia
	GROUP BY exc.idConsumible

	OPEN C1

	FETCH c1
	INTO @idConsumible
		,@cant
		,@precio
		,@total

	DECLARE @CONT INT

	SET @CONT = 1

	WHILE (@@FETCH_STATUS = 0)
	BEGIN
		INSERT INTO [PISOS_PICADOS].RenglonFactura (
			numeroRenglon
			,numeroFactura
			,consumible
			,cantidad
			,precio
			,total
			,estadia
			)
		VALUES (
			@CONT
			,@numFactura
			,@idConsumible
			,@cant
			,@precio
			,@total
			,@idEstadia
			)

		SET @CONT = @CONT + 1

		FETCH c1
		INTO @idConsumible
			,@cant
			,@precio
			,@total
	END

	CLOSE c1

	DEALLOCATE c1
END
GO

CREATE PROCEDURE [PISOS_PICADOS].corregirUsuarios
AS
BEGIN
	UPDATE [PISOS_PICADOS].Usuario
	SET estado = 3
	WHERE numeroIdentificacion IN (
			SELECT u.numeroIdentificacion
			FROM [PISOS_PICADOS].Usuario AS u
			WHERE u.tipoIdentificacion = 'Pasaporte'
			GROUP BY u.numeroIdentificacion
			HAVING COUNT(DISTINCT (u.nombre + u.apellido)) > 1
			)

	UPDATE [PISOS_PICADOS].Usuario
	SET estado = 4
	WHERE mail IN (
			SELECT u.mail
			FROM [PISOS_PICADOS].Usuario AS u
			GROUP BY u.apellido
				,u.nombre
				,u.mail
			HAVING COUNT(DISTINCT u.numeroIdentificacion) > 1
			)

	UPDATE [PISOS_PICADOS].Usuario
	SET estado = 1
	WHERE estado IS NULL
END
GO

CREATE PROCEDURE [PISOS_PICADOS].sumarIntento (@usuarioEmpleado VARCHAR(255))
AS
BEGIN
	UPDATE [PISOS_PICADOS].Empleado
	SET intentos = intentos + 1
	WHERE usuario = @usuarioEmpleado
END
GO

CREATE PROCEDURE [PISOS_PICADOS].resetearIntentos (@usuarioEmpleado VARCHAR(255))
AS
BEGIN
	UPDATE [PISOS_PICADOS].Empleado
	SET intentos = 0
	WHERE usuario = @usuarioEmpleado
END
GO

CREATE PROCEDURE [PISOS_PICADOS].darNombreAHoteles
AS
BEGIN
	UPDATE [PISOS_PICADOS].Hotel
	SET nombre = LTRIM(RTRIM(ciudad)) + '-' + LTRIM(RTRIM(calle)) + '-' + LTRIM(RTRIM(CONVERT(VARCHAR(255), nroCalle)))
	WHERE nombre IS NULL
END
GO

EXEC [PISOS_PICADOS].CorregirUsuarios

EXEC [PISOS_PICADOS].darNombreAHoteles