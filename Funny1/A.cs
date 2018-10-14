using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funny1
{
    public class A
    {
        public virtual void Prompt()
        {
            Console.WriteLine("Hello from A...");
        }
    }

    public class B : A
    {
        public override void Prompt()
        {
            Console.WriteLine("Hello from B...");
        }
    }

    public class C : B
    {
        public override void Prompt()
        {
            Console.WriteLine("Hello from C...");
        }
    }
}
