using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba8_task2
{
    class Program
    {
        class Disk_phone
        {
            public bool call = true;
            public int count_of_numbers = 10;

            public virtual void Call()
            {
                Console.WriteLine("Hello!I can call someone, dial the number by scrolling the disk!");
            }
        }

        class Knop_phone : Disk_phone
        {
            public bool Buttons = true;

            public override void Call()
            {
                Console.WriteLine("Hello! I can call someone using buttons!");
            }
        }

        class white_dark_phone : Knop_phone
        {
            public bool display = true;
            public override void Call()
            {
                Console.WriteLine("Hello-hello! I can call to someone using white-dark display!");
            }
        }

        class color_phone : white_dark_phone
        {
            public bool wi_fi = true;
            public override void Call()
            {
                Console.WriteLine("I’m calling the one you click on.");
            }

            public virtual void Surf_Net()
            {
                Console.WriteLine("I can surf the internet using wi-fi");
            }
        }

        class iPhone : color_phone
        {
            public override void Call()
            {
                Console.WriteLine("Well, put on your earpods and call to your friends");
            }

            public override void Surf_Net()
            {
                Console.WriteLine("We're using wi-fi and maybe 5g(:D). Do you want to watch something on Instagram?");
            }
        }

        class Google_glass : iPhone
        {
            public int lenses = 2;
            public override void Call()
            {
                Console.WriteLine("Say 'Ok, Gooooogle, let's call to this guys'.");
            }
            
            public override void Surf_Net()
            {
                Console.WriteLine("You have a browser, but I don’t remember where it is!");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Disk Phone");
            Disk_phone dp = new Disk_phone();
            dp.Call();
            Console.WriteLine();

            Console.WriteLine("Button Phone");
            Knop_phone kp = new Knop_phone();
            kp.Call();
            Console.WriteLine();

            Console.WriteLine("Black&White Phone");
            white_dark_phone siemens = new white_dark_phone();
            siemens.Call();
            Console.WriteLine();

            Console.WriteLine("Color Phone");
            color_phone xiaomi = new color_phone();
            xiaomi.Call();
            xiaomi.Surf_Net();
            Console.WriteLine();

            Console.WriteLine("iPhone");
            iPhone ten_pro_max = new iPhone();
            ten_pro_max.Call();
            ten_pro_max.Surf_Net();
            Console.WriteLine();

            Console.WriteLine("Google Glass");
            Google_glass Glasses = new Google_glass();
            Glasses.Call();
            Glasses.Surf_Net();
            Console.ReadKey();
        }
    }
}
