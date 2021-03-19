using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterHandson
{


    public interface IMoveable
    {
        public double GetSpeed();
        public double GetPrice();
    }


    public class Car : IMoveable
    {
        public double GetSpeed()
        {
            return 150; //in MPH
        }

        public double GetPrice()
        {
            return 28763;
        }
    }


    public interface IMoveableAdapter
    {
        public double GetSpeed(); //KMPH
        public double GetPrice();
    }


    public class AdapterImplementation : IMoveableAdapter
    {


        private IMoveable _moveable;


        public AdapterImplementation(IMoveable moveable)
        {
            this._moveable = moveable;
        }


        public double GetSpeed()
        {
            return ConvertToKmph(_moveable.GetSpeed());
        }

        public double GetPrice()
        {
            return ConvertToPounds(_moveable.GetPrice());
        }

        public double ConvertToKmph(double speed)
        {
            return speed * 1.60934;
        }

        public double ConvertToPounds(double usd)
        {
            return usd * 0.72;
        }
    }

}
