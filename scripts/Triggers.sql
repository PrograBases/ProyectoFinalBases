-- Triggers

CREATE TRIGGER TriggerComponentes
ON  PANTALLA_COMPONENTES
AFTER INSERT, UPDATE, DELETE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for trigger here
	DECLARE @id AS int
	DECLARE @pantalla AS int
	DECLARE @actividad AS int
	DECLARE @fecha AS datetime
	DECLARE @usuario AS int
	IF EXISTS(SELECT * FROM inserted)
       AND NOT EXISTS(SELECT * FROM deleted) 
	BEGIN
		SET @id = (SELECT IdBitacora FROM inserted)
		SET @pantalla = (SELECT IdPantalla FROM inserted)
		SET @actividad = (SELECT IdActividad FROM inserted)
		SET @fecha = (SELECT Fecha_hora FROM inserted)
	END
	ELSE 
	BEGIN
		SET @id = (SELECT IdBitacora FROM deleted)
		SET @pantalla = (SELECT IdPantalla FROM deleted)
		SET @actividad = (SELECT IdActividad FROM deleted)
		SET @fecha = (SELECT Fecha_hora FROM deleted)
	END

	INSERT INTO BITÁCORA (IdBitacora, IdPantalla, IdActividad, Fecha_hora)
	VALUES (@id, @pantalla, @actividad, @fecha)

END


-- Triggers Daniel

-- ================================================
-- Template generated from Template Explorer using:
-- Create Trigger (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- See additional Create Trigger templates for more
-- examples of different Trigger statements.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE TRIGGER Update_Bitacora_PantallaCheqList
   ON  PANTALLA_LISTA_CHEQUEO
   AFTER INSERT,UPDATE, DELETE
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	INSERT INTO BITÁCORA
	VALUES((SELECT IdBitácora FROM inserted),(SELECT IdListaChequeo FROM inserted),
	(SELECT IdActividad FROM inserted),(SELECT Fecha_hora FROM inserted),
	(SELECT Usuario FROM inserted))

    -- Insert statements for trigger here

END
GO
