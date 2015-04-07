namespace EventScheduler.Data.Staff.StaffAbstraction
{
    using System;

    [Serializable]
    public abstract class EventStaff : Person
    {
        protected string Name;
        protected Event EventToJoin;
        protected decimal Cost;
    }
}
