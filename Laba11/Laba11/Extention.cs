using System;
using System.Collections.Generic;

namespace Laba11
{
    static class Extention
    {
        public static List<Student> Find_student(this List<Student> list, StudentPredicateDelegate something)
        {
            List<Student> Listik = new List<Student>();
            foreach (Student el in list)
            {
                if (something.Invoke(el))
                    Listik.Add(el);
            }
            return Listik;
        }

        public static void PrintInfo(this List<Student> list)
        {
            foreach (Student el in list)
            {
                Console.WriteLine("First Name - " + el.FirstName);
                Console.WriteLine("Last Name - " + el.LastName);
                Console.WriteLine("Age - " + el.Age);
            }
        }
    }
}
