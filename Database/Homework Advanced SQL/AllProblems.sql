use SoftUni


--Problem 1. Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.


SELECT FirstName, LastName, Salary 
FROM Employees
WHERE Salary IN
	(SELECT MIN(Salary) FROM Employees)


--------------------------------------------------------------


--Problem 2.	Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.


SELECT FirstName, LastName, Salary 
FROM Employees
WHERE Salary <=
	(SELECT MIN(Salary)*1.1 FROM Employees)


--------------------------------------------------------------


--Problem 3.	Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department.


SELECT FirstName + ' ' + LastName AS [FullName], Salary, d.Name 
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE e.Salary in (
	SELECT MIN(Salary) 
	FROM Employees eTemp
	WHERE eTemp.DepartmentID = e.DepartmentID
	)


--------------------------------------------------------------


--Problem 4.	Write a SQL query to find the average salary in the department #1.


SELECT AVG(Salary) AS [Average Salary]
FROM Employees
WHERE DepartmentID = 1


--------------------------------------------------------------


--Problem 5.	Write a SQL query to find the average salary in the "Sales" department.


SELECT AVG(Salary) AS [Average Salary for Sales Department]
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID  
WHERE d.Name = 'Sales'


--------------------------------------------------------------


--Problem 6.	Write a SQL query to find the number of employees in the "Sales" department.


select COUNT(e.EmployeeID) AS [Sales Employees Count] 
from Employees e 
join Departments d
on e.DepartmentID = d.DepartmentID
where d.Name = 'Sales'


--------------------------------------------------------------


--Problem 7.	Write a SQL query to find the number of all employees that have manager.


select COUNT(e.EmployeeID) AS [Sales Employees Count] 
from Employees e
where ManagerID is not null


--------------------------------------------------------------


--Problem 8.	Write a SQL query to find the number of all employees that have no manager.


select COUNT(e.EmployeeID) AS [Sales Employees Count] 
from Employees e
where ManagerID is null


--------------------------------------------------------------


--Problem 9.	Write a SQL query to find all departments and the average salary for each of them.


select d.Name, AVG(salary) [Avg Salary] 
from Employees e 
join Departments d
on e.DepartmentID = d.DepartmentID
group by d.Name


--------------------------------------------------------------


--Problem 10. Write a SQL query to find the count of all employees in each department and for each town. 


select t.Name AS [Town], d.Name AS [Department Name], count(e.EmployeeID) AS [Number of Employee]
from Employees e
join Departments d
on e.DepartmentID = d.DepartmentID
join Addresses a
on e.AddressID = a.AddressID
join Towns t
on a.TownID = t.TownID
group by t.Name, d.Name


--------------------------------------------------------------


--Problem 11. Write a SQL query to find all managers that have exactly 5 employees.


select m.FirstName, m.LastName, count(e.EmployeeID)
from Employees e
join Employees m
on e.ManagerID = m.EmployeeID
group by m.FirstName, m.LastName
having count(e.EmployeeID) = 5


--------------------------------------------------------------


--Problem 12	Write a SQL query to find all employees along with their managers.


select e.FirstName + ' ' + e.LastName [Employee],
		isnull (m.FirstName + ' ' + m.LastName, 'no manager') AS [Manager]
from Employees e
left join Employees m
on e.ManagerID = m.EmployeeID


--------------------------------------------------------------


--Problem 13. Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. 


select e.FirstName + ' ' + e.LastName AS [Employee Name]
from Employees e
where len(e.LastName) = 5


--------------------------------------------------------------


--Problem 14. Write a SQL query to display the current date and time in the following format "day.month.year hour:minutes:seconds:milliseconds". 


select GETDATE()


--------------------------------------------------------------


--Problem 15. Write a SQL statement to create a table Users.


create table users(
	id int identity,
	username nvarchar(20) not null unique,
	userpassword nvarchar(20) not null,
	fullname nvarchar(30) not null,
	lastlogindate datetime,
	CONSTRAINT PK_users PRIMARY KEY(id),
	constraint ck_userpassword check(len(userpassword) >= 5) 
)
go


