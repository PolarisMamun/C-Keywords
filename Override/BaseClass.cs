using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override
{
    public class BaseClass
    {
        public virtual void Foo()
        {
            Console.WriteLine("BaseClass.Foo");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void Foo()
        {
            Console.WriteLine("DerivedClass.Foo");
        }
    }
}
