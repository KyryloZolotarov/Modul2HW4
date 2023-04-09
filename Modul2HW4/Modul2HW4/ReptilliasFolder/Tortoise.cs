using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW4.ReptilliasFolder
{
    internal class Tortoise : Lizard
    {
        public Tortoise(int weight, int age, string name, bool tail)
            : base(weight, age, name, tail)
        {
        }

        public string ShellCollor { get;  set; }
        public sealed override void GrabByTail(out bool tail, out string mesege)
        {
            Tail = true;
            tail = Tail;
            mesege = "I hid tail in to shell";
        }
    }
}
