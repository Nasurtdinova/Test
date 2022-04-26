using System;
using System.Collections.Generic;
using System.Text;

namespace Wpf
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Manufacturer> GetManufacturer()
        {
            return new List<Manufacturer>()
            {
                new Manufacturer { Id = 1, Name = "ЮлаЗавод" },
                new Manufacturer { Id = 2, Name = "Куклазавод" },
                new Manufacturer { Id = 3, Name = "Мишкаозавод" }
            };
        }
    }
}
