using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_6
{
    public class TypeOfPayment
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<TypeOfPayment> GetTypeOfPayment()
        {
            return new List<TypeOfPayment>()
            {
                new TypeOfPayment { Id = 1, Name = "самовывоз" },
                new TypeOfPayment { Id = 2, Name = "доставка" },
                new TypeOfPayment { Id = 3, Name = "срочная доставка" }
            };
        }
    }
}
