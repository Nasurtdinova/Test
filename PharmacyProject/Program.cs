using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyProject
{
    class Program
    {
        static void Main(string[] args)
        {
           // List<Medicine> medList = MedicinePharmacy.GetMedicinesInPharmacy(1);

            List<Medicine> expectedSortOrderByMedicine = Medicine.GetSortedOrderByMedicines();
            List<Medicine> expectedSortOrderByDescMedicine = Medicine.GetSortedOrderDescMedicines();

            Medicine expectedExpensiveMedicine = Medicine.GetMedicines().Where(a => a.Price == Medicine.GetMedicines().Max(i => i.Price)).FirstOrDefault();
            Console.WriteLine(expectedExpensiveMedicine.Id);
        }
    }
}
