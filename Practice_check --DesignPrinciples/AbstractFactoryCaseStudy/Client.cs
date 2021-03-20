namespace AbstractFactoryCaseStudy
{
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