---------------------------------------------------------------


--Problem 16. Write a SQL statement to create a view that displays the users from the Users table that have been in the system today.


create view [Users today] AS
select * from users
where day(lastlogindate) = day(GETDATE()) AND 
		MONTH(lastlogindate) = month(GETDATE()) AND 
		YEAR(lastlogindate) = year(GETDATE())


---------------------------------------------------------------


--Problem 17. Write a SQL statement to create a table Groups. 


create table Groups(
	id int identity not null primary key,
	name nvarchar(20) unique
	)


---------------------------------------------------------------


--Problem 18. Write a SQL statement to add a column GroupID to the table Users.


alter table users add GroupID int

alter table users
add constraint fk_users_groups
foreign key (GroupID) references Groups(Id)


---------------------------------------------------------------


--Problem 19. Write SQL statements to insert several records in the Users and Groups tables.


insert into users (username, userpassword, fullname, lastlogindate, GroupID)
	values('penkaa', '685742', 'Penka Minkova', GETDATE(), 2)

insert into Groups(name)
	values('Advanced Back-end')


---------------------------------------------------------------


--Problem 20. Write SQL statements to update some of the records in the Users and Groups tables.


update users
set userpassword = '369874'
where username = 'goshko'

update Groups
set name = 'Advanced Front-end'
where name = 'Advanced'


---------------------------------------------------------------


--Problem 21. Write SQL statements to delete some of the records from the Users and Groups tables.


delete from users
where id = 5


---------------------------------------------------------------


--Problem 22. Write SQL statements to insert in the Users table the names of all employees from the Employees table.


insert into users (username, userpassword, fullname)
select lower(e.FirstName + '_' + e.LastName), 
		lower(e.FirstName + '' + e.LastName),
		e.FirstName + ' ' + e.LastName	
from Employees e


---------------------------------------------------------------


--Problem 23. Write a SQL statement that changes the password to NULL for all users that have not been in the system since 10.03.2010.


update users
set userpassword = null
where lastlogindate >= Convert(datetime, '10-Mar-2010' )


---------------------------------------------------------------


--Problem 24. Write a SQL statement that deletes all users without passwords (NULL password).


delete from users
where userpassword is null

---------------------------------------------------------------


--Problem 25. Write a SQL query to display the average employee salary by department and job title.


select d.Name, e.JobTitle, AVG(e.Salary) AS [Avg Salary]
from Employees e
join Departments d
on e.DepartmentID = d.DepartmentID
group by d.Name, e.JobTitle


---------------------------------------------------------------


--Problem 26. Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it.


select d.Name, e.JobTitle, MIN(e.FirstName) AS [Name Employee], MIN(e.Salary) AS [Avg Salary]
from Employees e
join Departments d
on e.DepartmentID = d.DepartmentID
group by d.Name, e.JobTitle
order by d.Name


--------------------------------------------------------------


--Problem 27. Write a SQL query to display the town where maximal number of employees work.


select top 1 t.Name, count(e.EmployeeID) AS [Number of employees]
from Employees e
join Addresses a
on e.AddressID = a.AddressID
join Towns t
on t.TownID = a.TownID
group by t.Name
order by [Number of employees] DESC


--------------------------------------------------------------


--Problem 28. Write a SQL query to display the number of managers from each town.


select t.name, count(distinct e.ManagerID)
from towns t
join Addresses a
on t.TownID = a.TownID
join Employees e
on a.AddressID = e.AddressID
group by t.Name


---------------------------------------------------------------


--Problem 29.Write a SQL to create table WorkHours to store work reports for each employee.




--Problem 30.Issue few SQL statements to insert, update and delete of some data in the table.



--Problem 31. Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers.



--Problem 32. Start a database transaction, delete all employees from the 'Sales' department along with all dependent records from the pother tables. At the end rollback the transaction.



--Problem 33. Start a database transaction and drop the table EmployeesProjects.


--Problem 34. Find how to use temporary tables in SQL Server.



