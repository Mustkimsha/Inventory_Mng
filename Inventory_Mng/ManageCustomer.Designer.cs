
namespace Inventory_Mng
{
    partial class ManageCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_manage_user = new System.Windows.Forms.Label();
            this.txt_customer_id = new System.Windows.Forms.TextBox();
            this.txt_Customer_name = new System.Windows.Forms.TextBox();
            this.txt_customer_mobile = new System.Windows.Forms.TextBox();
            this.btn_customer_add = new System.Windows.Forms.Button();
            this.btn_customer_Edit = new System.Windows.Forms.Button();
            this.btn_Customer_lelete = new System.Windows.Forms.Button();
            this.btn_Customer_home = new System.Windows.Forms.Button();
            this.CustomerGv = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.customer_list = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Datelabel1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Amountlable1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.orderslabel1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGv)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(1250, 0);
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
            this.label1.Location = new System.Drawing.Point(316, 9);
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
            this.lbl_manage_user.Location = new System.Drawing.Point(492, 68);
            this.lbl_manage_user.Name = "lbl_manage_user";
            this.lbl_manage_user.Size = new System.Drawing.Size(311, 39);
            this.lbl_manage_user.TabIndex = 0;
            this.lbl_manage_user.Text = "Manage Customer";
            this.lbl_manage_user.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_customer_id
            // 
            this.txt_customer_id.BackColor = System.Drawing.Color.White;
            this.txt_customer_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer_id.ForeColor = System.Drawing.Color.Blue;
            this.txt_customer_id.Location = new System.Drawing.Point(315, 234);
            this.txt_customer_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_customer_id.Name = "txt_customer_id";
            this.txt_customer_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_customer_id.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_customer_id.Size = new System.Drawing.Size(202, 36);
            this.txt_customer_id.TabIndex = 2;
            this.txt_customer_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Customer_name
            // 
            this.txt_Customer_name.BackColor = System.Drawing.Color.White;
            this.txt_Customer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Customer_name.ForeColor = System.Drawing.Color.Blue;
            this.txt_Customer_name.Location = new System.Drawing.Point(315, 310);
            this.txt_Customer_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Customer_name.Name = "txt_Customer_name";
            this.txt_Customer_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Customer_name.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_Customer_name.Size = new System.Drawing.Size(202, 36);
            this.txt_Customer_name.TabIndex = 3;
            this.txt_Customer_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_customer_mobile
            // 
            this.txt_customer_mobile.BackColor = System.Drawing.Color.White;
            this.txt_customer_mobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer_mobile.ForeColor = System.Drawing.Color.Blue;
            this.txt_customer_mobile.Location = new System.Drawing.Point(315, 406);
            this.txt_customer_mobile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_customer_mobile.Name = "txt_customer_mobile";
            this.txt_customer_mobile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_customer_mobile.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_customer_mobile.Size = new System.Drawing.Size(202, 36);
            this.txt_customer_mobile.TabIndex = 4;
            this.txt_customer_mobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_customer_add
            // 
            this.btn_customer_add.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_customer_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_customer_add.FlatAppearance.BorderSize = 0;
            this.btn_customer_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer_add.Location = new System.Drawing.Point(45, 495);
            this.btn_customer_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_customer_add.Name = "btn_customer_add";
            this.btn_customer_add.Size = new System.Drawing.Size(87, 31);
            this.btn_customer_add.TabIndex = 6;
            this.btn_customer_add.Text = "ADD";
            this.btn_customer_add.UseVisualStyleBackColor = false;
            this.btn_customer_add.Click += new System.EventHandler(this.btn_customer_add_Click);
            // 
            // btn_customer_Edit
            // 
            this.btn_customer_Edit.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_customer_Edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_customer_Edit.FlatAppearance.BorderSize = 0;
            this.btn_customer_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer_Edit.Location = new System.Drawing.Point(176, 495);
            this.btn_customer_Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_customer_Edit.Name = "btn_customer_Edit";
            this.btn_customer_Edit.Size = new System.Drawing.Size(87, 31);
            this.btn_customer_Edit.TabIndex = 7;
            this.btn_customer_Edit.Text = "EDIT";
            this.btn_customer_Edit.UseVisualStyleBackColor = false;
            this.btn_customer_Edit.Click += new System.EventHandler(this.btn_customer_Edit_Click);
            // 
            // btn_Customer_lelete
            // 
            this.btn_Customer_lelete.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Customer_lelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Customer_lelete.FlatAppearance.BorderSize = 0;
            this.btn_Customer_lelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer_lelete.Location = new System.Drawing.Point(315, 495);
            this.btn_Customer_lelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Customer_lelete.Name = "btn_Customer_lelete";
            this.btn_Customer_lelete.Size = new System.Drawing.Size(87, 31);
            this.btn_Customer_lelete.TabIndex = 8;
            this.btn_Customer_lelete.Text = "DELETE";
            this.btn_Customer_lelete.UseVisualStyleBackColor = false;
            this.btn_Customer_lelete.Click += new System.EventHandler(this.btn_Customer_lelete_Click);
            // 
            // btn_Customer_home
            // 
            this.btn_Customer_home.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Customer_home.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Customer_home.FlatAppearance.BorderSize = 0;
            this.btn_Customer_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer_home.Location = new System.Drawing.Point(176, 558);
            this.btn_Customer_home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Customer_home.Name = "btn_Customer_home";
            this.btn_Customer_home.Size = new System.Drawing.Size(87, 31);
            this.btn_Customer_home.TabIndex = 9;
            this.btn_Customer_home.Text = "HOME";
            this.btn_Customer_home.UseVisualStyleBackColor = false;
            this.btn_Customer_home.Click += new System.EventHandler(this.btn_Customer_home_Click);
            // 
            // CustomerGv
            // 
            this.CustomerGv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CustomerGv.ColumnHeadersHeight = 29;
            this.CustomerGv.GridColor = System.Drawing.Color.PeachPuff;
            this.CustomerGv.Location = new System.Drawing.Point(527, 230);
            this.CustomerGv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomerGv.Name = "CustomerGv";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerGv.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerGv.RowHeadersWidth = 51;
            this.CustomerGv.RowTemplate.Height = 24;
            this.CustomerGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerGv.Size = new System.Drawing.Size(757, 359);
            this.CustomerGv.TabIndex = 10;
            this.CustomerGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerGv_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 777);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1296, 23);
            this.panel2.TabIndex = 11;
            // 
            // customer_list
            // 
            this.customer_list.AutoSize = true;
            this.customer_list.BackColor = System.Drawing.Color.Khaki;
            this.customer_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_list.ForeColor = System.Drawing.Color.Brown;
            this.customer_list.Location = new System.Drawing.Point(791, 159);
            this.customer_list.Name = "customer_list";
            this.customer_list.Size = new System.Drawing.Size(291, 48);
            this.customer_list.TabIndex = 12;
            this.customer_list.Text = "Customer List";
            this.customer_list.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Blue;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.Datelabel1);
            this.panel5.Location = new System.Drawing.Point(946, 605);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(262, 155);
            this.panel5.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 34);
            this.label7.TabIndex = 3;
            this.label7.Text = "Last Order Date";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Datelabel1
            // 
            this.Datelabel1.BackColor = System.Drawing.Color.Transparent;
            this.Datelabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelabel1.ForeColor = System.Drawing.Color.White;
            this.Datelabel1.Location = new System.Drawing.Point(59, 47);
            this.Datelabel1.Name = "Datelabel1";
            this.Datelabel1.Size = new System.Drawing.Size(137, 63);
            this.Datelabel1.TabIndex = 2;
            this.Datelabel1.Text = "Date";
            this.Datelabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 34);
            this.label6.TabIndex = 2;
            this.label6.Text = "Orders Amount";
            // 
            // Amountlable1
            // 
            this.Amountlable1.BackColor = System.Drawing.Color.Transparent;
            this.Amountlable1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amountlable1.ForeColor = System.Drawing.Color.White;
            this.Amountlable1.Location = new System.Drawing.Point(58, 60);
            this.Amountlable1.Name = "Amountlable1";
            this.Amountlable1.Size = new System.Drawing.Size(144, 37);
            this.Amountlable1.TabIndex = 1;
            this.Amountlable1.Text = "Amount";
            this.Amountlable1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LimeGreen;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.Amountlable1);
            this.panel4.Location = new System.Drawing.Point(515, 605);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(264, 155);
            this.panel4.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 34);
            this.label5.TabIndex = 1;
            this.label5.Text = "Orders Count";
            // 
            // orderslabel1
            // 
            this.orderslabel1.BackColor = System.Drawing.Color.Transparent;
            this.orderslabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderslabel1.ForeColor = System.Drawing.Color.White;
            this.orderslabel1.Location = new System.Drawing.Point(48, 65);
            this.orderslabel1.Name = "orderslabel1";
            this.orderslabel1.Size = new System.Drawing.Size(123, 41);
            this.orderslabel1.TabIndex = 0;
            this.orderslabel1.Text = "Orders";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Crimson;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.orderslabel1);
            this.panel3.Location = new System.Drawing.Point(102, 609);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 151);
            this.panel3.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Khaki;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(12, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 38);
            this.label4.TabIndex = 28;
            this.label4.Text = "Customer Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Khaki;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(12, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 38);
            this.label3.TabIndex = 29;
            this.label3.Text = "Customer ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Khaki;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Brown;
            this.label8.Location = new System.Drawing.Point(12, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 38);
            this.label8.TabIndex = 30;
            this.label8.Text = "Mobile Name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Cyan;
            this.label9.Location = new System.Drawing.Point(123, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "TS Infotech";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Developed By :";
            // 
            // ManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1296, 800);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.customer_list);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CustomerGv);
            this.Controls.Add(this.btn_Customer_home);
            this.Controls.Add(this.btn_Customer_lelete);
            this.Controls.Add(this.btn_customer_Edit);
            this.Controls.Add(this.btn_customer_add);
            this.Controls.Add(this.txt_customer_mobile);
            this.Controls.Add(this.txt_Customer_name);
            this.Controls.Add(this.txt_customer_id);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManageCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCustomer";
            this.Load += new System.EventHandler(this.ManageCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_manage_user;
        private System.Windows.Forms.TextBox txt_customer_id;
        private System.Windows.Forms.TextBox txt_Customer_name;
        private System.Windows.Forms.TextBox txt_customer_mobile;
        private System.Windows.Forms.Button btn_customer_add;
        private System.Windows.Forms.Button btn_customer_Edit;
        private System.Windows.Forms.Button btn_Customer_lelete;
        private System.Windows.Forms.Button btn_Customer_home;
        private System.Windows.Forms.DataGridView CustomerGv;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label customer_list;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Datelabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Amountlable1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label orderslabel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}