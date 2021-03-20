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


    public enum CarType
    {
        MICRO,MINI,LUXURY
    }

    public enum Location
    {
        DEFAULT,USA,INDIA
    }

    public abstract class Car
    {
        public CarType CarType { get; set; }
        public Location Location { get; set; }
        public Car(CarType model,Location location)
        {
            this.CarType = model;
            this.Location = location;
        }

        public abstract void Construct();

        public override string ToString()
        {
            return "Car Model - " + this.CarType.ToString() + " Located In -- " + this.Location.ToString();
        }
    }

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

    public class MiniCar: Car
    {
        public MiniCar(CarType model, Location location) : base(CarType.MINI, location)
        {
            Construct();
        }
        public override void Construct()
        {
            Console.WriteLine("Connecting to Mini Car");
            Console.WriteLine(base.ToString());
        }
    }

    public class MicroCar : Car
    {
        public MicroCar(CarType model, Location location) : base(CarType.MICRO, location)
        {
            Construct();
        }
        public override void Construct()
        {
            Console.WriteLine("Connecting to Micro Car");
            Console.WriteLine(base.ToString());
        }
    }


    public abstract class CarFactory
    {
        public abstract void Build(CarType carType,Location location);
    }

    public class ConcreteCarFactory : CarFactory
    {
        public override void Build(CarType carType, Location location)
        {
            
            switch (location)
            {
                case Location.USA:
                {
                        new USAFactory().Build(carType,location);
                    break;
                }

                case Location.INDIA:
                    {
                        new IndiaFactory().Build(carType, location);
                        break;
                    }
                case Location.DEFAULT:
                    {
                        new DefaultFactory().Build(carType, location);
                        break;
                    }

            }
        }
    }



    public class IndiaFactory : CarFactory
    {
        public override void Build(CarType carType, Location location)
        {

            switch (carType)
            {
                case CarType.MICRO:
                    {
                        new MicroCar(carType, location);
                        break;
                    }

                case CarType.MINI:
                    {
                        new MiniCar(carType, location);
                        break;
                    }
                case CarType.LUXURY:
                    {
                        new LuxuryCar(carType, location);
                        break;
                    }

            }
        }
    }


    public class USAFactory : CarFactory
    {
        public override void Build(CarType carType, Location location)
        {

            switch (carType)
            {
                case CarType.MICRO:
                    {
                        new MicroCar(carType, location);
                        break;
                    }

                case CarType.MINI:
                    {
                        new MiniCar(carType, location);
                        break;
                    }
                case CarType.LUXURY:
                    {
                        new LuxuryCar(carType, location);
                        break;
                    }

            }
        }
    }


    public class DefaultFactory : CarFactory
    {
        public override void Build(CarType carType, Location location)
        {

            switch (carType)
            {
                case CarType.MICRO:
                    {
                        new MicroCar(carType, location);
                        break;
                    }

                case CarType.MINI:
                    {
                        new MiniCar(carType, location);
                        break;
                    }
                case CarType.LUXURY:
                    {
                        new LuxuryCar(carType, location);
                        break;
                    }

            }
        }
    }


    public class Client
    {
       private CarFactory _carFactory;
       public Client(CarFactory carFactory)
        {
            this._carFactory = carFactory;
        }
        
        public void BuildMicroCar(Location location)
        {
            _carFactory.Build(CarType.MICRO,location);
        }
        public void BuildMiniCar(Location location)
        {
            _carFactory.Build(CarType.MINI, location);
        }

        public void BuildLuxuryCar(Location location)
        {
            _carFactory.Build(CarType.LUXURY, location);
        }

    }


}
