Use Northwind;

Select * from Products Where CategoryID = 5;

Select * from Categories;

Select p.ProductName, p.ProductID, p.UnitPrice, p.QuantityPerUnit, c.CategoryID, c.CategoryName from Products p INNER JOIN Categories c ON c.CategoryID = p.CategoryID
Order By c.CategoryName;