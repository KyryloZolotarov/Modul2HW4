using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW4
{
    internal static class SafariParkExtention
    {
        internal static IAnimals FindByName(this SafariPark animals, string animalname)
        {
            foreach (var animal in animals.GetAnimals())
            {
                if (string.Equals(animal.Name, animalname, StringComparison.OrdinalIgnoreCase))
                {
                    return animal;
                }
            }

            return null;
        }
    }
}
