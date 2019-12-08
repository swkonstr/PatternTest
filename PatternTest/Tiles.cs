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
        public string PlanetType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int NameIndex { get; set; }
        public int DescriptionIndex { get; set; }
        public int ReproductionMod { get; set; }
        public int ShieldPenBonus { get; set; }
        public int FertilityMod { get; set; }
        public int ProductionMod { get; set; }
        public int GroundCombatMod { get; set; }
        public int ResearchMod { get; set; }
        public int PlusFlatMoney { get; set; }
        public int DiplomacyMod { get; set; }
        public int SensorMod { get; set; }
        public int ModuleHPMod { get; set; }

        // конструктор по умолчанию
        public Tile() {
            Discovered = false;
            PlanetType = "Empty";
            Name = "Empty";
            Description = "Empty";
            NameIndex = 0;
            DescriptionIndex = 0;
            ReproductionMod = 0;
            ShieldPenBonus = 0;
            FertilityMod = 0;
            ProductionMod = 0;
            GroundCombatMod = 0;
            ResearchMod = 0;
            PlusFlatMoney = 0;
            DiplomacyMod = 0;
            SensorMod = 0;
            ModuleHPMod = 0;
        }

        // конструктор с параметрами
        public Tile(bool Discovered, string PlanetType, string Name, string Description,
                    int NameIndex, int DescriptionIndex, int ReproductionMod, int ShieldPenBonus,
                    int FertilityMod, int ProductionMod, int GroundCombatMod,
                    int ResearchMod, int PlusFlatMoney, int DiplomacyMod,
                    int SensorMod, int ModuleHPMod)
        {
            this.Discovered = Discovered;
            this.PlanetType = PlanetType;
            this.Name = Name;
            this.Description = Description;
            this.NameIndex = NameIndex;
            this.DescriptionIndex = DescriptionIndex;
            this.ReproductionMod = ReproductionMod;
            this.ShieldPenBonus = ShieldPenBonus;
            this.FertilityMod = FertilityMod;
            this.ProductionMod = ProductionMod;
            this.GroundCombatMod = GroundCombatMod;
            this.ResearchMod = ResearchMod;
            this.PlusFlatMoney = PlusFlatMoney;
            this.DiplomacyMod = DiplomacyMod;
            this.SensorMod = SensorMod;
            this.ModuleHPMod = ModuleHPMod;
        }

        public int GetProduction()
        {
            return this.ReproductionMod;
        }

    }

}
