select e.FirstName + ' ' + e.LastName AS [Employee],
		m.FirstName + ' ' + m.LastName AS [Manager]
from Employees e
left join Employees m
on e.ManagerID = m.EmployeeID