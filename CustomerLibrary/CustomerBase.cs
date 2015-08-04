using ICustomerInterface;
using Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLibrary
{
    public abstract class CustomerBase : ICustomer
    {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string Address { get; set; }

        public IValidationStrategy<ICustomer> ValidationType { get; private set; }

        public CustomerBase(IValidationStrategy<ICustomer> validate)
        {
            ValidationType = validate;
        }

        public void Validate()
        {
            ValidationType.Validate(this);
        }

        public ICustomer Clone()
        {
            return (ICustomer)this.MemberwiseClone();
        }
    }
}
