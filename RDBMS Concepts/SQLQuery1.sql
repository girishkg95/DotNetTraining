CREATE DATABASE EmployeeDB;

Use EmployeeDB;

CREATE TABLE Employee
(EmpID int not null PRIMARY KEY,
EmpName varchar(50) not null,
SSN bigint not null,
Salary float not null,
DepID int not null);

Insert Into Employee Values(1,'Jeffrey',23456,35000.00,1);

Insert Into Employee Values(2,'Robert',13456,25000.00,2);
Insert Into Employee Values(3,'Andrew',53456,35000.00,3);
Insert Into Employee Values(4,'Joseph',213456,23000.00,4);
Insert Into Employee Values(5,'Jeffrey',53458,35000.00,3);

Select * from Employee;

Drop Table Employee;

Create Table Department
(DepID int not null PRIMARY KEY,
DepName varchar(30) not null);

Insert Into Department Values(1,'Admin');
Insert Into Department Values(2,'Marketing');
Insert Into Department Values(3,'Technical');
Insert Into Department Values(4,'Stores');

Select * from Department;

Select * from Employee;

Update Employee SET Salary = 30000.00 Where EmpID = 1;

Update Employee SET Salary = 30000.00 Where DepID = 3;

Select * from Employee Where Salary BETWEEN 25000 AND 30000;

Select * from Employee Where Salary < 25000;

Select * from Employee Where Salary > 25000;

Select EmpID, EmpName, DepID from Employee Where DepID = 3; 

ALTER Table Department
ADD Description varchar(100);

Select * from Department;

Update Department SET Description = 'This is an admin department with higher activities' Where DepID = 1;
Update Department SET Description = 'This is marketing department where executives meet customers' Where DepID = 2;
Update Department SET Description = 'This is a technical department with project development activities' Where DepID = 3;
Update Department SET Description = 'This is a stores department with stock information' Where DepID = 4;

Alter Table Employee
Add Constraint FK_DepID FOREIGN KEY (DepID) References Department(DepID);

Alter Table Employee
Add DOB date

Select * from Employee;

Update Employee SET DOB = '10.08.1995';

Alter Table Employee
Add Constraint Chk_DOB CHECK (DOB BETWEEN '01/01/1990' AND '12/31/1999');

Insert Into Employee Values(6,'Joseph',21345,25000,4,'01/10/1998');






