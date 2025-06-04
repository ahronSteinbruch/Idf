using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idf
{

    public class Location
    {
        public double Latitude { get; }
        public double Longitude { get; }

        public Location(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        /// <summary>
        /// Calculates the distance to another Location using the Haversine formula.
        /// </summary>
        /// <param name="other">The other Location</param>
        /// <param name="inMiles">If true, returns distance in miles; otherwise in kilometers</param>
        public double GetDistanceTo(Location other, bool inMiles = false)
        {
            const double R_km = 6371.0;
            const double R_miles = 3958.8;

            double dLat = DegreesToRadians(other.Latitude - Latitude);
            double dLon = DegreesToRadians(other.Longitude - Longitude);

            double lat1 = DegreesToRadians(Latitude);
            double lat2 = DegreesToRadians(other.Latitude);

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(lat1) * Math.Cos(lat2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            double distance = (inMiles ? R_miles : R_km) * c;
            return distance;
        }

        private static double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }

        public override string ToString()
        {
            return $"Latitude: {Latitude}, Longitude: {Longitude}";
        }
    }
}