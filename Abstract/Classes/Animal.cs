using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Classes
{
    //Modifiers Keywords: There are 17 keywords in modifiers which are used to modify the declarations of type member.
    /*
     * public	
     * private	
     * internal	
     * protected	
     * abstract
     * const	
     * event	
     * extern	
     * new	
     * override
     * partial	
     * readonly	
     * sealed	
     * static	
     * unsafe
     * virtual	
     * volatile	
     */

    //Abstract Modifiers Keywords 

    /*
        In C#, the "abstract" keyword is used to indicate that a class or a member is incomplete and intended to be overridden or implemented by a derived class.
        An abstract class cannot be instantiated (তাত্ক্ষণিক) and is typically used as a base class to provide a common interface and implementation for its derived classes.
        An abstract method, which is a method with only a declaration and no implementation, can only be declared in an abstract class, and the derived classes 
        must provide an implementation for it. This allows for polymorphism and code reuse, as the derived classes can be used interchangeably and can inherit
        the implementation provided by the abstract class.
     */
     /*
      * Abstract method can not create in a non-abstract class ,it must be an abstract class
      * Abstract class can not declare a body
      */
    public abstract class Animal
    {
        public abstract void Speak();
        public void Eat()
        {
            Console.WriteLine("The animal is eating.");
        }
    }

    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Woof!");
        }
    }
    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Meow!");
        }
    }


    /*
        In this example, the Animal class is an abstract class with an abstract method Speak(). The Dog and Cat classes inherit from the Animal class and 
        provide their own implementation of the Speak() method. The Eat() method is a non-abstract method that provides a default implementation for all animals.
     */
}
