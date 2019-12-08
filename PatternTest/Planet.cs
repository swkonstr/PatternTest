using System;
using System.Collections.Generic;
using System.Text;

namespace PatternTest
{
    public interface IBuilder
    {
        void GivePlanetName();
        void GivePlanetCoordinates();
        void GivePlanetFertility();
        void GivePlanetRich();
    }

    /// <summary>
    /// Class for the planets
    /// </summary>
    /// <remarks>
    /// Planet parameters and methods
    /// etc.
    /// </remarks>
    public class Planet
    {
        public string name;
        public int x;
        public int y;
        public List<Tile> tiles;


        /// <summary>
        /// The class constructor with parameters.
        /// </summary>
        /// <param name="name"> The name for the planet.</param>
        /// <param name="x"> x coord.</param>
        /// <param name="y"> y coord.</param>
        /// <param name="tiles_arr"> The array of tje tiles.</param>
        public Planet(string name, int x, int y, List<Tile> tiles_arr) 
        {
            this.name = name;
            this.x = x;
            this.y = y;
            this.tiles = tiles_arr;
        }
        

    }
}
