namespace EventScheduler.Data.Interfaces
{
    public interface IDriver
    {
        int SeatsAvailable { get; set; }

        string MeetPoint { get; set; }
    }
}
