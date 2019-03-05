using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace P03_SalesDatabase.Data.Models
{
    public class Product
    {
    //    	ProductId
    //	Name(up to 50 characters, unicode)
    //	Quantity(real number)
    //	Price
    //	Sales

        public Product()
        {
            this.Sales = new HashSet<Sale>();

        }

        public int ProductId { get; set; }

        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public double Quantity { get; set; }

        public decimal Price { get; set; }

        public ICollection<Sale> Sales { get; set; }

        


    }
}
