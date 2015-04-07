namespace EventScheduler.Data
{    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    using EventScheduler.Data.Staff;

    public class Event
    {
        private string title;
        private DateTime dateTime;
        private Location location;
        private Organizer organizer;
        private List<Participant> participantsList;
        private string meetingPoint;
        private decimal budget;
        private List<EventStaff> eventStaff;


        public string Title
        {
            get
            {
                return this.title;
            }
             set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2)
                {
                    throw new Exception("Event title length must be at least 2 symbols.");
                }

                this.title = value;
            }
        }

        public DateTime DateTime
        {
            get
            {
                return this.dateTime;
            }
             set
            {
                if (value == default(DateTime))
                {
                    throw new Exception("Date must have value.");
                }

                this.dateTime = value;
            }
        }
        // TODO: Should we leave parameterless constructors of Location/Organizer?
        public Location Location
        {
            get
            {
                return this.location;
            }
             set
            {
                this.location = value;
            }
        }

        public Organizer Organizer
        {
            get
            {
                return this.organizer;
            }
             set
            {
                this.organizer = value;
            }
        }

        public List<Participant> ParticipantsList
        {
            get
            {
                return this.participantsList;
            }
             set
            {
                this.participantsList = new List<Participant>();
            }
        }

        public string MeetingPoint
        {
            get
            {
                return this.meetingPoint;
            }
             set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Meeting point must be assigned.");
                }
                this.meetingPoint = value;
            }
        }

        public decimal Budget
        {
            get
            {
                return this.budget;
            }
             set
            {
                if (value < 0)
                {
                    throw new Exception("Budget of the event must be assigned.");
                }
                this.budget = value;
            }
        }

        public List<EventStaff> EventStaff
        {
            get
            {
                return this.eventStaff;
            }
             set
            {
                this.eventStaff = new List<EventStaff>();
            }
        }

        public enum Status
        {
            Active, Cancelled, Past
        }

        public override string ToString()
        {
            return String.Format(@"Event: {0}
                                   Date: {1}
                                   Location: {2}
                                   Organizer: {3}
                                   Meeting point: {4}", this.Title, this.DateTime, this.Location, this.Organizer, this.MeetingPoint);
        }


    }
}
