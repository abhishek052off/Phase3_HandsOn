namespace ObserverPatternCaseStudyFinal
{
    /*
     *  create An Event...each event has notification service 
     * event has tickets count
     * customer buys ticket
     * if total tickets more than 100 send notification to admin
     */


    //*********EVENT (Customer accesible)********

    public interface IEvent
    {
        public string EventName { get; set; }
        public int TicketCount { get; set; }
        public INotificationService NotificationService { get; set; }
        public void ProcessRequest(Customer customer);
    }

   

   
}



