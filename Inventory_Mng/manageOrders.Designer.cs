
namespace Inventory_Mng
{
    partial class manageOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.customer_list = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_manage_user = new System.Windows.Forms.Label();
            this.CustomerGridview = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Searchcombo = new System.Windows.Forms.ComboBox();
            this.ProductGv = new System.Windows.Forms.DataGridView();
            this.txt_order_id = new System.Windows.Forms.TextBox();
            this.txt_Cust_id = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.QtyTb = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_cst_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TotAmount = new System.Windows.Forms.Label();
            this.btn_view_orser = new System.Windows.Forms.Button();
            this.btn_insert_orders = new System.Windows.Forms.Button();
            this.lbl_order_id = new System.Windows.Forms.Label();
            this.OrderGv = new System.Windows.Forms.DataGridView();
            this.btn_product_home = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGv)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.customer_list);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_manage_user);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1293, 132);
            this.panel1.TabIndex = 3;
            this.panel1.TabStop = true;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // customer_list
            // 
            this.customer_list.AutoSize = true;
            this.customer_list.BackColor = System.Drawing.Color.GhostWhite;
            this.customer_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_list.ForeColor = System.Drawing.Color.Brown;
            this.customer_list.Location = new System.Drawing.Point(388, -164);
            this.customer_list.Name = "customer_list";
            this.customer_list.Size = new System.Drawing.Size(202, 38);
            this.customer_list.TabIndex = 21;
            this.customer_list.Text = "Product List";
            this.customer_list.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(1247, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(310, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(702, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "JK INFO MANAGEMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_manage_user
            // 
            this.lbl_manage_user.AutoSize = true;
            this.lbl_manage_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_manage_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_manage_user.ForeColor = System.Drawing.Color.White;
            this.lbl_manage_user.Location = new System.Drawing.Point(523, 84);
            this.lbl_manage_user.Name = "lbl_manage_user";
            this.lbl_manage_user.Size = new System.Drawing.Size(265, 39);
            this.lbl_manage_user.TabIndex = 0;
            this.lbl_manage_user.Text = "Manage Orders";
            this.lbl_manage_user.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CustomerGridview
            // 
            this.CustomerGridview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomerGridview.ColumnHeadersHeight = 29;
            this.CustomerGridview.GridColor = System.Drawing.Color.PeachPuff;
            this.CustomerGridview.Location = new System.Drawing.Point(12, 183);
            this.CustomerGridview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerGridview.Name = "CustomerGridview";
            this.CustomerGridview.RowHeadersWidth = 51;
            this.CustomerGridview.RowTemplate.Height = 24;
            this.CustomerGridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerGridview.Size = new System.Drawing.Size(528, 226);
            this.CustomerGridview.TabIndex = 20;
            this.CustomerGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerGridview_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(125, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 38);
            this.label3.TabIndex = 21;
            this.label3.Text = "Customer List";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Searchcombo
            // 
            this.Searchcombo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Searchcombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchcombo.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.Searchcombo.FormattingEnabled = true;
            this.Searchcombo.Location = new System.Drawing.Point(881, 144);
            this.Searchcombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Searchcombo.Name = "Searchcombo";
            this.Searchcombo.Size = new System.Drawing.Size(192, 30);
            this.Searchcombo.TabIndex = 22;
            this.Searchcombo.Text = "Select Categories";
            this.Searchcombo.SelectionChangeCommitted += new System.EventHandler(this.Searchcombo_SelectionChangeCommitted);
            // 
            // ProductGv
            // 
            this.ProductGv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGv.GridColor = System.Drawing.Color.PeachPuff;
            this.ProductGv.Location = new System.Drawing.Point(547, 183);
            this.ProductGv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductGv.Name = "ProductGv";
            this.ProductGv.RowHeadersWidth = 51;
            this.ProductGv.RowTemplate.Height = 24;
            this.ProductGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGv.Size = new System.Drawing.Size(735, 226);
            this.ProductGv.TabIndex = 23;
            this.ProductGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGv_CellContentClick);
            // 
            // txt_order_id
            // 
            this.txt_order_id.BackColor = System.Drawing.Color.White;
            this.txt_order_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_order_id.ForeColor = System.Drawing.Color.Blue;
            this.txt_order_id.Location = new System.Drawing.Point(288, 451);
            this.txt_order_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_order_id.Name = "txt_order_id";
            this.txt_order_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_order_id.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_order_id.Size = new System.Drawing.Size(217, 36);
            this.txt_order_id.TabIndex = 24;
            this.txt_order_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Cust_id
            // 
            this.txt_Cust_id.BackColor = System.Drawing.Color.White;
            this.txt_Cust_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Cust_id.Enabled = false;
            this.txt_Cust_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cust_id.ForeColor = System.Drawing.Color.Blue;
            this.txt_Cust_id.Location = new System.Drawing.Point(288, 507);
            this.txt_Cust_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Cust_id.Name = "txt_Cust_id";
            this.txt_Cust_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Cust_id.Size = new System.Drawing.Size(215, 36);
            this.txt_Cust_id.TabIndex = 25;
            this.txt_Cust_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Crimson;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.LightSteelBlue;
            this.dateTimePicker1.Location = new System.Drawing.Point(288, 628);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 22);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // QtyTb
            // 
            this.QtyTb.BackColor = System.Drawing.Color.White;
            this.QtyTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QtyTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QtyTb.ForeColor = System.Drawing.Color.Blue;
            this.QtyTb.Location = new System.Drawing.Point(745, 411);
            this.QtyTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(167, 32);
            this.QtyTb.TabIndex = 28;
            this.QtyTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QtyTb.TextChanged += new System.EventHandler(this.txt_Qty_TextChanged);
            // 
            // Quantity
            // 
            this.Quantity.BackColor = System.Drawing.Color.Crimson;
            this.Quantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.ForeColor = System.Drawing.Color.White;
            this.Quantity.Location = new System.Drawing.Point(625, 410);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(115, 36);
            this.Quantity.TabIndex = 29;
            this.Quantity.Text = "Quantity";
            this.Quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(917, 410);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 36);
            this.button1.TabIndex = 30;
            this.button1.Text = "Add To Order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(1, 776);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1293, 25);
            this.panel2.TabIndex = 32;
            // 
            // txt_cst_name
            // 
            this.txt_cst_name.BackColor = System.Drawing.Color.White;
            this.txt_cst_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cst_name.Enabled = false;
            this.txt_cst_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cst_name.ForeColor = System.Drawing.Color.Blue;
            this.txt_cst_name.Location = new System.Drawing.Point(288, 564);
            this.txt_cst_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cst_name.Name = "txt_cst_name";
            this.txt_cst_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_cst_name.Size = new System.Drawing.Size(215, 36);
            this.txt_cst_name.TabIndex = 33;
            this.txt_cst_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(643, 722);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 38);
            this.label5.TabIndex = 34;
            this.label5.Text = "Total Amount";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TotAmount
            // 
            this.TotAmount.AutoSize = true;
            this.TotAmount.BackColor = System.Drawing.Color.GhostWhite;
            this.TotAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotAmount.ForeColor = System.Drawing.Color.Black;
            this.TotAmount.Location = new System.Drawing.Point(884, 724);
            this.TotAmount.Name = "TotAmount";
            this.TotAmount.Size = new System.Drawing.Size(60, 38);
            this.TotAmount.TabIndex = 35;
            this.TotAmount.Text = "Rs";
            this.TotAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_view_orser
            // 
            this.btn_view_orser.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_view_orser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_orser.ForeColor = System.Drawing.Color.Black;
            this.btn_view_orser.Location = new System.Drawing.Point(251, 682);
            this.btn_view_orser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_view_orser.Name = "btn_view_orser";
            this.btn_view_orser.Size = new System.Drawing.Size(199, 36);
            this.btn_view_orser.TabIndex = 36;
            this.btn_view_orser.Text = "View Order";
            this.btn_view_orser.UseVisualStyleBackColor = false;
            this.btn_view_orser.Click += new System.EventHandler(this.btn_view_orser_Click);
            // 
            // btn_insert_orders
            // 
            this.btn_insert_orders.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_insert_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert_orders.ForeColor = System.Drawing.Color.Black;
            this.btn_insert_orders.Location = new System.Drawing.Point(16, 682);
            this.btn_insert_orders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_insert_orders.Name = "btn_insert_orders";
            this.btn_insert_orders.Size = new System.Drawing.Size(199, 36);
            this.btn_insert_orders.TabIndex = 37;
            this.btn_insert_orders.Text = "Insert Order";
            this.btn_insert_orders.UseVisualStyleBackColor = false;
            this.btn_insert_orders.Click += new System.EventHandler(this.btn_insert_orders_Click);
            // 
            // lbl_order_id
            // 
            this.lbl_order_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_order_id.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_id.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_order_id.Location = new System.Drawing.Point(26, 451);
            this.lbl_order_id.Name = "lbl_order_id";
            this.lbl_order_id.Size = new System.Drawing.Size(195, 36);
            this.lbl_order_id.TabIndex = 39;
            this.lbl_order_id.Text = "Order ID";
            this.lbl_order_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrderGv
            // 
            this.OrderGv.BackgroundColor = System.Drawing.Color.White;
            this.OrderGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGv.Location = new System.Drawing.Point(547, 450);
            this.OrderGv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderGv.Name = "OrderGv";
            this.OrderGv.RowHeadersWidth = 51;
            this.OrderGv.RowTemplate.Height = 24;
            this.OrderGv.Size = new System.Drawing.Size(735, 270);
            this.OrderGv.TabIndex = 31;
            this.OrderGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGv_CellContentClick);
            // 
            // btn_product_home
            // 
            this.btn_product_home.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_product_home.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_product_home.FlatAppearance.BorderSize = 0;
            this.btn_product_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product_home.Location = new System.Drawing.Point(168, 722);
            this.btn_product_home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_product_home.Name = "btn_product_home";
            this.btn_product_home.Size = new System.Drawing.Size(114, 38);
            this.btn_product_home.TabIndex = 40;
            this.btn_product_home.Text = "HOME";
            this.btn_product_home.UseVisualStyleBackColor = false;
            this.btn_product_home.Click += new System.EventHandler(this.btn_product_home_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(12, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 36);
            this.label6.TabIndex = 41;
            this.label6.Text = "Customer ID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(12, 564);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 36);
            this.label7.TabIndex = 42;
            this.label7.Text = "Customer Name";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(6, 614);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 36);
            this.label4.TabIndex = 43;
            this.label4.Text = "Order Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Developed By :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Cyan;
            this.label9.Location = new System.Drawing.Point(123, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "TS Infotech";
            // 
            // manageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1296, 800);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_product_home);
            this.Controls.Add(this.lbl_order_id);
            this.Controls.Add(this.btn_insert_orders);
            this.Controls.Add(this.btn_view_orser);
            this.Controls.Add(this.TotAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_cst_name);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.OrderGv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.QtyTb);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_Cust_id);
            this.Controls.Add(this.txt_order_id);
            this.Controls.Add(this.ProductGv);
            this.Controls.Add(this.Searchcombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CustomerGridview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "manageOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "manageOrders";
            this.Load += new System.EventHandler(this.manageOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_manage_user;
        private System.Windows.Forms.Label customer_list;
        private System.Windows.Forms.DataGridView CustomerGridview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Searchcombo;
        private System.Windows.Forms.DataGridView ProductGv;
        private System.Windows.Forms.TextBox txt_order_id;
        private System.Windows.Forms.TextBox txt_Cust_id;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox QtyTb;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_cst_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TotAmount;
        private System.Windows.Forms.Button btn_view_orser;
        private System.Windows.Forms.Button btn_insert_orders;
        private System.Windows.Forms.Label lbl_order_id;
        private System.Windows.Forms.DataGridView OrderGv;
        private System.Windows.Forms.Button btn_product_home;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}