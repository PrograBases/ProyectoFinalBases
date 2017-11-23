-- Experimento a

-- Cree un stored procedure transaccional que genere y registre el flujo de un producto.

-- Para el flujo se ocupa

CREATE PROCEDURE [dbo].[flujoProducto] (@idActividadMaster int, @newid int)
AS
	INSERT INTO FLUJO_MASTER (IdFlujoMaestro)
	VALUES (@newid)

-- Experimento H
-- Realice dos consultas, cada una con almenos 4 JOINS que resuelva una Diferencia y otra una intersección. 
-- Mida el tiempo de respuesta para ambos casos usando: IN/NOT IN,  JOIN, EXCEPT, INTERSECT, EXIST y NOT EXISTS 
-- para determinar cual muestra un mejor rendimiento.

-- Consulta 1
CREATE PROCEDURE [dbo].[interseccion] (@id1 int, @id2 int)
AS
	-- Select para obtener los datos del primer producto
	SELECT IdMAterial, IdFlujo, IdActividadFlujo
	FROM PRODUCTOS_MASTER pm 
	inner join MATERIAL m on pm.IdProducto = m.IdProducto
	inner join FLUJO_MASTER fm on pm.IdFlujo = fm.IdFlujoMaestro
	inner join ACTIVIDAD_FLUJO_MASTER afm on afm.IdFlujoMaestro = fm.IdFlujoMaestro
	where pm.IdProducto = @id1

	INTERSECT
	-- Select para obtener los datos del segundo producto
	SELECT IdMAterial, IdFlujo, IdActividadFlujo
	FROM PRODUCTOS_MASTER pm 
	inner join MATERIAL m on pm.IdProducto = m.IdProducto
	inner join FLUJO_MASTER fm on pm.IdFlujo = fm.IdFlujoMaestro
	inner join ACTIVIDAD_FLUJO_MASTER afm on afm.IdFlujoMaestro = fm.IdFlujoMaestro
	where pm.IdProducto = @id2

-- Consulta 2
CREATE PROCEDURE [dbo].[diferencia] (@id1 int, @id2 int)
AS
	-- Select para obtener los datos del primer producto
	SELECT IdMAterial, IdFlujo, IdActividadFlujo
	FROM PRODUCTOS_MASTER pm 
	inner join MATERIAL m on pm.IdProducto = m.IdProducto
	inner join FLUJO_MASTER fm on pm.IdFlujo = fm.IdFlujoMaestro
	inner join ACTIVIDAD_FLUJO_MASTER afm on afm.IdFlujoMaestro = fm.IdFlujoMaestro
	where pm.IdProducto = @id1

	EXCEPT
	-- Select para obtener los datos del segundo producto
	SELECT IdMAterial, IdFlujo, IdActividadFlujo
	FROM PRODUCTOS_MASTER pm 
	inner join MATERIAL m on pm.IdProducto = m.IdProducto
	inner join FLUJO_MASTER fm on pm.IdFlujo = fm.IdFlujoMaestro
	inner join ACTIVIDAD_FLUJO_MASTER afm on afm.IdFlujoMaestro = fm.IdFlujoMaestro
	where pm.IdProducto = @id2


-- Experimento m
-- Cree una vista que use dos tablas

CREATE VIEW [dbo].[infoProducto]
AS
	SELECT * 
	FROM PRODUCTOS_MASTER pm 
	inner join MATERIAL m on pm.IdProducto = m.IdProducto


	