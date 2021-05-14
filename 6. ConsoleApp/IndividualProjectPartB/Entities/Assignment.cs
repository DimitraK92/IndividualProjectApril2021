using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartB.Entities
{
    public class Assignment
    {
        public const string INSERT_SQL = @"
            INSERT INTO Assignments (CourseID, Title, Description, SubDateTime, OralMark, TotalMark) 
            VALUES (@courseID, @title, @description, @subDateTime, @oralMark, @totalMark)";
        public static void Create(SqlCommand command)
        {
            Console.Clear();
            //course
            Console.WriteLine("\r\nThese are the courses: ");
            Console.WriteLine("");
            DbQueries.PrintData(3);
            Console.WriteLine("\r\nPlease enter the ID of the course you would like to insert an assingment into.");
            Console.WriteLine("");
            command.Parameters.Add(Helpers.GetIntParamFromKeyboard("courseID"));
            Console.WriteLine("\nPlease enter the info of the assignment: ");
            //title
            command.Parameters.Add(Helpers.GetStringParamFromKeyboard("title"));
            //description
            command.Parameters.Add(Helpers.GetStringParamFromKeyboard("description"));
            //submission date
            command.Parameters.Add(Helpers.GetDateTimeParamFromKeyboard("subDateTime"));
            //oral mark
            command.Parameters.Add(Helpers.GetFloatParamFromKeyboard("oralMark"));
            //total mark
            command.Parameters.Add(Helpers.GetFloatParamFromKeyboard("totalMark"));
        }

        public const string SELECT_ASSIGNMENTS = @"
            SELECT Assignments.ID AS [ID], Assignments.Title AS [Title], 
                   Assignments.Description AS [Description], SubDateTime AS [SubDate], 
                   Assignments.OralMark AS [OralMark], Assignments.TotalMark AS [TotalMark] 
            FROM Assignments";
        public static void PrintAssignments(SqlDataReader reader)
        {
            Console.Clear();
            Console.WriteLine("These are all assignmets:");
            Console.WriteLine("");
            while (reader.Read())
            {
                Console.WriteLine("\tAssignment id: {0}, \tTitle: {1}, \tDescription: {2}, \tSubmission date: {3}, \tOral mark: {4}, \tTotal mark: {5}",
                    reader["ID"], reader["Title"], reader["Description"], reader["SubDate"], reader["OralMark"], reader["TotalMark"]);
            }
        }

        public const string SELECT_ASSIGNMENTS_WITH_COURSES = @"
            SELECT Assignments.ID AS [Assignment ID], 
                   Assignments.Title AS [Assignment Title], 
                   Courses.Title AS [Course Title] 
            FROM  Assignments 
            INNER JOIN Courses ON Courses.ID = Assignments.CourseID";
        public static void PrintAssignmentsWithCourses(SqlDataReader reader)
        {
            Console.WriteLine("These are all assignments per course:");
            Console.WriteLine("");
            while (reader.Read())
            {
                Console.WriteLine("\tAssignment id: {0}, \tAssignment title: {1}, \tCourse title: {2}",
                    reader["Assignment ID"], reader["Assignment Title"], reader["Course Title"]);
            }
        }

        public const string SELECT_ASSIGNMENTS_WITH_COURSES_AND_STUDENTS = @"
            SELECT Assignments.Title AS [Assignment Title], 
                   Assignments.Description AS [Assignment Desc], 
                   Courses.Title AS [Course Title], 
                   Students.FirstName AS [Student First Name], 
                   Students.LastName AS [Student Last Name] 
            FROM Assignments 
            INNER JOIN AssignmentPerStudent ON AssignmentPerStudent.AssignmentID = Assignments.ID 
            INNER JOIN Students ON Students.ID = AssignmentPerStudent.StudentID 
            INNER JOIN Courses ON Courses.ID = Assignments.CourseID";
        public static void PrintAssignmentsWithCoursesAndStudents(SqlDataReader reader)
        {
            Console.WriteLine("These are all assignments per course per student:");
            Console.WriteLine("");
            while (reader.Read())
            {
                Console.WriteLine("\tAssignment title: {0}, \tAssignment description: {1}, \tCourse title: {2}, \tStudent first name: {3}, \tStudent last name: {4}",
                    reader["Assignment Title"], reader["Assignment Desc"], reader["Course Title"], reader["Student First Name"], reader["Student Last Name"]);
            }
        }
    }
}
