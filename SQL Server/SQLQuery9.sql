Create Database EmployeeEFDB;

Use EmployeeEFDB;

Create Table Employee
(EmpID int Primary Key,
Name varchar(30) not null,
SSN bigint not null,
Salary float not null,
DepID int not null);

Create Table Department
(DepID int Primary Key,
Name varchar(30) not null);

Alter Table Employee
Add Constraint FK_DepID FOREIGN KEY (DepID) references Department(DepID);

Insert Into Department Values(1,'Admin'); 
Insert Into Department Values(2,'Marketing'); 
Insert Into Department Values(3,'Technical'); 

Select * from Department;

Select * from Employee;

Insert Into Employee Values(4,'someEmployee',11111,10000,1);