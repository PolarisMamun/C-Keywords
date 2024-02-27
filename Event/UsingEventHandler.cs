using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    /*
     * Points to Remember :
     1. An event is a wrapper around a delegate. It depends on the delegate.
     2. Use "event" keyword with delegate type variable to declare an event.
     3. Use built-in delegate EventHandler or EventHandler<TEventArgs> for common events.
     4. The publisher class raises an event, and the subscriber class registers for an event and provides the event-handler method.
     5. Name the method which raises an event prefixed with "On" with the event name.
     6. The signature of the handler method must match the delegate signature.
     7. Register with an event using the += operator. Unsubscribe it using the -= operator. Cannot use the = operator.
     8. Pass event data using EventHandler<TEventArgs>.
     9. Derive EventArgs base class to create custom event data class.
    10. Events can be declared static, virtual, sealed, and abstract.
    11. An Interface can include the event as a member.
    12. Event handlers are invoked synchronously if there are multiple subscribers.
     */
    public class UsingEventHandler
    {
        public event EventHandler<bool> ProcessCompleted;

        public void StartProcess()
        {
            try
            {
                Console.WriteLine("Process Started!");

                OnProcessCompleted(true);
            }
            catch (Exception)
            {

                OnProcessCompleted(false);
            }
            
        }

        protected virtual void OnProcessCompleted(bool IsSuccessful)
        {
            ProcessCompleted?.Invoke(this, IsSuccessful);
        }
    }
}
