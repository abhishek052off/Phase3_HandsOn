using System;

namespace AbstractFactoryCaseStudyFinal
{
    public class ElectronicProduct : Product
    {
        public ElectronicProduct(ProductType productType, Channel channel) : base(productType,channel)
        {
            ProcessOrder();
        }
        public override void ProcessOrder()
        {
            Console.WriteLine("Selling Electronic Item");
            Console.WriteLine(base.ToString());
        }
    }
}
