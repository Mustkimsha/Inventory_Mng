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
using System.Dynamic;
using System.IO;
using System.Windows;

namespace Inventory_Mng
{
    public partial class manageOrders : Form
    {
        public manageOrders()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\asp.net\Inventory_Mng\Inventory_Mng\Inventory_jk.mdf;Integrated Security=True");
        void populate()
        {
            try
            {
                con.Open();
                string str = "select * from CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(str, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);

                CustomerGridview.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }

        void populateProduct()
        {
            try
            {
                con.Open();
                string str = "select * from ProductTbl";
                SqlDataAdapter da = new SqlDataAdapter(str, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);

                ProductGv.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }

        DataTable table = new DataTable();

        private void manageOrders_Load(object sender, EventArgs e)
        {
            populate();
            populateProduct();
            fillcategories();
           

            table.Columns.Add("Num", typeof(int));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("quntiti", typeof(int));
            table.Columns.Add("Uprice", typeof(int));
            table.Columns.Add("totprice", typeof(int));

            OrderGv.DataSource = table;

        }
        private void CustomerGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Cust_id.Text = CustomerGridview.SelectedRows[0].Cells[0].Value.ToString();
            txt_cst_name.Text=CustomerGridview.SelectedRows[0].Cells[1].Value.ToString();


        }
        int flag = 0;
        int stock;
        int num = 0;
        int uprice, totprice, qty;
        string product;
        private void ProductGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             product = ProductGv.SelectedRows[0].Cells[1].Value.ToString();
          //  qty = Convert.ToInt32(QtyTb.Text);
            stock = Convert.ToInt32(ProductGv.SelectedRows[0].Cells[2].Value.ToString());
            uprice = Convert.ToInt32(ProductGv.SelectedRows[0].Cells[3].Value.ToString());
           

           //totprice = qty + uprice;
            flag = 1;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            int sum = 0;
            if (QtyTb.Text == "")
            {
                MessageBox.Show("Enter the Qty of The Product");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select The Product");
            }
            else if (Convert.ToInt32(QtyTb.Text) > stock)
            {
                MessageBox.Show("No enough Stock Available");
            }
            else
            {

                num = num + 1;

                qty = Convert.ToInt32(QtyTb.Text);

                totprice = qty + uprice;

                table.Rows.Add(num, product, qty, uprice, totprice);
                OrderGv.DataSource = table;
                flag = 0;
                sum = sum + totprice;

                TotAmount.Text="Rs"+sum.ToString();

            }
            updateproduct();
        }


        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

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
                //comboBox1.ValueMember = "CatName";
                //comboBox1.DataSource = dt;
                Searchcombo.ValueMember = "CatName";
                Searchcombo.DataSource = dt;
                con.Close();

            }
            catch (Exception ex) { }
        }


        void updateproduct()
        {


            

            int newqty = stock - Convert.ToInt32(QtyTb.Text);
            int Id = Convert.ToInt32(ProductGv.SelectedRows[0].Cells[0].Value.ToString());
            if (newqty < 0)
                MessageBox.Show("Operation faild");
            else
            {


                con.Open();
                string query = "update ProductTbl set ProdQTY=" + newqty + " where  ProdID=" + Id + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                con.Close();
                populateProduct();
            }
        }




        void filterbycategory()
        {
            try
            {
                con.Open();
                string str = "select * from ProductTbl where Prod_CAt='" + Searchcombo.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(str, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);

                ProductGv.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }

        private void btn_insert_orders_Click(object sender, EventArgs e)
        {
            if(txt_order_id.Text=="" ||txt_Cust_id.Text==""|| txt_cst_name.Text==""|| TotAmount.Text=="")
            {
                MessageBox.Show("Fill The  data Correctly"); 
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into OrderTbl values(" + txt_order_id.Text + "," + txt_Cust_id.Text + ",'" + txt_cst_name.Text + "','"+dateTimePicker1.Text+"','" + TotAmount.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Sucessfull");
                con.Close();
              ///  populate();
                try
                {

                }
                catch
                {

                }
            }
        }

        private void OrderGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_view_orser_Click(object sender, EventArgs e)
        {
            Viworders view = new Viworders();
            view.Show();
        }

        private void btn_product_home_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_Qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void Searchcombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterbycategory();
        }
    }
}
