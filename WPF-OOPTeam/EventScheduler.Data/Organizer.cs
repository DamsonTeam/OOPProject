﻿namespace EventScheduler.Data
{
    using System;
    using System.Collections.Generic;

    using Enumerations;
    using Interfaces;

    [Serializable()]
    public class Organizer : Participant, IParticipant
    {

        public Organizer()
        {
        }

        public Organizer(string firstName, string lastName, Gender gender, Event eventToOrganize,string email, string gsm, decimal moneyPaid, int age)
            : base(firstName, lastName, gender,eventToOrganize, email, gsm, moneyPaid, age)
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

        public override string ToString()
        {
            return String.Format("{0} {1}", this.FirstName, this.LastName);
        }
    }
}
