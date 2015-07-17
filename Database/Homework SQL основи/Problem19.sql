select e.FirstName, e.LastName, a.AddressText 
from Employees e, Addresses a
where e.AddressID = a.AddressID