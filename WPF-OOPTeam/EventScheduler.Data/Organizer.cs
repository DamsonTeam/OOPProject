namespace EventScheduler.Data
{
    using Enumerations;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Interfaces;

    public class Organizer : Participant, IParticipant
    {
        
        public Organizer()
        { }

        public Organizer (string firstName, string lastName, Gender gender, Event eventToJoin, string email, string gsm, decimal moneyPaid) 
            : base (firstName, lastName, eventToJoin, email, gsm, moneyPaid)
        {

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
