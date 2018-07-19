using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!\n");
            Console.Write("Enter an integer:");
            var input = Console.ReadLine();
            if (int.TryParse(input, out var inputAsInt))
            {
                OutputHeaders();
                GeneratePowersTable(inputAsInt);
            }

            Console.ReadKey();
        }

        private static void GeneratePowersTable(int inputAsInt)
        {
            for (int i = 1; i <= inputAsInt; ++i)
            {
                OutputRow(i, Power(i, 2), Power(i, 3));
            }
        }

        private static void OutputHeaders()
        {
            Console.WriteLine();
            OutputRow("Number", "Squared", "Cubed");
            OutputRow("=======", "=======", "=======");
        }

        private static void OutputRow(string column1Value, string column2Value, string column3Value)
        {
            Console.WriteLine("{0,-15}{1,-15}{2,-15}", column1Value, column2Value, column3Value);
        }

        private static void OutputRow(int column1Value, int column2Value, int column3Value)
        {
            Console.WriteLine("{0,-15}{1,-15}{2,-15}", column1Value, column2Value, column3Value);
        }

        private static int Power(int number, int power)
        {
            int value = number;
            for (int i = 1; i < power; ++i)
            {
                value *= number;
            }

            return value;
        }
    }
}
