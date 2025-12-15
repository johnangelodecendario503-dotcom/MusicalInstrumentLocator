using System.Collections.Generic;
using System.Drawing;

namespace MusicalInstrumentLocator.Models
{
    public class Store
    {
        public string StoreName { get; set; }
        public string Location { get; set; }
        public List<Instrument> Instruments { get; set; } = new();

        public string Instrument { get; set; } = "";
        public double Price { get; set; }

        // MAP COORDINATES
        public Point Position { get; set; }
        public Color StoreColor { get; set; }
    }
}


