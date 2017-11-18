--------------------------------------------------
---------------------MATERIAL---------------------
--------------------------------------------------
----------------Insert, update, delete -----------
--------------------------------------------------
--------------------------------------------------
CREATE PROCEDURE updateMATERIAL @id int, 
@descripci�n nvarchar(50),
@idProducto int
as
update MATERIAL
set IdProducto = @idProducto,
Descripci�n = @descripci�n
where IdMAterial = @id

--------------------------------------------------
--------------------------------------------------
CREATE PROCEDURE [dbo].[insertMATERIAL] @id int, 
@descripci�n nvarchar(50),
@idProducto int
as
insert into MATERIAL
values (@id, @descripci�n, @idProducto)

--------------------------------------------------
--------------------------------------------------


CREATE PROCEDURE [dbo].[updateDescripci�nMATERIAL] @id int, 
@descripci�n nvarchar(50)
as
update MATERIAL
set Descripci�n = @descripci�n
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
select M.Descripci�n
from MATERIAL M
where M.IdProducto = @id

--------------------------------------------------
--------------------------------------------------

CREATE PROCEDURE getIdProductoMATERIAL @id int
as
select M.IdProducto
from MATERIAL M
where M.IdProducto = @id