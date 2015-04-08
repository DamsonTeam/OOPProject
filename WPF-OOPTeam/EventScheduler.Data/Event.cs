namespace EventScheduler.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;

    using EventScheduler.Data.Enumerations;
    using EventScheduler.Data.Exceptions;
    using EventScheduler.Data.Staff.StaffAbstraction;
    using EventScheduler.Data.Interfaces;

    [Serializable()]
    public class Event : IEventObservable
    {
        // OBSERVER PATTERN, http://www.c-sharpcorner.com/UploadFile/udeshikah/observer-pattern-in-net/

        /* This delegate holds the list of methods to be invoked when subject chnages */
        private delegate void NotificationDelegate(Notification notification);
        /* This is an wrapper around the subjectchnageddelegate to avoid executing it externally 
         * event gives publisher-subscriber model to the delegate
         */
        private event NotificationDelegate notificationReceived;        
        
        public const int EventTitleLenghtMinValue = 2;

        private string title;
        private DateTime dateTime;
        private Location location;
        private Organizer organizer;
        private List<Participant> participantsList;
        private string meetingPoint;
        private decimal budget;
        private List<EventStaff> eventStaff;
        private string comment;
        private EventStatus eventStatus;

        public Event(string title = "NewEvent")
        {
            string DateTimeString = String.Format("EventCreated{0}{1}", DateTime.Now.ToShortDateString(), DateTime.Now.ToShortTimeString());

            if (title == "NewEvent")
            {
                this.title = DateTimeString;
            }
            this.EventStatus = EventStatus.Active;
            this.comment = string.Concat(this.Comment, DateTimeString);
            this.ParticipantsList = new List<Participant>();
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                //if (string.IsNullOrEmpty(value) || value.Length < 2)
                //{
                //    throw new Exception("Event title length must be at least 2 symbols.");
                //}
                Validator.CheckIfNullOrEmpty(value, string.Format(ErrorMessages.NullOrEmpty, "Event title"));
                Validator.CheckIfLengthIsAtLeastNSymbols(value, EventTitleLenghtMinValue, string.Format(ErrorMessages.LengthAtLeast, "Event title", EventTitleLenghtMinValue));

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
            private set
            {
                this.participantsList = value;
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

        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = String.Format("{0}\n{1}", this.comment, value);
            }
        }

        public EventStatus EventStatus
        {
            get
            {
                return this.eventStatus;
            }
            set
            {
                this.eventStatus = value;
            }
        }


        public void AddParticipant(Participant participant)
        {
            this.ParticipantsList.Add(participant);
            this.notificationReceived += participant.ReceiveNotification;
        }

        public void RemoveParticipant(Participant participant)
        {
            this.ParticipantsList.Remove(participant);
            this.notificationReceived -= participant.ReceiveNotification;
        }
        
        public void NotifyAllParticipants(string subject, string description)
        {
            /* The only thing this method does is executing the Notify */
            this.Notify(new Notification(this, subject, description));
        }

        public void CarDistribution(Event eventToOrganize)
        {

            var participantsInCars = new Dictionary<string, string>();

            var participantsToDistribute = participantsList.Where(x => x.IsDriver == false);

            var participantsDrivers = participantsList.Where(x => x.IsDriver == true);

            foreach (var driver in participantsDrivers)
            {
                for (int j = 0; j < participantsToDistribute.Count(); j++)
                {
                    for (int i = 0; i < driver.SeatsAvailable; i++)
                    {
                        participantsInCars.Add(driver.GSM, participantsToDistribute.ElementAt(j).GSM);
                    }
                }
            }
        }

        /* This is the method where subject is notifying to the oberservers */
        private void Notify(Notification notification)
        {
            /* Interlocked is the best way to check whether event is null in a thread safe way             
             */
            Interlocked.CompareExchange(ref notificationReceived, null, null);

            if (notificationReceived != null)
            {
                /* Now we notify */
                notificationReceived(notification);
            }
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
