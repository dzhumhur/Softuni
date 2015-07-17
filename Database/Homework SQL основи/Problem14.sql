select FirstName + ' ' + LastName AS 'Name', Salary 
from Employees
where Salary in(25000, 14000, 12500, 23600)