using System;

namespace AbstractFactoryCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CarFactory carFactory = new ConcreteCarFactory();
            Client client = new Client(carFactory);

            client.BuildLuxuryCar(Location.INDIA);
            client.BuildMicroCar(Location.USA);
            client.BuildMiniCar(Location.DEFAULT);

        }
    }


}
