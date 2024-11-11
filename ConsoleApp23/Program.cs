
using ConsoleApp23;

namespace ConsoleApp23
{
    // Dog კლასი, რომელიც წარმოადგენს Animal-ის მემკვიდრეს
    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }

        public override string MakeSound()
        {
            return "Woof";
        }
    }
}

namespace ConsoleApp23
{
    // Cow კლასი, რომელიც წარმოადგენს Animal-ის მემკვიდრეს
    public class Cow : Animal
    {
        public Cow(string name, int age) : base(name, age)
        {
        }

        public override string MakeSound()
        {
            return "Moo";
        }
    }
}

namespace ConsoleApp23
{
    // Cat კლასი, რომელიც წარმოადგენს Animal-ის მემკვიდრეს
    public class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public override string MakeSound()
        {
            return "Meow";
        }
    }
}