using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW4.HerbivoresFolder
{
    internal abstract class Herbivores
    {
        public int Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public bool Tail { get; set; }
        public virtual string Move()
        {
            return "walking";
        }

        public virtual string Eating()
        {
            return "eating grass";
        }
    }
}
