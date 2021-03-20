using System;

namespace ObserverPatternCaseStudyFinal
{
    public class WhatsAppObserver : IObserver
    {
        public string Name { get ; set ; }

        public void SendNotification(string message)
        {
            Console.WriteLine($"\n\nWHATSAPP NOTIFICATION For {this.Name}\nMessage : " +message);
        }
    }

   

   
}



