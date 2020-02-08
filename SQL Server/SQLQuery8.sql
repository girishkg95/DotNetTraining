Use EmployeeDB;

Select * from Employee;

Select MAX(Salary) [Max Salary], MIN(Salary) 'Min Salary', AVG(Salary) 'Average Salary' from Employee;

Select DepID, SUM(Salary) 'Total Salary' from Employee
Group By DepID
Order By DepID;

Select DepID, SUM(Salary) 'Total Salary' from Employee
Group By DepID
Having SUM(Salary) >= 50000
Order By DepID;


--To retrieve top n records
Select Top(5) * from Employee;

Select Top(4) with ties Salary from Employee
Order By Salary;				--fetches similar data values which resides in the								top(n) group

--Select Top(4) Salary from Employee
--Order By Salary DESC;

Insert Into Employee Values(9,'Christian Nagell',35698,38000,3,'12/25/1990');
Insert Into Employee Values(10,'Anders Helsberg',53698,39000,3,'12/25/1993');

Insert Into Employee Values(11,'Pialo',55698,39000,null,'12/25/1995');
Insert Into Employee Values(12,'Jeffrey Richter',59698,39000,null,'12/25/1991');

Select * from Employee;

Select * from Department;

Select e.EmpID, e.EmpName,e.Salary,e.DepID,d.DepName from Employee As e INNER JOIN Department As d ON e.DepID = d.DepID;

Select e.EmpID, e.EmpName,e.Salary,e.DepID,d.DepName from Employee As e LEFT OUTER JOIN Department As d ON e.DepID = d.DepID;

Select e.EmpID, e.EmpName,e.Salary,e.DepID,d.DepName from Employee As e RIGHT OUTER JOIN Department As d ON e.DepID = d.DepID;

Select e.EmpID, e.EmpName,e.Salary,e.DepID,d.DepName from Employee As e FULL JOIN Department As d ON e.DepID = d.DepID;

--Top keyword to select top n records
Select Top 5 * from Employee;

--with ties is used with 'Top' and along with 'Order By' clause
Select Top(5) with ties *  from Employee
order by Salary;

Select * from Employee;

--Built-in Functions

Select GetDate() 'Today''s Date';

Select Day(GetDate()) As 'Day', Month(GetDate()) As 'Month', Year(GetDate()) As 'Year';
 
Select DATEDIFF(yy,DOB,GetDate()) 'Age of Employee(in Years)' from Employee;

Select DATEDIFF(mm,DOB,GetDate()) 'Age of Employee(in Months)' from Employee;

Select DATEDIFF(dd,DOB,GetDate()) 'Age of Employee(in Days)' from Employee;


--String functions

Select EmpName, Len(EmpName) as Length from Employee;

Select EmpName as 'Full Name', SUBSTRING(EmpName,1,5) as 'Part Name' from Employee;

--declaring local variables as a part of sql server dbms (T-Sql)
Declare @Greetings as varchar(50);
Set @Greetings = 'Hello Good Morning Everybody';

Select SUBSTRING(@Greetings,1,10) 'Some message';

Declare @name as varchar(30);

Set @name = '      Anders Helsberg       ';

Select LTrim(@name) as Name;
Select RTrim(@name) as Name;

declare @CompanyName as varchar(30);
Set @CompanyName = 'Cognizant Technlogy Solutions';
Select Upper(@CompanyName) as UpperCase, Lower(@CompanyName) as LowerCase 

Select Upper(EmpName) as 'Uppercase Name' from Employee;
Select Lower(DepName) as 'Lowercase Department' from Department;

Select Reverse(EmpName) as 'Name Reversed' from Employee;
Select Top 3 Left(EmpName,5)  as 'Part Name from Left' from Employee;
Select Top 3 Right(EmpName,5) as 'Part Name from Right' from Employee;

Select * from Employee;

--A simple sub-query
Select * from Employee Where Salary > (Select AVG(Salary) from Employee);
