using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class Admin : Organizer
    {
        private static string password = "mypass";
        public static bool IsCorrect(string s)
        {
            return password == s;
        }
        public int Event
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
    
        public void AddEvent()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteEvent()
        {
            throw new System.NotImplementedException();
        }
    }
}
