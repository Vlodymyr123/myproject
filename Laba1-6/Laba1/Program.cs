using System;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Обчислити об'єм та площу поверхні кулі заданого радіусу
            Console.Write("Input radius of sphere: ");

            int R = 0;
            while(!int.TryParse(Console.ReadLine(), out R)){
                Console.Write("Enter a number: ");
            }

            double pi = 3.14d;
            double S = 4 * pi * Math.Pow(R, 2);

            double V = (4 / 3) * pi * Math.Pow(R, 3);

            Console.WriteLine("The capacity of sphere :" + V);
            Console.WriteLine("Square of sphere: " + S);

            Console.ReadKey();
        }
    }
}