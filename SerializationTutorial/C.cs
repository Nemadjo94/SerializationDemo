using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationTutorial
{
    public class C : B
    {
        public override void Same()
        {
            Console.WriteLine("In C");
        }

        public override void Foo()
        {
            Console.WriteLine("Foo C");
        }
    }
}
