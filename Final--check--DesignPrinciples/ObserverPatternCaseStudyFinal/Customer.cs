using System;

namespace ObserverPatternCaseStudyFinal
{
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

   

   
}



