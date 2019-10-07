using System;

namespace Laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Даний масив розміру N. Переставити в зворотному порядку елементи масиву, розташовані між його мінімальним і максимальним елементами. 
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

            int min = array[0], max = array[0];

            for (int i = 0; i < N; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                else if (array[i] < min)
                {
                    min = array[i];
                }
            }

            Console.WriteLine("Max element: " + max);
            Console.WriteLine("Min element: " + min);

            for (int i = 0; i < N; i++)
            {
                if (array[i] < 0)
                    array[i] = max;
                else if (array[i] > 0)
                    array[i] = min;
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write("{0}\t", array[i]);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
