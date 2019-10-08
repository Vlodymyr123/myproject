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
            List<string> word = new List<string>();

            word.Add("exit");

            Console.WriteLine("Now we have to fill out our list. To stop filling, enter: 'exit' !");
            
            for (int i = 0; ; i++)
            {
                Console.Write("Input word: ");
                str.Add(Console.ReadLine());
                if (str[i] == word[0])
                {
                    str.Remove("exit");
                    break;
                }
            }

            Console.WriteLine("Now let's calculate how many identical numbers we have: ");

            int[] strLen = new int[str.Count];
            
            int j = 0;
            for(int i = 0; i < str.Count; i++)
            {
                char[] arr = str[i].ToCharArray();
                for (; j < str.Count;)
                {
                    strLen[j] = arr.Length;
                    break;
                }
                j++;
            }

            Console.WriteLine("Our list: ");
            foreach (string l in str)
            {
                Console.Write(l + "\t");
            }
            Console.WriteLine();

            Console.WriteLine("Length of string in this list: ");
            for (int i = 0; i < strLen.Length; i++)
            {
                Console.Write(strLen[i] + "\t");
            }
            Console.WriteLine();

            int count = 0;

            Array.Sort(strLen);
            
            for(int i = 0; i < strLen.Length - 1; i++)
            {
                if (strLen[i] == strLen[i + 1])
                    count++;
            }

            if (count == 1)
            {
                Console.WriteLine("We have " + count + " identical pair of string");
            }
            else
            {
                Console.WriteLine("We get that " + count  + " string have the same length.");
            }

            Console.ReadKey();
        }
    }
}
