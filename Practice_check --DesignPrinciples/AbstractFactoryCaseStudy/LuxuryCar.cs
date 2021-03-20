using System;

namespace AbstractFactoryCaseStudy
{
    public class LuxuryCar : Car
    {
        public LuxuryCar(CarType model, Location location) :base(CarType.LUXURY, location)
        {
            Construct();
        }
        public override void Construct()
        {
            Console.WriteLine("Connecting to Luxury Car");
            Console.WriteLine(base.ToString());
        }
    }


}
