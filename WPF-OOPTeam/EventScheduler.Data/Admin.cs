﻿namespace EventScheduler.Data
{
    using System;

    [Serializable]
    public class Admin : Organizer
    {
        public int Event { get; set; }

        public string Name { get; set; }

        private static string password = "mypass";

        public static bool IsCorrect(string s)
        {
            return password == s;
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
