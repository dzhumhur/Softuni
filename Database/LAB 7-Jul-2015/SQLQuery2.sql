-- Lab 7-Jul-2015

-- Task 1
 select q.Title
 from Questions q
 order by q.Title ASC

 -- Task 2
 select a.Content, a.CreatedOn
 from Answers a
 where a.CreatedOn between '15.Jun.2012 00:00:00' AND '21.Mar.2013 23:59:59'
 order by a.CreatedOn

 -- Task 3
 select u.Username, u.LastName, 
		iif(u.PhoneNumber is null, '0', '1') as [Has Phone]
 from Users u
 order by u.LastName ASC, u.Id ASC

 -- Task 4
 select q.Title as [Question Title], u.Username as [Author]
 from Questions q
 join Users u
 on u.Id = q.UserId
 order by q.Title ASC

 -- Task 5
 select top 50 a.Content as [Answer Content],
		 a.CreatedOn ,
		 u.Username as [Answer Author],
		 q.Title as [Question Title],
		 c.Name as [Category Name]
 from Answers a
 left join Questions q
 on a.QuestionId = q.Id
 left join Categories c
 on c.Id = q.CategoryId
 left join Users u
 on a.UserId = u.Id
 order by [Category Name] ASC, [Answer Author] ASC , [CreatedOn] 

 -- Task 6
 select cat.Name as [Category], q.Title as [Question], q.CreatedOn
 from Categories cat
 left join Questions q
 on q.CategoryId = cat.Id
 order by [Category], [Question]

 -- Task 7
 select u.Id, u.Username as [Username], u.FirstName as [FirstName], u.PhoneNumber,
		u.RegistrationDate, u.Email
 from Users u
 left join Questions q
 on q.UserId = u.Id
 where u.PhoneNumber is null AND q.UserId is null
 order by u.RegistrationDate

 -- Task 8
 select min(CreatedOn) as [MinDate], max(CreatedOn) as [MaxDate]
 from Answers a
 where year(a.CreatedOn) = '2012' OR year(a.CreatedOn) = '2014'

 -- Task 9
 select top 10 a.Content as [Answer], a.CreatedOn as [CreatedOn], u.Username as [Username]
 from Answers a
 join Users u
 on a.UserId = u.Id
 order by a.CreatedOn DESC

 -- Task 10
 select a.Content as [Answer Content],
		q.Title as [Question],
		c.Name as [Category]
 from Answers a
 join Questions q
 on q.Id = a.QuestionId
 join Categories c
 on q.CategoryId = c.Id
 where 
	(month(a.CreatedOn) = (select MONTH(MIN(CreatedOn)) from Answers) OR 
	month(a.CreatedOn) = (select MONTH(MAX(CreatedOn)) from Answers)) AND
	year(a.CreatedOn) = (select YEAR(MAX(CreatedOn)) from Answers) AND
	IsHidden = '1'
order by c.Name

 -- Task 11
 select c.Name as [Category] , count(a.Id) as [Answers Count]
 from Categories c
 left join Questions q
 on q.CategoryId = c.Id
 left join Answers a
 on a.QuestionId = q.Id
 group by c.Name
 order by [Answers Count] DESC

 -- Task 12
 select c.Name as [Category],
		u.Username as [Username],
		u.PhoneNumber as [PhoneNumber],
		count(a.Id) as [Answers Count]
 from Categories c
 right join Questions q
 on q.CategoryId = c.Id
 right join Answers a
 on a.QuestionId = q.Id
 right join Users u
 on u.Id = a.UserId
 group by c.Name, u.Username, u.PhoneNumber
 having count(a.Id) >= 0 AND [PhoneNumber] is not null
 order by [Answers Count] DESC, [Username]