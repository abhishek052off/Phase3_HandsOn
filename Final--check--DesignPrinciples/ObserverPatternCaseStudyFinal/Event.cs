namespace ObserverPatternCaseStudyFinal
{
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
                this.NotificationService.TriggerNotification($"Over 100 Tickets Sold For the Event -- {this.EventName}");
            }
        }
    }

   

   
}



