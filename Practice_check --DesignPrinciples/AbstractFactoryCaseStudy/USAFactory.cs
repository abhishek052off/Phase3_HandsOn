namespace AbstractFactoryCaseStudy
{
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


}
