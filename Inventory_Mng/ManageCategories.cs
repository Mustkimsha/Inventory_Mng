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
using System.IO;

namespace Inventory_Mng
{
   
    public partial class ManageCategories : Form
    {

        SqlConnection con = new SqlConnection();
        SqlCommand cmd;
        string str;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        public ManageCategories()
        {
            InitializeComponent();


            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\asp.net\Inventory_Mng\Inventory_Mng\Inventory_jk.mdf;Integrated Security=True";
           
        }

            
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        void populate()
        {
            con.Open();
            str = "select * from CategoriesTbl";
            da = new SqlDataAdapter(str, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Fill(ds);

            CategoriesGV.DataSource = ds.Tables[0];
            con.Close();
        }
      

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_Categories_id.Text = CategoriesGV.SelectedRows[0].Cells[0].Value.ToString();               txt_Categoris_name.Text = CategoriesGV.SelectedRows[0].Cells[1].ToString(); ;
                txt_Categoris_name.Text = CategoriesGV.SelectedRows[0].Cells[1].Value.ToString();
                
            }
            catch (Exception ex){ }
        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            populate();
        }

       

        private void btn_categories_Edit_Click(object sender, EventArgs e)
        {
            str = "select * from CategoriesTbl";
            da = new SqlDataAdapter(str, con);
            da.Fill(ds);

            
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update CategoriesTbl set CatName='" + txt_Categoris_name.Text + "' where CatID=" + txt_Categories_id.Text + "", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Updated Successfully");
                    con.Close();
                    populate();
                }
                catch (Exception ex)
                {

                }
        }

        private void btn_categories_home_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void customer_list_Click(object sender, EventArgs e)
        {

        }

        private void txt_Categories_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_categories_home_Click_1(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void btn_categories_add_Click_1(object sender, EventArgs e)
        {
            try
            {

                str = "insert into CategoriesTbl values(" + txt_Categories_id.Text + ",'" + txt_Categoris_name.Text + "')";
                cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Submeted Successfully");
                con.Close();
                populate();
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_categories_delete_Click_1(object sender, EventArgs e)
        {
            if (txt_Categories_id.Text == "")
            {
                MessageBox.Show("Enter The Categories Id");
            }
            else
            {
                try
                {
                    con.Open();
                    str = "delete from CategoriesTbl where CatID='" + txt_Categories_id.Text + "'";
                    cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Deleted");
                    con.Close();
                    populate();
                }
                catch
                {

                }
            }
        }
    }
}
