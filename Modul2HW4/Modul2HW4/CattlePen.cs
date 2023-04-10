using Modul2HW4.CarnivorasFolder;
using Modul2HW4.HerbivoresFolder;
using Modul2HW4.ReptilliasFolder;

namespace Modul2HW4
{
    internal class CattlePen
    {
        public SafariPark CreateSomeCattlePen()
        {
            var animals = new SafariPark();
            var count = new GeneratorRandom().Rand(0, 3);
            for (var i = 0; i < count; i++)
            {
                AnimalConstructor("Hyena", out int weight, out int age, out string name, out bool tail);
                Hyena hyena = new Hyena(weight, age, name, tail);
                animals.AddAnimall(hyena);
            }

            count = new GeneratorRandom().Rand(0, 3);
            for (var i = 0; i < count; i++)
            {
                AnimalConstructor("Lion", out int weight, out int age, out string name, out bool tail);
                Lion lion = new Lion(weight, age, name, tail);
                animals.AddAnimall(lion);
            }

            count = new GeneratorRandom().Rand(0, 3);
            for (var i = 0; i < count; i++)
            {
                AnimalConstructor("Rhino", out int weight, out int age, out string name, out bool tail);
                Rhino rhino = new Rhino(weight, age, name, tail, 4, 20);
                animals.AddAnimall(rhino);
            }

            count = new GeneratorRandom().Rand(0, 3);
            for (var i = 0; i < count; i++)
            {
                AnimalConstructor("Giraffe", out int weight, out int age, out string name, out bool tail);
                Giraffe giraffe = new Giraffe(weight, age, name, tail, 4);
                animals.AddAnimall(giraffe);
            }

            count = new GeneratorRandom().Rand(0, 3);
            for (var i = 0; i < count; i++)
            {
                AnimalConstructor("Gorilla", out int weight, out int age, out string name, out bool tail);
                Gorilla gorilla = new Gorilla(weight, age, name, tail, 2);
                animals.AddAnimall(gorilla);
            }

            count = new GeneratorRandom().Rand(0, 3);
            for (var i = 0; i < count; i++)
            {
                AnimalConstructor("Lizard", out int weight, out int age, out string name, out bool tail);
                Lizard lizard = new Lizard(weight, age, name, tail);
                animals.AddAnimall(lizard);
            }

            count = new GeneratorRandom().Rand(0, 3);
            for (var i = 0; i < count; i++)
            {
                AnimalConstructor("Tortoise", out int weight, out int age, out string name, out bool tail);
                Tortoise tortoise = new Tortoise(weight, age, name, tail);
                animals.AddAnimall(tortoise);
            }

            return animals;
        }

        private void AnimalConstructor(string animaltype, out int weight, out int age, out string name, out bool tail)
        {
            name = string.Empty;
            Console.WriteLine("enter " + animaltype + " name:");
            name = Console.ReadLine();
            switch (animaltype)
            {
                case "Hyena":
                    RandWeight(animaltype, 10, 60, out weight);
                    break;

                case "Lion":
                    RandWeight(animaltype, 40, 100, out weight);
                    break;
                case "Rhino":
                    RandWeight(animaltype, 100, 900, out weight);
                    break;
                case "Giraffe":
                    RandWeight(animaltype, 100, 700, out weight);
                    break;
                case "Gorilla":
                    RandWeight(animaltype, 60, 150, out weight);
                    break;
                case "Lizard":
                    RandWeight(animaltype, 1, 3, out weight);
                    break;
                case "Tortoise":
                    RandWeight(animaltype, 2, 200, out weight);
                    break;
                default:
                    weight = 0;
                    Console.WriteLine("Error");
                    break;
            }

            age = new GeneratorRandom().Rand(0, 20);
            tail = true;
        }

        private void RandWeight(string animaltype, int minweight, int maxweight, out int weight)
        {
            weight = new GeneratorRandom().Rand(minweight, maxweight);
        }
    }
}
