using System.Collections;
using System.Collections.Generic;

namespace P03_SalesDatabase.Data.Models
{
    public class Store
    {
    //    	StoreId
    //	Name(up to 80 characters, unicode)
    //	Sales

        public Store()
        {
            this.Sales = new HashSet<Sale>();
        }

        public int StoreId { get; set; }

        public string Name { get; set; }

        public ICollection<Sale> Sales { get; set; }
    }
}