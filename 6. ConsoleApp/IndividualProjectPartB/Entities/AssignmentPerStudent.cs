using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartB.Entities
{
    public class AssignmentPerStudent
    {
        public const string INSERT_SQL = @"
            INSERT INTO AssignmentPerStudent (StudentID, AssignmentID) 
            VALUES (@studentID, @assignmentID)";
        public static void Create(SqlCommand command)
        {
            Console.Clear();
            Console.WriteLine("");
            //Show students
            DbQueries.PrintData(1);
            Console.WriteLine("");
            //Show assignments per course
            DbQueries.PrintData(7);
            Console.WriteLine("\r\nPlease, match students to assignments by entering the student's ID and the assignment's ID.");
            command.Parameters.Add(Helpers.GetIntParamFromKeyboard("studentID"));
            command.Parameters.Add(Helpers.GetIntParamFromKeyboard("assignmentID"));
        }
    }
}
