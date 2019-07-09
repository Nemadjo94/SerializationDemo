using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationTutorial
{
    public class Test : C, IDisposable
    {
        public string firstName;
        public string MI;
        public string lastName;

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
