--------------------------------------------------
---------------------MATERIAL---------------------
--------------------------------------------------
----------------Insert, update, delete -----------
--------------------------------------------------
--------------------------------------------------
CREATE PROCEDURE updateMATERIAL @id int, 
@descripción nvarchar(50),
@idProducto int
as
update MATERIAL
set IdProducto = @idProducto,
Descripción = @descripción
where IdMAterial = @id

--------------------------------------------------
--------------------------------------------------
CREATE PROCEDURE [dbo].[insertMATERIAL] @id int, 
@descripción nvarchar(50),
@idProducto int
as
insert into MATERIAL
values (@id, @descripción, @idProducto)

--------------------------------------------------
--------------------------------------------------


CREATE PROCEDURE [dbo].[updateDescripciónMATERIAL] @id int, 
@descripción nvarchar(50)
as
update MATERIAL
set Descripción = @descripción
where IdMAterial = @id

--------------------------------------------------
--------------------------------------------------


CREATE PROCEDURE [dbo].[updateIdProductoMATERIAL] @id int, 
@idProducto int
as
update MATERIAL
set IdProducto = @idProducto
where IdMAterial = @id


--------------------------------------------------
--------------------------------------------------

CREATE PROCEDURE [dbo].[deleteMATERIAL] @id int
as
delete from MATERIAL
where IdMAterial = @id

--------------------------------------------------
--------------------------------------------------

CREATE PROCEDURE getDescMATERIAL @id int
as
select M.Descripción
from MATERIAL M
where M.IdProducto = @id

--------------------------------------------------
--------------------------------------------------

CREATE PROCEDURE getIdProductoMATERIAL @id int
as
select M.IdProducto
from MATERIAL M
where M.IdProducto = @id