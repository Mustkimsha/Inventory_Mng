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

namespace Inventory_Mng
{
    public partial class ManageProduct : Form
    {
        public ManageProduct()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\asp.net\Inventory_Mng\Inventory_Mng\Inventory_jk.mdf;Integrated Security=True");
        void fillcategories()
        {
            string str = "select * from CategoriesTbl";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader sdr;

            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                CatCombo.ValueMember = "CatName";
                CatCombo.DataSource = dt;
                Search_comboBox.ValueMember = "CatName";
                Search_comboBox.DataSource = dt;
                con.Close();

            }catch(Exception ex) { }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void populate()
        {
            try
            {
                con.Open();
                string str = "select * from ProductTbl";
                SqlDataAdapter da = new SqlDataAdapter(str, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);

                ProductGV.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }
        private void ManageProduct_Load(object sender, EventArgs e)
        {

            fillcategories();
            filterbycategory();
            populate();
        }

        private void btn_product_add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into ProductTbl values(" + txt_product_id.Text + ",'" + txt_product_name.Text + "'," + txt_product_qty.Text + "," + txt_product_price.Text + ",'" + txt_product_description.Text + "','" + CatCombo.SelectedValue.ToString() + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Submit Successfully");
                con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void btn_product_lelete_Click(object sender, EventArgs e)
        {
            try 
            {
                if(txt_product_id.Text=="")
                {
                    MessageBox.Show("Enter The Product Id");
                }
                else
                {
                    con.Open();
                    string str = "delete from ProductTbl where ProdID=" + txt_product_id.Text + ";";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Deleted Successfully");
                    con.Close();
                    populate();
                }

                
            }
            catch
            {

            }
        }

        private void btn_edit_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update ProductTbl set Prod_NAME='" + txt_product_name.Text + "',ProdQTY=" + txt_product_qty.Text + ", Prod_Price=" + txt_product_price.Text + ", Prod_Desc='" + txt_product_description.Text + "', Prod_CAt='" + CatCombo.SelectedValue.ToString() + "' where ProdID=" + txt_product_id.Text + " ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully");
                con.Close();
                populate();
            }
            catch
            {

            }
        }

        void filterbycategory()
        {
            try
            {
                con.Open();
                string str = "select * from ProductTbl where Prod_CAt='"+Search_comboBox.SelectedValue.ToString()+"'";
                SqlDataAdapter da = new SqlDataAdapter(str, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);

                ProductGV.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }
        void fillsearchcombo()
        {
            string str = "select * from CategoriesTbl where CatName='" + Search_comboBox.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader sdr;

            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                Search_comboBox.ValueMember = "CatName";
                Search_comboBox.DataSource = dt;
                con.Close();

            }
            catch (Exception ex) { }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            filterbycategory();
           
        }

        private void customer_list_Click(object sender, EventArgs e)
        {

        }

        private void ProductGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_product_id.Text = ProductGV.SelectedRows[0].Cells[0].Value.ToString();
            txt_product_name.Text= ProductGV.SelectedRows[0].Cells[1].Value.ToString();
            txt_product_qty.Text= ProductGV.SelectedRows[0].Cells[2].Value.ToString();
            txt_product_price.Text= ProductGV.SelectedRows[0].Cells[3].Value.ToString();
            txt_product_description.Text= ProductGV.SelectedRows[0].Cells[4].Value.ToString();
            CatCombo.SelectedValue= ProductGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void btn_product_home_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void Search_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterbycategory();
        }
    }
}
