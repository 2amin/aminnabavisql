Create table Product
(
Productid int Primary key Identity(1,1),
Productname nvarchar(50),
Productunitprice money,
Productdiscount money,
Productstock int,
Categoryid int Foreign key References Category(Categoryid)
)