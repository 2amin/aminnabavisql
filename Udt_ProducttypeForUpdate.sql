Create Type dbo.Udt_ProducttypeForUpdate as table
(
Productid int,
Productname nvarchar(50),
Productunitprice money,
Productdiscount money,
Productstock int,
sapplierid int,
categoryid int
)