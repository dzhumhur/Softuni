select e.FirstName, e.LastName, a.AddressText from Employees e
join Addresses a
on e.EmployeeID = a.AddressID