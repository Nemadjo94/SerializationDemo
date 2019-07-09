using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationTutorial
{
    public class A
    {
        public void Add()
        {
            Console.WriteLine("A");
        }

        public virtual void Same()
        {
            Console.WriteLine("In A");
        }

        public virtual void Foo()
        {
            Console.WriteLine("Foo A");
        }
    }
}
