CREATE or alter PROCEDURE dbo.UpdateProdct
  @UpdateProduct Udt_ProducttypeForInsert Readonly
AS
   Begin tran
	begin try
	Declare Cursor_UpdateProduct Cursor For Select * From  @UpdateProduct
	 declare @Categoryid int
   declare @Supplierid int
   declare @Productid int
   declare @Productname nvarchar(50)
   declare @Productunitprice money
   declare @Productdiscount money
   declare @Productstock int
   open Cursor_UpdateProduct
   fetch next from Cursor_UpdateProduct into @Productid, @Productname,@Productunitprice,@Productdiscount,@Productstock,@Categoryid,@Supplierid  
   While @@FETCH_STATUS=0
   begin
   if(@Productname in(Select P.Productname From Product P))
					BEGIN
					Print @Productname+' '+'is already exist'
					End
	IF(@Productname not in (Select P.Productname From Product P))
				Begin
					IF( @Categoryid in (Select C.Categoryid From Category C) and  @supplierid in (Select S.Supplierid From Supplier S) )
						BEGIN
							 Update  Product 
						   set Productname=@Productname,
							Productunitprice = @Productunitprice,
							 Productdiscount=@Productdiscount,
							 Productstock=@Productstock,
							 Categoryid=@categoryid,
							 Supplierid=@supplierid
						   Where Productid=@Productid
						Print 'Informationes are Updated Successfully'
						commit tran
					
						END

						IF(  @Categoryid not in (Select C.Categoryid From Category C) and  @supplierid not in (Select S.Supplierid From Supplier S)
							or @Categoryid not in (Select C.Categoryid From Category C) or @supplierid not in (Select S.Supplierid From Supplier S) )
						BEGIN
						Print 'There is not this categoryid or this supplierid'
						
						END
					
					
					End
					fetch next from Insertproductcursor into @Categoryid,@Supplierid,@Productname

End
close Insertproductcursor
deallocate Insertproductcursor
End try
begin catch
rollback tran

End catch
RETURN 0 