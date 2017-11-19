

--CRUD ORDENES DE PRODUCCION
--Crear orden de produccion
CREATE PROCEDURE [dbo]. Insert_ProdOrder @NoLote varchar(50),
								@idProductoAsignado int,
								@fechaCreacion datetime,
								@fechaTerminado datetime,
								@status int
AS INSERT INTO ORDEN_PROD
				(NoLote,IdProductoAsignado,DatetimeCreación,DatetimeFinalización,
				Estatus) VALUES
				(@NoLote ,@idProductoAsignado,@fechaCreacion,@fechaTerminado,
				@status)



--Update Orden de Produccion
CREATE PROCEDURE [dbo]. Update_ProdOrder @fechaTerminado datetime,
								@status int
AS UPDATE ORDEN_PROD
				SET DatetimeFinalización = @fechaTerminado,
				Estatus = @status



--Delete Orden de Produccion
CREATE PROCEDURE [dbo]. Delete_ProdOrder @NoLote varchar(50)
AS DELETE FROM ORDEN_PROD WHERE @NoLote = NoLote	
			

-- update fecha de terminado
CREATE PROCEDURE [dbo]. update_FechaTerminado @NoLote varchar(50),
											  @fechaTerminado datetime
AS 
UPDATE ORDEN_PROD
SET DatetimeFinalización = @fechaTerminado
WHERE NoLote = @NoLote


-- update status
CREATE PROCEDURE [dbo]. update_FechaTerminado @NoLote varchar(50),
											  @status int
AS 
UPDATE ORDEN_PROD
SET Estatus = @status
WHERE NoLote = @NoLote
