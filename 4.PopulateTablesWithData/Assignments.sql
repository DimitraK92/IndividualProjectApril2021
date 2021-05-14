USE [PrivateSchool]
GO

INSERT INTO [dbo].[Assignments]
           ([CourseID]
           ,[Title]
           ,[Description]
           ,[SubDateTime]
           ,[OralMark]
           ,[TotalMark])
     VALUES
           (1, 'Equations 1', 'Basic equations','2020-11-30',20,100),
		   (1, 'Equations 2', 'Advanced equations', '2021-02-20', 20, 100),
		   (2, 'Social Psychology 1', 'Pychology of the masses', '2020-11-15', 80, 100),
		   (2, 'Social Psychology 2', 'Mixed gender peer groups', '2021-01-15',80,100),
		   (3, 'Cognitive Psychology 1', 'Theory of behaviorism', '2021-05-20',50,100),
		   (3, 'Cognitive Psychology 2', 'Small-scale research on behaviorism', '2021-07-25', 0,100),
		   (4, 'Geometry 1', 'Basic geometry', '2021-05-10', 20, 100),
		   (4, 'Geometry 2', 'Advanced geometry', '2021-07-10', 20,100)
GO

