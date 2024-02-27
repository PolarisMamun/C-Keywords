using System;

namespace Event
{
    public class Program
    {
        static void Main(string[] args)
        {
           /* ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted; //register with an event
            bl.StartProcess();*/


            UsingEventHandler usingEvent = new UsingEventHandler();
            usingEvent.ProcessCompleted += event_ProcessCompleted;
            usingEvent.StartProcess();
            Console.ReadLine();
        }

        public static void bl_ProcessCompleted()
        {
            Console.WriteLine("Process Completed!");
        }

        public static void event_ProcessCompleted(object sender, bool IsSuccessful)
        {
            Console.WriteLine("Process " + (IsSuccessful ? "Completed Successfully" : "failed"));
        }
    }
}
