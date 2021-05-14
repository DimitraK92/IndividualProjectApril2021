USE [PrivateSchool]
GO

INSERT INTO [dbo].[Courses]
           ([Title],
			[Stream],
			[Type],
			[StartDate],
			[EndDate])
     VALUES
           ('Algebra','Maths', 'Mandatory', '2020-10-01', '2021-02-26'),
		   ('Social Psychology','Psychology', 'Optional', '2020-10-01', '2021-02-26'),
		   ('Cognitive Psychology','Psychology', 'Mandatory', '2021-03-01', '2021-07-30'),
		   ('Geometry','Maths', 'Optional', '2021-03-01', '2021-07-30')
		  

GO


