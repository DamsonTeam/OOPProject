﻿namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Event
    {
        //dobaveno Andrej 27.03
        private List<EventStaff> eventStaffs = new List<EventStaff>();
        
        private Location meetingPoint;
        private int budget;
        private int field;
        
        public DateTime DateTime
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Location EventLocation
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Organizer bigBoss
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int Participants
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Location MeetingPoint
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public decimal Budget
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        //dobaveno Andrej 27.03.
        public List<EventStaff> EventStaff { get { return this.eventStaffs; } }

        public void AddEventStaff(EventStaff staff)
        {
            this.EventStaff.Add(staff);
        }
        public void RemoveEventStaff(EventStaff staff)
        {
            this.EventStaff.Remove(staff);
        }
    }
}
