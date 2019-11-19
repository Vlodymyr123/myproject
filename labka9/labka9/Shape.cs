using System;
using System.Drawing;

namespace labka9
{
    abstract class Shape
    {
        public abstract string FigureColor { get; set; }

        public abstract int Angles { get; }

        public abstract string Name { get; }

        public abstract double Area();

        public abstract double Perimeter();

        public abstract void Display();

        protected string RandomColor()
        {
            Random randomGen = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomGen.Next(names.Length)];
            Color randomColor = Color.FromKnownColor(randomColorName);

            return randomColor.Name;
        }
    }
}
