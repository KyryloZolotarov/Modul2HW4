using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW4.HerbivoresFolder
{
    internal class Gorilla : Giraffe
    {
        public Gorilla(int weight, int age, string name, bool tail, int pawscount)
    : base(weight, age, name, tail, pawscount)
        {
        }

        public int HeandsCount { get; set; } = 2;
    }
}
