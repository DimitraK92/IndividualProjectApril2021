USE [PrivateSchool]
GO

INSERT INTO [dbo].[StudentPerCourse]
           ([StudentID],[CourseID])
     VALUES
           (1,1), (1,2),(1,3),(1,4), 
		   (2,1),(2,2),(2,3),(2,4),
		   (3,1),(3,3),(3,2),
		   (4,1),(4,3),(4,4),
		   (5,1),(5,3),
		   (6,1),(6,3)

GO

