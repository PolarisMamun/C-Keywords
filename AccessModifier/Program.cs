using AccessModifier.Classes;
using System;

namespace AccessModifier
{
    //Access Modifier Keywords
    /*
     * Access modifiers are applied to the declaration of the class, method, properties, fields, and other members. They define the accessibility of the class and its members.
     */
    public class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            Animal cat = new Cat();
            Dog dog1 = new Dog();
            
            dog.Speak();
            cat.Speak();

            dog.Work();
            cat.Work();

            dog.Play();
            cat.Play();

            //dog.sl
        }
    }
}
/*Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0122	'Animal.Sleep()' is inaccessible due to its protection level	AccessModifier	D:\Personal\Learning\C#\C#Keywords\AccessModifier\Program.cs	20	Active
*/