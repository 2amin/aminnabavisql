CREATE PROCEDURE dbo.getcategory
    
AS

BEGIN tran

BEGIN try

 Select * From Category 
 Commit tran

END try

BEGIN catch

 rollback tran

END catch
   
RETURN 0 
go
exec dbo.getcategory