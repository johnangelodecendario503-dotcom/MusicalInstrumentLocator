using System.Collections.Generic;
using System.Drawing;

namespace MusicalInstrumentLocator.Models
{
    public class Store
    {
        public string StoreName { get; set; }
        public string Location { get; set; }
        public List<Instrument> Instruments { get; set; } = new();

        // MAP COORDINATES
        public Point Position { get; set; }
        public Color StoreColor { get; set; }
    }
}



