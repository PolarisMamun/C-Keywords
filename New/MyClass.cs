using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New
{
     class BaseClass
    {
        public virtual void Foo()
        {
            Console.WriteLine("BaseClass.Foo");
        }
    }

    class DerivedClass : BaseClass
    {
        public new void Foo()
        {
            Console.WriteLine("DerivedClass.Foo");
        }

        public new class NestedClass
        {

        }
    }
}
