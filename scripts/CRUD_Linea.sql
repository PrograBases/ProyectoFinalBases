-- CRUD Linea_Producto

-- Insert
CREATE PROCEDURE usp_Linea_Read
	   @IdLinea int,
	   @IdOrden int
	 
AS
BEGIN
INSERT INTO Linea_Prod  (
	   IdLineaProd, 
	   IdOrdenAsignada)
    VALUES (
    	@IdLinea int,
    	@IdOrden int)
END

-- Read
CREATE PROCEDURE cusp_Linea_Read
    @IdLinea int
AS 
BEGIN 
 
    SELECT IdLineaProd, IdOrdenAsignada
    FROM   Linea_Prod 
    WHERE  (IdLineaProd = @IdLinea) 
END

-- Update
CREATE PROCEDURE cusp_Linea_Update
    @IdLinea int,
	@IdOrden int
  
AS 
BEGIN 
 
UPDATE Linea_Prod
SET IdOrdenAsignada = @IdOrden
     
WHERE  IdLineaProd = @IdLinea
END

-- Delete
CREATE PROCEDURE cusp_Linea_Delete 
    @IdLinea int
AS 
BEGIN 
DELETE
FROM   Linea_Prod
WHERE  IdLineaProd = @IdLinea
 
END