﻿namespace Laboratory.PL
{
    partial class Add_StoreProduct
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
            this.dataGridViewPR = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.Cmb_Store = new System.Windows.Forms.ComboBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Txt_Minimum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Cmb_ProdName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPR)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPR
            // 
            this.dataGridViewPR.AllowUserToAddRows = false;
            this.dataGridViewPR.AllowUserToDeleteRows = false;
            this.dataGridViewPR.AllowUserToResizeRows = false;
            this.dataGridViewPR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPR.Location = new System.Drawing.Point(4, 302);
            this.dataGridViewPR.MultiSelect = false;
            this.dataGridViewPR.Name = "dataGridViewPR";
            this.dataGridViewPR.ReadOnly = true;
            this.dataGridViewPR.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewPR.Size = new System.Drawing.Size(580, 231);
            this.dataGridViewPR.TabIndex = 29;
            this.dataGridViewPR.DoubleClick += new System.EventHandler(this.dataGridViewPR_DoubleClick);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(390, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 32);
            this.label15.TabIndex = 28;
            this.label15.Text = "بحث";
            // 
            // txt_search
            // 
            this.txt_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_search.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(122, 262);
            this.txt_search.Name = "txt_search";
            this.txt_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_search.Size = new System.Drawing.Size(249, 29);
            this.txt_search.TabIndex = 26;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // Cmb_Store
            // 
            this.Cmb_Store.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Cmb_Store.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_Store.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_Store.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Store.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Store.FormattingEnabled = true;
            this.Cmb_Store.ItemHeight = 24;
            this.Cmb_Store.Location = new System.Drawing.Point(174, 63);
            this.Cmb_Store.Name = "Cmb_Store";
            this.Cmb_Store.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmb_Store.Size = new System.Drawing.Size(225, 32);
            this.Cmb_Store.TabIndex = 2;
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_update.BackColor = System.Drawing.Color.Black;
            this.btn_update.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(198, 204);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(159, 42);
            this.btn_update.TabIndex = 24;
            this.btn_update.Text = "تعديل صنف";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_add.BackColor = System.Drawing.Color.Black;
            this.btn_add.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(389, 204);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(175, 42);
            this.btn_add.TabIndex = 23;
            this.btn_add.Text = "اضافه الصنف";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(433, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 29);
            this.label13.TabIndex = 1;
            this.label13.Text = "اسم المنتج";
            // 
            // btn_new
            // 
            this.btn_new.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_new.BackColor = System.Drawing.Color.Black;
            this.btn_new.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.Location = new System.Drawing.Point(398, 204);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(158, 42);
            this.btn_new.TabIndex = 25;
            this.btn_new.Text = "جديد";
            this.btn_new.UseVisualStyleBackColor = false;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.Txt_Minimum);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.Cmb_ProdName);
            this.groupBox3.Controls.Add(this.Cmb_Store);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_quantity);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(8, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(574, 196);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Txt_Minimum
            // 
            this.Txt_Minimum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_Minimum.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Minimum.Location = new System.Drawing.Point(201, 153);
            this.Txt_Minimum.Name = "Txt_Minimum";
            this.Txt_Minimum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_Minimum.Size = new System.Drawing.Size(157, 29);
            this.Txt_Minimum.TabIndex = 31;
            this.Txt_Minimum.Text = "0";
            this.Txt_Minimum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Minimum.Click += new System.EventHandler(this.Txt_Minimum_Click);
            this.Txt_Minimum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Minimum_KeyPress);
            this.Txt_Minimum.Leave += new System.EventHandler(this.Txt_Minimum_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(376, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "الحد الادنى للطلب ";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(43, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 31);
            this.button1.TabIndex = 30;
            this.button1.Text = "+ + +";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cmb_ProdName
            // 
            this.Cmb_ProdName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Cmb_ProdName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_ProdName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_ProdName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_ProdName.FormattingEnabled = true;
            this.Cmb_ProdName.ItemHeight = 24;
            this.Cmb_ProdName.Location = new System.Drawing.Point(129, 19);
            this.Cmb_ProdName.Name = "Cmb_ProdName";
            this.Cmb_ProdName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmb_ProdName.Size = new System.Drawing.Size(296, 32);
            this.Cmb_ProdName.TabIndex = 23;
            this.Cmb_ProdName.Leave += new System.EventHandler(this.Cmb_ProdName_Leave);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(415, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "الكميه ";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_quantity.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(203, 110);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_quantity.Size = new System.Drawing.Size(157, 29);
            this.txt_quantity.TabIndex = 3;
            this.txt_quantity.Text = "0";
            this.txt_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_quantity.Click += new System.EventHandler(this.txt_quantity_Click);
            this.txt_quantity.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_quantity_MouseClick);
            this.txt_quantity.TextChanged += new System.EventHandler(this.txt_quantity_TextChanged);
            this.txt_quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_quantity_KeyPress);
            this.txt_quantity.Leave += new System.EventHandler(this.txt_quantity_Leave);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(419, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 29);
            this.label9.TabIndex = 3;
            this.label9.Text = "المخزن";
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Delete.BackColor = System.Drawing.Color.Black;
            this.Btn_Delete.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.ForeColor = System.Drawing.Color.White;
            this.Btn_Delete.Location = new System.Drawing.Point(14, 205);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(142, 42);
            this.Btn_Delete.TabIndex = 30;
            this.Btn_Delete.Text = "حذف الصنف ";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Add_StoreProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(588, 536);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.dataGridViewPR);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.groupBox3);
            this.MinimumSize = new System.Drawing.Size(532, 574);
            this.Name = "Add_StoreProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة أصناف للمخزن";
            this.Load += new System.EventHandler(this.Add_StoreProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPR)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPR;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.ComboBox Cmb_Store;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Cmb_ProdName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox Txt_Minimum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Delete;
    }
}