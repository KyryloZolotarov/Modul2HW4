using Modul2HW4.CarnivorasFolder;
using Modul2HW4.HerbivoresFolder;
using Modul2HW4.ReptilliasFolder;

namespace Modul2HW4
{
    internal class Program
    {
        internal static void Main()
        {
            var cattlpen = new CattlePen().CreateSomeCattlePen();
            Console.WriteLine();
            foreach (var item in cattlpen.GetAnimals())
            {
                Console.WriteLine($"{item.GetType().Name}: name {item.Name.ToString()} weight {item.Weight.ToString()} age {item.Age.ToString()}");
            }

            Console.WriteLine();
            Array.Sort(cattlpen.GetAnimals());
            Console.WriteLine("Animals sorted by age:");
            foreach (var item in cattlpen.GetAnimals())
            {
                Console.WriteLine($"{item.GetType().Name}: name {item.Name.ToString()} weight {item.Weight.ToString()} age {item.Age.ToString()}");
            }

            var hyenaCount = 0;
            var lionCount = 0;
            var giraffeCount = 0;
            var gorillaCount = 0;
            var rhinoCount = 0;
            var lizardCount = 0;
            var tortoiseCount = 0;
            foreach (IAnimals animal in cattlpen.GetAnimals())
            {
                Type type = animal.GetType();
                if (type == typeof(Hyena))
                {
                    hyenaCount++;
                }
                else if (type == typeof(Lion))
                {
                    lionCount++;
                }
                else if (type == typeof(Giraffe))
                {
                    giraffeCount++;
                }
                else if (type == typeof(Gorilla))
                {
                    gorillaCount++;
                }
                else if (type == typeof(Rhino))
                {
                    rhinoCount++;
                }
                else if (type == typeof(Lizard))
                {
                    lizardCount++;
                }
                else if (type == typeof(Tortoise))
                {
                    tortoiseCount++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("hyenas count in safari park: " + hyenaCount.ToString());
            Console.WriteLine("lions count in safari park: " + lionCount.ToString());
            Console.WriteLine("giraffes count in safari park: " + giraffeCount.ToString());
            Console.WriteLine("gorillas count in safari park: " + gorillaCount.ToString());
            Console.WriteLine("rhinos count in safari park: " + rhinoCount.ToString());
            Console.WriteLine("lizards count in safari park: " + lizardCount.ToString());
            Console.WriteLine("tortoises count in safari park: " + tortoiseCount.ToString());
            Console.WriteLine();
            Console.WriteLine("To find animal enter name:");
            var animalname = Console.ReadLine();
            var foundedanimal = cattlpen.FindByName(animalname);
            if (foundedanimal != null)
            {
                Console.WriteLine($"{foundedanimal.GetType().Name}: name {foundedanimal.Name.ToString()} weight {foundedanimal.Weight.ToString()} age {foundedanimal.Age.ToString()}");
            }
            else
            {
                Console.WriteLine("not found");
            }
        }
    }
}