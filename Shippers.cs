using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind
{
    class Shippers
    {
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public Shippers(int shipperID,string companyName)
        {
            this.ShipperID = shipperID;
            this.CompanyName = companyName;
        }
        public override string ToString()
        {
            return CompanyName;
        }
    }
}
