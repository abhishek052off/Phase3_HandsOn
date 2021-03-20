namespace AbstractFactoryCaseStudy
{
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


}
