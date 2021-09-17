
namespace Inventory_Mng
{
    partial class ManageCategories
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_manage_user = new System.Windows.Forms.Label();
            this.txt_Categories_id = new System.Windows.Forms.TextBox();
            this.txt_Categoris_name = new System.Windows.Forms.TextBox();
            this.CategoriesGV = new System.Windows.Forms.DataGridView();
            this.customer_list = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_categories_home = new System.Windows.Forms.Button();
            this.btn_categories_delete = new System.Windows.Forms.Button();
            this.btn_categories_Edit = new System.Windows.Forms.Button();
            this.btn_categories_add = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGV)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(281, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(702, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "JK INFO MANAGEMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_manage_user
            // 
            this.lbl_manage_user.AutoSize = true;
            this.lbl_manage_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_manage_user.ForeColor = System.Drawing.Color.White;
            this.lbl_manage_user.Location = new System.Drawing.Point(460, 75);
            this.lbl_manage_user.Name = "lbl_manage_user";
            this.lbl_manage_user.Size = new System.Drawing.Size(331, 39);
            this.lbl_manage_user.TabIndex = 0;
            this.lbl_manage_user.Text = "Manage Categories";
            this.lbl_manage_user.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_Categories_id
            // 
            this.txt_Categories_id.BackColor = System.Drawing.Color.White;
            this.txt_Categories_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Categories_id.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Categories_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Categories_id.ForeColor = System.Drawing.Color.Blue;
            this.txt_Categories_id.Location = new System.Drawing.Point(328, 220);
            this.txt_Categories_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Categories_id.Name = "txt_Categories_id";
            this.txt_Categories_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Categories_id.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_Categories_id.Size = new System.Drawing.Size(214, 29);
            this.txt_Categories_id.TabIndex = 3;
            this.txt_Categories_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Categories_id.TextChanged += new System.EventHandler(this.txt_Categories_id_TextChanged);
            // 
            // txt_Categoris_name
            // 
            this.txt_Categoris_name.BackColor = System.Drawing.Color.White;
            this.txt_Categoris_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Categoris_name.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txt_Categoris_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Categoris_name.ForeColor = System.Drawing.Color.Blue;
            this.txt_Categoris_name.Location = new System.Drawing.Point(328, 371);
            this.txt_Categoris_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Categoris_name.Name = "txt_Categoris_name";
            this.txt_Categoris_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Categoris_name.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txt_Categoris_name.Size = new System.Drawing.Size(214, 29);
            this.txt_Categoris_name.TabIndex = 4;
            this.txt_Categoris_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CategoriesGV
            // 
            this.CategoriesGV.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.CategoriesGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoriesGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.CategoriesGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoriesGV.DefaultCellStyle = dataGridViewCellStyle11;
            this.CategoriesGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CategoriesGV.Location = new System.Drawing.Point(561, 220);
            this.CategoriesGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CategoriesGV.Name = "CategoriesGV";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CategoriesGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.CategoriesGV.RowHeadersWidth = 51;
            this.CategoriesGV.RowTemplate.Height = 24;
            this.CategoriesGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoriesGV.Size = new System.Drawing.Size(684, 520);
            this.CategoriesGV.TabIndex = 11;
            this.CategoriesGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // customer_list
            // 
            this.customer_list.AutoSize = true;
            this.customer_list.BackColor = System.Drawing.Color.Transparent;
            this.customer_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_list.ForeColor = System.Drawing.Color.Brown;
            this.customer_list.Location = new System.Drawing.Point(733, 152);
            this.customer_list.Name = "customer_list";
            this.customer_list.Size = new System.Drawing.Size(314, 48);
            this.customer_list.TabIndex = 13;
            this.customer_list.Text = "Categories List";
            this.customer_list.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customer_list.Click += new System.EventHandler(this.customer_list_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 771);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1296, 29);
            this.panel2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Khaki;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(12, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 38);
            this.label4.TabIndex = 27;
            this.label4.Text = "Categories ID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Khaki;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(12, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 38);
            this.label3.TabIndex = 28;
            this.label3.Text = "Categories Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_categories_home
            // 
            this.btn_categories_home.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_categories_home.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_categories_home.FlatAppearance.BorderSize = 0;
            this.btn_categories_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_categories_home.Location = new System.Drawing.Point(182, 570);
            this.btn_categories_home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_categories_home.Name = "btn_categories_home";
            this.btn_categories_home.Size = new System.Drawing.Size(87, 31);
            this.btn_categories_home.TabIndex = 32;
            this.btn_categories_home.Text = "HOME";
            this.btn_categories_home.UseVisualStyleBackColor = false;
            this.btn_categories_home.Click += new System.EventHandler(this.btn_categories_home_Click_1);
            // 
            // btn_categories_delete
            // 
            this.btn_categories_delete.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_categories_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_categories_delete.FlatAppearance.BorderSize = 0;
            this.btn_categories_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_categories_delete.Location = new System.Drawing.Point(303, 483);
            this.btn_categories_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_categories_delete.Name = "btn_categories_delete";
            this.btn_categories_delete.Size = new System.Drawing.Size(87, 31);
            this.btn_categories_delete.TabIndex = 31;
            this.btn_categories_delete.Text = "DELETE";
            this.btn_categories_delete.UseVisualStyleBackColor = false;
            this.btn_categories_delete.Click += new System.EventHandler(this.btn_categories_delete_Click_1);
            // 
            // btn_categories_Edit
            // 
            this.btn_categories_Edit.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_categories_Edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_categories_Edit.FlatAppearance.BorderSize = 0;
            this.btn_categories_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_categories_Edit.Location = new System.Drawing.Point(182, 483);
            this.btn_categories_Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_categories_Edit.Name = "btn_categories_Edit";
            this.btn_categories_Edit.Size = new System.Drawing.Size(87, 31);
            this.btn_categories_Edit.TabIndex = 30;
            this.btn_categories_Edit.Text = "EDIT";
            this.btn_categories_Edit.UseVisualStyleBackColor = false;
            // 
            // btn_categories_add
            // 
            this.btn_categories_add.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_categories_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_categories_add.FlatAppearance.BorderSize = 0;
            this.btn_categories_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_categories_add.Location = new System.Drawing.Point(64, 483);
            this.btn_categories_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_categories_add.Name = "btn_categories_add";
            this.btn_categories_add.Size = new System.Drawing.Size(87, 31);
            this.btn_categories_add.TabIndex = 29;
            this.btn_categories_add.Text = "ADD";
            this.btn_categories_add.UseVisualStyleBackColor = false;
            this.btn_categories_add.Click += new System.EventHandler(this.btn_categories_add_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Cyan;
            this.label9.Location = new System.Drawing.Point(123, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "TS Infotech";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "Developed By :";
            // 
            // ManageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1296, 800);
            this.Controls.Add(this.btn_categories_home);
            this.Controls.Add(this.btn_categories_delete);
            this.Controls.Add(this.btn_categories_Edit);
            this.Controls.Add(this.btn_categories_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.customer_list);
            this.Controls.Add(this.CategoriesGV);
            this.Controls.Add(this.txt_Categoris_name);
            this.Controls.Add(this.txt_Categories_id);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCategories";
            this.Load += new System.EventHandler(this.ManageCategories_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_manage_user;
        private System.Windows.Forms.TextBox txt_Categories_id;
        private System.Windows.Forms.TextBox txt_Categoris_name;
        private System.Windows.Forms.DataGridView CategoriesGV;
        private System.Windows.Forms.Label customer_list;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_categories_home;
        private System.Windows.Forms.Button btn_categories_delete;
        private System.Windows.Forms.Button btn_categories_Edit;
        private System.Windows.Forms.Button btn_categories_add;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}