using System;
using System.Collections.Generic;
using System.Text;

namespace Wpf
{
    public class MethodOfObtaining
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<MethodOfObtaining> GetMethodOfObtaining()
        {
            return new List<MethodOfObtaining>()
            {
                new MethodOfObtaining { Id = 1, Name = "Наличными при получении" },
                new MethodOfObtaining { Id = 2, Name = "Банковская карта" },
                new MethodOfObtaining { Id = 3, Name = "Google Pay" },
                new MethodOfObtaining { Id = 4, Name = "Apple Pay" }
            };
        }
    }
}
