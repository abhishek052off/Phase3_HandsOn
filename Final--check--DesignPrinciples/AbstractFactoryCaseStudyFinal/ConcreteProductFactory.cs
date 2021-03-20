namespace AbstractFactoryCaseStudyFinal
{
    public class ConcreteProductFactory : ProductFactory
    {
        public override void Sell(ProductType productType, Channel channel)
        {

            switch (channel)
            {
                case Channel.ECOMMERCE:
                    {
                        new ECommerceFactory().Sell(productType, channel);
                        break;
                    }

                case Channel.TELECALLER:
                    {
                        new TeleMarketFactory().Sell(productType, channel);
                        break;
                    }
               

            }
        }
    }
}
