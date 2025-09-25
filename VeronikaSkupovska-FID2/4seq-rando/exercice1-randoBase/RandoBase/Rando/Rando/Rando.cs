using Gpx;

namespace Rando
{
    
        public partial class Rando : Form
    {
        string gpxFile = @"..\..\..\gpx\Ballade_châtaignère.gpx";
        List<TrackPoint> trackPoints = new();

        public Rando()
        {

            InitializeComponent();

            if (!File.Exists(gpxFile))
            {
                MessageBox.Show($"Fichier {gpxFile} non trouvé !!");
            }

            StreamReader streamReader = new StreamReader(gpxFile);

            using (GpxReader reader = new GpxReader(streamReader.BaseStream))
            {
                while (reader.Read())
                {
                    switch (reader.ObjectType)
                    {
                        case GpxObjectType.Track:
                            var gpxPoints = reader.Track.ToGpxPoints();

                            var converted = gpxPoints
                                .Select(gpxPoint => new TrackPoint()
                                {
                                    Elevation = gpxPoint.Elevation,
                                    Latitude = gpxPoint.Latitude * 10000,
                                    Longitude = gpxPoint.Longitude * 10000
                                });
 
                            trackPoints.AddRange(converted.ToList());

                            break;
                    }
                }
            }
        }

        private void Rando_Form_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Red);
            myPen.Width = 2;

            //Point[] points = new Point[4] { new Point(30, 50), new Point(50, 10), new Point(80, 50), new Point(111, 400) };

            var minLat = trackPoints.Min(tp => tp.Latitude);
            var maxLat = trackPoints.Max(tp => tp.Latitude);
            var rangeLat = maxLat - minLat;
            var ratioLat = rangeLat / Width;

            var minLong = trackPoints.Min(tp => tp.Longitude);
            var maxLong = trackPoints.Max(tp => tp.Longitude);
            var rangeLong = maxLong - minLong;
            var ratioLong = rangeLong / Height;

            //De trackpoint VERS POINT
            Point[] points = trackPoints
                .Select(trackPoint => new Point()
                {
                    X = Convert.ToInt32((trackPoint.Latitude - minLat) * ratioLat),
                    Y = Convert.ToInt32((trackPoint.Longitude - minLong) * ratioLong)
                }
                )
                .ToArray();



            this.CreateGraphics().DrawLines(myPen, points);
        }



        //Pour calculer la distance
        
    }   
}