-- Select 
-- ANSII
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City = 'London'

-- Case  insensitive / küçük büyük harf önemli değil
select * from Products where categoryid = 1 or categoryid = 3

select * from Products where categoryid = 1 and unitprice>=10

select * from products order by UnitPrice asc --ascending, artan

select * from products where CategoryID=1 order by UnitPrice desc -- descending azalan

select count(*) Adet from Products where CategoryID=2

select CategoryID,count(*) Adet from Products where Unitprice>20 group by CategoryID having count(*)<10

select Products.ProductID [Urun Id], Products.ProductName Urun,Products.UnitPrice [Birim Fiyat],Categories.CategoryName [Kategori Ismi],Products.CategoryID KategoriID
from Products inner join Categories
on Products.CategoryID= Categories.CategoryID
where Products.UnitPrice>10 order by UnitPrice
-- inner join 2 tablodada eşleşen verileri getirir.

select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID= od.OrderID



select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null




--DTO data transformation object




