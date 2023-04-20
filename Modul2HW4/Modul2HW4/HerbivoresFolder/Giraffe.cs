using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW4.HerbivoresFolder
{
    internal class Giraffe : Herbivores
    {
        public Giraffe(int weight, int age, string name, bool tail, int pawscount)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Tail = tail;
            PawsCount = pawscount;
        }

        public int PawsCount { get; set; }
    }
}
