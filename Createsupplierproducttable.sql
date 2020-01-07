create table ProductSupplier
(
Productid int  Foreign key References Product(Productid),
Supplierid int Foreign key References Supplier(Supplierid),
SupplierProductstuck int
 Constraint Pk_Product_Supplier  Primary Key (Productid,Supplierid)

)