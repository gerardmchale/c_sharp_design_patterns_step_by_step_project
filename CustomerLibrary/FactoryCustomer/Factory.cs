using CustomerLibrary;
using ICustomerInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCustomer
{
    public class Factory
    {
        private IList<ICustomer> customers = new List<ICustomer>();

        public ICustomer Create(int customerType)
        {
            if (customerType == 0)
            {
                return new Lead();
            }
            else
            {
                return new Customer();
            }
        }
    }
}
