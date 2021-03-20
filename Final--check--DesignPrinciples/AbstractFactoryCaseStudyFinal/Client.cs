namespace AbstractFactoryCaseStudyFinal
{
    public class Client
    {
        private ProductFactory _productFactory;
        public Client(ProductFactory productFactory)
        {
            this._productFactory = productFactory;
        }

        //public void SellElectronic(Channel channel)
        //{
        //    _productFactory.Sell(ProductType.ELECTRONIC, channel);
        //}
        //public void SellToy(Channel channel)
        //{
        //    _productFactory.Sell(ProductType.TOY, channel);
        //}

        //public void SellFurniture(Channel channel)
        //{
        //    _productFactory.Sell(ProductType.FURNITURE, channel);
        //}

        public void SellProduct(ProductType productType,Channel channel)
        {
            _productFactory.Sell(productType, channel);
        }
    }
}
