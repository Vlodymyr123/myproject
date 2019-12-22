using System;
using System.Collections.Generic;

namespace Laba11
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1
            Auto Nissan = new Auto();

            ServiceStation service_station = new ServiceStation();

            service_station.CompleteAllProcess(Nissan);
            service_station.PrintInfo(Nissan);
            Console.WriteLine();

            Auto Ford = new Auto();

            service_station.OilAndWheels(Ford);
            service_station.PrintInfo(Ford);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //task2
            List<Student> Group = new List<Student>();

            Group.Add(new Student("Yurii", "Kukharenko", 18));
            Group.Add(new Student("Vova", "Kovalenko", 15));
            Group.Add(new Student("Andrew", "Panibratov", 25));
            Group.Add(new Student("Artem", "Matviychuk", 16));
            Group.Add(new Student("Vova", "Lenio", 32));
            Group.Add(new Student("Andrew", "Le", 13));
            Group.Add(new Student("Yurii", "Troelsen", 24));
            Group.Add(new Student("Masha", "Ignatova", 28));
            Group.Add(new Student("Yarik", "Ko", 52));
            Group.Add(new Student("Dima", "Bo", 16));

            List<Student> rokers = new List<Student>();
            StudentPredicateDelegate something;

            //task2(8)
            Console.WriteLine("Adult people:");
            something = Student.AboutAge;
            rokers = Group.Find_student(something);
            rokers.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("People which have 'A' as a first symbol in name");
            something = Student.FirstSymbol_a;
            rokers = Group.Find_student(something);
            rokers.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("People which have more than 3 symbols in last name");
            something = Student.LastNameLength;
            rokers = Group.Find_student(something);
            rokers.PrintInfo();
            Console.WriteLine();
            Console.WriteLine();

            //task2(9)
            Console.WriteLine("Adults:");
            something = man => man.Age >= 18 ? true : false;
            rokers = Group.Find_student(something);
            rokers.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Fist letter - 'A'");
            something = man => man.FirstName[0] == 'A' ? true : false;
            rokers = Group.Find_student(something);
            rokers.PrintInfo();
            Console.WriteLine();

            Console.WriteLine("Last name more than 3");
            something = man => man.LastName.Length > 3 ? true : false;
            rokers = Group.Find_student(something);
            rokers.PrintInfo();
            Console.WriteLine();
            Console.WriteLine();

            //task2(10)
            Console.WriteLine("Punks 20 - 25 years");
            something = man => man.Age > 20 && man.Age < 25 ? true : false;
            rokers = Group.Find_student(something);
            rokers.PrintInfo();
            Console.WriteLine();

            //task2(11)
            Console.WriteLine("Only Andrew");
            something = man => man.FirstName == "Andrew" ? true : false;
            rokers = Group.Find_student(something);
            rokers.PrintInfo();
            Console.WriteLine();

            //task2(12)
            Console.WriteLine("Only Troelsen");
            something = man => man.LastName == "Troelsen" ? true : false;
            rokers = Group.Find_student(something);
            rokers.PrintInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
