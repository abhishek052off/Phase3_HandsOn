using System;
using System.Collections.Generic;

namespace ObserverPatternCaseStudyFinal
{
    public class NotificationService : INotificationService
    {
        List<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
            Console.WriteLine("Added Observer "+observer.Name);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("Removed Observer " + observer.Name);
        }

        public void TriggerNotification(string message)
        {
            foreach (var obs in _observers)
            {
                obs.SendNotification(message);
            }
        }
    }

   

   
}



