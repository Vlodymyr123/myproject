using System;

namespace Laba7_task7
{
    class Program
    {
        static public string[] Change(string[] arr)
        {
            string[] revArr = new string[10];
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                revArr[arr.Length - 1 - i] = arr[i];
            }
            return revArr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Enter data manually(Enter each item)");
            Console.WriteLine("2 - Flip a pre-written array(0 to 9)");
            Console.WriteLine("3 - Exit");
            Console.Write("Choose a way:");
            int way = Convert.ToInt32(Console.ReadLine());
            switch (way)
            {
                case 1:
                    {
                        string[] arr = new string[5];
                        Console.WriteLine("Input anything(you can input 5 words):");
                        for (int i = 0; i < arr.Length; i++)
                        {
                            arr[i] = Console.ReadLine();
                        }

                        arr = Change(arr);
                        for (int i = 0; i < arr.Length; i++)
                        {
                            Console.Write(arr[i] + " ");
                        }
                        break;
                    }
                case 2:
                    {
                        string[] text = new string[10];
                        for (int i = 0; i < 10; i++)
                        {
                            text[i] = $"{i}";
                        }

                        text = Change(text);

                        for (int i = 0; i < text.Length; i++)
                        {
                            Console.Write(text[i] + " ");
                        }
                        break;
                    }
                case 3:
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
