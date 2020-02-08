--Stored Procedures And Functions

--1. A stored procedure is a database object that contains specific business logic and that will be executed whenever it is invoked

--2. The query engine will have the execution plan for every stored procedure whenever it is compiled for the first time

--3. In real time applications, most of the business logic will be stored inside this stored procedures and will be retrieved from the front-end applications wherever it is required

--4. Using stored procedures increases the performance of database applications when compared with passing sql queris across the network from every client

Use Northwind;

Create Procedure GetCustomersByCountry
(@country varchar(30))
As
Select CustomerID,ContactName,CompanyName,Address,Country from Customers Where Country = @country;
Go

Execute GetCustomersByCountry 'USA';

Create Procedure GetProductsByCategoryID
(@categoryID int)
As
Select p.ProductID, p.ProductName, p.UnitPrice, p.QuantityPerUnit,c.CategoryID,c.CategoryName from Products p INNER JOIN Categories c ON p.CategoryID = c.CategoryID AND c.categoryID = @categoryID;

Execute GetProductsByCategoryID 3;

--Declaring Local variables

Declare @country as varchar(30);
Set @country = 'France';
Select * from Customers Where Country = @country;

Alter Procedure GetTotalOrdersByDates
(@date1 date, @date2 date, @countOrder int output)
As
Select @countOrder = Count(OrderID) from Orders Where OrderDate Between @date1 And @date2;
Go

Declare @count as int;
Declare @date1 as date, @date2 as date;

Set @date1 = '01/01/1990';
Set @date2 = '12/31/1998'

Execute GetTotalOrdersByDates @date1,@date2,@count output;

Print 'Total number of orders placed: ' + Convert(varchar(10),@count);

Print GetDate();

Select * from Orders;

--Creating functions

--by default this function is stored inside the default schema known as 'dbo' which stands for database owner

--Scalar functions
Alter function Multiply(@n1 int, @n2 int) Returns bigint
As
Begin
Declare @prod as bigint;
Set @prod = @n1*@n2;
Return @prod;
End

Select dbo.Multiply(50,80) as Product;

--Table valued function
Create function GetCustomers(@country varchar(30)) Returns Table
AS
Return Select * from Customers Where Country = @country;
Go

Select * from dbo.GetCustomers('Germany');

Create function GetAllProductsByCategoryID(@categoryID int) Returns Table
As
Return Select p.ProductID, p.ProductName, p.UnitPrice, p.QuantityPerUnit,c.CategoryID,c.CategoryName from Products p INNER JOIN Categories c ON p.CategoryID = c.CategoryID AND c.categoryID = @categoryID;

Select * from dbo.GetAllProductsByCategoryID(5);

--Subqueries
--1. A subquery is used as a part of a main query, and the value returned from the subquery will be used by the main query for its execution

--2. Sometimes a subquery is used in-place of JOIN operations to combine two tables, but Joins are preferred over subqueries because of their efficiency

Select ProductID, ProductName, UnitPrice, QuantityPerUnit, CategoryID from Products Where UnitPrice > (Select AVG(UnitPrice) from Products) Order By UnitPrice;

Select * from Orders;

Select OrderID,CustomerID,EmployeeID,OrderDate,ShippedDate from Orders Where OrderID = (Select OrderID from Orders Where EmployeeID = 5 AND CustomerID = 'VINET');



--Correlated Subqueries

--A correlated subquery doesn't return any data back to the main query. But it always returns a boolean value of either 'true' or 'false' depending on whether it executes by itself or not. Accordingly the main query gets executed if it recieves a boolean value of true. Otherwise, the main query will not be executed

--These correlated subqueries make use of EXISTS or NOT EXISTS operators as a part of main query

Select CustomerID, CompanyName, Address, Country from Customers Where EXISTS (Select ContactName from Customers Where Country = 'UK');

Select CustomerID, CompanyName, Address, Country from Customers Where NOT EXISTS (Select ContactName from Customers Where Country = 'Russia');

















select * from Products;

Select * from Categories;



