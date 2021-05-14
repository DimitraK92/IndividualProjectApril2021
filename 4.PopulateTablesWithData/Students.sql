USE [PrivateSchool]
GO

INSERT INTO [dbo].[Students]
           ([FirstName]
           ,[LastName]
           ,[DateOfBirth]
           ,[TuitionFees])
     VALUES
           ('Anastasia', 'Zografidou', '1998-04-20', 1500),
		   ('Kostis', 'Loufadoros', '1992-11-15', 1500),
		   ('Giorgos','Sensitakis','1995-05-23', 1250),
		   ('Maria','Eksafanizol','1994-03-12', 1250),
		   ('Dimitra','Tsitomeni','1992-11-30',1000),
		   ('Thodoris','Sotiras','1983-11-07',1000)
GO


