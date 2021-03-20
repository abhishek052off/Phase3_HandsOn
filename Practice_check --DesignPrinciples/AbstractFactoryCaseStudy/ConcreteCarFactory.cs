namespace AbstractFactoryCaseStudy
{
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


}
