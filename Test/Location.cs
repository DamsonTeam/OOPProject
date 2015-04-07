namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Location : IGeographicLocaion
    {
        private string name;
        Coordinates exactCoords;
       
        public Location(string name, Coordinates coordinates)
        {
            this.Name = name;
            this.exactCoords = coordinates;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Location must have name!");
                }
                name = value;
            }
        }

        public string Locate()
        {
            return string.Format("{0} - {1}N {2}E",this.name,this.exactCoords.X,exactCoords.Y);
        }

        public Coordinates GeographicCoordinates
        {
            get
            {
                return this.exactCoords;
            }
        }
    }
}
