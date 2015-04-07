using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
//using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization;



namespace EventScheduler.Data
{
    public static class SerializeEvent
    {
        public static void SerializeEventType(Event t, string fileName)
        {
            // Create an instance of the type and serialize it.
    
            IFormatter formatter = new BinaryFormatter();
            //SerializeEvent.SerializeEventType(eventOne, "EventOne", formatter);
            FileStream s = new FileStream(fileName, FileMode.Create);
            formatter.Serialize(s, t);
            s.Close();

        }
    
    
        public static Event DeserializeEvent(string fileName)
        {
            IFormatter formatter = new BinaryFormatter();
            FileStream s = new FileStream(fileName, FileMode.Open);
            Event t = (Event)formatter.Deserialize(s);
            return t;
        }  
    }
}
