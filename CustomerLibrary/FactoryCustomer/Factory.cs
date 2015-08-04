using CustomerLibrary;
using ICustomerInterface;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationStrategy;

namespace FactoryCustomer
{
    public static class Factory<T>
    {
        private static IUnityContainer cont = null;

        public static T Create(string type)
        {
            if (cont == null)
            {
                cont = new UnityContainer();
                cont.RegisterType<ICustomer, Lead>("Lead",
                    new InjectionConstructor(new LeadValidation()));
                cont.RegisterType<ICustomer, Customer>("Customer",
                    new InjectionConstructor(new CustomerValidation()));
            }
            return cont.Resolve<T>(type);
        }
    }
}
