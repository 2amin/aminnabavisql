CREATE PROCEDURE dbo.InsertProduct
   @insertProduct dbo.Udt_Producttypeforinsert3 Readonly
AS
  
declare Insertproductcursor Cursor For Select ipr.categoryid,ipr.sapplierid From @insertProduct ipr
   declare @Categoryid nvarchar(50)
   declare @Supplierid nvarchar(50)
   declare @Eror nvarchar(100)
	open Insertproductcursor
	fetch next from Insertproductcursor into @Categoryid,@Supplierid
	while @@FETCH_STATUS=0
		begin
			
			IF( @Categoryid in (Select C.Categoryid From Category C) and  @supplierid in (Select S.Supplierid From Supplier S) )
			BEGIN
			insert into Product (Productname,Productunitprice,Productdiscount,Productstock)
			Select ipr.Productname,ipr.Productunitprice,ipr.Productdiscount,ipr.Productstock From @insertProduct ipr
			set @Eror='Informationes are saved Successfully'
			END

			IF(  @Categoryid not in (Select C.Categoryid From Category C) and  @supplierid not in (Select S.Supplierid From Supplier S) )
			BEGIN
			set @Eror = 'There is not this categoryid or this supplierid'

			END


				--Where make=@make
	fetch next from Insertproductcursor into @Categoryid,@Supplierid
		end

close Insertproductcursor
deallocate Insertproductcursor
Print @Eror

Exec dbo.dbo.InsertProduct 