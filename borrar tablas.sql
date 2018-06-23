DROP TABLE [PISOS_PICADOS].BajaHabitacion
DROP TABLE [PISOS_PICADOS].EstadiaxConsumible
DROP TABLE [PISOS_PICADOS].HabitacionxReserva
DROP TABLE [PISOS_PICADOS].Modificacion
DROP TABLE [PISOS_PICADOS].RegimenxHotel
DROP TABLE [PISOS_PICADOS].RenglonFactura
DROP TABLE [PISOS_PICADOS].RolxFuncionalidad
DROP TABLE [PISOS_PICADOS].RolxUsuario
DROP TABLE [PISOS_PICADOS].EmpleadoxHotel
DROP TABLE [PISOS_PICADOS].Consumible
DROP TABLE [PISOS_PICADOS].Empleado
DROP TABLE [PISOS_PICADOS].Factura
DROP TABLE [PISOS_PICADOS].Estadia
DROP TABLE [PISOS_PICADOS].FormaDePago
DROP TABLE [PISOS_PICADOS].Funcionalidad
DROP TABLE [PISOS_PICADOS].Habitacion
DROP TABLE [PISOS_PICADOS].BajaHotel
DROP TABLE [PISOS_PICADOS].Hotel
DROP TABLE [PISOS_PICADOS].Reserva
DROP TABLE [PISOS_PICADOS].Rol
DROP TABLE [PISOS_PICADOS].Tipo
DROP TABLE [PISOS_PICADOS].Cliente
DROP TABLE [PISOS_PICADOS].Estado
DROP TABLE [PISOS_PICADOS].Regimen
DROP TABLE [PISOS_PICADOS].Empleado
DROP TABLE [PISOS_PICADOS].Usuario
DROP TABLE [PISOS_PICADOS].Pais
GO
DROP PROCEDURE [PISOS_PICADOS].altaRol
GO
DROP PROCEDURE [PISOS_PICADOS].altaEmpleado
GO
DROP PROCEDURE [PISOS_PICADOS].agregarFuncionalidad
GO
DROP PROCEDURE [PISOS_PICADOS].bajaRol
GO
DROP PROCEDURE [PISOS_PICADOS].modificarRol
GO
DROP PROCEDURE [PISOS_PICADOS].quitarFuncionalidad
GO
DROP PROCEDURE [PISOS_PICADOS].agregarRolAUsuario
GO
DROP PROCEDURE [PISOS_PICADOS].quitarRolAUsuario
GO
DROP PROCEDURE [PISOS_PICADOS].modificarEmpleado
GO
DROP PROCEDURE [PISOS_PICADOS].bajaUsuario
GO
DROP FUNCTION [PISOS_PICADOS].obtenerIDUsuario
GO
DROP PROCEDURE [PISOS_PICADOS].SPEstadoHabitacion
GO
DROP PROCEDURE [PISOS_PICADOS].SPModificarHabitacion
GO
DROP PROCEDURE [PISOS_PICADOS].SPAltaHabitacion
GO
DROP PROCEDURE [PISOS_PICADOS].SPEstadoCliente
GO
DROP PROCEDURE [PISOS_PICADOS].SPModificarCliente
GO
DROP PROCEDURE [PISOS_PICADOS].SPAltaCliente
GO
DROP FUNCTION [PISOS_PICADOS].obtenerIDHotel
GO
DROP FUNCTION [PISOS_PICADOS].obtenerIDPais
GO
DROP FUNCTION [PISOS_PICADOS].esAdmin
GO
DROP FUNCTION [PISOS_PICADOS].existeNumEnHotel
GO
DROP FUNCTION [PISOS_PICADOS].existeEmpleado
GO
DROP PROCEDURE [PISOS_PICADOS].SPAltaHabitacion
GO
DROP PROCEDURE [PISOS_PICADOS].SPModificarHabitacion
GO
DROP PROCEDURE [PISOS_PICADOS].SPEstadoHabitacion
GO
DROP FUNCTION [PISOS_PICADOS].usuarioValido
GO
DROP FUNCTION [PISOS_PICADOS].obtenerIDUsuarioEmpleado
GO
DROP FUNCTION [PISOS_PICADOS].obtenerRolEmpleado
GO
DROP FUNCTION [PISOS_PICADOS].HotelTieneReservas
GO
DROP PROCEDURE [PISOS_PICADOS].bajaDeHotel
GO
DROP PROCEDURE [PISOS_PICADOS].quitarEncargado
GO
DROP PROCEDURE [PISOS_PICADOS].agregarEncargado
GO
DROP PROCEDURE [PISOS_PICADOS].modificarHotel
GO
DROP PROCEDURE [PISOS_PICADOS].agregarRegimen
GO
DROP PROCEDURE [PISOS_PICADOS].quitarRegimen
GO
DROP PROCEDURE [PISOS_PICADOS].crearHotel
GO
DROP FUNCTION [PISOS_PICADOS].habilitadoHotel
GO
DROP PROCEDURE [PISOS_PICADOS].cancelarReserva
GO
DROP PROCEDURE [PISOS_PICADOS].agregarConsumible
GO
DROP PROCEDURE [PISOS_PICADOS].quitarConsumible
GO
DROP FUNCTION  [PISOS_PICADOS].netearConsumibles
GO
DROP FUNCTION [PISOS_PICADOS].cantidadPersonasHabitacion
GO
DROP FUNCTION [PISOS_PICADOS].incrementoHotel
GO
DROP FUNCTION [PISOS_PICADOS].precioRegimen
GO
DROP FUNCTION [PISOS_PICADOS].precioHabitacion
GO
DROP FUNCTION [PISOS_PICADOS].hotelCumple
GO
DROP FUNCTION [PISOS_PICADOS].habitacionQueCumple
GO
DROP FUNCTION [PISOS_PICADOS].obtenerHotelDeHabitacion
GO
DROP PROCEDURE [PISOS_PICADOS].hotelesConMasCancelaciones
GO
DROP FUNCTION [PISOS_PICADOS].consultarRegimen
GO
DROP PROCEDURE [PISOS_PICADOS].hotelesConMasConsumiblesFacturados
GO
DROP PROCEDURE [PISOS_PICADOS].hotelesConMasDiasDeBaja
GO
DROP PROCEDURE [PISOS_PICADOS].registrarReserva
GO
DROP FUNCTION [PISOS_PICADOS].normalizarMail
GO
DROP FUNCTION [PISOS_PICADOS].validarMail
GO
DROP FUNCTION [PISOS_PICADOS].existeMail
GO
DROP FUNCTION [PISOS_PICADOS].habilitadoCLiente
GO
DROP PROCEDURE [PISOS_PICADOS].topHabitacionesOcupadasVeces
GO
DROP PROCEDURE [PISOS_PICADOS].topHabitacionesOcupadasDias
GO
DROP FUNCTION [PISOS_PICADOS].precioReserva
GO
DROP PROCEDURE [PISOS_PICADOS].EliminarReservasNoEfectivizada
GO