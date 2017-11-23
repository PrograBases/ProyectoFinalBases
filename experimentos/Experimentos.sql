-- Experimento a
-- Cree un stored procedure transaccional que genere y registre el flujo de un producto.

-- Para el flujo se ocupa

CREATE PROCEDURE [dbo].[flujoProducto] (@idActividadMaster int, @newid int)
AS
	INSERT INTO FLUJO_MASTER (IdFlujoMaestro)
	VALUES (@newid)

--***************************************************************************************************************************

-- Experimento C
-- Haga una consulta para cada una de los siguientes tipos de sentencias de tal manera que se demuestre claramente su uso 
-- y las consultas tengan valor agregado para el usuario del sistema:
--	HAVING
--	UNION
--	LIKE
--	Uso de cursor local.
--	Tabla temporal
--	Uso de un trigger

-- Consulta HAVING
-- Consulta para saber cuales flujos tienen mas de x actividades
CREATE PROCEDURE [dbo].[min5Actividades] (@amount int)
AS
	SELECT IdFlujoMaestro ,COUNT(afm.IdActividadFlujo)
	from FLUJO_MASTER fm 
	inner join ACTIVIDAD_FLUJO_MASTER afm on fm.IdFlujoMaestro = afm.IdFlujoMaestro
	group by IdFlujoMaestro
	HAVING COUNT(afm.IdActividadFlujo) >= @amount;


-- Consulta UNION
-- Consulta que une devuelve las ordenes con dos estados deseados
CREATE PROCEDURE [dbo].[unionStatus] (@status1 int, @status2 int)
AS
	SELECT NoLote, Estatus
	FROM ORDEN_PROD op 
	inner join ESTADO e on op.Estatus = e.IsEstado
	where op.Estatus = @status1

	UNION

	SELECT NoLote, Estatus
	FROM ORDEN_PROD op 
	inner join ESTADO e on op.Estatus = e.IsEstado
	where op.Estatus = @status2



-- Consulta LIKE
-- Consulta para encontrar un producto por un nombre dado
CREATE PROCEDURE [dbo].[findProductoName] (@name nvarchar(50))
AS
	SELECT Descripcion
	from PRODUCTOS_MASTER pm
	where pm.Descripcion LIKE '%@name%'

-- Uso de cursor local
DECLARE test CURSOR   
     FOR SELECT *
		FROM MATERIAL   
 

 DECLARE @Codigo int,
 @Descripción nvarchar(50),
 @IdProducto int

DECLARE @init time = CURRENT_TIMESTAMP 
 
OPEN test  

FETCH NEXT FROM test   
INTO @Codigo,
 @Descripción,
@IdProducto

WHILE @@FETCH_STATUS = 0  
BEGIN  

--PRINT ('...')


FETCH NEXT FROM test   
INTO @Codigo,
@Descripción,
@IdProducto

END
DECLARE @end time = CURRENT_TIMESTAMP


PRINT (DATEDIFF(nanosecond, @init, @end))

CLOSE test
DEALLOCATE test; 

-- Tabla temporal

-- Uso de un trigger
-- Se usa para alterar las descripccion de algun producto
CREATE PROCEDURE [dbo].[updateDescription] (@id int, @newDescription nvarchar(50))
AS
	UPDATE PRODUCTOS_MASTER pm
	SET Descripcion = @newDescription
	WHERE pm.IdProducto = @id
	-- Esto ejecuta el trigger que afecta la bitacora

--***************************************************************************************************************************

-- Experimento E
-- Cree un cursor que bloquee los datos que utiliza, luego ejecute un script que demuestre que sucede un deadlock mientras 
-- el cursor está siendo recorrido. Los registros deben ser bloqueados por el cursor en su barrido sin tener que hacer 
-- operaciones adicionales sobre los mismos.

-- Se crea un curso que bloquea los datos
SET TRANSACTION ISOLATION LEVEL REPEATABLE READ
GO
BEGIN TRANSACTION
GO
DECLARE prueba CURSOR STATIC FOR
SELECT * FROM MATERIAL.Descripcion
GO
OPEN prueba
GO

--***************************************************************************************************************************

-- Experimento F
-- Haga un script que provoque un deadlock cíclico de 4 transacciones A – B – C – D – A 

-- Transaccion A
BEGIN TRANSACTION Tran_A;

UPDATE FROM FLUJO_MASTER
SET IdFlujoMaestro = 3
WHERE IdFlujoMaestro = 1; 

UPDATE FROM PRODUCTOS_MASTER
SET IdFlujo = 1
WHERE IdProducto = 1;

COMMIT Tran_A;

-- Transaccion B
BEGIN TRANSACTION Tran_B;
UPDATE FROM PRODUCTOS_MASTER
SET IdFlujo = 3
WHERE IdProducto = 1;

UPDATE FROM MATERIAL
SET Descripcion = 'Casa'
WHERE IdMAterial = 2;

COMMIT Tran_B;

