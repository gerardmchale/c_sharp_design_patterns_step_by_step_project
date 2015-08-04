using CustomerLibrary;
using FactoryCustomer;
using ICustomerInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCustomerUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ICustomer icust = null;
            var customerType = cmbCustomerType.SelectedItem.ToString();
            icust = Factory<ICustomer>.Create(customerType);
            icust.CustomerName = txtCustomerName.Text;
            icust.Address = txtAddress.Text;
            icust.PhoneNumber = txtPhoneNumber.Text;
            icust.BillDate = Convert.ToDateTime(txtBillingDate.Text);
            icust.BillAmount = Convert.ToDecimal(txtBillingAmount.Text);
        }
    }
}
