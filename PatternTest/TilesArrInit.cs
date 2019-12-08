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
                    if (childnode.Name == "Discovered")
                    {
                        tile.Discovered=bool.Parse(childnode.InnerText);
                    }
                    if (childnode.Name == "PlanetType")
                    {
                        tile.PlanetType = childnode.InnerText;
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
                    if (childnode.Name == "ReproductionMod")
                    {
                        tile.ReproductionMod = int.Parse(childnode.InnerText);
                    }
                    if (childnode.Name == "ShieldPenBonus")
                    {
                        tile.ShieldPenBonus = int.Parse(childnode.InnerText);
                    }
                    if (childnode.Name == "FertilityMod")
                    {
                        tile.FertilityMod = int.Parse(childnode.InnerText);
                    }
                    if (childnode.Name == "ProductionMod")
                    {
                        tile.ProductionMod = int.Parse(childnode.InnerText);
                    }
                    if (childnode.Name == "GroundCombatMod")
                    {
                        tile.GroundCombatMod = int.Parse(childnode.InnerText);
                    }
                    if (childnode.Name == "ResearchMod")
                    {
                        tile.ResearchMod = int.Parse(childnode.InnerText);
                    }
                    if (childnode.Name == "PlusFlatMoney")
                    {
                        tile.PlusFlatMoney = int.Parse(childnode.InnerText);
                    }
                    if (childnode.Name == "DiplomacyMod")
                    {
                        tile.DiplomacyMod = int.Parse(childnode.InnerText);
                    }
                    if (childnode.Name == "SensorMod")
                    {
                        tile.SensorMod = int.Parse(childnode.InnerText);
                    }
                    if (childnode.Name == "ModuleHPMod")
                    {
                        tile.ModuleHPMod = int.Parse(childnode.InnerText);
                    }
                }
                tiles_arr.Add(tile);
            }
            return tiles_arr;
        }
        
    }
}
