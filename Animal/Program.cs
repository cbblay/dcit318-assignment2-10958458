using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Animal
    {
        public void MakeSound()
        {
            Console.WriteLine("Some generic Sound");
        }
    }
    class Dog
    {
        public void MakeSound()
        {
            Console.WriteLine("Bark!!");
        }
    }
    class Cat
    {
        public void MakeSound()
        {
            Console.WriteLine("Meow!!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal anim = new Animal();
            anim.MakeSound();

            Dog dog = new Dog();
            dog.MakeSound();

            Cat cat =new Cat();
            cat.MakeSound();

        }
    }
}
