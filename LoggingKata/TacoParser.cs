namespace LoggingKata
{

    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();

        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            var cells = line.Split(',');

            if (cells.Length < 3)
            {
                return null;
            }

            // grab the latitude from array at index 0
            // grab the longitude from array at index 1
            // grab the name from array at index 2

            var latitude = double.Parse(cells[0]);
            var longitude = double.Parse(cells[1]);
            var name = cells[2];

            var parsedLatitude = latitude;
            var parsedLongitude = longitude;


            var tacoBell = new TacoBell();
            tacoBell.Name = name;
            var latLong = new Point() { Longitude = parsedLongitude, Latitude = parsedLatitude };
            tacoBell.Location = latLong;

            return tacoBell;
        }
    }
}