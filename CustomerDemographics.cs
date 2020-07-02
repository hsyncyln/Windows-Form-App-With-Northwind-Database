using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind
{
    class CustomerDemographics
    {
        public string CustomerTypeID { get; set; }
        public string CustomerDesc { get; set; }
        public CustomerDemographics(string customerTypeID,string customerDesc)
        {
            this.CustomerTypeID = customerTypeID;
            this.CustomerDesc = customerDesc;
        }
        public override string ToString()
        {
            return this.CustomerTypeID;
        }
    }
}
