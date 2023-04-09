using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW4
{
    internal interface IAnimals
    {
        public int Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public bool Tail { get; set; }
        public string Move();
    }
}
