using System;
using System.Collections.Generic;

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

    public interface INotificationObserver
    {
        public string Name { get; set; }
        public void OnServerDown();
    }

    public class SteveObserver : INotificationObserver
    {
        public string Name { get; set; }

        public void OnServerDown()
        {
            Console.WriteLine($" Notification For {this.Name } ---- server down");
        }
    }

    public class JohnObserver : INotificationObserver
    {
        public string Name { get; set; }

        public void OnServerDown()
        {
            Console.WriteLine($" Notification For {this.Name } ---- server down");
        }
    }

    
    public interface INotificationService
    {
        public void AddSubscriber(INotificationObserver observer);

        public void RemoveSubscriber(INotificationObserver observer);

        public void NotifySubscriber();
    }

    public class NotificationService : INotificationService
    {
        List<INotificationObserver> _observers = new List<INotificationObserver>();

        public void AddSubscriber(INotificationObserver observer)
        {
            _observers.Add(observer);

            Console.WriteLine("------"+observer.Name + " Added To Subscribers" );

            Console.WriteLine("Current subscribers : ");

            foreach(var obs in _observers)
            {
                Console.WriteLine(obs.Name + "   " );
            }
        }

        public void NotifySubscriber()
        {
           foreach(var obs in _observers)
            {
                obs.OnServerDown();
            }
        }

        public void RemoveSubscriber(INotificationObserver observer)
        {
            _observers.Remove(observer);

            Console.WriteLine("---------"+observer.Name + " Removed From Subscribers");

            Console.WriteLine("Current subscribers : ");

            foreach (var obs in _observers)
            {
                Console.Write(obs.Name + "   ");
            }
        }
    }


}
