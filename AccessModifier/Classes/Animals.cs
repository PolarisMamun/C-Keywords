using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier.Classes
{
    /*
     In this example, the Animal class has methods with different access modifiers:
         * public: The method can be accessed from anywhere.
         * private: The method can only be accessed within the class it is defined in.
         * protected: The method can be accessed within the class it is defined in and any derived classes.
         * internal: The method can be accessed within the same assembly.
         * protected internal: The method can be accessed within the same assembly and any derived classes.
     
     The Dog and Cat classes inherit from the Animal class and can access the Sleep(), Play(), 
     and Work() methods. However, they cannot access the Eat() method because it is private.
     */
    public class Animal
    {
        public string Name { get; set; }
        private void Eat()
        {
            Console.WriteLine("Private: The animal is eating.");
        }
        protected void Sleep()
        {
            Console.WriteLine("Protected: The animal is sleeping.");
        }
        internal void Play()
        {
            Console.WriteLine("Internal: The animal is playing.");
        }
        protected internal void Work()
        {
            Console.WriteLine("Protected Internal: The animal is working.");
        }
        public void Speak()
        {
            Sleep();
            Console.WriteLine("Public: The animal is speaking.");
        }
    }

    public class Dog : Animal
    {       
        public void Bark()
        {
            Animal animal = new Animal();

            Console.WriteLine("Woof!");
            //Sleep();
            //Eat();
        }
    }
    public class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine("Meow!");
        }
    }
}
