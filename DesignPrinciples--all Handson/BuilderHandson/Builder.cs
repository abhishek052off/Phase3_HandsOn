using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHandson
{
    public class Director

    {
        public void Construct(AbstractBuilder builder)
        {
            builder.BuildSweet();
            builder.BuildSavory();
        }
    }



    public abstract class AbstractBuilder

    {
        public abstract void BuildSweet();
        public abstract void BuildSavory();
        public abstract Product GetPackage();
    }


    public class ChildPackageBuilder : AbstractBuilder

    {
        private Product _product = new Product();

        public override void BuildSweet()
        {
            _product.Add("Sweet 1 ");
            _product.Add("Sweet 2 ");
        }

        public override void BuildSavory()
        {
            _product.Add("Savory 1");
        }

        public override Product GetPackage()
        {
            return _product;
        }
    }

   

    public class AdultPackageBuilder : AbstractBuilder

    {
        private Product _product = new Product();

        public override void BuildSweet()
        {
            _product.Add("Sweet 1");
            _product.Add("Sweet 2");
        }

        public override void BuildSavory()
        {
            _product.Add("Savory 1");
            _product.Add("Savory 2");
        }

        public override Product GetPackage()
        {
            return _product;
        }
    }

   

   public  class Product

    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\nItem In Package -------");
            foreach (string part in _parts)
                Console.WriteLine(part);
        }
    }
}
