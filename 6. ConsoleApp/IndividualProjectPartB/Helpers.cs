using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartB
{
    public static class Helpers
    {
        public static SqlParameter GetStringParamFromKeyboard(string labelName)
        {
            Console.Write($"Please, give {labelName}: ");
            string inputStringValue = "";
            do
            {
                inputStringValue = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(inputStringValue))
                {
                    Console.Write($"Please enter a valid {labelName}:");
                }
            }
            while (string.IsNullOrWhiteSpace(inputStringValue));
            SqlParameter labelNameParam = new SqlParameter($"@{labelName}", inputStringValue);
            return labelNameParam;
        }
        public static SqlParameter GetDateTimeParamFromKeyboard(string labelName)
        {
            Console.Write($"Please, give {labelName} in this format: (year),(month),(day):");
            DateTime inputDate;
            while (!DateTime.TryParse(Console.ReadLine(), out inputDate))
            {
                Console.Write($"Please enter a valid {labelName}:");
            }
            SqlParameter labelNameParam = new SqlParameter($"@{labelName}", inputDate);
            return labelNameParam;
        }
        public static SqlParameter GetDecimalParamFromKeyboard(string labelName)
        {
            Console.Write($"Please, give {labelName} in euros:");
            decimal inputDecimal;
            while (!decimal.TryParse(Console.ReadLine(), out inputDecimal) || inputDecimal < 0)
            {
                Console.Write($"Please enter a valid {labelName}:");
            }
            SqlParameter labelNameParam = new SqlParameter($"@{labelName}", inputDecimal);
            return labelNameParam;
        }
        public static SqlParameter GetFloatParamFromKeyboard(string labelName)
        {
            Console.Write($"Please, give {labelName}:");
            float inputFloat;
            while (!float.TryParse(Console.ReadLine(), out inputFloat) || inputFloat < 0)
            {
                Console.Write($"Please enter a valid {labelName}:");
            }
            SqlParameter labelNameParam = new SqlParameter($"@{labelName}", inputFloat);
            return labelNameParam;
        }
        public static SqlParameter GetIntParamFromKeyboard(string labelName)
        {
            Console.Write($"Please, give {labelName}:");
            int inputInt;
            while (!int.TryParse(Console.ReadLine(), out inputInt) || inputInt < 0)
            {
                Console.Write($"Please enter a valid {labelName}:");
            }
            SqlParameter labelNameParam = new SqlParameter($"@{labelName}", inputInt);
            return labelNameParam;
        }
    }
}
