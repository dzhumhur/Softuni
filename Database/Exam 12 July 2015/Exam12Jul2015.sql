/*
-- Task 1
select c.Name
from Characters c
order by c.Name


-- Task 2
select top 50 g.Name as [Game], 
		convert(nvarchar(10),g.Start, 20) as [Start]
from Games g
where g.Start between '2011' AND '2013'
order by [Start]


-- Task 3
select u.Username, substring(u.Email, CHARINDEX('@', u.Email) + 1, len(u.Email)) as [Email Provider]
from Users u
order by [Email Provider] ASC, u.Username


-- Task 4
select u.Username, u.IpAddress as [IP Address]
from Users u
where u.IpAddress like '___.1%.%.___'
order by u.Username asc
 

-- Task 5
select g.Name as [Game],
		(CASE
		WHEN DATEPART(HOUR, g.Start) >= 0 AND DATEPART(HOUR, g.Start) < 12 THEN 'Morning'
		WHEN DATEPART(HOUR, g.Start) >= 12 and DATEPART(HOUR, g.Start) < 18 THEN 'Afternoon'
		WHEN DATEPART(HOUR, g.Start) >= 18 and DATEPART(HOUR, g.Start) < 24 THEN 'Evening'
		END) as [Part of the Day],
		isnull((CASE
		WHEN g.Duration <= 3  THEN 'Extra Short'
		WHEN g.Duration >= 4 AND g.Duration <= 6  THEN 'Short'
		WHEN g.Duration > 6  THEN 'Long'
		WHEN g.Duration is null then 'Extra Long'
		END), 'Extra Long'
		) as [Duration]
from Games g
order by [Game], [Duration], [Part of the Day]


-- Task 6
select substring(u.Email, CHARINDEX('@', u.Email) + 1, len(u.Email)) as [Email Provider],
	count(u.Id) as [Number Of Users]
from Users u
group by substring(u.Email, CHARINDEX('@', u.Email) + 1, len(u.Email))
order by [Number of Users] DESC, [Email Provider] ASC


-- Task 7
select g.Name as [Game], 
		gt.Name as [Game Type],
		u.Username as [Username],
		ug.Level as [Level],
		ug.Cash as [Cash],
		c.Name as [Character]
from Games g
join UsersGames ug
on  ug.GameId = g.Id
join Users u
on ug.UserId = u.Id
join GameTypes gt
on gt.Id = g.GameTypeId
join Characters c
on ug.CharacterId = c.Id
order by [Level] DESC, [Username], [Game]


-- Task 8
select u.Username as [Username],
		g.Name as [Game],
		count(i.Id) as [Items Count],
		sum(i.Price) as [Items Price]
from Users u
join UsersGames ug
on ug.UserId = u.Id
join Games g
on ug.GameId = g.Id
join UserGameItems ugi
on ugi.UserGameId = ug.Id
join Items i
on ugi.ItemId = i.Id
group by u.Username, g.Name
having count(i.Id) >= 10
order by [Items Count] DESC, [Items Price] DESC, [Username] ASC


-- Task 9
select u.Username as [Username],
		g.Name as [Game],
		c.Name as [Character],
		s.Strength as [Strength],
		s.Defence as [Defence],
		s.Speed as [Speed],
		s.Mind as [Mind],
		s.Luck as [Luck]
from Users u
join UsersGames ug
on ug.UserId = u.Id
join Games g
on ug.GameId = g.Id
join Characters c
on ug.CharacterId = c.Id
join [Statistics] s
on s.Id = c.StatisticId
join GameTypes gt
on gt.Id = g.GameTypeId
join Items i
on i.StatisticId = s.Id
group by u.Username
order by [Strength] DESC, [Defence] DESC, [Speed] DESC, [Mind] DESC, [Luck] DESC


-- Task 10
select i.Name, i.Price, i.MinLevel, st.Strength, st.Defence, st.Speed, st.Luck, st.Mind
from Items i
join [Statistics] st
on st.Id = i.StatisticId
where st.Mind > (select avg(Mind) from [Statistics]) AND 
		st.Luck > (select avg(Luck) from [Statistics]) AND 
		st.Speed > (select avg(Speed) from [Statistics])
order by i.Name


-- Task 11
select i.Name as [Item],
		i.Price as [Price],
		i.MinLevel as [MinLevel],
		gt.Name as [Forbidden Game Type]
from Items i
left join GameTypeForbiddenItems gtfi
on gtfi.ItemId = i.Id
left join GameTypes gt
on gt.Id = gtfi.GameTypeId
order by [Forbidden Game Type] DESC, [Item] ASC


-- Task 12
insert into UserGameItems (ItemId, UserGameId)
values((select Id from Items where Name = 'Blackguard'),
		(select Id from UsersGames where GameId = 221 AND UserId = 5)),

		((select Id from Items where Name = 'Bottomless Potion of Amplification'),
		(select Id from UsersGames where GameId = 221 AND UserId = 5)),

		((select Id from Items where Name = 'Eye of Etlich (Diablo III)'),
		(select Id from UsersGames where GameId = 221 AND UserId = 5)),

		((select Id from Items where Name = 'Gem of Efficacious Toxin'),
		(select Id from UsersGames where GameId = 221 AND UserId = 5)),

		((select Id from Items where Name = 'Golden Gorget of Leoric'),
		(select Id from UsersGames where GameId = 221 AND UserId = 5)),

		((select Id from Items where Name = 'Hellfire Amulet'),
		(select Id from UsersGames where GameId = 221 AND UserId = 5))

update UsersGames 
set Cash = Cash + (select i.Price from Items i where i.Name = 'Hellfire Amulet')
where Id = (select Id from UsersGames where GameId = 221 AND UserId = 5)
	
select u.Username, g.Name, ug.Cash, i.Name as [Item Name]
from UsersGames ug
join Users u
on ug.UserId = u.Id
join Games g
on ug.GameId = g.Id
join UserGameItems ugi
on ugi.UserGameId = ug.Id
join Items i
on ugi.ItemId = i.Id
where g.Name = 'Edinburgh'
order by [Item Name]


-- Task 13


-- Task 14


-- Task 15


-- Task 16


*/

