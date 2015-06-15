// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Location.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace P_01_GalacticGPS
{
    using System;

    public struct Location
    {
        private double latitude;

        private double longitude;

        // private Planet planet;
        public Location(double latitude, double longitude, Planet planet)
            : this()
        {
            this.Planet = planet;
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        public double Latitude
        {
            get
            {
                return this.latitude;
            }

            set
            {
                if (value < -90 || value > 90)
                {
                    throw new IndexOutOfRangeException("Latitude cant be less than -90 and more than 90 degrees.");
                }

                this.latitude = value;
            }
        }

        public double Longitude
        {
            get
            {
                return this.longitude;
            }

            set
            {
                if (value < -180 || value > 180)
                {
                    throw new IndexOutOfRangeException("Longitude must be between [-180..180] degrees");
                }

                this.longitude = value;
            }
        }

        public Planet Planet { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}", this.Latitude, this.Longitude, this.Planet);
        }
    }
}
