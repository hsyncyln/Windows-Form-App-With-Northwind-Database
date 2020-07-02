using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind
{
    class Categories
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public Categories(int categoryID,string categoryName)
        {
            this.CategoryID = categoryID;
            this.CategoryName = categoryName;
        }
        public override string ToString()
        {
            return this.CategoryName;
        }
    }
}
