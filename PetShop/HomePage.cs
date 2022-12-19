using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PetShop
{
    public partial class HomePage : Form
    {
        Thread th;
        public HomePage()
        {
            InitializeComponent();
        }

        private void btncus_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opencustomer);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void opencustomer()
        {
            Application.Run(new CustomerPage());
        }

        private void btnemp_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openemp);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openemp()
        {
            Application.Run(new EmployeePage());
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openprod);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openprod()
        {
            Application.Run(new ProductsPage());
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
