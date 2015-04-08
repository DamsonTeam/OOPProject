using System;
namespace EventScheduler.Data
{
    [Serializable]
    public class Notification : EventArgs
    {
        public Event Event { get; set; }

        public string Subject { get; set; }

        public string Description { get; set; }

        public Notification(Event @event, string subject, string description)
        {
            this.Event = @event;
            this.Subject = subject;
            this.Description = description;
        }
    }
}
