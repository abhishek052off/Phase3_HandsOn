namespace ObserverPatternCaseStudy
{
    public interface INotificationObserver
    {
        public string Name { get; set; }
        public void OnServerDown();
    }


}
