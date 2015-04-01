

namespace Classes
{
    using Classes.Enumerations;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Classes.Interfaces;

    public class Organizer : Participant, IParticipant
    {
        private Event eventToOrganize;
        //constructor 
        public Organizer()
        { }

        public Organizer (string firstName, string lastName, Gender gender, Event eventToJoin, string email, string gsm, decimal moneyPaid) 
            : base (firstName, lastName, eventToJoin, email, gsm, moneyPaid)
        {

        }

        public Event EventToOrganize
        {
            get
            {
                return this.eventToOrganize;
            }
            set
            {
                this.eventToOrganize = new Event();
            }
        }
        
        public void AddParticipant(List<Participant> participantList, Participant newParticipant)
        {
            participantList.Add(newParticipant);
        }

        public void DeleteParticipant(List<Participant> participantList, Participant participantToDelete)
        {
            participantList.Remove(participantToDelete);
        }

        public void ChangeStatus(Event organizedEvent)
        {
            throw new NotImplementedException();
        }
    }
}
