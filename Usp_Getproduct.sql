
CREATE or alter PROCEDURE dbo.getproduct
    @categoryname varchar(50)
AS
  BEGIN tran

BEGIN try



Select Q3.Categoryid,Q3.Categoryname,Q3.Productid,Q3.Productname,Q3.Productunitprice,Q3.Productdiscount,Q3.Productstock,Q4.Suppliername
From
(Select C.Categoryid,C.Categoryname,P.Productid,P.Productname,P.Productunitprice,P.Productdiscount,P.Productstock
From dbo.Category C left join dbo.Product P
on C.Categoryid=P.Categoryid)Q3
inner join
(Select Q1.Productid,Q1.Supplierid,Q2.Suppliername
From 
(Select P.Productid,ps.Supplierid
From Product P inner join ProductSupplier Ps
on P.Productid=ps.Productid)Q1
inner join
(Select S.Supplierid,S.Suppliername
From Supplier S left join ProductSupplier ps
on S.Supplierid=Ps.Supplierid)Q2
on Q1.Supplierid=Q2.Supplierid)Q4
on Q3.Productid=Q4.Productid
Where   Q3.Categoryname= @categoryname


Commit tran


END try

BEGIN catch

 rollback tran

END catch
RETURN 0
Exec dbo.getproduct fruit
