using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind
{
    class Region
    {
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }
        public Region(int regionID)
        {
            this.RegionID = regionID;
        }
        public override string ToString()
        {
            return this.RegionID.ToString();
        }
    }
}
