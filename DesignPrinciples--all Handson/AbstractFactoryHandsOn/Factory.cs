using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryHandsOn
{
    public abstract class AbstractFactory
    {
        public abstract Headlight MakeHeadlight();
        public abstract Tire MakeTire();
    }

    public class MercedesFactory : AbstractFactory
    {
        public override Headlight MakeHeadlight()
        {
            Headlight headlight = new MercedesHeadlight();
            return headlight;
        }

        public override Tire MakeTire()
        {
            Tire tire = new MercedesTire();
            return tire;
        }
    }

    public class AudiFactory : AbstractFactory
    {
        public override Headlight MakeHeadlight()
        {
            Headlight headlight = new AudiHeadLight();
            return headlight;
        }

        public override Tire MakeTire()
        {
            Tire tire = new AudiTire();
            return tire;
        }
    }


    public abstract class Headlight
    {
       public abstract void MakingHeadlight();
        
    }

    public class MercedesHeadlight : Headlight
    {
        public override void MakingHeadlight()
        {
            Console.WriteLine("Mercedes..Making Headlight");
        }
    }

    public class AudiHeadLight : Headlight
    {
        public override void MakingHeadlight()
        {
            Console.WriteLine("Audi .. Making Headlight");
        }
    }

    public abstract class Tire
    {
        public abstract void MakingTire();
        
    }

    public class MercedesTire : Tire
    {
       public override void MakingTire()
        {
            Console.WriteLine("Mercedes...Making Tire");
        }
    }

    public class AudiTire : Tire
    {
        public override void MakingTire()
        {
            Console.WriteLine("Audi ... Making Tire");
        }
    }

    public class FactoryFetcher
    {
        public static  AbstractFactory GetFactory(string factoryType)
        {
            AbstractFactory factory = null;

            if (factoryType.Equals("MERCEDES", StringComparison.InvariantCultureIgnoreCase))
            {
                factory = new MercedesFactory();
            }
            else if (factoryType.Equals("AUDI", StringComparison.InvariantCultureIgnoreCase))
            {
                factory = new AudiFactory();
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            return factory;
        }
    }

}
