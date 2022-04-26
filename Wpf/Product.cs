using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Wpf
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int IdManufacturer { get; set; }
        public double Price { get; set; }
        public bool Activity { get; set; }
        public int Count { get; set; }

        public static ObservableCollection<Product> GetProducts()
        {
            return new ObservableCollection<Product>()
            {
                new Product { Id = 1, Name = "Мишка", Description="красивый мишка", IdManufacturer = 3, Price=454, Count=12, Activity=true},
                new Product { Id = 2, Name = "Юла", Description="красивая юла", IdManufacturer = 1, Price=554, Count=12, Activity=true},
                new Product { Id = 3, Name = "Кукла", Description="красивая кукла", IdManufacturer = 2, Price=354, Count=12, Activity=true }
            };
        }
    }
}
