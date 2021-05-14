using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using IndividualProjectPartB.Entities;
using System.Configuration;

namespace IndividualProjectPartB
{
    public static class DbQueries
    {
        public static Dictionary<int, string> queries = new Dictionary<int, string> {
            { 1, Student.SELECT_STUDENTS },
            { 2, Trainer.SELECT_TRAINERS },
            { 3, Course.SELECT_COURSES },
            { 4, Assignment.SELECT_ASSIGNMENTS },
            { 5, Student.SELECT_STUDENTS_WITH_COURSES },
            { 6, Trainer.SELECT_TRAINERS_WITH_COURSES},
            { 7, Assignment.SELECT_ASSIGNMENTS_WITH_COURSES },
            { 8, Assignment.SELECT_ASSIGNMENTS_WITH_COURSES_AND_STUDENTS },
            { 9, Student.SELECT_STUDENTS_WITH_MORE_THAN_ONE_COURSES },
        };

        //EXECUTE QUERIES
        public static void PrintData(int choice)
        {
            if (queries.ContainsKey(choice))
            {
                var connectionString = ConfigurationManager.ConnectionStrings["PrivateSchoolConnectionString"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //Match user's choice with query
                    SqlCommand command = new SqlCommand(queries[choice], connection);
                    SqlDataReader reader = null;
                    try
                    {
                        connection.Open();
                        reader = command.ExecuteReader();
                        switch (choice)
                        {
                            case 1:
                                Student.PrintStudents(reader);
                                break;
                            case 2:
                                Trainer.PrintTrainers(reader);
                                break;
                            case 3:
                                Course.PrintCourses(reader);
                                break;
                            case 4:
                                Assignment.PrintAssignments(reader);
                                break;
                            case 5:
                                Student.PrintStudentsWithCourses(reader);
                                break;
                            case 6:
                                Trainer.PrintTrainersWithCourses(reader);
                                break;
                            case 7:
                                Assignment.PrintAssignmentsWithCourses(reader);
                                break;
                            case 8:
                                Assignment.PrintAssignmentsWithCoursesAndStudents(reader);
                                break;
                            case 9:
                                Student.PrintStudentsWithMoreThanOneCourses(reader);
                                break;
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        if (reader != null)
                            reader.Close();
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}