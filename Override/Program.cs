using System;

namespace Override
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

    //Override is a Modifiers Keywords 

    /*
     * the override keyword is used to override a virtual or abstract method in a derived class. An overridden method provides a new implementation for a method that is inherited from a base class. The overridden method must have the same name, return type, and parameter list as the method in the base class.     
     */
    public class Program
    {
        static void Main(string[] args)
        {
            BaseClass obj1 = new BaseClass();
            obj1.Foo();// Output: BaseClass.Foo

            DerivedClass obj2 = new DerivedClass();
            obj2.Foo();// Output: DerivedClass.Foo

            BaseClass obj3 = obj2;
            obj3.Foo();// Output: DerivedClass.Foo

            Console.ReadLine();
        }
    }
    /*
     * In this example, the BaseClass class has a virtual method called Foo. The DerivedClass class inherits from BaseClass and overrides the Foo method with a new implementation.
     * In the Main method, a new instance of BaseClass is created and the Foo method is called on it, which outputs the string "BaseClass.Foo". A new instance of DerivedClass is created and the Foo method is called on it, which outputs the string "DerivedClass.Foo". 
     * The Foo method is then called on the obj3 instance, which is a reference to the DerivedClass instance, and it outputs the string "DerivedClass.Foo".
     * The override keyword is used to indicate that the Foo method in DerivedClass is an overridden method, and it provides a new implementation for the Foo method in BaseClass.
     */
}
