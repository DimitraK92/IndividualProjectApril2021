using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IndividualProjectPartB
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            // show available options until user chooses to exit the program
            while (showMenu)
            {
                showMenu = ProjectBMenu.Menu();
            }
        }
    }
}
