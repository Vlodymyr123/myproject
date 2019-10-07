using System;

namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Обчислити суму 8-варіант
            Console.WriteLine("Please input index:");

            Console.Write("Input nn= ");
            int nn = 0;
            while (!int.TryParse(Console.ReadLine(), out nn))
            {
                Console.Write("Enter a number: ");
            }
            
            Console.Write("Input nk= ");
            int nk = 0;
            while (!int.TryParse(Console.ReadLine(), out nk))
            {
                Console.Write("Enter a number: ");
            }

            double sum = 0;

            if (nn >= 0 && nk >= nn)
            {
                for (int k = nn; k < nk; k++)
                {
                    double a = (k * k - 3) / (k * k - Math.Pow(-1, k) * k + 3);
                    sum += a;
                }

                Console.WriteLine("Sum of this numeric series: " + sum);
            }
            else
                Console.WriteLine("The numbers do not satisfy the condition");

            Console.ReadKey();
        }
    }
}
