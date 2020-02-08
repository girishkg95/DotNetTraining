Use Pubs;

Select * from Titles;

Select * from Publishers;

Select * from Titles t INNER JOIN Publishers p ON t.pub_id = p.pub_id;

Use Northwind;

Select * from Customers c INNER JOIN Orders o ON o.CustomerID = c.CustomerID;

