namespace AbstractFactoryCaseStudyFinal
{
    public class TeleMarketFactory : ProductFactory
    {
        public override void Sell(ProductType productType, Channel channel)
        {
            switch (productType)
            {
                case ProductType.ELECTRONIC:
                    {
                        new ElectronicProduct(productType, channel);
                        break;
                    }

                case ProductType.TOY:
                    {
                        new ToyProduct(productType, channel);
                        break;
                    }
                case ProductType.FURNITURE:
                    {
                        new FurnitureProduct(productType, channel);
                        break;
                    }

            }
        }
    }
}
