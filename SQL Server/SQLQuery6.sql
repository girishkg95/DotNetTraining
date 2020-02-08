CREATE DATABASE EmployeeDB;

Use EmployeeDB;

Create Table Employees
(EmpID int not null,
EmpName varchar(50) not null,
SSN bigint not null,
DeptID smallint not null);

Select * from Employees;

Insert Into Employees Values(1,'Robert',23456,1);
Insert Into Employees Values(2,'John',13456,2);
Insert Into Employees Values(3,'Stephen',33456,3);
Insert Into Employees Values(4,'Laxman',53456,4);
Insert Into Employees Values(5,'Matthew',53456,3);

Select * from Employees Where EmpID = 4;

Create Table Departments
(DeptID smallint not null,
DeptName varchar(50) not null);

Select * from Departments;

Insert Into Departments Values(1,'Admin');
Insert Into Departments Values(2,'Marketing');
Insert Into Departments Values(3,'Technical');
Insert Into Departments Values(4, 'Stores');

