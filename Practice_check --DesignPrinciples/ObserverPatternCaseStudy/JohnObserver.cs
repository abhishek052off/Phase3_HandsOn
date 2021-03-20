using System;

namespace ObserverPatternCaseStudy
{
    public class JohnObserver : INotificationObserver
    {
        public string Name { get; set; }

        public void OnServerDown()
        {
            Console.WriteLine($" Notification For {this.Name } ---- server down");
        }
    }


}
