using Abstract.Classes;
using System;

namespace Abstract
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

    //Abstract is a Modifiers Keywords 
    public class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            Animal cat = new Cat();

            dog.Speak();
            cat.Speak();

            dog.Eat();
            cat.Eat();

            Console.ReadLine();
        }
    }
}
