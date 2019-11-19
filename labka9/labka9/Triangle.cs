using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labka9
{
    class Triangle : Shape, IDraw
    {
        private string name;
        private double side_bedro;
        private double side_osnova;

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
                return 3;
            }
        }

        public Triangle() { }
        public Triangle(string name)
        {
            Random ran = new Random();
            this.name = name;
            side_bedro = ran.Next(100);
            side_osnova = ran.Next(100);
            FigureColor = RandomColor();
        }
        public Triangle(string name, double side_bedro, double side_osnova)
        {
            this.name = name;
            this.side_bedro = side_bedro;
            this.side_osnova = side_osnova;
            FigureColor = RandomColor();
        }
        public Triangle(string name, double side_bedro, double side_osnova, string color)
        {
            this.name = name;
            this.side_bedro = side_bedro;
            this.side_osnova = side_osnova;
            FigureColor = color;
        }

        public override string FigureColor { get; set; }

        public override double Area()
        {
            return (side_bedro * side_osnova) / 2;
        }

        public override double Perimeter()
        {
            return (2 * side_bedro) + side_osnova;
        }

        public override void Display()
        {
            Console.WriteLine("Name - {0}, \nColor - {1}, \nAngles - {2}, \nSides - bedro {3}, osnova {4}, \nArea - {5}, \nPerimeter - {6} ", name, FigureColor, Angles, side_bedro, side_osnova, Area(), Perimeter());
        }

        public void Draw()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Name - {0}, \nColor - {1}, \nAngles - {2}, \nSides - bedro {3}, osnova {4}, \nArea - {5}, \nPerimeter - {6} ", name, FigureColor, Angles, side_bedro, side_osnova, Area(), Perimeter());
            Console.WriteLine();

            Console.Write(
                "         *\n" +
                "        * *\n" +
                "       *   *\n" +
                "      *     *\n" +
                "     *       *\n" +
                "    * * * * * *\n");
            Console.WriteLine();
            Console.WriteLine("Amazing TRIANGLE, yeah?");
            Console.WriteLine("-------------------------------");
        }
    }
}
