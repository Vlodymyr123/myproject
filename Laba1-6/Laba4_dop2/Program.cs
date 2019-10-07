using System;

namespace Laba4_dop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Впорядкувати масив розміру N по 1) зростанню; 2) спаданню . 
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
            Console.WriteLine("Array Ascending: ");
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = 0; j < N - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write("{0}\t", array[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Array Descending:");
            Array.Sort(array);
            Array.Reverse(array);

            for (int i = 0; i < N; i++)
            {
                Console.Write("{0}\t", array[i]);
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
