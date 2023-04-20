using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW4.CarnivorasFolder
{
    internal class Lion : Carnivoras
    {
        public Lion(int weight, int age, string name, bool tail)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Tail = tail;
        }

        public bool Mane { get; set; } = true;
        public int PawsCount { get; set; } = 4;
    }
}
