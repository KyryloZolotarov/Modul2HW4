using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW4.ReptilliasFolder
{
    internal class Lizard : Reptillias
    {
        public Lizard(int weight, int age, string name, bool tail)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Tail = tail;
        }

        public int PawsCount { get; set; } = 4;
        public virtual void GrabByTail(out bool tail, out string mesege)
        {
            Tail = false;
            tail = Tail;
            mesege = "I droped tail";
        }
    }
}
