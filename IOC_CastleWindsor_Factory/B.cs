using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC_CastleWindsor_Factory
{
    public class B : IB
    {
        private readonly Func<IA> _creatorA;

        public B(Func<IA> a)
        {
            _creatorA = a;
            Console.WriteLine("Constructor B");
        }

        public void method()
        {
            var a = _creatorA();
            a.method();
        }

        ~B()
        {
            Console.WriteLine("Desctructor B");
        }
    }
}
