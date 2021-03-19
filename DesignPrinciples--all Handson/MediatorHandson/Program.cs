using System;

namespace MediatorHandson
{
    class Program
    {
        static void Main(string[] args)
        {
            IChatMediator chatMediator = new ChatMediator();
            IUser foo = new BasicUser(chatMediator, "Foo");
            IUser bar = new PremiumUser(chatMediator, "Bar");
            IUser spam = new PremiumUser(chatMediator, "Spam");
            IUser egg = new BasicUser(chatMediator,"Egg");
            chatMediator.AddUser(foo);
            chatMediator.AddUser(bar);
            chatMediator.AddUser(spam);
            chatMediator.AddUser(egg);
            foo.SendMessage("Hi From Foo");
            Console.ReadLine();
        }
    }
}
