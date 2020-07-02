using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind
{
    class Territories
    {
        public string TerritoryID { get; set; }
        public string TerritoryDescription { get; set; }
        public int RegionID { get; set; }
        public Territories(string territoryID,int regionID)
        {
            this.TerritoryID = territoryID;
            this.RegionID = regionID;
        }
        public override string ToString()
        {
            return this.TerritoryID;
        }
    }
}
