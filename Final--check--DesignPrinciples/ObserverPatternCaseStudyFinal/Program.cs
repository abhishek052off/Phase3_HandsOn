using System;
using System.Collections.Generic;

namespace ObserverPatternCaseStudyFinal
{

    /*
     *  create An Event... 
     * even has tickets 
     * make normal subscriber and admin observers
     * if tickets more than 100 send notification to admin
     */


    //*********EVENT (Customer accesible)********

    public interface IEvent
    {
        public string EventName { get; set; }
        public int TicketCount { get; set; }
        public INotificationService NotificationService { get; set; }
        public void ProcessRequest(Customer customer);
    }

    public class Event : IEvent
    {
        //customer part
        public string EventName { get; set; }
        public int TicketCount { get; set; }  
        public INotificationService NotificationService { get; set; }
        public void ProcessRequest(Customer customer)
        {
            this.TicketCount += customer.NumberOfTickets;

            if(this.TicketCount > 100)
            {
                this.NotificationService.TriggerNotification($"Over 100 Tickets Sold For the Even {this.EventName}");
            }
        }
    }

    public class Customer  //buys event tickets
    {
        public string Name { get; set; }
        public int NumberOfTickets { get; set; }
        public IEvent ForEvent { get; set; }
        public Customer(string name, int numberOfTickets, IEvent forEvent)
        {
            Name = name;
            NumberOfTickets = numberOfTickets;
            ForEvent = forEvent;
            ConfirmPurchase();
        }
        private void ConfirmPurchase()
        {
            Console.WriteLine($"\n\n{Name} purchased {NumberOfTickets} for {ForEvent.EventName}");
            ForEvent.ProcessRequest(this);
        }
    }

    //******************** Admin **************


    public interface IObserver
    {
        public string Name { get; set; }
        public void SendNotification(string message);
    }

    public class WhatsAppObserver : IObserver
    {
        public string Name { get ; set ; }

        public void SendNotification(string message)
        {
            Console.WriteLine($"\n\nWHATSAPP NOTIFICATION For {this.Name}\nMessage : " +message);
        }
    }


    public class EmailObserver : IObserver
    {
        public string Name { get; set; }

        public void SendNotification(string message)
        {
            Console.WriteLine($"\n\nE-MAIL NOTIFICATION  For {this.Name} \nMessage : " + message);
        }
    }


    public class TextObserver : IObserver
    {
        public string Name { get; set; }

        public void SendNotification(string message)
        {
            Console.WriteLine($"\n\n TEXT MESSAGE NOTIFICATION  For {this.Name} \nMessage : " + message);
        }
    }
    //***************NOTIFICATION SERVICE**************
    public interface INotificationService //Subject under Observation
    {
        public void AddObserver(IObserver observer);
        public void RemoveObserver(IObserver observer);
        public void TriggerNotification(string message);
    }

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

    
    public  class Program
    {
        public static void Main(string[] args)
        {
            INotificationService notificationService = new NotificationService();
            IObserver whatsappObserver = new WhatsAppObserver() { Name = "John" };
            IObserver emailObserver = new EmailObserver() { Name = "Mark" };
            IObserver textObserver = new TextObserver() { Name = "Steve" };

            notificationService.AddObserver(whatsappObserver);
            notificationService.AddObserver(emailObserver);
            notificationService.AddObserver(textObserver);
            IEvent movieEvent = new Event() { EventName = " Random Movie", NotificationService = notificationService };


            Customer ram = new Customer("Ram",30,movieEvent);
            Customer mohan = new Customer("Mohan",50,movieEvent);
            Customer suresh = new Customer("Suresh",40,movieEvent);



        }
    }

   

   
}



