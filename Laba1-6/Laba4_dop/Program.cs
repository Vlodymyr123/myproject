using System;

namespace Laba4_dop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Даний масив ненульових цілих чисел розміру N. Перевірити, чи чергуються в ньому 1)парні та непарні і 2) додатні і від ємні числа. Якщо чергуються, 
            // то вивести 0, якщо ні, то вивести номер першого елементу, що порушує закономірність. 
            Console.Write("Input size of array: ");
            uint N = 0;
            while (!uint.TryParse(Console.ReadLine(), out N))
            {
                Console.Write("Enter a positive number: ");
            }

            int[] array = new int[N];
            Random ran = new Random();

            for (int i = 0; i < N; i++)
            {
                array[i] = ran.Next(-100, 100);
                Console.Write("{0}\t", array[i]);
            }
            Console.WriteLine();

            int way;
            Console.Write("Input the way: ");
            way = Convert.ToInt32(Console.ReadLine());

            switch (way)
            {
                case 1:
                    for (int i = 0; i < N; i++)
                    {
                        if (array[i] > 0)
                            array[i + 1] = 0;
                    }

                    for (int i = 0; i < N; i++)
                    {
                        Console.Write("{0}\t", array[i]);
                    }

                    Console.WriteLine();
                    break;
                case 2:
                    for (int i = 1; i < N; i++)
                    {
                        if (array[i] < 0)
                            array[i - 1] = 0;
                    }

                    for (int i = 0; i < N; i++)
                    {
                        Console.Write("{0}\t", array[i]);
                    }

                    Console.WriteLine();
                    break;
            }

            Console.ReadKey();
        }
    }
}
