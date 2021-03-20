namespace AbstractFactoryCaseStudyFinal
{
    public abstract class Product
    {
        public ProductType ProductType { get; set; }
        public Channel Channel { get; set; }
        public Product(ProductType productType,Channel channel)
        {
            this.ProductType = productType;
            this.Channel = channel;
        }

        public abstract void ProcessOrder();

        public override string ToString()
        {
            return "Product Type - " + this.ProductType.ToString() + " Sold Through -- " + this.Channel.ToString();
        }
    }
}
