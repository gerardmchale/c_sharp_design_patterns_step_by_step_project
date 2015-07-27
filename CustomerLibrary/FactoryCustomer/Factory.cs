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
        private static Lazy<IList<ICustomer>> customers = null;

        static Factory()
        {
            customers = new Lazy<IList<ICustomer>>(() => LoadCustomers());
        }

        private static IList<ICustomer> LoadCustomers()
        {
            var customerList = new List<ICustomer>();
            customerList.Add(new Lead());
            customerList.Add(new Customer());
            return customerList;
        }

        public static ICustomer Create(int customerType)
        {
            return customers.Value[customerType].Clone();
        }
    }
}
