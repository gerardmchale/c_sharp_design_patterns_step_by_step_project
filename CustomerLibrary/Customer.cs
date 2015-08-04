using ICustomerInterface;
using Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLibrary
{
    public class Customer : CustomerBase
    {
        public Customer(IValidationStrategy<ICustomer> obj)
            : base(obj)
        {
        }
    }
}
