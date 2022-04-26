using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_6
{
    public class MethodOfObtaining
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<MethodOfObtaining> GetMethodOfObtaining()
        {
            return new List<MethodOfObtaining>()
            {
                new MethodOfObtaining { Id = 1, Name = "самовывоз" },
                new MethodOfObtaining { Id = 2, Name = "доставка" },
                new MethodOfObtaining { Id = 3, Name = "срочная доставка" }
            };
        }
    }
}
