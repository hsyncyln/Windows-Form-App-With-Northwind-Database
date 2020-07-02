using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind
{
    class CustomerCustomerDemo
    {
        public string CustomerID { get; set; }
        public string CustomerTypeID { get; set; }

        public CustomerCustomerDemo(string customerID,string customerTypeID)
        {
            this.CustomerID = customerID;
            this.CustomerTypeID = customerTypeID;
        }
        public override string ToString()
        {
            return this.CustomerID;
        }
    }
}
