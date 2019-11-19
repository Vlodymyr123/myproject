using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labka9
{
    class Square : Shape, IDraw
    {
        private string name;
        private double square_side;

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
                return 4;
            }
        }

        public override string FigureColor { get; set; }

        public Square(){}
        public Square(string name)
        {
            Random ran = new Random();
            this.name = name;
            square_side = ran.Next(100);
            FigureColor = RandomColor();
        }
        public Square(string name, double side)
        {
            this.name = name;
            square_side = side;
            FigureColor = RandomColor();
        }
        public Square(string name, double side, string color)
        {
            this.name = name;
            square_side = side;
            FigureColor = color;
        }

        public override double Area()
        {
            return square_side * square_side;
        }

        public override double Perimeter()
        {
            return 4 * square_side;
        }

        public override void Display()
        {
            Console.WriteLine("Name - {0}, \nColor - {1}, \nAngles - {2}, \nSide - {3}, \nArea - {4}, \nPerimeter - {5} " , name, FigureColor, Angles, square_side, Area(), Perimeter() );
        }

        public void Draw()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Name - {0}, \nColor - {1}, \nAngles - {2}, \nSide - {3}, \nArea - {4}, \nPerimeter - {5} ", name, FigureColor, Angles, square_side, Area(), Perimeter());
            Console.WriteLine();

            Console.Write(
                "    * * * * * *\n" +
                "    *         *\n" +
                "    *         *\n" +
                "    *         *\n" +
                "    *         *\n" +
                "    * * * * * *\n");
            Console.WriteLine();
            Console.WriteLine("Amazing SQUARE, yeah?");
            Console.WriteLine("-------------------------------");
        }
    }
}
