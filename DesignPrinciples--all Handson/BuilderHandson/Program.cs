using System;

namespace BuilderHandson
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            AbstractBuilder child = new ChildPackageBuilder();
            AbstractBuilder adult = new AdultPackageBuilder();

  
            director.Construct(child);
            Product childPack = child.GetPackage();
            childPack.Show();

            director.Construct(adult);
            Product adultPack = adult.GetPackage();
            adultPack.Show();


            Console.Read();
        }
    }
}
