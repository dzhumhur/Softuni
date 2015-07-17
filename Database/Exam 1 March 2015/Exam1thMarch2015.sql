--Task 1
select PeakName
from Peaks
order by PeakName


-- Task 2
select top 30 c.CountryName, c.Population
from Countries c
join Continents con
on c.ContinentCode = con.ContinentCode
where con.ContinentName = 'Europe'
order by Population DESC, c.CountryName


-- Task 3
select CountryName, CountryCode,
	(case when CurrencyCode = 'EUR'
	then 'Euro'
	else 'Not Euro'
	end) as Currency
from Countries
order by CountryName ASC


-- Task 4
select CountryName as [Country Name], IsoCode as [ISO Code]
from Countries
where CountryName like '%a%a%a%'
order by IsoCode


-- Task 5
select PeakName, m.MountainRange as [Mountain], Elevation
from Peaks p
join Mountains m
on p.MountainId = m.Id
order by Elevation DESC, PeakName ASC


-- Task 6
select PeakName, m.MountainRange as [Mountain], c.CountryName, con.ContinentName
from Peaks p
join Mountains m
on p.MountainId = m.Id
join MountainsCountries mc
on mc.MountainId = m.Id
join Countries c
on mc.CountryCode = c.CountryCode
join Continents con
on con.ContinentCode = c.ContinentCode
order by PeakName ASC , c.CountryName ASC


-- Task 7
select  r.RiverName as [River] , count(cr.CountryCode) as [Countries Count]
from Rivers r
join CountriesRivers cr
on cr.RiverId = r.Id
join Countries c
on cr.CountryCode = c.CountryCode
group by r.RiverName
having count(cr.CountryCode) >= 3
order by r.RiverName


-- Task 8
select max(Elevation) as [MaxElevation] , min(Elevation) [MinElevation], avg(Elevation) as [AverageElevation]
from Peaks


-- Task 9
select c.CountryName, con.ContinentName, count(r.Id) as [RiversCount], isnull(sum(r.Length), 0) as [TotalLength]
from Countries c
left join Continents con
on con.ContinentCode = c.ContinentCode
left join CountriesRivers cr
on cr.CountryCode = c.CountryCode
left join Rivers r
on cr.RiverId = r.Id
group by c.CountryName, con.ContinentName
order by count(r.Id) DESC, sum(r.Length) DESC, c.CountryName ASC


-- Task 10
select cur.CurrencyCode, cur.Description as [Currency], count(c.CountryCode) as [NumberOfCountries]
from Currencies cur
left join Countries c
on cur.CurrencyCode = c.CurrencyCode
group by cur.CurrencyCode, cur.Description
order by count(c.CountryCode) DESC, cur.Description ASC


-- Task 11
select cont.ContinentName, 
		sum(convert(numeric, c.AreaInSqKm)) as [CountriesArea],
		sum(convert(numeric, c.Population)) as [CountriesPopulation]
from Continents cont
join Countries c
on cont.ContinentCode = c.ContinentCode
group by cont.ContinentName
order by [CountriesPopulation] DESC


-- Task 12
select c.CountryName, max(p.Elevation) as [HighestPeakElevation] , max(r.Length) as [LongestRiverLength]
from Countries c
left join MountainsCountries mc
on mc.CountryCode = c.CountryCode
left join Mountains m
on m.Id = mc.MountainId
left join Peaks p
on p.MountainId = m.Id
left join CountriesRivers cr
on cr.CountryCode = c.CountryCode
left join Rivers r
on r.Id = cr.RiverId
group by c.CountryName
order by [HighestPeakElevation] DESC, [LongestRiverLength] DESC, c.CountryName ASC


-- Task 13
select p.PeakName, r.RiverName, 
		LOWER(SUBSTRING(p.PeakName, 0, len(p.PeakName)) + r.RiverName) as [Mix]
from Peaks p
join Rivers r
on lower(right(p.PeakName, 1)) = lower(left(r.RiverName, 1))
order by [Mix] ASC

-- Task 14
--// TO DO

-- Task 15
create table Monasteries(
	Id int not null identity,
	Name nvarchar(max) not null,
	CountryCode char(2) not null,
	constraint pk_Monasteries primary key(Id),
	constraint fk_Monasteries_Countries foreign key(CountryCode)
	references Countries(CountryCode))

INSERT INTO Monasteries(Name, CountryCode) VALUES
('Rila Monastery “St. Ivan of Rila”', 'BG'), 
('Bachkovo Monastery “Virgin Mary”', 'BG'),
('Troyan Monastery “Holy Mother''s Assumption”', 'BG'),
('Kopan Monastery', 'NP'),
('Thrangu Tashi Yangtse Monastery', 'NP'),
('Shechen Tennyi Dargyeling Monastery', 'NP'),
('Benchen Monastery', 'NP'),
('Southern Shaolin Monastery', 'CN'),
('Dabei Monastery', 'CN'),
('Wa Sau Toi', 'CN'),
('Lhunshigyia Monastery', 'CN'),
('Rakya Monastery', 'CN'),
('Monasteries of Meteora', 'GR'),
('The Holy Monastery of Stavronikita', 'GR'),
('Taung Kalat Monastery', 'MM'),
('Pa-Auk Forest Monastery', 'MM'),
('Taktsang Palphug Monastery', 'BT'),
('Sümela Monastery', 'TR')

alter table Countries 
drop column IsDeleted

alter table Countries
add IsDeleted bit not null
default 0

update Countries 
set IsDeleted = 0
where IsDeleted is null


select m.Name as [Monastery], c.CountryName as [Country]
from Monasteries m
join Countries c
on m.CountryCode = c.CountryCode
where IsDeleted = 0
order by m.Name ASC

-- Task 16
update Countries
set CountryName = 'Burma'
where CountryName = 'Myanmar'

insert into Monasteries (Name, CountryCode)
values('Hanga Abbey', 
		(select CountryCode 
		from Countries
		where CountryName = 'Tanzania'))

select con.ContinentName as [ContinentName],
		cou.CountryName as [CountryName],
		count(m.Id)as [MonasteriesCount]
from Continents con
left join Countries cou
on con.ContinentCode = cou.ContinentCode
left join Monasteries m
on m.CountryCode = cou.CountryCode
where cou.IsDeleted = 0
group by [ContinentName], [CountryName]
order by [MonasteriesCount] DESC, [CountryName]

-- Task 17

