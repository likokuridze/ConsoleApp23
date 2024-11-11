

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal[] animals = new IAnimal[]
            {
                new Dog("Rex", 3),
                new Cat("shai", 2),
                new Cow("nisla", 5)
            };

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.GetType().Name} says: {animal.MakeSound()}");
            }
        }
    }
}