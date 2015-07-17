select e.FirstName + ' ' + e.LastName AS [Employee], d.Name AS [Department Name], e.HireDate 
from Employees e, Departments d
where e.DepartmentID in 
	(select d.DepartmentID 
	 from Departments
	 where d.Name in ('Sales', 'Finance') AND
	 e.HireDate between '1995' AND '2005' )



	SELECT E.FirstName + ' ' + e.LAStName AS [Full Name], d.Name AS [Department], e.HireDate
FROM Employees e 
  JOIN Departments d
    ON d.DepartmentID=e.DepartmentID AND d.Name IN ('Sales','Finance')
WHERE e.HireDate BETWEEN '1995-1-1' AND '2005-1-1'
