Create  type dbo.Udt_Producttypeforinsert3 as table
(
Productname nvarchar(50),
Productunitprice money,
Productdiscount money,
Productstock int,
ProductCategory int,
sapplierid int,
categoryid int
)