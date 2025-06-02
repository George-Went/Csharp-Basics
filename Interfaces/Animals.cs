using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Animals
    {
    }
    public interface IAnimal
    {
        // these methods MUST be used by a class that inherits this interface
        void EatString(string food);
        public virtual void MakeSound()
        {
            Console.WriteLine("Gneric animal sound");
        }
    }

    public class Dog : IAnimal
    {
        public void EatString(string food)
        {
            Console.WriteLine($"Dog ate {food}");
        }

        public void MakeSound()
        {
            Console.WriteLine("Bark!");
        }
    }

    public class Cat : IAnimal
    {
        public void EatString(string food)
        {
            Console.WriteLine($"Cat ate {food}");
        }

        public void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
        
    }
}
