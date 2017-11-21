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



 -----------------------------------------------------------
 -----------------------------------------------------------
 -----------------------------------------------------------
 -----------------------------------------------------------
 CREATE TABLE #Temp (Codigo int,
 Descripción nvarchar(50),
 IdProducto int) 

 INSERT INTO #Temp
SELECT * FROM MATERIAL


DECLARE testTemp CURSOR   
     FOR SELECT *
		FROM #Temp   
 

 DECLARE @CodigoTemp int,
 @DescripciónTemp nvarchar(50),
 @IdProductoTemp int

DECLARE @initTemp time = CURRENT_TIMESTAMP 
 
OPEN testTemp  

FETCH NEXT FROM testTemp   
INTO @CodigoTemp,
 @DescripciónTemp,
@IdProductoTemp

WHILE @@FETCH_STATUS = 0  
BEGIN  

--PRINT ('...')


FETCH NEXT FROM testTemp   
INTO @CodigoTemp,
 @DescripciónTemp,
@IdProductoTemp

END
DECLARE @endTemp time = CURRENT_TIMESTAMP


PRINT (DATEDIFF(nanosecond, @initTemp, @endTemp))

 CLOSE testTemp
 DEALLOCATE testTemp; 

 DROP TABLE #Temp

  -----------------------------------------------------------
 -----------------------------------------------------------
 -----------------------------------------------------------
 -----------------------------------------------------------

 
 DECLARE @Variable TABLE (Codigo int,
 Descripción nvarchar(50),
 IdProducto int)


 INSERT INTO @Variable
SELECT * FROM MATERIAL


DECLARE testVar CURSOR   
     FOR SELECT *
		FROM @Variable   
 

 DECLARE @CodigoVar int,
 @DescripciónVar nvarchar(50),
 @IdProductoVar int

DECLARE @initVar time = CURRENT_TIMESTAMP 
 
OPEN testVar  

FETCH NEXT FROM testVar   
INTO @CodigoVar,
 @DescripciónVar,
@IdProductoVar

WHILE @@FETCH_STATUS = 0  
BEGIN  

--PRINT ('...')


FETCH NEXT FROM testVar   
INTO @CodigoVar,
 @DescripciónVar,
@IdProductoVar

END
DECLARE @endVar time = CURRENT_TIMESTAMP


PRINT (DATEDIFF(nanosecond, @initVar, @endVar))

 CLOSE testVar
 DEALLOCATE testVar; 


 /*
DECLARE @cnt INT = 4;

WHILE @cnt < 10000
BEGIN
   
   INSERT INTO
   MATERIAL
   VALUES(@cnt, 'Test' + CAST(@cnt as varchar), 1)
   SET @cnt = @cnt + 1;
END;

select *
from MATERIAL*/



--Time in nanoseconds
/*
With table:
123333300


With temporary table:
153333300


With table variable:
140000000*/