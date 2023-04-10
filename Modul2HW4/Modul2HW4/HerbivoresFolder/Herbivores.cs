using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW4.HerbivoresFolder
{
    internal abstract class Herbivores : IAnimals
    {
        public int Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public bool Tail { get; set; }
        public virtual string Type { get; set; }
        public virtual string Move()
        {
            return "walking";
        }

        public virtual string Eating()
        {
            return "eating grass";
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            IAnimals? otherAnimal = obj as IAnimals;
            if (otherAnimal != null)
            {
                return this.Age.CompareTo(otherAnimal.Age);
            }
            else
            {
                throw new ArgumentException("Object is not a Animal");
            }
        }
    }
}
