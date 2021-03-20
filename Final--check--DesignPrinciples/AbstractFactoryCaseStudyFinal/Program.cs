using System;

namespace AbstractFactoryCaseStudyFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ProductFactory productFactory = new ConcreteProductFactory();
            Client client = new Client(productFactory);


            //client.SellElectronic(Channel.ECOMMERCE);
            //client.SellFurniture(Channel.TELECALLER);
            //client.SellToy(Channel.ECOMMERCE);

            client.SellProduct(ProductType.ELECTRONIC,Channel.ECOMMERCE);
            client.SellProduct(ProductType.TOY, Channel.TELECALLER);
            client.SellProduct(ProductType.FURNITURE, Channel.ECOMMERCE);


            Console.Read();


        }
    }


    public enum ProductType
    {
        ELECTRONIC, TOY, FURNITURE
    }

    public enum Channel
    {
        ECOMMERCE,TELECALLER
    }

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


    public abstract class ProductFactory
    {
        public abstract void Sell(ProductType productType, Channel channel);
    }

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


    public class ECommerceFactory : ProductFactory
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
