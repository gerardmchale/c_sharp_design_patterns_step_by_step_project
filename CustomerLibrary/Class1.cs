using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLibrary
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public decimal BillAmount { get; set; }
        public DateTime BillDate { get; set; }
        public string Address { get; set; }

        /// <summary>
        /// Validate the customer values
        /// </summary>
        public virtual void Validate()
        {
            if (CustomerName.Length == 0)
            {
                throw new Exception("Customer Name is required");
            }
            if (PhoneNumber.Length == 0)
            {
                throw new Exception("Phone number is required");
            }
            if (BillAmount > 0)
            {
                throw new Exception("Bill is required");
            }
            if (BillDate >= DateTime.Now)
            {
                throw new Exception("Bill date  is not proper");
            }
        }
    }

    public class Lead : Customer
    {

    }
}
