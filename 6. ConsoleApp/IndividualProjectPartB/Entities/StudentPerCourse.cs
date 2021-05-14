using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartB.Entities
{
    public class StudentPerCourse
    {
        public const string INSERT_SQL = @"
            INSERT INTO StudentPerCourse (CourseID, StudentID) 
            VALUES (@courseID, @studentID)";
        public static void Create(SqlCommand command)
        {
            Console.Clear();
            Console.WriteLine("");
            //Show courses
            DbQueries.PrintData(3);
            Console.WriteLine("");
            //Show students
            DbQueries.PrintData(1);
            Console.WriteLine("\r\nnPlease, match students to courses by entering the course's ID and the student's ID.");
            command.Parameters.Add(Helpers.GetIntParamFromKeyboard("courseID"));
            command.Parameters.Add(Helpers.GetIntParamFromKeyboard("studentID"));
        }
    }
}
