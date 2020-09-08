using Castle.Facilities.TypedFactory;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC_CastleWindsor_Factory
{
    public class ServiceInstallers : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IA>().ImplementedBy<A>().LifestyleTransient());
            container.Register(Component.For<IB>().ImplementedBy<B>().LifestyleTransient());

            container.AddFacility<TypedFactoryFacility>();
            //container.Register(Component.For<Func<IA>>().AsFactory()); // Not needed
        }
    }
}
