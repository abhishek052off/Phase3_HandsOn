using System;

namespace ObserverPatternCaseStudyFinal
{
    public class TextObserver : IObserver
    {
        public string Name { get; set; }

        public void SendNotification(string message)
        {
            Console.WriteLine($"\n\n TEXT MESSAGE NOTIFICATION  For {this.Name} \nMessage : " + message);
        }
    }

   

   
}



