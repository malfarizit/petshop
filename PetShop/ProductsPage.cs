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
    public partial class ProductsPage : Form
    {
        string category;
        Thread th;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6DDLFRC;Initial Catalog=AlfaPetShop;Integrated Security=True");
        public ProductsPage()
        {
            InitializeComponent();
            showproductdata();
        }

        private void clearproductdata()
        {
            txtID.Text = "";
            txtProdName.Text = "";
            txtProdPrice.Text = "";
            txtProdQty.Text = "";
            cmbProdCat.Text = "";
        }

        private void showproductdata()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from ProductTbl";
            //cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter(cmd);
            dta.Fill(dt);
            productList.DataSource = dt;
            conn.Close();
        }

        private void btnProdSave_Click(object sender, EventArgs e)
        {
            if (txtProdName.Text == "" || txtProdPrice.Text == "" || cmbProdCat.SelectedIndex == -1 || txtProdQty.Text == "")
            {
                MessageBox.Show("Please Fill All Data");
            }
            else
            {
                try
                {
                    category = cmbProdCat.Text;
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into [ProductTbl] (ProdName,ProdCat,ProdQty,ProdPrice) values ('" + txtProdName.Text + "', '" + category + "', '" + txtProdQty.Text + "', '" + txtProdPrice.Text + "')";
                    //cmd.Parameters.Add(new SqlParameter("@images", images));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Added");
                    clearproductdata();
                    conn.Close();
                    showproductdata();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearproductdata();
            txtProdName.Focus();
        }

        private void btnProdEdit_Click(object sender, EventArgs e)
        {
            if (txtProdName.Text == "" || txtProdPrice.Text == "" || txtProdQty.Text == "" || cmbProdCat.SelectedIndex == -1)
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
                    cmd.CommandText = "update ProductTbl set ProdName='" + txtProdName.Text + "',ProdCat='" + cmbProdCat.Text + "',ProdQty='" + txtProdQty.Text + "',ProdPrice='" + txtProdPrice.Text + "'";
                    //cmd.Parameters.Add(new SqlParameter("@images", images));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated");
                    clearproductdata();
                    conn.Close();
                    showproductdata();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void productList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (productList.SelectedRows.Count >= 0)
            {
                txtID.Text = productList.SelectedRows[0].Cells[0].Value.ToString();
                txtProdName.Text = productList.SelectedRows[0].Cells[1].Value.ToString();
                cmbProdCat.Text = productList.SelectedRows[0].Cells[2].Value.ToString();
                txtProdQty.Text = productList.SelectedRows[0].Cells[3].Value.ToString();
                txtProdPrice.Text = productList.SelectedRows[0].Cells[4].Value.ToString();
                
            }
        }

        private void ProductsPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alfaPetShopDataSet.ProductTbl' table. You can move, or remove it, as needed.
            this.productTblTableAdapter.Fill(this.alfaPetShopDataSet.ProductTbl);

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
