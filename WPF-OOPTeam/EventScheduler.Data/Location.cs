namespace EventScheduler.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Location
    {

        private Coordinates coordinates;
        private string restaurant;
        public Location(Coordinates coordinates, string restaurant = "NOT SPECIFIED")
        {
            this.coordinates = coordinates;
            this.Restaurant = restaurant;
        }
        public string Restaurant
        {
            get
            {
                return this.restaurant;
            }
            private set
            {
                if (value.Length<3 || value.Length>15)
                {
                    throw new ArgumentOutOfRangeException("Restaurant name must be b/n 3 and 15 symbols.");
                }
                this.restaurant = value;

            }
        }

        public struct Coordinates
        {
            public decimal Latitude { get; set; }
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
