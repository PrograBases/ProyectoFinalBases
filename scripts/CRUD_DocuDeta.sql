-- CRUD Documentos_Detalle

-- Read
CREATE PROCEDURE cusp_DocuDetalle_Read
    @IdDocumento int
AS 
BEGIN 
 
    SELECT IdDocumentoDetalle, Nombre, Fecha, IdPantallaDocumentos
    FROM   DOCUMENTOS_DETALLE dd 
    WHERE  (IdDocumentoDetalle = @IdDocumento) 
END

-- Update, solo modifica la fecha
CREATE PROCEDURE cusp_DocuDetalle_Update
    @IdDocumento int,
	@newFecha date
  
AS 
BEGIN 
 
UPDATE DOCUMENTOS_DETALLE
SET Fecha = @newFecha
     
WHERE  IdDocumentoDetalle = @IdDocumento
END

-- Insert
CREATE PROCEDURE usp_DocuDetalle_Insert
	@IdDocumento int,
	@Fecha date,
	@Nombre nvarchar(50),
	@IdPantallaDocumentos int
	 
AS
BEGIN
INSERT INTO DOCUMENTOS_DETALLE  (
	IdDocumentoDetalle,
	Fecha,
	Nombre,
	IdPantallaDocumentos
    VALUES (
    	@IdDocumento,
		@Fecha,
		@Nombre,
		@IdPantallaDocumentos)
END

-- Delete
CREATE PROCEDURE cusp_DocuDetalle_Delete 
    @IdDocumento int
AS 
BEGIN 
DELETE
FROM   DOCUMENTOS_DETALLE
WHERE  IdDocumentoDetalle = @IdDocumento
 
END

