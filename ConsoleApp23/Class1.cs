namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal[] animals = new IAnimal[]
            {
                new Dog(),
                new Cat(),
                new Cow()
            };

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.GetType().Name} says: {animal.MakeSound()}");
            }
        }
    }
}