USE [PrivateSchool]
GO

INSERT INTO [dbo].[AssignmentPerStudent]
           ([StudentID]
           ,[AssignmentID])
     VALUES
           (1,1), (1,2), (1,3), (1,4), (1,5), (1,6), (1,7), (1,8),
		   (2,1), (2,2), (2,3), (2,4), (2,5), (2,6), (2,7),
		   (3,1), (3,2), (3,3), (3,4), (3,5),
		   (4,1), (4,2), (4,5), (4,6), (4,7),
		   (5,1), (5,2), (5,5), (5,6),
		   (6,1), (6,5)
GO

