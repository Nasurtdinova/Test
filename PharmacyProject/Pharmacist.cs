using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyProject
{
    public class Pharmacist
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Experience { get; set; }

        public List<Pharmacist> GetPharmacists()
        {
            return new List<Pharmacist>() 
            { 
                new Pharmacist { Id = 1, FullName = "Геннадьева Елена Сергеевна", Experience = 3},
                new Pharmacist { Id = 2, FullName = "Мулюкова Лариса Тимофеевна", Experience = 4},
                new Pharmacist { Id = 3, FullName = "Синицина Ольга Андреевна", Experience = 5} 
            };
        }
    }
}
