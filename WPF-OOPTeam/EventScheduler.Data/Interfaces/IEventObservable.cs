namespace EventScheduler.Data.Interfaces
{
    public interface IEventObservable
    {
        void NotifyAllParticipants(string subject, string description);
    }
}
