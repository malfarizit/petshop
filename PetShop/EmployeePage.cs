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
    public partial class EmployeePage : Form
    {
        Thread th;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6DDLFRC;Initial Catalog=AlfaPetShop;Integrated Security=True");

        public EmployeePage()
        {
            InitializeComponent();
            showemployeedata();
        }

        private void clearemployeedata()
        {
            txtID.Text = "";
            txtEmpName.Text = "";
            txtEmpPhone.Text = "";
            txtEmpPassword.Text = "";
            txtEmpAddress.Text = "";

        }

        private void showemployeedata()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from employeeTbl";
            //cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            dta.Fill(dt);
            EmployeeList.DataSource = dt;
            conn.Close();
        }

        private void btnEmpInsert_Click(object sender, EventArgs e)
        {
            if (txtEmpName.Text == "" || txtEmpAddress.Text == "" || txtEmpPhone.Text == "" || txtEmpPassword.Text == "")
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
                    cmd.CommandText = "insert into [employeeTbl] (EmpName,EmpAdd,EmpDOB,EmpPhone,EmpPass) values ('" + txtEmpName.Text + "', '" + txtEmpAddress.Text + "', '" + dtEmpBirth.Text + "', '" + txtEmpPhone.Text + "', '" + txtEmpPassword.Text + "')";
                    //cmd.Parameters.Add(new SqlParameter("@images", images));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Added");
                    clearemployeedata();
                    conn.Close();
                    showemployeedata();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EmployeePage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alfaPetShopDataSet.EmployeeTbl' table. You can move, or remove it, as needed.
            this.employeeTblTableAdapter.Fill(this.alfaPetShopDataSet.EmployeeTbl);

        }

        int key = 0;
        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView EmployeeList = new DataGridView();
            //if (e.RowIndex >= 0)
            //{
            //    txtID.Text = EmployeeList.SelectedRows[0].Cells[0].Value.ToString();
            //    txtEmpName.Text = EmployeeList.SelectedRows[0].Cells[1].Value.ToString();
            //    txtEmpAddress.Text = EmployeeList.SelectedRows[0].Cells[2].Value.ToString();
            //    dtEmpBirth.Text = EmployeeList.SelectedRows[0].Cells[3].Value.ToString();
            //    txtEmpPhone.Text = EmployeeList.SelectedRows[0].Cells[4].Value.ToString();
            //    txtEmpPassword.Text = EmployeeList.SelectedRows[0].Cells[5].Value.ToString();
            //}
            
            //if (txtEmpName.Text == "")
            //{
            //    key = Convert.ToInt32(EmployeeList.SelectedRows[0].Cells[0].Value.ToString());
            //}

        }

        private void btnEmpEdit_Click(object sender, EventArgs e)
        {
            if (txtEmpName.Text == "" || txtEmpAddress.Text == "" || txtEmpPhone.Text == "" || txtEmpPassword.Text == "")
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
                    cmd.CommandText = "update employeeTbl set EmpName='" + txtEmpName.Text + "',EmpAdd='" + txtEmpAddress.Text + "',EmpDOB='" + dtEmpBirth.Text + "',EmpPhone='" + txtEmpPhone.Text + "',EmpPass='" + txtEmpPassword.Text + "' where EmpNum='" + txtID.Text + "'";
                    //cmd.Parameters.Add(new SqlParameter("@images", images));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated");
                    clearemployeedata();
                    conn.Close();
                    showemployeedata();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void EmployeeList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (EmployeeList.SelectedRows.Count >= 0)
            {
                txtID.Text = EmployeeList.SelectedRows[0].Cells[0].Value.ToString();
                txtEmpName.Text = EmployeeList.SelectedRows[0].Cells[1].Value.ToString();
                txtEmpAddress.Text = EmployeeList.SelectedRows[0].Cells[2].Value.ToString();
                dtEmpBirth.Text = EmployeeList.SelectedRows[0].Cells[3].Value.ToString();
                txtEmpPhone.Text = EmployeeList.SelectedRows[0].Cells[4].Value.ToString();
                txtEmpPassword.Text = EmployeeList.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void btnEmpDelete_Click(object sender, EventArgs e)
        {
            if (txtEmpName.Text == "")
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
                    cmd.CommandText = "delete from employeeTbl where EmpNum='" + txtID.Text + "'";
                    //cmd.Parameters.Add(new SqlParameter("@images", images));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted");
                    clearemployeedata();
                    conn.Close();
                    showemployeedata();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearemployeedata();
            txtEmpName.Focus();
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
