using System;

namespace Laba3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Перевірити істинність вислову: "Серед трьох даних цілих чисел є хоч би одна пара взаємно протилежних". 
            int a = 0, b = 0, c = 0;
            Console.WriteLine("You need to input 3 numbers!");

            Console.Write("Input a: ");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.Write("Enter a number: ");
            }

            Console.Write("Input b: ");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.Write("Enter a number: ");
            }

            Console.Write("Input c: ");
            while (!int.TryParse(Console.ReadLine(), out c))
            {
                Console.Write("Enter a number: ");
            }

            Console.WriteLine("a = " + a + " b = " + b + " c = " + c);

            Console.WriteLine("Now let's see if there are two opposite numbers!");

            if (a == -b)
            {
                Console.WriteLine("Yes we have opposite numbers!");
                if (a == -b)
                    Console.WriteLine("a the opposite of b");
            }
            else if (b == -c)
            {
                Console.WriteLine("Yes we have opposite numbers!");
                if (b == -c)
                    Console.WriteLine("b the opposite of c");
            }
            else if (a == -c)
            {
                Console.WriteLine("Yes we have opposite numbers!");
                if (a == -c)
                    Console.WriteLine("a the opposite of c");
            }
            else
                Console.WriteLine("We don`t have opposite numbers!!");

            Console.ReadKey();
        }
    }
}
