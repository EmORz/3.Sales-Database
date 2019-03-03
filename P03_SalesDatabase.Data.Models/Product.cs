using System;
using System.Collections;
using System.Collections.Generic;

namespace P03_SalesDatabase.Data.Models
{
    public class Product
    {
    //    	ProductId
    //	Name(up to 50 characters, unicode)
    //	Quantity(real number)
    //	Price
    //	Sales

        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public ICollection<Sale> Sales { get; set; }

        


    }
}
