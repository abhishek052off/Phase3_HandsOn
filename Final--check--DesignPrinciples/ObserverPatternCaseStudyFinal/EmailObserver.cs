using System;

namespace ObserverPatternCaseStudyFinal
{
    public class EmailObserver : IObserver
    {
        public string Name { get; set; }

        public void SendNotification(string message)
        {
            Console.WriteLine($"\n\nE-MAIL NOTIFICATION  For {this.Name} \nMessage : " + message);
        }
    }

   

   
}



