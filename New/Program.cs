using System;

namespace New
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Use new to create a new instance of a class
            BaseClass obj1 = new DerivedClass();
            obj1.Foo();// Output: DerivedClass.Foo


            // Use new to hide a member of a base class
            DerivedClass obj2 = (DerivedClass)obj1;
            obj2.Foo();// Output: DerivedClass.Foo
            BaseClass obj3 = obj1;
            obj3.Foo();// Output: BaseClass.Foo


            // Use new to create a delegate instance
            Action<int> action = new Action<int>(x=> Console.WriteLine(x));
            action(42);// Output: 42

            // Use new to create a type that hides a base type
            DerivedClass.NestedClass obj4 = new DerivedClass.NestedClass();



            Console.ReadLine();
        }
    }
}
