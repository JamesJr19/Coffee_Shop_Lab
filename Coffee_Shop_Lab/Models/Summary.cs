using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_Shop_Lab.Models
{
    public class Summary
    {
        public string Name { get; set; }
        public Summary(string name)
        {
            Name = name;
        }

        public void WelcomeUser()
        {
            Console.WriteLine($"Welcome");
        }
    }
}
