Use Northwind;

Select p.ProductID,p.ProductName,p.UnitPrice,p.QuantityPerUnit,c.CategoryID,c.CategoryName from Products p INNER JOIN Categories c ON p.CategoryID = c.CategoryID;

Use Pubs;

Select * from Titles;
Select * from Publishers;