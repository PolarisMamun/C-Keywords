using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public delegate void Notify(); //delegate
    public class ProcessBusinessLogic
    {
        public event Notify ProcessCompleted; // event


        /*
         * In the above example, we declared a delegate Notify and then declared an event ProcessCompleted of delegate type 
         * Notify using "event" keyword in the ProcessBusinessLogic class. Thus, the ProcessBusinessLogic class is called the publisher. 
         * The Notify delegate specifies the signature for the ProcessCompleted event handler. It specifies that the event handler method in subscriber class must have a void return type and no parameters.
         
         */

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted()
        {
            // //if ProcessCompleted is not null then call delegate
            ProcessCompleted?.Invoke();
        }


        /*
         * Above, the StartProcess() method calls the method onProcessCompleted() at the end, which raises an event. Typically, to raise an event, protected and virtual method should be defined with the name On<EventName>. Protected and virtual enable derived classes to override the logic for raising the event. However, 
         * A derived class should always call the On<EventName> method of the base class to ensure that registered delegates receive the event.
         * The OnProcessCompleted() method invokes the delegate using ProcessCompleted?.Invoke();. This will call all the event handler methods registered with the ProcessCompleted event.

         */
    }
}
