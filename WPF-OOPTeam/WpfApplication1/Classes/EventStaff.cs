using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Classes;
using Classes.Interfaces;

namespace Classes
{
    public abstract class EventStaff : Person
    {
        protected string Name;
        protected Event EventToJoin;
        protected decimal Cost;


    }
}
