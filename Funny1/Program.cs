using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funny1
{
    class Program
    {
        static void Main(string[] args)
        {
            A o1 = new A();
            o1.Prompt();

            B o2 = new B();
            o2.Prompt();

            C o3 = new C();
            o3.Prompt();

            A o4 = new C();
            o4.Prompt();

            A o5 = new B();
            o5.Prompt();

            B o6 = new C();
            o6.Prompt();

            //C o7 = new A();

            Console.ReadLine();
        }
    }
}
