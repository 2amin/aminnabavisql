Create  type dbo.Udt_Producttypeforinsert3 as table
(
Productname nvarchar(50),
Productunitprice money,
Productdiscount money,
Productstock int,

sapplierid int,
categoryid int
)