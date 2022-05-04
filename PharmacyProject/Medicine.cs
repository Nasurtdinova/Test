using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyProject
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdManufacturer { get; set; }
        public double Price { get; set; }

        public static List<Medicine> GetMedicines()
        {
            return new List<Medicine>()
            {
                new Medicine { Id = 1, Name = "Парацетамол", IdManufacturer = 1, Price = 49},
                new Medicine { Id = 2, Name = "Цитрамон", IdManufacturer = 2, Price = 65},
                new Medicine { Id = 3, Name = "Нош-па", IdManufacturer = 3, Price = 156}
            };
        }

        public static List<string> GetNameMedicines()
        {
            List<string> NameMedicine = new List<string>();
            foreach (var i in GetMedicines())
                NameMedicine.Add(i.Name);
            return NameMedicine;
        }

        public static List<string> GetNameManufacturers()
        {
            List<string> NameManufacturers = new List<string>();
            foreach (var i in Manufacturer.GetManufactures())
                NameManufacturers.Add(i.Name);
            return NameManufacturers;
        }

        public static List<Medicine> GetSortedOrderByMedicines()
        {
            return GetMedicines().OrderBy(x => x.Price).ToList();
        }

        public static List<Medicine> GetSortedOrderDescMedicines()
        {
            return  GetMedicines().OrderByDescending(x => x.Price).ToList();
        }
    }
}
