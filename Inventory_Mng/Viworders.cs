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
using System.Drawing.Text;
using System.Drawing.Printing;


namespace Inventory_Mng
{
    public partial class Viworders : Form
    {
        public Viworders()
        {
            InitializeComponent();
            //printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\asp.net\Inventory_Mng\Inventory_Mng\Inventory_jk.mdf;Integrated Security=True");
        void populateorders()
        {
            try
            {
                con.Open();
                string str = "select * from OrderTbl";
                SqlDataAdapter da = new SqlDataAdapter(str, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);

                viewordersGv.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }
      

        private void viewordersGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()== DialogResult.OK)
            {
                printDocument1.Print();
            }
            

           // populateorders();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
           // populateorders();

            this.Hide();
        }

        private void Viworders_Load(object sender, EventArgs e)
        {
            populateorders();
        }

        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // System.Drawing.StringFormat d = new System.Drawing.StringFormat();

            e.Graphics.DrawString("Order Summery",new Font("Centuey", 25,FontStyle.Bold),Brushes.Red,new Point(230));
            e.Graphics.DrawString("Order ID:" + viewordersGv.SelectedRows[0].Cells[0].Value.ToString(), new Font("Centuey", 20, FontStyle.Regular), Brushes.Black, new Point(80, 100));
            e.Graphics.DrawString("Customer ID:" + viewordersGv.SelectedRows[0].Cells[1].Value.ToString(), new Font("Centuey", 20, FontStyle.Regular), Brushes.Black, new Point(80, 136));
            e.Graphics.DrawString("Customer NAME:" + viewordersGv.SelectedRows[0].Cells[2].Value.ToString(), new Font("Centuey", 20, FontStyle.Regular), Brushes.Black, new Point(80, 166));
            e.Graphics.DrawString("Order DATE:" + viewordersGv.SelectedRows[0].Cells[3].Value.ToString(), new Font("Centuey", 20, FontStyle.Regular), Brushes.Black, new Point(80, 199));
            e.Graphics.DrawString("Customer ID" + viewordersGv.SelectedRows[0].Cells[4].Value.ToString(), new Font("Centuey", 20, FontStyle.Regular), Brushes.Black, new Point(80, 226));

            e.Graphics.DrawString("PoweredBy JK Info", new Font("Centuey", 25, FontStyle.Bold), Brushes.Red, new Point(230,350));

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
