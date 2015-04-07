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

        
        public override string ToString()
        {
            return this.coordinates.ToString();
        }
    }
}
