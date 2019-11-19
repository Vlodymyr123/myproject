using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace labka9
{
    interface IDraw 
    {
        void Draw();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square("qwe");
            square1.Display();
            Console.WriteLine();

            Square square2 = new Square("asd", 12);
            square2.Display();
            Console.WriteLine();

            Circle circle1 = new Circle("zxc");
            circle1.Display();
            Console.WriteLine();

            Circle circle2 = new Circle("circle", 4, "yellow");
            circle2.Display();
            Console.WriteLine();

            Triangle triangle1 = new Triangle("triangle1", 6, 4);
            triangle1.Display();
            Console.WriteLine();

            Triangle triangle2 = new Triangle("triangle2", 10, 5, "blue");
            triangle2.Display();
            Console.WriteLine();

            //task-2

            Picture picture = new Picture();

            picture.Add(square2);
            picture.Add(circle2);
            picture.Add(triangle2);
            picture.Add(new Circle("biiig_circle", 5, "red"));
            picture.Add(new Triangle("trianglik", 3, 4));

            picture.Draw();
            Console.WriteLine();

            picture.RemoveByArea(10);
            picture.RemoveByName("biiig_circle");
            picture.RemoveByType(typeof(Square));

            //task-3

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Painter.Draw(circle2);
            Painter.Draw(square2);
            Painter.Draw(picture);

            Console.ReadKey();
        }
    }
}
