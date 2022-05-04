using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyProject
{
    public class Pharmacy
    {
        public int Id { get; set; }
        public string Address { get; set; }

        public List<Pharmacy> GetPharmacies()
        {
            return new List<Pharmacy>()
            {
                new Pharmacy { Id = 1, Address = "Вахитова"},
                new Pharmacy { Id = 2, Address = "Ершова"},
                new Pharmacy { Id = 3, Address = "Калинина"}
            };
        }
    }
}
