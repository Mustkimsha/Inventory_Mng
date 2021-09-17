
namespace Inventory_Mng
{
    partial class ManageProduct
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_manage_user = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_product_name = new System.Windows.Forms.TextBox();
            this.txt_product_qty = new System.Windows.Forms.TextBox();
            this.txt_product_price = new System.Windows.Forms.TextBox();
            this.txt_product_id = new System.Windows.Forms.TextBox();
            this.txt_product_description = new System.Windows.Forms.TextBox();
            this.CatCombo = new System.Windows.Forms.ComboBox();
            this.ProductGV = new System.Windows.Forms.DataGridView();
            this.customer_list = new System.Windows.Forms.Label();
            this.btn_product_home = new System.Windows.Forms.Button();
            this.btn_product_lelete = new System.Windows.Forms.Button();
            this.btn_edit_Edit = new System.Windows.Forms.Button();
            this.btn_product_add = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.BTN_SEARCH = new System.Windows.Forms.Button();
            this.Search_comboBox = new System.Windows.Forms.ComboBox();
            this.lbl_order_id = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_manage_user);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 128);
            this.panel1.TabIndex = 2;
            this.panel1.TabStop = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(1253, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 44);
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
            this.label1.Location = new System.Drawing.Point(303, 19);
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
            this.lbl_manage_user.Location = new System.Drawing.Point(505, 77);
            this.lbl_manage_user.Name = "lbl_manage_user";
            this.lbl_manage_user.Size = new System.Drawing.Size(280, 39);
            this.lbl_manage_user.TabIndex = 0;
            this.lbl_manage_user.Text = "Manage Product";
            this.lbl_manage_user.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 777);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1296, 23);
            this.panel2.TabIndex = 12;
            // 
            // txt_product_name
            // 
            this.txt_product_name.BackColor = System.Drawing.Color.White;
            this.txt_product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_name.ForeColor = System.Drawing.Color.Blue;
            this.txt_product_name.Location = new System.Drawing.Point(311, 293);
            this.txt_product_name.Name = "txt_product_name";
            this.txt_product_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_product_name.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_product_name.Size = new System.Drawing.Size(192, 36);
            this.txt_product_name.TabIndex = 16;
            this.txt_product_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_product_qty
            // 
            this.txt_product_qty.BackColor = System.Drawing.Color.White;
            this.txt_product_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_qty.ForeColor = System.Drawing.Color.Blue;
            this.txt_product_qty.Location = new System.Drawing.Point(311, 350);
            this.txt_product_qty.Name = "txt_product_qty";
            this.txt_product_qty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_product_qty.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_product_qty.Size = new System.Drawing.Size(192, 36);
            this.txt_product_qty.TabIndex = 15;
            this.txt_product_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_product_price
            // 
            this.txt_product_price.BackColor = System.Drawing.Color.White;
            this.txt_product_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_price.ForeColor = System.Drawing.Color.Blue;
            this.txt_product_price.Location = new System.Drawing.Point(311, 408);
            this.txt_product_price.Name = "txt_product_price";
            this.txt_product_price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_product_price.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_product_price.Size = new System.Drawing.Size(192, 36);
            this.txt_product_price.TabIndex = 14;
            this.txt_product_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_product_id
            // 
            this.txt_product_id.BackColor = System.Drawing.Color.White;
            this.txt_product_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_id.ForeColor = System.Drawing.Color.Blue;
            this.txt_product_id.Location = new System.Drawing.Point(311, 235);
            this.txt_product_id.Name = "txt_product_id";
            this.txt_product_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_product_id.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_product_id.Size = new System.Drawing.Size(192, 36);
            this.txt_product_id.TabIndex = 13;
            this.txt_product_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_product_description
            // 
            this.txt_product_description.BackColor = System.Drawing.Color.White;
            this.txt_product_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product_description.ForeColor = System.Drawing.Color.Blue;
            this.txt_product_description.Location = new System.Drawing.Point(311, 457);
            this.txt_product_description.Name = "txt_product_description";
            this.txt_product_description.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_product_description.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_product_description.Size = new System.Drawing.Size(192, 36);
            this.txt_product_description.TabIndex = 17;
            this.txt_product_description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CatCombo
            // 
            this.CatCombo.FormattingEnabled = true;
            this.CatCombo.Location = new System.Drawing.Point(311, 523);
            this.CatCombo.Name = "CatCombo";
            this.CatCombo.Size = new System.Drawing.Size(192, 24);
            this.CatCombo.TabIndex = 18;
            // 
            // ProductGV
            // 
            this.ProductGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGV.GridColor = System.Drawing.Color.PeachPuff;
            this.ProductGV.Location = new System.Drawing.Point(540, 233);
            this.ProductGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ProductGV.Name = "ProductGV";
            this.ProductGV.RowHeadersWidth = 51;
            this.ProductGV.RowTemplate.Height = 24;
            this.ProductGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGV.Size = new System.Drawing.Size(722, 422);
            this.ProductGV.TabIndex = 11;
            this.ProductGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGV_CellContentClick);
            // 
            // customer_list
            // 
            this.customer_list.AutoSize = true;
            this.customer_list.BackColor = System.Drawing.Color.Transparent;
            this.customer_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_list.ForeColor = System.Drawing.Color.Brown;
            this.customer_list.Location = new System.Drawing.Point(766, 150);
            this.customer_list.Name = "customer_list";
            this.customer_list.Size = new System.Drawing.Size(202, 38);
            this.customer_list.TabIndex = 19;
            this.customer_list.Text = "Product List";
            this.customer_list.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customer_list.Click += new System.EventHandler(this.customer_list_Click);
            // 
            // btn_product_home
            // 
            this.btn_product_home.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_product_home.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_product_home.FlatAppearance.BorderSize = 0;
            this.btn_product_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product_home.Location = new System.Drawing.Point(176, 649);
            this.btn_product_home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_product_home.Name = "btn_product_home";
            this.btn_product_home.Size = new System.Drawing.Size(74, 29);
            this.btn_product_home.TabIndex = 23;
            this.btn_product_home.Text = "HOME";
            this.btn_product_home.UseVisualStyleBackColor = false;
            this.btn_product_home.Click += new System.EventHandler(this.btn_product_home_Click);
            // 
            // btn_product_lelete
            // 
            this.btn_product_lelete.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_product_lelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_product_lelete.FlatAppearance.BorderSize = 0;
            this.btn_product_lelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product_lelete.Location = new System.Drawing.Point(286, 588);
            this.btn_product_lelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_product_lelete.Name = "btn_product_lelete";
            this.btn_product_lelete.Size = new System.Drawing.Size(92, 31);
            this.btn_product_lelete.TabIndex = 22;
            this.btn_product_lelete.Text = "DELETE";
            this.btn_product_lelete.UseVisualStyleBackColor = false;
            this.btn_product_lelete.Click += new System.EventHandler(this.btn_product_lelete_Click);
            // 
            // btn_edit_Edit
            // 
            this.btn_edit_Edit.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_edit_Edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_edit_Edit.FlatAppearance.BorderSize = 0;
            this.btn_edit_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_Edit.Location = new System.Drawing.Point(176, 588);
            this.btn_edit_Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_edit_Edit.Name = "btn_edit_Edit";
            this.btn_edit_Edit.Size = new System.Drawing.Size(74, 31);
            this.btn_edit_Edit.TabIndex = 21;
            this.btn_edit_Edit.Text = "EDIT";
            this.btn_edit_Edit.UseVisualStyleBackColor = false;
            this.btn_edit_Edit.Click += new System.EventHandler(this.btn_edit_Edit_Click);
            // 
            // btn_product_add
            // 
            this.btn_product_add.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_product_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_product_add.FlatAppearance.BorderSize = 0;
            this.btn_product_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product_add.Location = new System.Drawing.Point(53, 588);
            this.btn_product_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_product_add.Name = "btn_product_add";
            this.btn_product_add.Size = new System.Drawing.Size(70, 31);
            this.btn_product_add.TabIndex = 20;
            this.btn_product_add.Text = "ADD";
            this.btn_product_add.UseVisualStyleBackColor = false;
            this.btn_product_add.Click += new System.EventHandler(this.btn_product_add_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_refresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_refresh.FlatAppearance.BorderSize = 0;
            this.btn_refresh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(1002, 191);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(141, 40);
            this.btn_refresh.TabIndex = 29;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = false;
            // 
            // BTN_SEARCH
            // 
            this.BTN_SEARCH.BackColor = System.Drawing.Color.DarkOrange;
            this.BTN_SEARCH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTN_SEARCH.FlatAppearance.BorderSize = 0;
            this.BTN_SEARCH.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_SEARCH.ForeColor = System.Drawing.Color.White;
            this.BTN_SEARCH.Location = new System.Drawing.Point(843, 190);
            this.BTN_SEARCH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_SEARCH.Name = "BTN_SEARCH";
            this.BTN_SEARCH.Size = new System.Drawing.Size(134, 41);
            this.BTN_SEARCH.TabIndex = 28;
            this.BTN_SEARCH.Text = "SEARCH";
            this.BTN_SEARCH.UseVisualStyleBackColor = false;
            // 
            // Search_comboBox
            // 
            this.Search_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_comboBox.FormattingEnabled = true;
            this.Search_comboBox.Location = new System.Drawing.Point(636, 191);
            this.Search_comboBox.Name = "Search_comboBox";
            this.Search_comboBox.Size = new System.Drawing.Size(192, 30);
            this.Search_comboBox.TabIndex = 27;
            this.Search_comboBox.SelectedIndexChanged += new System.EventHandler(this.Search_comboBox_SelectedIndexChanged);
            // 
            // lbl_order_id
            // 
            this.lbl_order_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_order_id.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_order_id.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_order_id.Location = new System.Drawing.Point(24, 233);
            this.lbl_order_id.Name = "lbl_order_id";
            this.lbl_order_id.Size = new System.Drawing.Size(195, 36);
            this.lbl_order_id.TabIndex = 40;
            this.lbl_order_id.Text = "Product ID";
            this.lbl_order_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(24, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 36);
            this.label3.TabIndex = 41;
            this.label3.Text = "Product Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(24, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 36);
            this.label4.TabIndex = 42;
            this.label4.Text = "Quantity";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(24, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 36);
            this.label5.TabIndex = 43;
            this.label5.Text = "Price";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(24, 457);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 36);
            this.label6.TabIndex = 44;
            this.label6.Text = "Description";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(24, 511);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 36);
            this.label7.TabIndex = 45;
            this.label7.Text = "Categories";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Cyan;
            this.label9.Location = new System.Drawing.Point(123, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "TS Infotech";
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
            this.label8.TabIndex = 46;
            this.label8.Text = "Developed By :";
            // 
            // ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1296, 800);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_order_id);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.BTN_SEARCH);
            this.Controls.Add(this.Search_comboBox);
            this.Controls.Add(this.btn_product_home);
            this.Controls.Add(this.btn_product_lelete);
            this.Controls.Add(this.btn_edit_Edit);
            this.Controls.Add(this.btn_product_add);
            this.Controls.Add(this.customer_list);
            this.Controls.Add(this.ProductGV);
            this.Controls.Add(this.CatCombo);
            this.Controls.Add(this.txt_product_description);
            this.Controls.Add(this.txt_product_name);
            this.Controls.Add(this.txt_product_qty);
            this.Controls.Add(this.txt_product_price);
            this.Controls.Add(this.txt_product_id);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProduct";
            this.Load += new System.EventHandler(this.ManageProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_manage_user;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_product_name;
        private System.Windows.Forms.TextBox txt_product_qty;
        private System.Windows.Forms.TextBox txt_product_price;
        private System.Windows.Forms.TextBox txt_product_id;
        private System.Windows.Forms.TextBox txt_product_description;
        private System.Windows.Forms.ComboBox CatCombo;
        private System.Windows.Forms.DataGridView ProductGV;
        private System.Windows.Forms.Label customer_list;
        private System.Windows.Forms.Button btn_product_home;
        private System.Windows.Forms.Button btn_product_lelete;
        private System.Windows.Forms.Button btn_edit_Edit;
        private System.Windows.Forms.Button btn_product_add;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button BTN_SEARCH;
        private System.Windows.Forms.ComboBox Search_comboBox;
        private System.Windows.Forms.Label lbl_order_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}