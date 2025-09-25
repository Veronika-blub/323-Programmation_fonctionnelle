namespace Rando
{

    public class TrackPoint
    {

                private const double EARTH_RADIUS = 6371; // [km]
        private const double RADIAN = Math.PI / 180;
        private double _latitude;
        private double _longitude;
        private double? _elevation;


        /*
                public TrackPoint(double latitude, double longitude, double elevation)
                {
                    _latitude = latitude;
                    _longitude = longitude;
                    Elevation = elevation;
                }*/

        public double? Elevation { get => _elevation; set => _elevation = value; }
        public double Longitude { get => _longitude; set => _longitude = value; }
        public double Latitude { get => _latitude; set => _latitude = value; }
        
        public double GetDistanceFrom(TrackPoint other)
        {
            double thisLatitude = Latitude * RADIAN;
            double otherLatitude = other.Latitude * RADIAN;
            double deltaLongitude = Math.Abs(Longitude - other.Longitude) * RADIAN;

            double cos = Math.Cos(deltaLongitude) * Math.Cos(thisLatitude) * Math.Cos(otherLatitude) +
                Math.Sin(thisLatitude) * Math.Sin(otherLatitude);

            return EARTH_RADIUS * Math.Acos(Math.Max(Math.Min(cos, 1), -1));
        }
    }
}