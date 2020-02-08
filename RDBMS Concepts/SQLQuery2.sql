
Alter Table Employee
Add DOB date 

Update Employee SET DOB = '10/08/1995';

Select * from Employee;

Alter Table Employee
Add Constraint PK_EmpID PRIMARY KEY (EmpID);

Insert Into Employee Values(6,'asdfd',45323,20000,4,'01/10/1990');

Create Table Department
(DepID int PRIMARY KEY not null,
DepName varchar(30) not null);

Insert Into Department Values (1,'Admin');
Insert Into Department Values (2,'Marketing');
Insert Into Department Values (3,'Technical');
Insert Into Department Values (4,'Stores');

Alter Table Department
Add Description varchar(100);

Select * from Department;

Update Department SET Description = 'This is an admin department with higher activities' Where DepID = 1;
Update Department SET Description = 'This is a marketing department with where executives meet customers' Where DepID = 2;
Update Department SET Description = 'This is a tehcnical department where development activities happen' Where DepID = 3;
Update Department SET Description = 'This is a stores department which gives the stock information' Where DepID = 4;

Select * from Employee;

Alter Table Employee
Add Constraint chk_DOB CHECK (DOB BETWEEN '01/01/1990' AND '12/31/1999');

Select * from Employee Where DepID IN (1,3);

Select * from Employee Where DepID = 1 OR DepID = 3;

Alter Table Employee
Add Constraint FK_DepID FOREIGN KEY (DepID) REFERENCES Department(DepID);

--Aggregate functions

Select MAX(Salary) 'Max Salary', MIN(Salary) 'Min Salary' from Employee;

Select AVG(Salary) 'Avg Salary' from Employee;

Select COUNT(EmpID) 'Total Employees' from Employee;

Select SUM(Salary) 'Total Salary' from Employee;

Select DepID, SUM(Salary) 'Total Salary' from Employee 
Group By DepID
Order By 'Total Salary';

Select * from Employee;

Select DepID, SUM(Salary) 'Total Salary' from Employee 
Group By DepID
Having SUM(Salary) > 30000
Order By 'Total Salary';

Select e.EmpID, e.EmpName, e.Salary,e.DepID,d.DepName from Employee e INNER JOIN Department d ON e.DepID = d.DepID;

Insert Into Employee Values(7,'Jims',23418,26000,4,null);
Insert Into Employee Values(8,'John',53418,27000,4,null);

Delete Employee Where EmpID IN (7,8);

Select e.EmpID, e.EmpName, e.Salary,e.DepID,d.DepName from Employee e LEFT OUTER JOIN Department d ON e.DepID = d.DepID;

Select e.EmpID, e.EmpName, e.Salary,e.DepID,d.DepName from Employee e RIGHT OUTER JOIN Department d ON e.DepID = d.DepID;

Select * from Department;

Update Department SET Description = 'This is an HR Department which finds human resources' Where DepID = 5;

Insert Into Employee Values(7,'Jims',42315,24000,5,'10/12/1996');
Insert Into Employee Values(8,'John',52315,26000,5,'12/15/1996');

Select * from Employee;

Delete Employee Where DepID = 4;






