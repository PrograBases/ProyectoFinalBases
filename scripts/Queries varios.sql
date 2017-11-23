CREATE PROCEDURE [dbo].[insertStatus] @IdEstado int,
									  @Nombre nvarchar(50)

AS INSERT INTO ESTADO
(IdEstado, Nombre)
VALUES (@IdEstado,@Nombre)
-------------------------------------------------------------
CREATE PROCEDURE [dbo].[insert_PantallaTipo] @Id int,
											 @Nombre varchar(50) 

AS INSERT INTO PANTALLA_TIPO
(IdTipoPantalla,Nombre )
VALUES (@Id,@Nombre)

----------------------------------------------------------
CREATE PROCEDURE [dbo].[insert_PantallaListaChequeo] @Id int,
											 @IdActividad int,
											 @IdTipoPantalla int,
											 @IdBitacora int,
											 @ForApr nvarchar(50),
											 @ForRep nvarchar(50),
											 @fecha datetime,
											 @usuario int
											  

AS INSERT INTO PANTALLA_LISTA_CHEQUEO (
IdListaChequeo,IdActividad,IdTipoPantalla,IdBitácora,FormatoAprobado
,FormatoReprobado,Fecha_hora,Usuario) VALUES (
@Id ,@IdActividad ,@IdTipoPantalla , @IdBitacora ,
@ForApr, @ForRep ,@fecha ,@usuario )





CREATE PROCEDURE [dbo]. Update_ListaChequeo @IdListaC int,
								 @IdActividad int,
								 @FormatoAp nvarchar(50),
								 @FormatoRep nvarchar(50),
								 @Usuario int
AS UPDATE PANTALLA_LISTA_CHEQUEO
				SET Fecha_hora = SYSDATETIME(),
					FormatoAprobado = @FormatoAp,
					FormatoReprobado = @FormatoRep,
					Usuario = @Usuario
				--Estatus = @status
				WHERE IdListaChequeo = @IdListaC and 
					  IdActividad = @IdActividad

---------------------------------------------------------------
CREATE PROCEDURE [dbo].[insert_PantallaDocumentos] @Id int,
											 @IdPantalla int,
											 @IdActividad int,
											 @IdBitacora int

											  

AS INSERT INTO PANTALLA_DOCUMENTOS 
(IdDocumentosPantalla,IdTipoPantalla,IdActividad,
IdBitácora) VALUES ( @Id ,
											 @IdPantalla ,
											 @IdActividad ,
											 @IdBitacora )

---------------------------------------------------------------
CREATE PROCEDURE [dbo].[insert_PantallaCierreProd] @Id int,
											 @IdActividad int,
											 @Cantidad int,
											 @IdTipoPantalla int,
											 @turno nvarchar(50)


											  

AS INSERT INTO PANTALLA_CIERRE_PROD
(IdPantallaCierre,IdActividad,Cantidad_prod,IdTipoPantalla,
Turno_prod) VALUES (@Id ,
											 @IdActividad ,
											 @Cantidad ,
											 @IdTipoPantalla ,
											 @turno
)

----------------------------------------------------------------
CREATE PROCEDURE [dbo].[insert_PantallaComponentes] @IdPantallaComp int,
											 @IdActividad int,
											 @IdBitacora int,
											 @IdTipoPantalla int


											  

AS INSERT INTO PANTALLA_COMPONENTES(
IdPantallaComponentes,IdActividad,IdBitácora,
IdTipoPantalla) VALUES (
@IdPantallaComp ,
											 @IdActividad ,
											 @IdBitacora ,
											 @IdTipoPantalla 
)

-----------------------------------------------------------
CREATE PROCEDURE [dbo].[insert_Bitacora] @IdBitacora int,
											 @IdPantalla int,
											 @IdActividad int,
											 @Fecha datetime,
											 @Usuario int

											 


											  

AS INSERT INTO BITÁCORA (
IdBitácora,IdPantalla,IdActividad,Fecha_hora,Usuario
) VALUES (
@IdBitacora , @IdPantalla , @IdActividad , @Fecha ,
 @Usuario

----------------------------------------------------------