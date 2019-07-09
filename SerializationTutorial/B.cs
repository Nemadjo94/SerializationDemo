using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationTutorial
{
    public class B : A
    {
        public void Z()
        {
            Console.WriteLine("Z");
        }

        public override void Same()
        {
            Console.WriteLine("In B");
        }

        public override void Foo()
        {
            Console.WriteLine("Foo B");
        }
    }
}
