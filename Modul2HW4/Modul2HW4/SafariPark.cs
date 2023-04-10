using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW4
{
    internal class SafariPark
    {
        private IAnimals[] _animals = Array.Empty<IAnimals>();
        public void AddAnimall(IAnimals animal)
        {
            var length = _animals.Length;
            Array.Resize(ref _animals, newSize: length + 1);
            _animals[length] = animal;
        }

        public IAnimals[] GetAnimals()
        {
            return _animals;
        }
    }
}
