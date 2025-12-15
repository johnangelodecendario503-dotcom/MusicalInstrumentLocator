using System.Collections.Generic;

namespace MusicalInstrumentLocator.Models
{
    public static class Graph
    {
        public static List<Store> Stores = new List<Store>();

        public static string UserName;
        public static string UserLocation;
        public static List<string> InstrumentsToBuy = new List<string>();
        public static int MapWidth = 300;
        public static int MapHeight = 400;
        public static Point UserPosition;
        public static Point GetPositionFromLocation(string location)
        {
            if (string.IsNullOrWhiteSpace(location))
                return new Point(MapWidth / 2, MapHeight / 2);

            int hash = Math.Abs(location.ToLower().GetHashCode());

            int x = (hash % (MapWidth - 40)) + 20;
            int y = ((hash / 1000) % (MapHeight - 40)) + 20;

            return new Point(x, y);
        }
        public static double GetDistance(Point a, Point b)
        {
            double dx = a.X - b.X;
            double dy = a.Y - b.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public static Store? GetBestStore()
        {
            if (InstrumentsToBuy.Count == 0 || Stores.Count == 0)
                return null;

            Store? best = null;
            double bestScore = double.MaxValue;

            foreach (var store in Stores)
            {
                // Find the first instrument in this store that matches user's request
                var matchingInstrument = store.Instruments
                    .FirstOrDefault(i => InstrumentsToBuy.Contains(i.Name.ToLower()));

                if (matchingInstrument == null)
                    continue;

                double distance = GetDistance(store.Position, UserPosition);

                // Score = distance + 50% of instrument price (you can adjust weight)
                double score = distance + (matchingInstrument.Price * 0.5);

                if (score < bestScore)
                {
                    bestScore = score;
                    best = store;
                }
            }

            return best;
        }






    }
}
