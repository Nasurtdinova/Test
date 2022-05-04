using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyProject
{
    public class MedicinePharmacy
    {
        public int IdMedicine { get; set; }
        public int IdPharmacy { get; set; }
        public int Count { get; set; }

        public static List<MedicinePharmacy> GetMedicinesPharmacy()
        {
            return new List<MedicinePharmacy>()
            {
                new MedicinePharmacy { IdMedicine = 1, IdPharmacy = 2, Count = 10},
                new MedicinePharmacy { IdMedicine = 2, IdPharmacy = 3, Count = 14},
                new MedicinePharmacy { IdMedicine = 3, IdPharmacy = 1, Count = 15},
                new MedicinePharmacy { IdMedicine = 2, IdPharmacy = 1, Count = 25},
                new MedicinePharmacy { IdMedicine = 1, IdPharmacy = 1, Count = 15}
            };
        }

        public static List<Medicine> GetMedicinesInPharmacy(int IdPharmacy)
        {
            List<Medicine> listMed = new List<Medicine>();
            foreach (var i in GetMedicinesPharmacy().Where(a=> a.IdPharmacy == IdPharmacy))
            {
                listMed.Add(Medicine.GetMedicines().Where(a => a.Id == i.IdMedicine).FirstOrDefault());
            }
            return listMed;
        }
    }
}
