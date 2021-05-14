-- A list of all students--
SELECT * FROM Students
-- A list of all trainers--
SELECT * FROM Trainers
-- A list of all courses--
SELECT * FROM Courses
-- A list of all assignments--
SELECT * FROM Assignments

--A list of all the students per course--
SELECT Students.FirstName AS [Student First Name],
	   Students.LastName AS [Student Last Name],
	   Courses.Title AS [Course Title]
FROM Students
INNER JOIN StudentPerCourse ON Students.ID = StudentPerCourse.StudentID
INNER JOIN Courses ON Courses.ID = StudentPerCourse.CourseID

--A list of all the trainers per course--
SELECT Trainers.FirstName AS [Trainer First Name],
	   Trainers.LastName AS [Trainer Last Name],
	   Courses.Title AS [Course Title]
FROM Trainers
INNER JOIN TrainerPerCourse ON Trainers.ID = TrainerPerCourse.TrainerID
INNER JOIN Courses ON Courses.ID = TrainerPerCourse.CourseID

--A list of all the assignments per course--
SELECT Assignments.Title AS [Assignment Title],
	   Courses.Title AS [Course Title]
FROM   Assignments
INNER JOIN Courses ON Courses.ID = Assignments.CourseID

--A list of all the assignments per course per student--
SELECT Assignments.Title AS [Assignment Title],
       Assignments.Description AS [Assignment Desc],
	   Courses.Title AS [Course Title],
	   Students.FirstName AS [Student First Name],
	   Students.LastName AS [Student Last Name]
FROM   Assignments
INNER JOIN AssignmentPerStudent ON AssignmentPerStudent.AssignmentID = Assignments.ID
INNER JOIN Students ON Students.ID = AssignmentPerStudent.StudentID
INNER JOIN Courses ON Courses.ID = Assignments.CourseID

--A list of students that belong to more than one courses--
SELECT Students.FirstName AS [Student First Name],
	   Students.LastName AS [Student Last Name],
	   COUNT (*) AS [Number of Courses]
FROM Students
INNER JOIN StudentPerCourse	ON Students.ID = StudentPerCourse.StudentID
GROUP BY Students.ID,Students.FirstName, Students.LastName HAVING COUNT (*) > 1




