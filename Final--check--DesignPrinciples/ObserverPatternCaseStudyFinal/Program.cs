namespace ObserverPatternCaseStudyFinal
{


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



