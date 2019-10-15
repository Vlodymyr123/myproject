using System;

namespace task1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Task 1
            Console.Write("Input number: ");
            int n = 0;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Enter a number: ");
            }
            Console.Write(n % 10);
            while ((n /= 10) != 0)
                Console.Write(n % 10);
            Console.WriteLine();

            // Task 2
            Console.Write("Input string: ");
            string text = Console.ReadLine();

            for (int i = text.Length - 1; i >= 0; i--)
                Console.Write(text[i]);
            Console.WriteLine();

            // Task 3
            Console.WriteLine("Input double: ");
            double num = 0;
            while (!double.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Input double: ");
            }

            string str3 = num.ToString();

            string[] splitedStr = str3.Split(',');

            for (int j = splitedStr[0].Length - 1; j >= 0; j--)
            {
                Console.Write(splitedStr[0][j]);
            }
            Console.Write(",");
            for (int j = splitedStr[1].Length - 1; j >= 0; j--)
            {
                Console.Write(splitedStr[1][j]);
            }
            Console.WriteLine();

            // Task 4
            Console.WriteLine("Input string with magic symbol: ");
            string words = Console.ReadLine();

            string[] changeStr = words.Split(',');

            for (int j = changeStr[0].Length - 1; j >= 0; j--)
            {
                Console.Write(changeStr[0][j]);
            }
            Console.Write(",");
            for (int j = changeStr[1].Length - 1; j >= 0; j--)
            {
                Console.Write(changeStr[1][j]);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}