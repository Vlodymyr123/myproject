using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labka9
{
    class Circle : Shape, IDraw
    {
        private string name;
        private double radius;

        public override string Name
        {
            get
            {
                return name;
            }
        }

        public override int Angles
        {
            get
            {
                return 0;
            }
        }

        public Circle() { }
        public Circle(string name)
        {
            Random ran = new Random();
            this.name = name;
            radius = ran.Next(100);
            FigureColor = RandomColor();
        }
        public Circle(string name, double radius)
        {
            this.name = name;
            this.radius = radius;
            FigureColor = RandomColor();
        }
        public Circle(string name, double radius, string color)
        {
            this.name = name;
            this.radius = radius;
            FigureColor = color;
        }

        public override string FigureColor { get; set; }

        public override double Area()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override void Display()
        {
            Console.WriteLine("Name - {0}, \nColor - {1}, \nAngles - {2}, \nSide - {3}, \nArea - {4}, \nPerimeter - {5} ", name, FigureColor, Angles, radius, Area(), Perimeter());
        }

        public void Draw()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Name - {0}, \nColor - {1}, \nAngles - {2}, \nSide - {3}, \nArea - {4}, \nPerimeter - {5} ", name, FigureColor, Angles, radius, Area(), Perimeter());
            Console.WriteLine();

            Console.Write(
                "       *  *\n" +
                "     *      *\n" +
                "    *        *\n" +
                "    *        *\n" +
                "     *      *\n" +
                "       *  *\n" );
            Console.WriteLine();
            Console.WriteLine("Amazing circle, yeah?");
            Console.WriteLine("-------------------------------");
        }
    }
}
