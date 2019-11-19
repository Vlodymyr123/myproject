using System;

namespace Labka10
{
    public static class ExtensionsMethods
    {
        //task-1
        public static void ForInt(this int n)
        {
            Console.Write(n % 10);
            while ((n /= 10) != 0)
                Console.Write(n % 10);
            Console.WriteLine();
        }

        public static void ForString(this string text)
        {
            for (int i = text.Length - 1; i >= 0; i--)
                Console.Write(text[i]);
            Console.WriteLine();
        }

        public static void ForDouble(this double num)
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

        public static void ForIntArray(this int[] array)
        {
            for(int i = array.Length - 1; i >= 0; i--)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }

        //task-2
        public static void Max_Min_Change(this int[] massive)
        {
            int max = 0, min = 0;

            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] > max)
                    max = massive[i];
                else if (massive[i] < min)
                    min = massive[i];
            }

            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] == max)
                    massive[i] = min;
                else if (massive[i] == min)
                    massive[i] = max;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //task-1
            int n = 123;
            n.ForInt();
            Console.WriteLine();

            string text = "Yura";
            text.ForString();
            Console.WriteLine();

            double num = 123.456;
            num.ForDouble();
            Console.WriteLine();

            int[] array = new int[] { 1, 3, 5, 7, 2, };
            array.ForIntArray();
            Console.WriteLine();

            //task-2
            int[] massive = new int[] { 1, 13, -5, 7, -23, };

            for (int i = 0; i < massive.Length; i++)
            {
                Console.Write(massive[i] + " ");
            }
            Console.WriteLine();

            massive.Max_Min_Change();

            for (int i = 0; i < massive.Length; i++)
            {
                Console.Write(massive[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
