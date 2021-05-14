using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartB.Entities
{
    public class Course
    {
        public const string INSERT_SQL = @"
            INSERT INTO Courses (Title, Stream, Type, StartDate, EndDate) 
            VALUES (@title, @stream, @type, @startDate, @endDate)";
        public static void Create(SqlCommand command)
        {
            Console.Clear();
            Console.WriteLine("\nPlease enter the info of the course you want to add to the table.");
            //title
            command.Parameters.Add(Helpers.GetStringParamFromKeyboard("title"));
            //stream
            command.Parameters.Add(Helpers.GetStringParamFromKeyboard("stream"));
            //type
            command.Parameters.Add(Helpers.GetStringParamFromKeyboard("type"));
            //start date
            command.Parameters.Add(Helpers.GetDateTimeParamFromKeyboard("startDate"));
            //end date
            command.Parameters.Add(Helpers.GetDateTimeParamFromKeyboard("endDate"));
        }

        public const string SELECT_COURSES = @"
            SELECT Courses.ID AS [ID], Courses.Title AS [Title], Courses.Stream AS [Stream], 
                   Courses.Type AS [Type], Courses.StartDate AS [StartDate], Courses.EndDate AS [EndDate] 
            FROM Courses";
        public static void PrintCourses(SqlDataReader reader)
        {
            Console.WriteLine("These are all courses:");
            Console.WriteLine("");
            while (reader.Read())
            {
                Console.WriteLine("\tCourse id: {0}, \tTitle: {1}, \tStream: {2}, \tType: {3}, \tStart date: {4}, \tEnd date: {5}", 
                    reader["ID"], reader["Title"], reader["Stream"], reader["Type"], reader["StartDate"], reader["EndDate"]);
            }
        }
    }
}
