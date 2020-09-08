using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC_CastleWindsor_Factory
{
    public class A : IA
    {
        public A()
        {
            Console.WriteLine("Constructor A");

        }
        public void method()
        {
            Console.WriteLine("method");
        }
        ~A()
        {
            Console.WriteLine("Desctructor A");

        }
    }
}
