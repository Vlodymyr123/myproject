using System;

namespace Laba7_task5
{
    class Program
    {
        static void Change(int n)
        {
            Console.Write(n % 10);
            while ((n /= 10) != 0)
                Console.Write(n % 10);
            Console.WriteLine();
        }

        static void Change(string text)
        {
            for (int i = text.Length - 1; i >= 0; i--)
                Console.Write(text[i]);
            Console.WriteLine();
        }

        static void Change(double num)
        {
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
        }

        static void Change(string words, char symbol)
        {
            string[] changeStr = words.Split(symbol);

            for (int j = changeStr[0].Length - 1; j >= 0; j--)
            {
                Console.Write(changeStr[0][j]);
            }
            Console.Write(symbol);
            for (int j = changeStr[1].Length - 1; j >= 0; j--)
            {
                Console.Write(changeStr[1][j]);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1. Int value reverse!");
            Console.WriteLine("2. String value reverse!");
            Console.WriteLine("3. Double value reverse!");
            Console.WriteLine("4. String with magic symbol reverse!");
            Console.Write("Select option that you want to use: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Enter a number: ");
                    int n = 0;
                    while (!int.TryParse(Console.ReadLine(), out n))
                    {
                        Console.Write("Enter a number: ");
                    }
                    Change(n);
                    break;
                case 2:
                    Console.Write("Input string: ");
                    string text = Console.ReadLine();
                    Change(text);
                    break;
                case 3:
                    Console.WriteLine("Input double: ");
                    double num = 0;
                    while (!double.TryParse(Console.ReadLine(), out num))
                    {
                        Console.Write("Input double: ");
                    }
                    Change(num);
                    break;
                case 4:
                    Console.Write("Input string with magic symbol: ");
                    string words = Console.ReadLine();

                    Console.Write("Please, input magic symbol: ");
                    char symbol = Convert.ToChar(Console.ReadLine());
                    
                    Change(words, symbol);
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
