using CustomerLibrary;
using ICustomerInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCustomer
{
    public static class Factory
    {
        private static IList<ICustomer> customers = new List<ICustomer>();

        static Factory()
        {
            customers.Add(new Lead());
            customers.Add(new Customer());
        }

        public static ICustomer Create(int customerType)
        {
            return customers[customerType];
        }
    }
}
