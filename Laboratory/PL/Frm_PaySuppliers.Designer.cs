﻿namespace Laboratory.PL
{
    partial class Frm_PaySuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PaySuppliers));
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_Stock = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_prise = new System.Windows.Forms.TextBox();
            this.rdbPartPay = new System.Windows.Forms.RadioButton();
            this.RdbAllPay = new System.Windows.Forms.RadioButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.Btn_SelectProduct = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_sales = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmb_Branch = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(246, 54);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 47;
            this.label7.Text = "اختر خزنة:";
            // 
            // cmb_Stock
            // 
            this.cmb_Stock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Stock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Stock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Stock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Stock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Stock.FormattingEnabled = true;
            this.cmb_Stock.Location = new System.Drawing.Point(6, 51);
            this.cmb_Stock.Name = "cmb_Stock";
            this.cmb_Stock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Stock.Size = new System.Drawing.Size(234, 27);
            this.cmb_Stock.TabIndex = 46;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(366, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(244, 32);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_prise);
            this.groupBox2.Controls.Add(this.rdbPartPay);
            this.groupBox2.Controls.Add(this.RdbAllPay);
            this.groupBox2.Location = new System.Drawing.Point(73, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 67);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            // 
            // txt_prise
            // 
            this.txt_prise.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prise.Location = new System.Drawing.Point(128, 21);
            this.txt_prise.MaxLength = 8;
            this.txt_prise.Name = "txt_prise";
            this.txt_prise.Size = new System.Drawing.Size(116, 27);
            this.txt_prise.TabIndex = 63;
            this.txt_prise.Text = "0";
            this.txt_prise.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_prise.Click += new System.EventHandler(this.txt_prise_Click);
            this.txt_prise.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_prise_KeyPress);
            this.txt_prise.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txt_prise_MouseMove);
            // 
            // rdbPartPay
            // 
            this.rdbPartPay.AutoSize = true;
            this.rdbPartPay.BackColor = System.Drawing.Color.Black;
            this.rdbPartPay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPartPay.ForeColor = System.Drawing.Color.White;
            this.rdbPartPay.Location = new System.Drawing.Point(250, 22);
            this.rdbPartPay.Name = "rdbPartPay";
            this.rdbPartPay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdbPartPay.Size = new System.Drawing.Size(122, 26);
            this.rdbPartPay.TabIndex = 1;
            this.rdbPartPay.Text = "تسديد جزء منه";
            this.rdbPartPay.UseVisualStyleBackColor = false;
            // 
            // RdbAllPay
            // 
            this.RdbAllPay.AutoSize = true;
            this.RdbAllPay.BackColor = System.Drawing.Color.Black;
            this.RdbAllPay.Checked = true;
            this.RdbAllPay.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbAllPay.ForeColor = System.Drawing.Color.White;
            this.RdbAllPay.Location = new System.Drawing.Point(464, 23);
            this.RdbAllPay.Name = "RdbAllPay";
            this.RdbAllPay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RdbAllPay.Size = new System.Drawing.Size(149, 26);
            this.RdbAllPay.TabIndex = 0;
            this.RdbAllPay.TabStop = true;
            this.RdbAllPay.Text = "تسديد المبلغ بالكامل";
            this.RdbAllPay.UseVisualStyleBackColor = false;
            this.RdbAllPay.CheckedChanged += new System.EventHandler(this.RdbAllPay_CheckedChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.simpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(359, 386);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(179, 37);
            this.simpleButton1.TabIndex = 169;
            this.simpleButton1.Text = "حفظ المدفوع";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(578, 14);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(185, 26);
            this.dateTimePicker1.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(346, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 72;
            this.label1.Text = "المبالغ المتبقيه للموردين ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.GridColor = System.Drawing.Color.DimGray;
            this.dataGridView1.Location = new System.Drawing.Point(9, 218);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(854, 87);
            this.dataGridView1.TabIndex = 74;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Cmb_Branch);
            this.groupBox1.Controls.Add(this.Btn_Save);
            this.groupBox1.Controls.Add(this.Btn_SelectProduct);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.Txt_sales);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb_Stock);
            this.groupBox1.Location = new System.Drawing.Point(10, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 94);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            // 
            // Btn_Save
            // 
            this.Btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Save.Appearance.BackColor = System.Drawing.Color.Black;
            this.Btn_Save.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Save.Appearance.ForeColor = System.Drawing.Color.White;
            this.Btn_Save.Appearance.Options.UseBackColor = true;
            this.Btn_Save.Appearance.Options.UseFont = true;
            this.Btn_Save.Appearance.Options.UseForeColor = true;
            this.Btn_Save.Appearance.Options.UseTextOptions = true;
            this.Btn_Save.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Btn_Save.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Btn_Save.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.Btn_Save.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Save.ImageOptions.Image")));
            this.Btn_Save.Location = new System.Drawing.Point(391, 172);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(179, 37);
            this.Btn_Save.TabIndex = 169;
            this.Btn_Save.Text = "حفظ الفاتورة";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.Black;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.Appearance.Options.UseTextOptions = true;
            this.simpleButton2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.simpleButton2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.simpleButton2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(228, 19);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(115, 32);
            this.simpleButton2.TabIndex = 168;
            this.simpleButton2.Text = "بحث";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Btn_SelectProduct
            // 
            this.Btn_SelectProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_SelectProduct.Appearance.BackColor = System.Drawing.Color.Black;
            this.Btn_SelectProduct.Appearance.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SelectProduct.Appearance.ForeColor = System.Drawing.Color.White;
            this.Btn_SelectProduct.Appearance.Options.UseBackColor = true;
            this.Btn_SelectProduct.Appearance.Options.UseFont = true;
            this.Btn_SelectProduct.Appearance.Options.UseForeColor = true;
            this.Btn_SelectProduct.Appearance.Options.UseTextOptions = true;
            this.Btn_SelectProduct.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.Btn_SelectProduct.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.Btn_SelectProduct.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.Btn_SelectProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Btn_SelectProduct.ImageOptions.Image")));
            this.Btn_SelectProduct.Location = new System.Drawing.Point(285, -115);
            this.Btn_SelectProduct.Name = "Btn_SelectProduct";
            this.Btn_SelectProduct.Size = new System.Drawing.Size(158, 32);
            this.Btn_SelectProduct.TabIndex = 168;
            this.Btn_SelectProduct.Text = "إختيار صنف";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(615, 28);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 59;
            this.label5.Text = "إسم المورد";
            // 
            // Txt_sales
            // 
            this.Txt_sales.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_sales.Location = new System.Drawing.Point(541, 54);
            this.Txt_sales.Name = "Txt_sales";
            this.Txt_sales.ReadOnly = true;
            this.Txt_sales.Size = new System.Drawing.Size(222, 26);
            this.Txt_sales.TabIndex = 58;
            this.Txt_sales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(777, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 75;
            this.label3.Text = "تاريخ الدفع";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(769, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 57;
            this.label4.Text = "اسم المستخدم";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.simpleButton2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(9, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(854, 67);
            this.groupBox3.TabIndex = 170;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 170;
            this.label2.Text = "الفرع";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cmb_Branch
            // 
            this.Cmb_Branch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Cmb_Branch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_Branch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_Branch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_Branch.FormattingEnabled = true;
            this.Cmb_Branch.Location = new System.Drawing.Point(6, 14);
            this.Cmb_Branch.Name = "Cmb_Branch";
            this.Cmb_Branch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Cmb_Branch.Size = new System.Drawing.Size(234, 27);
            this.Cmb_Branch.TabIndex = 171;
            // 
            // Frm_PaySuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(871, 431);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(887, 469);
            this.MinimumSize = new System.Drawing.Size(860, 402);
            this.Name = "Frm_PaySuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدفوعات مورد";
            this.Load += new System.EventHandler(this.Frm_PaySuppliers_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_Stock;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_prise;
        private System.Windows.Forms.RadioButton rdbPartPay;
        private System.Windows.Forms.RadioButton RdbAllPay;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Txt_sales;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton Btn_Save;
        private DevExpress.XtraEditors.SimpleButton Btn_SelectProduct;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox Cmb_Branch;
    }
}