using System;

namespace AdapterHandson
{
    class Program
    {
        static void Main(string[] args)
        {
            IMoveable CarObject = new Car();

            IMoveableAdapter CarAdapter = new AdapterImplementation(CarObject);

            Console.WriteLine($" Speed in MPH -->> {CarObject.GetSpeed()}");
            Console.WriteLine($" Price in USD -->> {CarObject.GetPrice()}");

            Console.WriteLine($" Speed in KMPH -->> {CarAdapter.GetSpeed()}");
            Console.WriteLine($" Price in Pounds -->> {CarAdapter.GetPrice()}");

        }
    }
}
