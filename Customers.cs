using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind
{
    class Customers
    {
        public string CustomerID{ get; set; }
        public string CompanyName { get; set; }
        public string ContactTitle { get; set; }
        public string Adress { get; set; }
        public string City{ get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public Customers(string customerID,string companyName,string phone)
        {
            this.CustomerID = customerID;
            this.CompanyName = companyName;
            this.Phone = phone;
        }
        public override string ToString()
        {
            return this.CompanyName;
        }
    }
}
