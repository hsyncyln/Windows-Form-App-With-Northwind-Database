using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind
{
    class Suppliers
    {
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string HomePage { get; set; }

        public Suppliers(int supplierID, string companyName, string contactName,string phone)
        {
            this.SupplierID = supplierID;
            this.CompanyName = companyName;
            this.ContactName = contactName;
            this.Phone = phone;
        }
        public override string ToString()
        {
            return CompanyName;
        }
    }
}
