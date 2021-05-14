using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartB.Entities
{
    public class Trainer
    {
        public const string INSERT_SQL = @"
            INSERT INTO Trainers (FirstName, LastName, Subject) 
            VALUES (@firstName, @lastName, @subject)";
        public static void Create(SqlCommand command)
        {
            Console.Clear();
            Console.WriteLine("\nPlease enter the info of the trainer you want to add to the table.");
            //first name
            command.Parameters.Add(Helpers.GetStringParamFromKeyboard("firstName"));
            //last name
            command.Parameters.Add(Helpers.GetStringParamFromKeyboard("lastName"));
            //subject
            command.Parameters.Add(Helpers.GetStringParamFromKeyboard("subject"));
        }

        public const string SELECT_TRAINERS = @"
            SELECT Trainers.ID AS [ID], Trainers.FirstName AS [FirstName], 
                   Trainers.LastName AS [LastName], Trainers.Subject AS [Subject] 
            FROM Trainers";
        public static void PrintTrainers(SqlDataReader reader)
        {
            Console.WriteLine("These are all trainers:");
            Console.WriteLine("");
            while (reader.Read())
            {
                Console.WriteLine("\tTrainer id: {0}, \tFirst name: {1}, \tLast name: {2}, \tSubject: {3}",
                    reader["ID"], reader["FirstName"], reader["LastName"], reader["Subject"]);
            }
        }

        public const string SELECT_TRAINERS_WITH_COURSES = @"
            SELECT Trainers.FirstName AS [Trainer First Name], 
            Trainers.LastName AS [Trainer Last Name], 
            Courses.Title AS [Course Title] 
            FROM Trainers 
            INNER JOIN TrainerPerCourse ON Trainers.ID = TrainerPerCourse.TrainerID 
            INNER JOIN Courses ON Courses.ID = TrainerPerCourse.CourseID";
        public static void PrintTrainersWithCourses(SqlDataReader reader)
        {
            Console.WriteLine("These are all trainers per course:");
            Console.WriteLine("");
            while (reader.Read())
            {
                Console.WriteLine("\tFirst name: {0}, \tLast name: {1}, \tCourse title: {2}",
                    reader["Trainer First Name"], reader["Trainer Last Name"], reader["Course Title"]);
            }
        }

    }
}
