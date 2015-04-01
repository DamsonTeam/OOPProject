using Classes.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public abstract class Person
    {
        private string firstName;
        private string lastName;
        public Person()
        {

        }
        public Person(string firstName, string lastName, Gender sex = Gender.notSpecified)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = sex;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            protected set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2)
                {
                    throw new Exception("Name length must be greater than 2.");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            protected set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2)
                {
                    throw new Exception("Name length must be greater than 2.");
                }
                this.lastName = value;
            }
        }

        public Gender Gender { get; private set; }

        
        public void RoomDistribuition(Participant person)//  Rooms room
        {
            throw new System.NotImplementedException();
        }

        public void CarDistribution (Participant person, Participant driver)
        {
            throw new System.NotImplementedException();
        }

        public void PrintSummary(Event newEvent)
        {
            throw new NotImplementedException();
        }
    }

    
}
