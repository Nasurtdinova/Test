using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Wpf
{
    public class TypeOfPayment
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static ObservableCollection<TypeOfPayment> GetTypeOfPayment()
        {
            return new ObservableCollection<TypeOfPayment>()
            {
               
                new TypeOfPayment { Id = 1, Name = "Наличными при получении" },
                new TypeOfPayment { Id = 2, Name = "Банковская карта" },
                new TypeOfPayment { Id = 3, Name = "Google Pay" },
                new TypeOfPayment { Id = 4, Name = "Apple Pay" }
            };
        }
    }
}
