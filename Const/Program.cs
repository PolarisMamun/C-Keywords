using System;

namespace Const
{
    /*
     * In C#, the const keyword is used to declare a constant value, 
     * which is a value that cannot be changed after it is assigned.
     * A constant is a read-only variable whose value is known at compile-time. 
     * This means that the value of a constant must be a compile-time constant expression, 
         such as a literal value, a mathematical expression involving only constant values, 
         or a call to a method that returns a constant value.
     */
    public class Program
    {
        const double PI = 3.141592653589793;
        const int DaysInWeek = 7;
        const string Greeting = "Hello, World!";
        static void Main(string[] args)
        {
            Console.WriteLine("The value of PI is: " + PI);
            Console.WriteLine("There are " + DaysInWeek + " days in a week");
            Console.WriteLine(Greeting);
            
        }
    }
}
