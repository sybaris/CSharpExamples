using Castle.MicroKernel;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC_CastleWindsor_Factory
{
    class Program
    {
        static void MainInternal()
        {
            IWindsorContainer container = new WindsorContainer();
            container.Install(new ServiceInstallers());

            IB b = container.Kernel.Resolve<IB>();

            b.method();
            //container.Release(b);
            b = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        static void Main(string[] args)
        {
            MainInternal();

            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }
    }
}
