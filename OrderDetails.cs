using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind
{
    class OrderDetails
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public float UnitPrice { get; set; }
        public int Quantity { get; set; }
        public double Discount { get; set; }
        public OrderDetails(int orderID,int productID)
        {
            this.OrderID = orderID;
            this.ProductID = productID;
           
        }
        public override string ToString()
        {
            return this.OrderID.ToString();
        }
    }
}
