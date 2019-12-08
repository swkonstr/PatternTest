using System.Collections;
using System.Collections.Generic;
using System.Xml;

namespace PatternTest
{
    sealed class TilesArrInit
    {
        public static List<Tile> ReadFile()
        {
            /// <summary> Make Tile array and fill it from file </summary>
            List<Tile> tiles_arr = new List<Tile>();

            XmlDocument xDoc = new XmlDocument();
            string dirWork = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string fileXML = dirWork + @"\Tiles.xml";
            xDoc.Load(fileXML);


            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                Tile tile = new Tile();
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "PlanetTypes")
                    {
                        tile.PlanetTypes = childnode.InnerText;
                    }
                    if (childnode.Name == "Name")
                    {
                        tile.Name = childnode.InnerText;
                    }
                    if (childnode.Name == "Description")
                    {
                        tile.Description = childnode.InnerText;
                    }
                    if (childnode.Name == "NameIndex")
                    {
                        tile.NameIndex = int.Parse(childnode.InnerText);
                    }
                    if (childnode.Name == "DescriptionIndex")
                    {
                        tile.DescriptionIndex = int.Parse(childnode.InnerText);
                    }
                    if (childnode.Name == "Population")
                    {
                        tile.Population = ushort.Parse(childnode.InnerText);
                    }
                    if (childnode.Name == "Production")
                    {
                        tile.Production = ushort.Parse(childnode.InnerText);
                    }
                    if (childnode.Name == "Fertility")
                    {
                        tile.Fertility = ushort.Parse(childnode.InnerText);
                    }
                    if (childnode.Name == "Energy")
                    {
                        tile.Energy = ushort.Parse(childnode.InnerText);
                    }
                }
                tiles_arr.Add(tile);
            }
            return tiles_arr;
        }
        
    }
}