-- Transaccion C
BEGIN TRANSACTION Tran_C;
UPDATE FROM MATERIAL
SET Descripcion = 'Bola'
WHERE IdMAterial = 2;

UPDATE FROM MUESTRA
SET IdTipoMuestra = 1
WHERE IdMuestra = 1;

COMMIT Tran_C;

-- Transaccion D
BEGIN TRANSACTION Tran_D;
UPDATE FROM MUESTRA
SET IdTipoMuestra = 2
WHERE IdMuestra = 1;

UPDATE FROM FLUJO_MASTER
SET IdFlujoMaestro = 2
WHERE IdFlujoMaestro = 1; 

COMMIT Tran_D;

BE


-- Experimento H
-- Realice dos consultas, cada una con almenos 4 JOINS que resuelva una Diferencia y otra una intersección. 
-- Mida el tiempo de respuesta para ambos casos usando: IN/NOT IN,  JOIN, EXCEPT, INTERSECT, EXIST y NOT EXISTS 
-- para determinar cual muestra un mejor rendimiento.

-- Consulta 1 con Intersect
-- Consulta para ver las ordenes activas de dos productos y sus componentes
CREATE PROCEDURE [dbo].[interseccion] (@id1 int, @id2 int)
AS
	-- Select para obtener los datos del primer producto
	SELECT IdMAterial, IdFlujo, IdActividadFlujo
	FROM PRODUCTOS_MASTER pm 
	inner join ORDEN_PROD op on pm.IdProducto = op.IdProductoAsignado
	inner join MATERIAL m on pm.IdProducto = m.IdProducto
	inner join FLUJO_MASTER fm on pm.IdFlujo = fm.IdFlujoMaestro
	inner join ACTIVIDAD_FLUJO_MASTER afm on afm.IdFlujoMaestro = fm.IdFlujoMaestro
	where pm.IdProducto = @id1

	INTERSECT
	-- Select para obtener los datos del segundo producto
	SELECT IdMAterial, IdFlujo, IdActividadFlujo
	FROM PRODUCTOS_MASTER pm 
	inner join ORDEN_PROD op on pm.IdProducto = op.IdProductoAsignado
	inner join MATERIAL m on pm.IdProducto = m.IdProducto
	inner join FLUJO_MASTER fm on pm.IdFlujo = fm.IdFlujoMaestro
	inner join ACTIVIDAD_FLUJO_MASTER afm on afm.IdFlujoMaestro = fm.IdFlujoMaestro
	where pm.IdProducto = @id2

-- Consulta 1 con IN
CREATE PROCEDURE [dbo].[interseccionIN] (@id1 int, @id2 int)
AS
	-- Select para obtener los datos del primer producto
	SELECT IdMAterial, IdFlujo, IdActividadFlujo
	FROM PRODUCTOS_MASTER pm 
	inner join ORDEN_PROD op on pm.IdProducto = op.IdProductoAsignado
	inner join MATERIAL m on pm.IdProducto = m.IdProducto
	inner join FLUJO_MASTER fm on pm.IdFlujo = fm.IdFlujoMaestro
	inner join ACTIVIDAD_FLUJO_MASTER afm on afm.IdFlujoMaestro = fm.IdFlujoMaestro
	where pm.IdProducto = @id1 and (IdMAterial, IdFlujo, IdActividadFlujo) IN (SELECT IdMAterial, IdFlujo, IdActividadFlujo
																				FROM PRODUCTOS_MASTER pm 
																				inner join ORDEN_PROD op on pm.IdProducto = op.IdProductoAsignado
																				inner join MATERIAL m on pm.IdProducto = m.IdProducto
																				inner join FLUJO_MASTER fm on pm.IdFlujo = fm.IdFlujoMaestro
																				inner join ACTIVIDAD_FLUJO_MASTER afm on afm.IdFlujoMaestro = fm.IdFlujoMaestro
																				where pm.IdProducto = @id2)

-- Consulta 1 con Exists
CREATE PROCEDURE [dbo].[interseccionE] (@id1 int, @id2 int)
AS
	-- Select para obtener los datos del primer producto
	SELECT IdMAterial, IdFlujo, IdActividadFlujo
	FROM PRODUCTOS_MASTER pm 
	inner join ORDEN_PROD op on pm.IdProducto = op.IdProductoAsignado
	inner join MATERIAL m on pm.IdProducto = m.IdProducto
	inner join FLUJO_MASTER fm on pm.IdFlujo = fm.IdFlujoMaestro
	inner join ACTIVIDAD_FLUJO_MASTER afm on afm.IdFlujoMaestro = fm.IdFlujoMaestro
	where pm.IdProducto = @id1 and (IdMAterial, IdFlujo, IdActividadFlujo) EXISTS (SELECT IdMAterial, IdFlujo, IdActividadFlujo
																				FROM PRODUCTOS_MASTER pm 
																				inner join ORDEN_PROD op on pm.IdProducto = op.IdProductoAsignado
																				inner join MATERIAL m on pm.IdProducto = m.IdProducto
																				inner join FLUJO_MASTER fm on pm.IdFlujo = fm.IdFlujoMaestro
																				inner join ACTIVIDAD_FLUJO_MASTER afm on afm.IdFlujoMaestro = fm.IdFlujoMaestro
																				where pm.IdProducto = @id2)

