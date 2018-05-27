CREATE TABLE [PISOS_PICADOS].hoteles 
(
nombre VARCHAR(255),
mail VARCHAR(255),
telefono VARCHAR(20),
calle VARCHAR(255),
nro_calle NUMERIC(9),
ciudad VARCHAR(255),
pais VARCHAR(255),
fecha_de_creacion DATETIME,
estrellas NUMERIC(1)
)

DROP TABLE [PISOS_PICADOS].hoteles

SELECT * FROM gd_esquema.Maestra

SELECT Habitacion_Numero FROM gd_esquema.Maestra WHERE Habitacion_Numero < 30

SELECT DISTINCT Habitacion_Numero FROM gd_esquema.Maestra 
WHERE Hotel_Calle='Avenida Córdoba' AND Hotel_Nro_Calle=10482
ORDER BY Habitacion_Numero


