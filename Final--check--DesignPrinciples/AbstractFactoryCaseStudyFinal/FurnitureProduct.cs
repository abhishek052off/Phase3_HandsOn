using System;

namespace AbstractFactoryCaseStudyFinal
{
    public class FurnitureProduct : Product
    {
        public FurnitureProduct(ProductType productType, Channel channel) : base(productType, channel)
        {
            ProcessOrder();
        }
        public override void ProcessOrder()
        {
            Console.WriteLine("Selling Furniture Product");
            Console.WriteLine(base.ToString());
        }
    }
}
