using CustomerLibrary;
using ICustomerInterface;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCustomer
{
    public static class Factory<T>
    {
        private static IUnityContainer cont = null;

        static Factory()
        {
            cont = new UnityContainer();
            cont.RegisterType<ICustomer, Lead>("0");
            cont.RegisterType<ICustomer, Customer>("1");
        }

        public static T Create(int customerType)
        {
            return cont.Resolve<T>(customerType.ToString());
        }
    }
}
