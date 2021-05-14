using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartB.Entities
{
    public class TrainerPerCourse
    {
        public const string INSERT_SQL = @"
            INSERT INTO TrainerPerCourse (CourseID, TrainerID) 
            VALUES (@courseID, @trainerID)";
        public static void Create(SqlCommand command)
        {
            Console.Clear();
            Console.WriteLine("");
            //Show courses
            DbQueries.PrintData(3);
            Console.WriteLine("");
            //Show trainers
            DbQueries.PrintData(2);
            Console.WriteLine("\r\nPlease, match trainers to courses by entering the course's ID and the trainer's ID.");
            command.Parameters.Add(Helpers.GetIntParamFromKeyboard("courseID"));
            command.Parameters.Add(Helpers.GetIntParamFromKeyboard("trainerID"));
        }
    }
}
