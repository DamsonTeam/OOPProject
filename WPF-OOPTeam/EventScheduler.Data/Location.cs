namespace EventScheduler.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Location
    {
        public int Restaurant
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public struct Coordinates
        {
            public decimal Latitude  { get; set; }
            public decimal Longitude { get; set; }

            public Coordinates(decimal latitude, decimal longitude) //constructor 
                : this()
            {
                this.Latitude = latitude;
                this.Longitude = longitude;
            }

            public override string ToString()
            {
                return string.Format("Lat:{0} Long:{1}", this.Latitude, this.Longitude);
            }
        }
    }
}
