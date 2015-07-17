select e.FirstName + ' ' + e.LastName AS [Employee], 
		m.FirstName + ' ' + m.LastName AS [Manager],
		a.AddressText AS [Employee Address]
from Employees e
join Employees m
on e.ManagerID = m.EmployeeID 
join Addresses a
on e.AddressID = a.AddressID