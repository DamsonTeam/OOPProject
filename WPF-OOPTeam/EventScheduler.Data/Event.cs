namespace EventScheduler.Data
{    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    using EventScheduler.Data.Staff;

    public class Event
    {
        public string Title
        {
            get
            {
                return this.Title;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2)
                {
                    throw new Exception("Event title length must be at least 2 symbols.");
                }

                this.Title = value;
            }
        }

        public DateTime DateTime
        {
            get
            {
                throw new System.NotImplementedException();
            }
            private set
            {
                if (value == default(DateTime))
                {
                    throw new Exception("Date must have value.");
                }

                this.DateTime = value;
            }
        }

        public Location Location
        {
            get
            {
                return this.Location;
            }
            private set
            {
                this.Location = new Location();
            }
        }

        public Organizer Organizer
        {
            get
            {
                return this.Organizer;
            }
            private set
            {
                this.Organizer = new Organizer();
            }
        }

        public List<Participant> ParticipantsList
        {
            get
            {
                return this.ParticipantsList;
            }
            private set
            {
                this.ParticipantsList = new List<Participant>();
            }
        }

        public string MeetingPoint
        {
            get
            {
                return this.MeetingPoint;
            }
            private set
            {
                if (string.IsNullOrEmpty(MeetingPoint))
                {
                    throw new Exception("Meeting point must be assigned.");
                }
                this.MeetingPoint = value;
            }
        }

        public decimal Budget
        {
            get
            {
                return this.Budget;
            }
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Budget of the event must be assigned.");
                }
                this.Budget = value;
            }
        }

        public List<EventStaff> EventStaff
        {
            get
            {
                return this.EventStaff;
            }
            private set
            {
                this.EventStaff = new List<EventStaff>();
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
