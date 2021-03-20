namespace ObserverPatternCaseStudyFinal
{
    //***************NOTIFICATION SERVICE**************
    public interface INotificationService //Subject under Observation
    {
        public void AddObserver(IObserver observer);
        public void RemoveObserver(IObserver observer);
        public void TriggerNotification(string message);
    }

   

   
}



