using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW4.HerbivoresFolder
{
    internal class Rhino : Giraffe
    {
        public Rhino(int weight, int age, string name, bool tail, int pawscount, int hornlength)
    : base(weight, age, name, tail, pawscount)
        {
            HornLength = hornlength;
        }

        public int HornLength { get; set; }
    }
}
