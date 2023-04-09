using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW4.CarnivorasFolder
{
    internal class Hyena: Carnivoras
    {
        public int PawsCount { get; set; } = 4;
        public Hyena(int weight, int age, string name, bool tail)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Tail = tail;
        }
    }
}
