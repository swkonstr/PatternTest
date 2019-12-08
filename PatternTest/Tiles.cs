using System;
using System.Collections.Generic;
using System.Text;

namespace PatternTest
{
    /// <summary>
    /// Class for the tiles
    /// </summary>
    /// <remarks>
    /// Tiles parameters and methods
    /// etc.
    /// </remarks>
    public class Tile
    {
        public bool Discovered { get; set; }
        public string PlanetTypes { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NameIndex { get; set; }
        public int DescriptionIndex { get; set; }

        /// <summary>
        /// Tile production
        /// </summary>
        public ushort Population { get; set; }
        public ushort Production { get; set; }
        public ushort Fertility { get; set; }
        public ushort Energy { get; set; }


        // конструктор по умолчанию
        public Tile() {
            Discovered = false;
            PlanetTypes = "0";
            Name = "Empty";
            Description = "Empty";
            NameIndex = 0;
            DescriptionIndex = 0;
            Population = 0;
            Production = 0;
            Fertility = 0;
            Energy = 0;
        }


        public int GetProduction()
        {
            return this.Production;
        }

    }

}
