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
    public partial class manageuser : Form
    {
        //SqlConnection con = new SqlConnection();
        //SqlCommand cmd;
        //string str;
        //SqlDataAdapter da = new SqlDataAdapter();
        //DataSet ds = new DataSet();
        //DataTable dt = new DataTable();

       
        //con.ConnectionString = "Data Source=JAYESH\\SQLEXPRESS;Initial Catalog=Inventory;Integrated Security=True";
        public manageuser()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\asp.net\Inventory_Mng\Inventory_Mng\Inventory_jk.mdf;Integrated Security=True");
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
               // SqlCommand cmd = new SqlCommand("insert into ProductTbl values('" + txt_username.Text + "','" + txt_fullname.Text + "','" + txt_pass.Text + "','" + txt_moile.Text + "')", con);
               // cmd.ExecuteNonQuery();
                string    str = "insert into UserTbl values('"+txt_username.Text+"','"+txt_fullname.Text+"','"+txt_pass.Text+"','"+txt_moile.Text+"')";
                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Submit Successfully");
                Populare();

            }
            catch (Exception ex)
            {
                
                
            }
        }

        

        

public void Populare()
        {

            try
            {

                con.Open();
                string str = "select * from UserTbl";
                SqlDataAdapter da = new SqlDataAdapter(str, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);

                UserGridview.DataSource = ds.Tables[0];
                con.Close();
                

            }
            catch(Exception ex)
            {

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(txt_moile.Text == "")
            {
                MessageBox.Show("Enter The Users Mobile No");
            }
            else
            {
                try
                {
                    con.Open();
                    string str = "delete from UserTbl where Prod_ID='" + txt_moile.Text + "';";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();

                    //str = "delete from UserTbl where Umobile='" + txt_moile.Text + "'";
                    //cmd = new SqlCommand(str, con);
                    //cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Deleted");

                    con.Close();
                    Populare();
                }
                catch
                {

                }
            }
        }

        private void UserGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
                txt_username.Text= UserGridview.SelectedRows[0].Cells[0].Value.ToString();
                txt_fullname.Text = UserGridview.SelectedRows[0].Cells[1].Value.ToString();
                txt_pass.Text = UserGridview.SelectedRows[0].Cells[2].Value.ToString();
                txt_moile.Text = UserGridview.SelectedRows[0].Cells[3].Value.ToString();
            
            
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            //str = "select * from UserTbl";
            //da = new SqlDataAdapter(str, con);
            //da.Fill(ds);

            if (txt_moile.Text == "")
            {
                MessageBox.Show("Enter the user mobile number");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update UserTbl set Uname='" + txt_username.Text + "',Ufullname='"+txt_fullname.Text+"', Upassword='" + txt_pass.Text + "' where Umobile='" + txt_moile.Text + "'", con);
                    //string str1 = "update UserTbl set Uname='" + txt_username.Text + "', Ufullname='" + txt_fullname.Text + "', Upassword='" + txt_pass.Text + "' where Umobile='" + txt_moile.Text + "'";
                   // cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Successfully");
                    con.Close();
                    Populare();
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void label2_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void manageuser_Load(object sender, EventArgs e)
        {
            Populare();
        }
    }
}
