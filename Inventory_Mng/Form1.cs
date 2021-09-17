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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection
        (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\asp.net\Inventory_Mng\Inventory_Mng\Inventory_jk.mdf;Integrated Security=True");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox_login_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_login.Checked)
            {
                txt_login_password.UseSystemPasswordChar = true;
                var checkbox = (CheckBox)sender;
                checkbox.Text = "View";
            }
            else
            {
                txt_login_password.UseSystemPasswordChar = true;
                var checkbox = (CheckBox)sender;
                checkbox.Text = "Hide";
            }
            
        }

        private void lbl_login_clrar_Click(object sender, EventArgs e)
        {
            txt_login_username.Text = "";
            txt_login_password.Text = "";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select Count(*) from Userdata  where Uname='" + txt_login_username.Text + "'  and Upassword='" + txt_login_password.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                HomeForm home = new HomeForm();
                home.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Wrong Username Or Password");
            }

            con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_login_password_TextChanged(object sender, EventArgs e)
        {
            InitializeMyControl();
           
        }
        private void InitializeMyControl()
        {
           // txt_login_password = " ";
            txt_login_password.PasswordChar = '*';
            txt_login_password.MaxLength = 12;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
