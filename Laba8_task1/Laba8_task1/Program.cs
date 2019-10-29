using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba8_task1
{
    class Program
    {
        class Garage
        {
            List<Car> listOfCars = new List<Car>();

            public void Create_new_car()
            {
                string name;
                string color;
                int speed;
                int year;

                Console.Write("Enter a name of car: ");
                name = Console.ReadLine();

                Console.Write("Enter a color of car: ");
                color = Console.ReadLine();

                Console.Write("Enter car speed: ");
                while (!int.TryParse(Console.ReadLine(), out speed) || speed <= 0)
                {
                    Console.Write("Enter a correct speed value, please: ");
                }

                Console.Write("Enter a cars year of issue: ");
                while (!int.TryParse(Console.ReadLine(), out year) || year < 1900)
                {
                    Console.Write("Enter a correct year, please: ");
                }

                Car newCar = new Car(name, color, speed, year);

                listOfCars.Add(newCar);
            }

            public void Display(string name)
            {
                foreach (Car i in listOfCars)
                {
                    if (i.Name == name)
                    {
                        Console.WriteLine("{0} - {1} - {2} - {3}", i.Name, i.Color, i.Speed, i.Year_of_issue);
                    }
                }
            }

            public void DisplayByColor(string color)
            {
                foreach (Car i in listOfCars)
                {
                    if (i.Color == color)
                    {
                        Console.WriteLine("{0} - {1} - {2} - {3}", i.Name, i.Color, i.Speed, i.Year_of_issue);
                    }
                }
            }

            public void Display(int speed)
            {
                foreach (Car i in listOfCars)
                {
                    if (i.Speed == speed)
                    {
                        Console.WriteLine("{0} - {1} - {2} - {3}", i.Name, i.Color, i.Speed, i.Year_of_issue);
                    }
                }
            }

            public void DisplayByYear(int year)
            {
                foreach (Car i in listOfCars)
                {
                    if (i.Year_of_issue == year)
                    {
                        Console.WriteLine("{0} - {1} - {2} - {3}", i.Name, i.Color, i.Speed, i.Year_of_issue);
                    }
                }
            }

            public void Show_all_cars()
            {
                foreach(Car all_cars in listOfCars)
                {
                    Console.WriteLine("{0} - {1} - {2} - {3}", all_cars.Name, all_cars.Color, all_cars.Speed, all_cars.Year_of_issue);
                }
            }
            public void Delete_car(int position)
            {
                listOfCars.RemoveAt(position);
            }
        }
        class Car
        {
            public string Name { get; }
            public string Color { get; }
            public int Speed { get; }
            public int Year_of_issue { get; }

            public Car() { }
            public Car(string name, string color, int speed, int year_of_issue)
            {
                Name = name;

                Color = color;

                Speed = speed;

                Year_of_issue = year_of_issue;
            }
        }
        
        static void Main(string[] args)
        {
            Garage myGarage = new Garage();

            Console.WriteLine("1 - add new car");
            Console.WriteLine("2 - delete car from selected position");
            Console.WriteLine("3 - show cars by one characteristic");
            Console.WriteLine("4 - show all cars");
            Console.WriteLine("5 - for exit");
            int way;

            do
            {
                Console.Write("Select way:");

                way = Convert.ToInt32(Console.ReadLine());
                switch (way)
                {
                    case 1:
                        {
                            myGarage.Create_new_car();
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Choose position that you want to delete: ");
                            int position = Convert.ToInt32(Console.ReadLine());
                            myGarage.Delete_car(position);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("1 - name");
                            Console.WriteLine("2 - color");
                            Console.WriteLine("3 - speed");
                            Console.WriteLine("4 - year of issue");
                            Console.WriteLine("5 - don`t choose");
                            Console.Write("Choose which characteristic you need:");
                            int characteristic = Convert.ToInt32(Console.ReadLine());
                            switch (characteristic)
                            {
                                case 1:
                                    {
                                        Console.Write("Input name: ");
                                        string name = Console.ReadLine();
                                        myGarage.Display(name);
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.Write("Input color: ");
                                        string color = Console.ReadLine();
                                        myGarage.DisplayByColor(color);
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.Write("Input speed: ");
                                        int speed;
                                        Console.Write("Enter car speed: ");
                                        while (!int.TryParse(Console.ReadLine(), out speed) || speed <= 0)
                                        {
                                            Console.Write("Enter a correct speed value, please: ");
                                        }
                                        myGarage.Display(speed);
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.Write("Input year: ");
                                        int year;
                                        Console.Write("Enter a cars year of issue: ");
                                        while (!int.TryParse(Console.ReadLine(), out year) || year < 1900)
                                        {
                                            Console.Write("Enter a correct year, please: ");
                                        }
                                        myGarage.DisplayByYear(year);
                                        break;
                                    }
                                case 5:
                                    {
                                        break;
                                    }
                            }
                            break;
                        }
                    case 4:
                        {
                            myGarage.Show_all_cars();
                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                }
            } while (way != 5);
            
            Console.ReadKey();
        }
    }
}
