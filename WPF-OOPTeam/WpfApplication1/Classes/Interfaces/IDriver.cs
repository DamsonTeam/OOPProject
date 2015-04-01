

namespace Classes.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface IDriver
    {
        
        int SeatsAvailable
        {
            get;
            set;
        }

        string MeetPoint
        {
            get;
            set;
        }
    }
}
