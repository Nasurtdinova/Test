using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PharmacyProject;
using System.Collections.Generic;
using System.Linq;
using Shouldly;

namespace UnitTestPharmacy
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestNameMedicine()
        {
            List<string> expectedNameMedicine = Medicine.GetNameMedicines();

            List<string> actualNameMedicine = new List<string>()
            {
                "Парацетамол", "Цитрамон", "Нош-па"
            };

            CollectionAssert.AreEqual(expectedNameMedicine, actualNameMedicine);
        }

        [TestMethod]
        public void TestNameManufacturer()
        {
            List<string> expectedNameManufacturer = Medicine.GetNameManufacturers();

            List<string> actualNameManufacturer = new List<string>()
            {
                "Несквик", "Хенкел", "Екхольм"
            };

            CollectionAssert.AreEqual(expectedNameManufacturer, actualNameManufacturer);
        }

        [TestMethod]
        public void TestExpensiveMedicine()
        {
            List<Medicine> med = new List<Medicine>()
            {
                new Medicine { Id = 1, Name = "Парацетамол", IdManufacturer = 1, Price = 49 },
                new Medicine { Id = 2, Name = "Цитрамон", IdManufacturer = 2, Price = 65 },
                new Medicine { Id = 3, Name = "Нош-па", IdManufacturer = 3, Price = 156 }
            };
            Medicine expectedExpensiveMedicine = med.Where(a=> a.Price == med.Max(i => i.Price)).FirstOrDefault();

            Medicine actualExpensiveMedicine = new Medicine()
            {
                Id = 3,
                IdManufacturer = 3,
                Name = "Нош-па",              
                Price = 156
            };
            Assert.AreEqual(expectedExpensiveMedicine.Name, actualExpensiveMedicine.Name);
        }

        [TestMethod]
        public void TestSortByOrderAndDesc()
        {
            List<Medicine> expectedSortOrderByMedicine = Medicine.GetSortedOrderByMedicines();
            List<Medicine> actualSortOrderByMedicine = new List<Medicine>()
            {
                new Medicine { Id = 1, Name = "Парацетамол", IdManufacturer = 1, Price = 49},
                new Medicine { Id = 2, Name = "Цитрамон", IdManufacturer = 2, Price = 65},
                new Medicine { Id = 3, Name = "Нош-па", IdManufacturer = 3, Price = 156}
            };
            CollectionAssert.AreEqual(expectedSortOrderByMedicine, actualSortOrderByMedicine);

           
        }

        [TestMethod]
        public void TestSortByOrderAndDesc1()
        {
         
            List<Medicine> expectedSortOrderByDescMedicine = Medicine.GetSortedOrderDescMedicines();
            List<Medicine> actualSortOrderByDescMedicine = new List<Medicine>()
            {
                new Medicine { Id = 3, Name = "Нош-па", IdManufacturer = 3, Price = 156},
                new Medicine { Id = 2, Name = "Цитрамон", IdManufacturer = 2, Price = 65},
                new Medicine { Id = 1, Name = "Парацетамол", IdManufacturer = 1, Price = 49}
            };
            CollectionAssert.AreEqual(expectedSortOrderByDescMedicine, actualSortOrderByDescMedicine);
        }
        [TestMethod]
        public void TestGetMedicinesInPharmacy()
        {
            List<Medicine> actualMedicineInPharmacy = new List<Medicine>()
            {
                new Medicine { Id = 3, IdManufacturer = 3, Name = "Нош-па", Price = 156},
                new Medicine { Id = 2, IdManufacturer = 2, Name = "Цитрамон", Price = 65},
                new Medicine { Id = 1, IdManufacturer = 1, Name = "Парацетамол", Price = 49}
            };
            Assert.AreEqual(MedicinePharmacy.GetMedicinesInPharmacy(1).Count(), actualMedicineInPharmacy.Count());
        }
    }
}
