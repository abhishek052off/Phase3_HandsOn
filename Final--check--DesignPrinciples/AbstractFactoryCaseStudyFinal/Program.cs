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
}
