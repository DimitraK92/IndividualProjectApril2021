using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IndividualProjectPartB
{
    class ProjectBMenu
    {
        public static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("\r\n--- SHOW OPTIONS" );
            Console.WriteLine("\r\n1. Show students");
            Console.WriteLine("\r\n2. Show trainers");
            Console.WriteLine("\r\n3. Show courses");
            Console.WriteLine("\r\n4. Show assignments");
            Console.WriteLine("\r\n5. Show students per course");
            Console.WriteLine("\r\n6. Show trainers per course");
            Console.WriteLine("\r\n7. Show assignments per course");
            Console.WriteLine("\r\n8. Show assignments per course per student");
            Console.WriteLine("\r\n9. Show students that belong to more than one courses");
            Console.WriteLine("\r\n--- INSERT OPTIONS");
            Console.WriteLine("\r\n10. Insert student");
            Console.WriteLine("\r\n11. Insert trainer");
            Console.WriteLine("\r\n12. Insert course");
            Console.WriteLine("\r\n13. Insert assignment");
            Console.WriteLine("\r\n14. Insert students per course");
            Console.WriteLine("\r\n15. Insert trainers per course");
            Console.WriteLine("\r\n16. Insert assignments per student per course");
            Console.WriteLine("\r\n--- EXIT");
            Console.WriteLine("\r\nX. Exit program");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    DbQueries.PrintData(1);
                    return true;
                case "2":
                    Console.Clear();
                    DbQueries.PrintData(2);
                    return true;
                case "3":
                    Console.Clear();
                    DbQueries.PrintData(3);
                    return true;
                case "4":
                    Console.Clear();
                    DbQueries.PrintData(4);
                    return true;
                case "5":
                    Console.Clear();
                    DbQueries.PrintData(5);
                    return true;
                case "6":
                    Console.Clear();
                    DbQueries.PrintData(6);
                    return true;
                case "7":
                    Console.Clear();
                    DbQueries.PrintData(7);
                    return true;
                case "8":
                    Console.Clear();
                    DbQueries.PrintData(8);
                    return true;
                case "9":
                    Console.Clear();
                    DbQueries.PrintData(9);
                    return true;
                case "10":
                    Console.Clear();
                    DbInserts.InsertData(10);
                    return true;
                case "11":
                    Console.Clear();
                    DbInserts.InsertData(11);
                    return true;                
                case "12":
                    Console.Clear();
                    DbInserts.InsertData(12);
                    return true; 
                case "13":
                    Console.Clear();
                    DbInserts.InsertData(13);
                    return true;  
                case "14":
                    Console.Clear();
                    DbInserts.InsertData(14);
                    return true;  
                case "15":
                    Console.Clear();
                    DbInserts.InsertData(15);
                    return true;  
                case "16":
                    Console.Clear();
                    DbInserts.InsertData(16);
                    return true;                  
                case "x":
                case "X":
                    return false;
                default:
                    return true;
            }
        }
    }    
}
