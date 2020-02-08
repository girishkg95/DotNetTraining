Select GetDate() as 'Current Date';

--DateDiff() function
Select EmpName, DateDiff(yy,DOB,GetDate()) as Age from Employee;

Select Day(GetDate()) as 'Day';
Select Month(GetDate()) as 'Month';
Select Year(GetDate()) as 'Year';

--String functions
Select EmpName, Len(EmpName) as 'Length' from Employee;

Select Upper(EmpName) as 'Uppercase', Lower(EmpName) as 'Lowercase' from Employee;

Select EmpName,SubString(EmpName,1,5) as 'PartName' from Employee;

--These functions can also be used individually by passing data arguments
Select SubString('Good morning everybody',1,10);

Select EmpName, Reverse(EmpName) as 'Name Reversed' from Employee;

Select Replace('Good Morning','Morning','Evening') as 'Greetings';


--Sub-queries
Select EmpID,EmpName,Salary from Employee Where Salary > (Select AVG(Salary) from Employee);

--Writing sub-query from another table
Select EmpID,EmpName,Salary,DepID from Employee Where DepID = (Select DepID from Department Where DepName = 'Technical');

Select EmpID,EmpName,Salary,DepID from Employee Where DepID = (Select DepID from Department Where DepName = 'Admin');



