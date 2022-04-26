using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_6
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public bool Activity { get; set; }
        public int Count { get; set; }

        public static List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product { Id = 1, Name = "grhbfg", Description="bfgdgfb", Manufacturer ="bdgbd", Price=454, Count=12, Activity=true},
                new Product { Id = 2, Name = "bgbg", Description="bfgdgfb", Manufacturer ="bdgbd", Price=454, Count=12, Activity=true},
                new Product { Id = 3, Name = "grhgbgbfgbfg", Description="bfgdgfb", Manufacturer ="bdgbd", Price=454, Count=12, Activity=true }
            };
        }
    }
}
