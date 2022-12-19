using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace PetShop
{
    public partial class CustomerPage : Form
    {
        string email;
        Thread th;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6DDLFRC;Initial Catalog=AlfaPetShop;Integrated Security=True");
        public CustomerPage()
        {
            InitializeComponent();
            showcustomerdata();
        }

        private void clearcustomerdata()
        {
            txtID.Text = "";
            txtCusName.Text = "";
            txtCusEmail.Text = "";
            txtCusAddress.Text = "";
            txtCusPhone.Text = "";
            //txtCusName.Focus();

        }

        private void showcustomerdata()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from CustomerTbl";
            //cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            dta.Fill(dt);
            customerlist.DataSource = dt;
            conn.Close();
        }

        private void btnCusSave_Click(object sender, EventArgs e)
        {
            if (txtCusName.Text == "" || txtCusAddress.Text == "" || txtCusPhone.Text == "" || txtCusEmail.Text == "")
            {
                MessageBox.Show("Please Fill All Customer Data");
            }
            else
            {
                try
                {
                    conn.Open();
                    email = txtCusEmail.Text;
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into [CustomerTbl] (CusName,CusAdd,CusPhone,CusEmail,CusDJ) values ('" + txtCusName.Text + "', '" + txtCusAddress.Text + "', '" + txtCusPhone.Text + "', '" + email + "', '" + dtCusDate.Text + "')";
                    //cmd.Parameters.Add(new SqlParameter("@images", images));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Added");
                    clearcustomerdata();
                    conn.Close();
                    showcustomerdata();
                    txtCusName.Focus();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void customerlist_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void customerlist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (customerlist.SelectedRows.Count >= 0)
            {
                txtID.Text = customerlist.SelectedRows[0].Cells[0].Value.ToString();
                txtCusName.Text = customerlist.SelectedRows[0].Cells[1].Value.ToString();
                txtCusAddress.Text = customerlist.SelectedRows[0].Cells[2].Value.ToString();
                txtCusPhone.Text = customerlist.SelectedRows[0].Cells[3].Value.ToString();
                txtCusEmail.Text = customerlist.SelectedRows[0].Cells[4].Value.ToString();
                dtCusDate.Text = customerlist.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void CustomerPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alfaPetShopDataSet.CustomerTbl' table. You can move, or remove it, as needed.
            this.customerTblTableAdapter.Fill(this.alfaPetShopDataSet.CustomerTbl);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearcustomerdata();
        }

        private void btnCusEdit_Click(object sender, EventArgs e)
        {
            if (txtCusName.Text == "" || txtCusAddress.Text == "" || txtCusPhone.Text == "" || txtCusEmail.Text == "")
            {
                MessageBox.Show("Please Fill All Data");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "update CustomerTbl set CusName='" + txtCusName.Text + "',CusAdd='" + txtCusAddress.Text + "',CusPhone='" + txtCusPhone.Text + "',CusEmail='" + txtCusEmail.Text + "',CusDJ='" + dtCusDate.Text + "' where Cusid='" + txtID.Text + "'";
                    //cmd.Parameters.Add(new SqlParameter("@images", images));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Updated");
                    clearcustomerdata();
                    conn.Close();
                    showcustomerdata();
                    txtCusName.Focus();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnCusDelete_Click(object sender, EventArgs e)
        {
            if (txtCusName.Text == "")
            {
                MessageBox.Show("Please Select Data");
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from customerTbl where Cusid='" + txtID.Text + "'";
                    //cmd.Parameters.Add(new SqlParameter("@images", images));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted");
                    clearcustomerdata();
                    conn.Close();
                    showcustomerdata();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openhome);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openhome()
        {
            Application.Run(new HomePage());
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
