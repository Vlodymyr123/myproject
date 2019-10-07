using System;

namespace Laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дана квадратна матриця порядку M. Знайти суму елементів її 1) головної; 2) побічної діагоналей. 
            int n;
            Console.WriteLine("Input size of array, please!");
            do
            {
                Console.Write("Input n: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                    Console.WriteLine("Mistake! Try again:");
            } while (n < 0);
            

            int[,] array = new int[n, n];
            Random ran = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = ran.Next(-100, 100);
                    Console.Write("{0}\t", array[i,j]);
                }
                Console.WriteLine();
            }

            int sum_m = 0, sum_s = 0;
            for (int i = 0; i < n; i++)
                sum_m += array[i, i];
            
            int k, l;
            for (k = 0, l = n - 1; k < n; k++, l--)
                sum_s += array[k,l];

            Console.WriteLine("The sum of the main matrix: " + sum_m);
            Console.WriteLine("The sum of the secondary matrix: " + sum_s);


            Console.ReadKey();
        }
    }
}
