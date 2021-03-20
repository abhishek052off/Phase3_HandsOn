using System;

namespace ObserverPatternCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            INotificationObserver steve = new SteveObserver() { Name = "Steve" };
            INotificationObserver john = new JohnObserver() { Name = "John" };
            INotificationService notification = new NotificationService();
            notification.AddSubscriber(steve);
            notification.AddSubscriber(john);

            notification.NotifySubscriber();

            notification.RemoveSubscriber(john);

        }
    }


}
