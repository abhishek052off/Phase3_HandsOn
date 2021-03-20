using System;

namespace AbstractFactoryCaseStudyFinal
{
    public class ToyProduct : Product
    {
        public ToyProduct(ProductType productType, Channel channel) : base(productType, channel)
        {
            ProcessOrder();
        }
        public override void ProcessOrder()
        {
            Console.WriteLine("Selling Toy ");
            Console.WriteLine(base.ToString());
        }
    }
}
