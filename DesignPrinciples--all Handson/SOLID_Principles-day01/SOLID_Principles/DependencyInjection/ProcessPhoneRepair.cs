using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.DependencyInjection
{
    class ProcessPhoneRepair
    {
        public void RepairSteps(IPhone phone)
        {
            string part1 = phone.GetPhonePart1();
            Console.WriteLine(string.Format("{0} repaired", part1));

            double partCost = phone.GetPart1Cost();
            Console.WriteLine(string.Format("Repair cost {0}", partCost * 0.5));
        }
    }
}
