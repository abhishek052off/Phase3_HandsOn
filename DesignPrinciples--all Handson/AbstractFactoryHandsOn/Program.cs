using System;

namespace AbstractFactoryHandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;

            do
            {
                Console.WriteLine("*********Welcome*******");
                Console.WriteLine("Enter the car manufacturer (MERCEDES/AUDI) ");
                string factoryType = Console.ReadLine();
                AbstractFactory factory = FactoryFetcher.GetFactory(factoryType);
                factory.MakeHeadlight().MakingHeadlight();
                factory.MakeTire().MakingTire();

                Console.WriteLine("Repeat? (y/n) ");
                var v = Console.ReadLine()[0];
                flag = (v == 'y') ? true : false;

            } while (flag);
                

            
        }
    }
}
