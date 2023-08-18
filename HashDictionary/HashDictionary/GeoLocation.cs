using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashDictionary
{
    public class GeoLocation : IEquatable<GeoLocation>
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public GeoLocation(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public override int GetHashCode()
        {
            return Latitude.GetHashCode() ^ Longitude.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(obj is GeoLocation other)
            {
                return Equals(other);
            }
            return false;
        }


        public bool Equals(GeoLocation other)
        {
            if (other == null)
            {
                return false;
            }   

            return Latitude.Equals(other.Latitude) && Longitude.Equals(other.Longitude);
        }

        public static bool operator ==(GeoLocation left, GeoLocation right)
        {
            if (ReferenceEquals(left, null))
            {
                return ReferenceEquals(right, null);
            }

            return left.Equals(right);
        }

        public static bool operator !=(GeoLocation left, GeoLocation right)
        {
            return !(left == right);
        }
    }
}
