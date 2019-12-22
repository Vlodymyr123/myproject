using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba11
{
    delegate bool StudentPredicateDelegate(Student man);
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public Student(string first_name, string last_name, int age)
        {
            FirstName = first_name;
            LastName = last_name;
            Age = age;
        }

        public static bool AboutAge(Student man)
        {
            if (man.Age >= 18) 
                return true;
            return false;
        }

        public static bool FirstSymbol_a(Student man)
        {
            if (man.FirstName[0] == 'A')
                return true;
            return false;
        }

        public static bool LastNameLength(Student man)
        {
            if (man.LastName.Length > 3)
                return true;
            return false;
        }
    }
}
