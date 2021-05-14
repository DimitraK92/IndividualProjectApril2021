using IndividualProjectPartB.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace IndividualProjectPartB
{
    public static class DbInserts
    {
        public static Dictionary<int, string> commands = new Dictionary<int, string> {
            { 10, Student.INSERT_SQL },
            { 11, Trainer.INSERT_SQL },
            { 12, Course.INSERT_SQL },
            { 13, Assignment.INSERT_SQL },
            { 14, StudentPerCourse.INSERT_SQL },
            { 15, TrainerPerCourse.INSERT_SQL },
            { 16, AssignmentPerStudent.INSERT_SQL },
        };

        //EXECUTE COMMANDS
        public static void InsertData(int choice)
        {
            if (commands.ContainsKey(choice))
            {
                var connectionString = ConfigurationManager.ConnectionStrings["PrivateSchoolConnectionString"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //Match user's choice with command
                    using (SqlCommand command = new SqlCommand(commands[choice], connection))
                    {
                        bool addMore = false;
                        do
                        {
                            switch (choice)
                            {
                                case 10:
                                    Student.Create(command);
                                    break;
                                case 11:
                                    Trainer.Create(command);
                                    break;
                                case 12:
                                    Course.Create(command);
                                    break;
                                case 13:
                                    Assignment.Create(command);
                                    break;
                                case 14:
                                    StudentPerCourse.Create(command);
                                    break;
                                case 15:
                                    TrainerPerCourse.Create(command);
                                    break;
                                case 16:
                                    AssignmentPerStudent.Create(command);
                                    break;
                            }
                            try
                            {
                                connection.Open();
                                command.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            finally
                            {
                                connection.Close();
                            }
                            Console.WriteLine("\n\nDo you want to add more? Enter Y for yes.\nOtherwise, press any other key to return to the menu.");
                            var answer = Console.ReadLine();
                            if (answer.ToUpper() == "Y") { addMore = true; }
                            else { addMore = false; }
                        }
                        while (addMore);
                    }
                }

            }
        }

    }
}