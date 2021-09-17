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
    public partial class ManageCustomer : Form
    {
        public ManageCustomer()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\asp.net\Inventory_Mng\Inventory_Mng\Inventory_jk.mdf;Integrated Security=True");
        //SqlConnection con = new SqlConnection();
        //SqlCommand cmd;
        //string str;
        //SqlDataAdapter da = new SqlDataAdapter();
        //DataSet ds = new DataSet();
        //DataTable dt = new DataTable();

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void btn_customer_add_Click(object sender, EventArgs e)
        {
            insert();
        }

        void populare()
        {
            con.Open();
            string str = "select * from  CustomerTbl";
            SqlDataAdapter da = new SqlDataAdapter(str, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CustomerGv.DataSource = ds.Tables[0];

            con.Close();
        }

        void insert()
        {
            try
            {
                
                con.Open();

                SqlCommand cmd =new SqlCommand( "insert into CustomerTbl values(" + txt_customer_id.Text + ",'" + txt_Customer_name.Text + "','" + txt_customer_mobile.Text + "')",con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Submited..");
                con.Close();
                populare();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void CustomerGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_customer_id.Text = CustomerGv.SelectedRows[0].Cells[0].Value.ToString();
                txt_Customer_name.Text = CustomerGv.SelectedRows[0].Cells[1].Value.ToString();
                txt_customer_mobile.Text = CustomerGv.SelectedRows[0].Cells[2].Value.ToString();

                con.Open();
                
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from OrderTbl where CustID=" + txt_customer_id.Text + "", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                orderslabel1.Text = dt.Rows[0][0].ToString();

                

                SqlDataAdapter sda2 = new SqlDataAdapter("select max(OrderDATE ) from OrderTbl where CustID=" + txt_customer_id.Text+ "", con);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                Datelabel1.Text = dt2.Rows[0][0].ToString();

                con.Close();
                populare();
            }
            catch(Exception ex)
            {

            }
            
        }

        private void btn_Customer_lelete_Click(object sender, EventArgs e)
        {
            dlt();
        }

       
        void dlt()
        {

          
            con.Open();

            if (txt_customer_id.Text == "")
            {
                MessageBox.Show("Enter The Users Customer Id");
            }
            else
            {
                try
                {
                    
                   string str = "delete from CustomerTbl  where CustomerId=" + txt_customer_id.Text + ";";
                   SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Deleted");

                    con.Close();
                    populare();
                }
                catch
                {

                }
            }
        }

        private void btn_customer_Edit_Click(object sender, EventArgs e)
        {
            con.Open();
            // SqlCommand cmd = new SqlCommand ("update CustomerTbl set CustomerName='" + txt_Customer_name.Text + "', CustomerMobile='" + txt_customer_mobile.Text + "' where CustomerId=" + txt_customer_id.Text + ""),con );
            string str1 = "update CustomerTbl set CustomerName='"+txt_Customer_name.Text+"', CustomerMobile='"+txt_customer_mobile.Text+"' where CustomerID="+txt_customer_id+"";
            SqlCommand cmd = new SqlCommand(str1,con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Successfully Updated");
            con.Close();
            populare();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
           
           con.Open();
           string stramt = "select max(TotAmount) as TotAmount from OrderTbl";
           SqlDataAdapter daa = new SqlDataAdapter(stramt, con);
           DataSet dss = new DataSet();
           daa.Fill(dss);

           stramt = dss.Tables[0].Rows[0]["TotAmount"].ToString();
            
            Amountlable1.Text = stramt.ToString();
            con.Close();
            populare();
        }

        private void btn_Customer_home_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
