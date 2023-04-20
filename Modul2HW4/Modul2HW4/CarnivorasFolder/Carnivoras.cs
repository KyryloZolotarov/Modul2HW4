using Modul2HW4.HerbivoresFolder;

namespace Modul2HW4.CarnivorasFolder
{
    internal abstract class Carnivoras : Herbivores
    {
        public sealed override string Eating()
        {
            return "eating grass and meat";
        }
    }
}
