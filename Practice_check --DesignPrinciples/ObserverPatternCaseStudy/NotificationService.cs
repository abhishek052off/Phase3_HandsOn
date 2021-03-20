using System;
using System.Collections.Generic;

namespace ObserverPatternCaseStudy
{
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