-- Consulta 2 con Except
CREATE PROCEDURE [dbo].[diferencia] (@id1 int, @id2 int)
AS
	-- Select para obtener los datos del primer producto
	SELECT IdMAterial, IdFlujo, IdActividadFlujo
	FROM PRODUCTOS_MASTER pm 
	inner join ORDEN_PROD op on pm.IdProducto = op.IdProductoAsignado
	inner join MATERIAL m on pm.IdProducto = m.IdProducto
	inner join FLUJO_MASTER fm on pm.IdFlujo = fm.IdFlujoMaestro
	inner join ACTIVIDAD_FLUJO_MASTER afm on afm.IdFlujoMaestro = fm.IdFlujoMaestro
	where pm.IdProducto = @id1

	EXCEPT
	-- Select para obtener los datos del segundo producto
	SELECT IdMAterial, IdFlujo, IdActividadFlujo
	FROM PRODUCTOS_MASTER pm 
	inner join ORDEN_PROD op on pm.IdProducto = op.IdProductoAsignado
	inner join MATERIAL m on pm.IdProducto = m.IdProducto
	inner join FLUJO_MASTER fm on pm.IdFlujo = fm.IdFlujoMaestro
	inner join ACTIVIDAD_FLUJO_MASTER afm on afm.IdFlujoMaestro = fm.IdFlujoMaestro
	where pm.IdProducto = @id2

-- Consulta 2 con Not In
CREATE PROCEDURE [dbo].[diferenciaNI] (@id1 int, @id2 int)
AS
	-- Select para obtener los datos del primer producto
	SELECT IdMAterial, IdFlujo, IdActividadFlujo
	FROM PRODUCTOS_MASTER pm 
	inner join ORDEN_PROD op on pm.IdProducto = op.IdProductoAsignado
	inner join MATERIAL m on pm.IdProducto = m.IdProducto
	inner join FLUJO_MASTER fm on pm.IdFlujo = fm.IdFlujoMaestro
	inner join ACTIVIDAD_FLUJO_MASTER afm on afm.IdFlujoMaestro = fm.IdFlujoMaestro
	where pm.IdProducto = @id1 and (IdMAterial, IdFlujo, IdActividadFlujo) NOT IN (SELECT IdMAterial, IdFlujo, IdActividadFlujo
																					FROM PRODUCTOS_MASTER pm 
																					inner join ORDEN_PROD op on pm.IdProducto = op.IdProductoAsignado
																					inner join MATERIAL m on pm.IdProducto = m.IdProducto
																					inner join FLUJO_MASTER fm on pm.IdFlujo = fm.IdFlujoMaestro
																					inner join ACTIVIDAD_FLUJO_MASTER afm on afm.IdFlujoMaestro = fm.IdFlujoMaestro
																					where pm.IdProducto = @id2)

-- Consulta 2 con Not Exists
CREATE PROCEDURE [dbo].[diferenciaNE] (@id1 int, @id2 int)
AS
	-- Select para obtener los datos del primer producto
	SELECT IdMAterial, IdFlujo, IdActividadFlujo
	FROM PRODUCTOS_MASTER pm 
	inner join ORDEN_PROD op on pm.IdProducto = op.IdProductoAsignado
	inner join MATERIAL m on pm.IdProducto = m.IdProducto
	inner join FLUJO_MASTER fm on pm.IdFlujo = fm.IdFlujoMaestro
	inner join ACTIVIDAD_FLUJO_MASTER afm on afm.IdFlujoMaestro = fm.IdFlujoMaestro
	where pm.IdProducto = @id1 and (IdMAterial, IdFlujo, IdActividadFlujo) NOT EXISTS (SELECT IdMAterial, IdFlujo, IdActividadFlujo
																					FROM PRODUCTOS_MASTER pm 
																					inner join ORDEN_PROD op on pm.IdProducto = op.IdProductoAsignado
																					inner join MATERIAL m on pm.IdProducto = m.IdProducto
																					inner join FLUJO_MASTER fm on pm.IdFlujo = fm.IdFlujoMaestro
																					inner join ACTIVIDAD_FLUJO_MASTER afm on afm.IdFlujoMaestro = fm.IdFlujoMaestro
																					where pm.IdProducto = @id2)

--***************************************************************************************************************************

-- Experimento M
-- Cree una vista que use dos tablas

CREATE VIEW [dbo].[infoProducto]
AS
	SELECT * 
	FROM PRODUCTOS_MASTER pm 
	inner join MATERIAL m on pm.IdProducto = m.IdProducto

--***************************************************************************************************************************


	