using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind
{
    class EmployeeTerritories
    {
        public int EmployeeID { get; set; }
        public string TerritoryID { get; set; }
        public EmployeeTerritories(int employeeID,string territoryID)
        {
            this.EmployeeID = employeeID;
            this.TerritoryID = territoryID;
        }

        public override string ToString()
        {
            return this.EmployeeID.ToString();
        }
    }
}
