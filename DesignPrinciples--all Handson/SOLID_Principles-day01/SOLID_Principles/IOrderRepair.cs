using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
 
    public interface IProcesRequest
    {
        void ProcessOrder(string modelName);
    }

    public interface IPhoneRepair
    {
        void ProcessPhoneRepair(string modelName);
    }

    public interface IAccesoryRepair
    {
        void ProcessAccessoryRepair(string accessoryType);
    }
}
