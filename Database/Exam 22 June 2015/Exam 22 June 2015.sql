-- Task 1


-- Task 2


-- Task 3
select CountryName, CountryCode,
	(case when CurrencyCode = 'EUR'
	then 'Inside'
	else 'Outside'
	end) as [Eurozone]
from Countries
order by CountryName ASC


-- Task 4
select TeamName as [Team Name], CountryCode as [Country Code]
from Teams
where TeamName like '%[0-9]%'

-- Task 5
select c1.CountryName as [Home Team],
		c2.CountryName as [Away Team],
		im.MatchDate as [Match Date]
from InternationalMatches im
join Countries c2
on im.AwayCountryCode = c2.CountryCode
join Countries c1
on im.HomeCountryCode = c1.CountryCode
order by im.MatchDate 


-- Task 6
select t.TeamName as [Team Name], l.LeagueName as [League],
	 (select iif (l.CountryCode is null, 'International', c.CountryName)) as [League Country]
from Teams t
join Leagues_Teams lt
on t.Id = lt.TeamId
join Leagues l
on lt.LeagueId = l.Id
left join Countries c
on l.CountryCode = c.CountryCode
order by  t.TeamName, LeagueName

-- Task 7
select t.TeamName as [Team], count(t.Id) as [Matches Count]
from Teams t
join TeamMatches tm
on tm.HomeTeamId = t.Id or tm.AwayTeamId = t.id
group by t.TeamName
having count(t.Id) > 1
order by t.TeamName

-- Task 8
select l.LeagueName as [League Name], 
	count(distinct lt.TeamId) as [Teams],
	count(distinct tm.Id) as [Matches],
	isnull(avg(tm.HomeGoals + tm.AwayGoals), 0) as [Average Goals]
from Leagues l
left join Leagues_Teams lt on lt.LeagueId = l.Id
left join TeamMatches tm on tm.LeagueId = l.Id
group by l.LeagueName
order by [Teams] DESC, [Matches] desc

-- Task 9
SELECT
  t.TeamName,
  ISNULL(SUM(tm1.HomeGoals), 0) + ISNULL(SUM(tm2.AwayGoals), 0) AS [Total Goals]
FROM Teams t
LEFT JOIN TeamMatches tm1 on tm1.HomeTeamId = t.Id
LEFT JOIN TeamMatches tm2 on tm2.AwayTeamId = t.Id
GROUP BY t.TeamName
ORDER BY [Total Goals] DESC, TeamName

-- Task 10
select tm1.MatchDate as [First Date], 
		tm2.MatchDate as [Second Date]
from TeamMatches tm1, TeamMatches tm2
where (day(tm1.MatchDate) = day(tm2.MatchDate) AND 
		month(tm1.MatchDate) = month(tm2.MatchDate) AND
		year(tm1.MatchDate) = year(tm2.MatchDate)) AND
		tm2.MatchDate > tm1.MatchDate
order by [First Date] DESC, [Second Date] DESC

-- Task 11
select lower(SUBSTRING(tm1.TeamName,0,len(tm1.TeamName)) + REVERSE(tm2.TeamName)) as [Mix]
from Teams tm1, Teams tm2
where right(tm1.TeamName,1) = right(tm2.TeamName,1)
order by [Mix] ASC

-- Task 12
select  c.CountryName as [Country Name],
		count(im.Id) as [International Matches],
		count(tm.Id) as [Team Matches]
from Countries c
left join Leagues l
on l.CountryCode = c.CountryCode
left join TeamMatches tm
on l.Id = tm.LeagueId
left join InternationalMatches im
on im.AwayCountryCode = c.CountryCode and im.HomeCountryCode = c.CountryCode
group by c.CountryName
having count(distinct im.Id) > 0 OR count(distinct tm.Id) > 0
order by [International Matches] DESC, [Team Matches] DESC, [Country Name]
