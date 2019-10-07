using System;
using System.Collections.Generic;

namespace Laba6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створити ліст стрінгових значень, дозволити можливість заповнення з клавіатури. Вивести кількість елементів рівної двожини. 
            List<string> str = new List<string>();

            Console.Write("Input number of elements: ");
            uint N = 0;
            while (!uint.TryParse(Console.ReadLine(), out N))
            {
                Console.Write("Enter a positive number: ");
            }

            int[] strLen = new int[N];
            
            for(int i = 0; i < N; i++)
            {
                Console.Write("Input word: ");
                str.Add(Console.ReadLine());
                foreach(string k in str)
                {
                    char[] arr = k.ToCharArray();
                    for(int j = 0; j < N; j++)
                    {
                        strLen[i] = arr.Length;
                    }
                }
            }
            
            foreach (string l in str)
            {
                Console.Write(l + "\t");
            }
            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(strLen[i] + "\t");
            }

            int count = 0;
            
            for(int i = 1; i < N; i++)
            {
                if (strLen[i] == strLen[i - 1])
                    count++;
            }

            if (count == 1)
            {
                Console.WriteLine("We have " + count + " identical pair of numbers");
            }
            else
            {
                Console.WriteLine("We have " + (count + 1) + " same numbers!");
            }

            Console.ReadKey();
        }
    }
}
