using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labka9
{
    class Picture: IDraw
    {
        public List<Shape> figures;
        
        public int Count_of_shapes { get { return figures.Count; } set{} }

        public Picture()
        {
            figures = new List<Shape>();
        }
        public Picture(int collectionLength)
        {
            figures = new List<Shape>(collectionLength);

            Count_of_shapes = collectionLength;
        }

        //indexer
        public Shape[] shapes;

        public Shape this[int index]
        {
            get
            {
                return shapes[index];
            }
            set
            {
                shapes[index] = value;
            }
        }

        //add figure
        public void Add(Shape figure)
        {
            figures.Add(figure);
        }

        //delete by name
        public void RemoveByName(string remove_name)
        {
            if (Count_of_shapes == 0)
            {
                Console.WriteLine("Sorry! But list is empty!");
            }
            else
            {
                for (int i = 0; i < Count_of_shapes; i++)
                {
                    if (figures[i].Name == remove_name)
                    {
                        figures.Remove(figures[i]);
                    }
                }
            }
        }

        //delete by type
        public void RemoveByType(Type figure)
        {
            if (Count_of_shapes == 0)
            {
                Console.WriteLine("Sorry! But list is empty!");
            }
            else
            {
                for (int i = 0; i < Count_of_shapes; i++)
                {
                    if (figures[i].GetType() == figure)
                    {
                        figures.Remove(figures[i]);
                    }
                }
            }
        }

        //delete by area limit
        public void RemoveByArea(double area_limit)
        {
            if (Count_of_shapes == 0)
            {
                Console.WriteLine("Sorry! But list is empty!");
            }
            else
            {
                for (int i = 0; i < Count_of_shapes; i++)
                {
                    if (figures[i].Area() > area_limit)
                    {
                        figures.Remove(figures[i]);
                    }
                }
            }
        }


        public void Draw()
        {
            if (Count_of_shapes == 0)
            {
                Console.WriteLine("List is empty!");
            }
            else
            {
                int i = 1;
                foreach (Shape el in figures)
                {
                    Circle c;
                    Square q;
                    Triangle t;
                    if (el is Circle)
                    {
                        c = (Circle)el;
                        Console.WriteLine("Figure # {0}", i++);
                        c.Draw();
                    }
                    else if (el is Square)
                    {
                        q = (Square)el;
                        Console.WriteLine("Figure # {0}", i++);
                        q.Draw();
                    }
                    else
                    {
                        t = (Triangle)el;
                        Console.WriteLine("Figure # {0}", i++);
                        t.Draw();
                    }
                }
            }

        }
    }
}
