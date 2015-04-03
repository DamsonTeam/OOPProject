namespace EventScheduler.Data.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface IParticipant
    {
        bool IsParticipant { get; }

        Event EventToOrganize { get; }

        void PayForAttendance(Participant participant, decimal moneyPaid);
    }
}
