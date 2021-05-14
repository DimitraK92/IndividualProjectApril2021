using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartB.Entities
{
    public class Student
    {
        public const string INSERT_SQL = @"
            INSERT INTO Students (FirstName, LastName, DateOfBirth, TuitionFees) 
            VALUES (@firstName, @lastName, @dateOfBirth,@tuitionFees)";
        public static void Create(SqlCommand command)
        {
            Console.Clear();
            Console.WriteLine("\nPlease enter the info of the students you want to add to the table.");
            //first name                        
            command.Parameters.Add(Helpers.GetStringParamFromKeyboard("firstName"));
            //last name
            command.Parameters.Add(Helpers.GetStringParamFromKeyboard("lastName"));
            //date of birth
            command.Parameters.Add(Helpers.GetDateTimeParamFromKeyboard("dateOfBirth"));
            //tuition fees
            command.Parameters.Add(Helpers.GetDecimalParamFromKeyboard("tuitionFees"));
        }

        public const string SELECT_STUDENTS = @"
            SELECT Students.ID AS [ID], 
                   Students.FirstName AS [FirstName], 
                   Students.LastName AS [LastName], 
                   Students.DateOfBirth AS [DateOfBirth], 
                   Students.TuitionFees AS [TuitionFees]
            FROM Students";
        public static void PrintStudents(SqlDataReader reader)
        {
            Console.WriteLine("These are all students:");
            Console.WriteLine("");
            while (reader.Read())
            {
                Console.WriteLine("\tStudent id: {0}, \tFirst name: {1}, \tLast name: {2}, \tDate of birth: {3}, \tTuition fees: {4}",
                    reader["ID"], reader["FirstName"], reader["LastName"], reader["DateOfBirth"], reader["TuitionFees"]);
            }
        }

        public const string SELECT_STUDENTS_WITH_COURSES = @"
            SELECT Students.FirstName AS [Student First Name], 
                   Students.LastName AS [Student Last Name],
                   Courses.Title AS [Course Title] 
            FROM Students 
            INNER JOIN StudentPerCourse ON Students.ID = StudentPerCourse.StudentID 
            INNER JOIN Courses ON Courses.ID = StudentPerCourse.CourseID";
        public static void PrintStudentsWithCourses(SqlDataReader reader)
        {
            Console.WriteLine("These are all students per course:");
            Console.WriteLine("");
            while (reader.Read())
            {
                Console.WriteLine("\tFirst name: {0}, \tLast name: {1}, \tCourse title: {2}",
                    reader["Student First Name"], reader["Student Last Name"], reader["Course Title"]);
            }
        }

        public const string SELECT_STUDENTS_WITH_MORE_THAN_ONE_COURSES = @"
            SELECT Students.FirstName AS [Student First Name],
                   Students.LastName AS [Student Last Name], 
                   COUNT (*) AS [Number of Courses] 
            FROM Students 
            INNER JOIN StudentPerCourse ON Students.ID = StudentPerCourse.StudentID 
            GROUP BY Students.ID,Students.FirstName, Students.LastName HAVING COUNT (*) > 1";
        public static void PrintStudentsWithMoreThanOneCourses(SqlDataReader reader)
        {
            Console.WriteLine("These are all the students that belong to more than one courses:");
            Console.WriteLine("");
            while (reader.Read())
            {
                Console.WriteLine("\tFirst name: {0}, \tLast name: {1}, \tNumber of cources: {2}",
                    reader["Student First Name"], reader["Student Last Name"], reader["Number of Courses"]);
            }
        }
    }
}
