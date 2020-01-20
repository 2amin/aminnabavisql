CREATE or alter PROCEDURE dbo.InsertProduct
   @insertProduct dbo.Udt_Producttypeforinsert Readonly
AS
  
declare Insertproductcursor Cursor For Select ipr.categoryid,ipr.sapplierid,ipr.productname From @insertProduct ipr
   declare @Categoryid nvarchar(50)
   declare @Supplierid nvarchar(50)
   declare @Productname nvarchar(50)
   declare @Eror nvarchar(100)
	open Insertproductcursor
	fetch next from Insertproductcursor into @Categoryid,@Supplierid,@Productname
	while @@FETCH_STATUS=0
		begin
		        if(@Productname in(Select P.Productname From Product P))
					BEGIN
					set @Eror=@Productname+' '+'is already exist'
					
					End
				IF(@Productname not in (Select P.Productname From Product P))
				Begin
					IF( @Categoryid in (Select C.Categoryid From Category C) and  @supplierid in (Select S.Supplierid From Supplier S) )
						BEGIN
						insert into Product (Productname,Productunitprice,Productdiscount,Productstock,Categoryid,supplierid)
						Select ipr.Productname,ipr.Productunitprice,ipr.Productdiscount,ipr.Productstock,ipr.categoryid,ipr.sapplierid From @insertProduct ipr
						set @Eror='Informationes are saved Successfully'
					
						END

						IF(  @Categoryid not in (Select C.Categoryid From Category C) and  @supplierid not in (Select S.Supplierid From Supplier S)
							or @Categoryid not in (Select C.Categoryid From Category C) or @supplierid not in (Select S.Supplierid From Supplier S) )
						BEGIN
						set @Eror = 'There is not this categoryid or this supplierid'
						
						END
						
					End


					fetch next from Insertproductcursor into @Categoryid,@Supplierid
		End

close Insertproductcursor
deallocate Insertproductcursor
Print @Eror
return @Eror

declare @x Udt_producttypeforinsert

Insert into @x(Productname,Productunitprice,Productdiscount,Productstock,categoryid,sapplierid) values ('laptop',9,3,10,4,1)
Insert into @x(Productname,Productunitprice,Productdiscount,Productstock,categoryid,sapplierid) values  ('Bmw',5,2,17,2,1) 


Exec dbo.InsertProduct @x



