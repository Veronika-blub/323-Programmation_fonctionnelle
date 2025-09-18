namespace Rando
{
    public partial class Rando : Form
    {
        string gpxFile = @"..\..\Ballade_châtaignère.gpx";
        public Rando()
        {
            InitializeComponent();
            List<TrackPoint> points = new();
            using (GpxReader reader = new GpxReader(streamReader.BaseStream))
            {
                while (reader.Read())
                {
                    switch (reader.ObjectType)
                    {
                        case GpxObjectType.Track:
                            //writer.WriteTrack(reader.Track);
                            var gpxPoints = reader.Track.ToGpxPoints();

                            //TODO convertir les gpxPoints en points
                            //avec un SELECT ;-)
                            var converted = gpxPoints
                                .Select(gpxPoint => new TrackPoint()
                                {
                                    Elevation = gpxPoint.Elevation,
                                    Latitude = gpxPoint.Latitude,
                                    Longitude = gpxPoint.Longitude
                                });

                            points.AddRange(converted.ToList());

                            break;

                        case GpxObjectType.Metadata:
                            // writer.WriteMetadata(reader.Metadata);
                            break;
                        case GpxObjectType.WayPoint:
                            // writer.WriteWayPoint(reader.WayPoint);
                            break;
                        case GpxObjectType.Route:
                            // writer.WriteRoute(reader.Route);
                            break;
                        case GpxObjectType.Track:
                            // writer.WriteTrack(reader.Track);
                            break;
                    }
                }
            }

            /**************************/

            if (!File.Exists(gpxFile))
            {
                MessageBox.Show($"Fichier {gpxFile} non trouvé !!");
            }

     
        }

        private void Rando_Form_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Red);
            myPen.Width = 2;

            Point[] points = new Point[4] { new Point(30,50), new Point(50,10), new Point(80,50), new Point(111,400) };
            this.CreateGraphics().DrawLines(myPen, points);
        }
    }
}
