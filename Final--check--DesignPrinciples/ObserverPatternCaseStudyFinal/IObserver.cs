namespace ObserverPatternCaseStudyFinal
{
    //******************** Admin **************


    public interface IObserver
    {
        public string Name { get; set; }
        public void SendNotification(string message);
    }

   

   
}



