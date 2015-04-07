namespace EventScheduler.Data.Interfaces
{
    public interface IEventObserver
    {
        void ReceiveNotification(Notification notification);
    }
}
