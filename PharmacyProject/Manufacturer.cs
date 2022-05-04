using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyProject
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Manufacturer> GetManufactures()
        {
            return new List<Manufacturer>()
            {
                new Manufacturer { Id = 1, Name = "Несквик"},
                new Manufacturer { Id = 2, Name = "Хенкел"},
                new Manufacturer { Id = 3, Name = "Екхольм"}
            };
        }
    }
}
