using System;

namespace Laba11
{
    public delegate void AllComplete(Auto car);
    public delegate void OilAndWheelsChanged(Auto car);

    class ServiceStation
    {
        public void rozval(Auto car)
        {
            car.Rozval = true;
        }

        public void painted(Auto car)
        {
            car.Painted = true;
        }

        public void oilChanged(Auto car)
        {
            car.OilChanged = true;
        }

        public void reviewComplete(Auto car)
        {
            car.ReviewComplete = true;
        }

        public void wheelsChanged(Auto car)
        {
            car.WheelsChanged = true;
        }

        public void bodyRepaired(Auto car)
        {
            car.BodyRepaired = true;
        }

        public void CompleteAllProcess(Auto car)
        {
            AllComplete Process;
            Process = rozval;
            Process += painted;
            Process += oilChanged;
            Process += reviewComplete;
            Process += wheelsChanged;
            Process += bodyRepaired;
            Process.Invoke(car);
        }

        public void OilAndWheels(Auto car)
        {
            OilAndWheelsChanged Work;
            Work = oilChanged;
            Work += wheelsChanged;
            Work.Invoke(car);
        }

        public void PrintInfo(Auto car)
        {
            Console.WriteLine("All information abour our Service");
            Console.WriteLine("Rozval - " + car.Rozval);
            Console.WriteLine("Painted - " + car.Painted);
            Console.WriteLine("Oil Changed - " + car.OilChanged);
            Console.WriteLine("Review Complete - " + car.ReviewComplete);
            Console.WriteLine("Wheels Changed - " + car.WheelsChanged);
            Console.WriteLine("Body Repaired - " + car.BodyRepaired);

        }

    }
}
