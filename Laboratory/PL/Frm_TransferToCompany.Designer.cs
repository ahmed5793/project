﻿namespace Laboratory.PL
{
    partial class Frm_TransferToCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TransferToCompany));
            this.cmb_Company = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_reasonAddition = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdb_discountPatient = new System.Windows.Forms.RadioButton();
            this.Txt_RentCustomer = new System.Windows.Forms.TextBox();
            this.rdb_MoneyPatient = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.Txt_addtionPaymentrate = new System.Windows.Forms.TextBox();
            this.Txt_PricePayment = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_LastPayOut = new System.Windows.Forms.TextBox();
            this.Txt_PayLast = new System.Windows.Forms.TextBox();
            this.Txt_RentCompany = new System.Windows.Forms.TextBox();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Stock = new System.Windows.Forms.ComboBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_patientname = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.Txt_IdCust = new System.Windows.Forms.TextBox();
            this.txt_IdTeckit = new System.Windows.Forms.TextBox();
            this.Txt_OldRentBeforeTransfair = new System.Windows.Forms.TextBox();
            this.Txt_TotalBeforeTransfair = new System.Windows.Forms.TextBox();
            this.Txt_OldBranch = new System.Windows.Forms.TextBox();
            this.Txt_IdOldBranch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_Company
            // 
            this.cmb_Company.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_Company.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmb_Company.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Company.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Company.FormattingEnabled = true;
            this.cmb_Company.Location = new System.Drawing.Point(200, 162);
            this.cmb_Company.Name = "cmb_Company";
            this.cmb_Company.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Company.Size = new System.Drawing.Size(294, 32);
            this.cmb_Company.TabIndex = 90;
            this.cmb_Company.SelectedIndexChanged += new System.EventHandler(this.cmb_Company_SelectedIndexChanged);
            this.cmb_Company.SelectionChangeCommitted += new System.EventHandler(this.cmb_Company_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(506, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 91;
            this.label1.Text = "اسم الشركة";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 7);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(202, 78);
            this.dataGridView1.TabIndex = 126;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(110, 202);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView2.Size = new System.Drawing.Size(562, 60);
            this.dataGridView2.TabIndex = 127;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(164, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(153, 19);
            this.label16.TabIndex = 103;
            this.label16.Text = "المبلغ المردود مسبقا للعميل";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(662, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 19);
            this.label11.TabIndex = 99;
            this.label11.Text = "الاجمالي";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txt_reasonAddition
            // 
            this.txt_reasonAddition.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_reasonAddition.Location = new System.Drawing.Point(8, 136);
            this.txt_reasonAddition.MaxLength = 3000;
            this.txt_reasonAddition.Multiline = true;
            this.txt_reasonAddition.Name = "txt_reasonAddition";
            this.txt_reasonAddition.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_reasonAddition.Size = new System.Drawing.Size(239, 62);
            this.txt_reasonAddition.TabIndex = 99;
            this.txt_reasonAddition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_reasonAddition.TextChanged += new System.EventHandler(this.txt_reasonAddition_TextChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.White;
            this.label26.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(151, 55);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(100, 19);
            this.label26.TabIndex = 116;
            this.label26.Text = "نسبة تحمل العميل";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.White;
            this.label27.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(153, 89);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(98, 19);
            this.label27.TabIndex = 118;
            this.label27.Text = "مبلغ تحمل العميل";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.White;
            this.label28.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(262, 163);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(55, 19);
            this.label28.TabIndex = 120;
            this.label28.Text = "ملاحظات";
            this.label28.Click += new System.EventHandler(this.label28_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.White;
            this.label29.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(606, 210);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(114, 19);
            this.label29.TabIndex = 121;
            this.label29.Text = "المتبقي على الشركة";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.Txt_LastPayOut);
            this.groupBox3.Controls.Add(this.Txt_PayLast);
            this.groupBox3.Controls.Add(this.Txt_RentCompany);
            this.groupBox3.Controls.Add(this.Txt_Total);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txt_reasonAddition);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(7, 268);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(745, 246);
            this.groupBox3.TabIndex = 92;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "الحسابات";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdb_discountPatient);
            this.groupBox4.Controls.Add(this.Txt_RentCustomer);
            this.groupBox4.Controls.Add(this.rdb_MoneyPatient);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.Txt_addtionPaymentrate);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.Txt_PricePayment);
            this.groupBox4.Location = new System.Drawing.Point(469, 44);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(261, 153);
            this.groupBox4.TabIndex = 188;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "تحمل المريض";
            // 
            // rdb_discountPatient
            // 
            this.rdb_discountPatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rdb_discountPatient.AutoSize = true;
            this.rdb_discountPatient.BackColor = System.Drawing.Color.Yellow;
            this.rdb_discountPatient.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_discountPatient.Location = new System.Drawing.Point(155, 19);
            this.rdb_discountPatient.Name = "rdb_discountPatient";
            this.rdb_discountPatient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdb_discountPatient.Size = new System.Drawing.Size(66, 22);
            this.rdb_discountPatient.TabIndex = 124;
            this.rdb_discountPatient.Text = "نسبة %";
            this.rdb_discountPatient.UseVisualStyleBackColor = false;
            this.rdb_discountPatient.CheckedChanged += new System.EventHandler(this.rdb_discountPatient_CheckedChanged);
            // 
            // Txt_RentCustomer
            // 
            this.Txt_RentCustomer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_RentCustomer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_RentCustomer.ForeColor = System.Drawing.SystemColors.Info;
            this.Txt_RentCustomer.Location = new System.Drawing.Point(4, 119);
            this.Txt_RentCustomer.Name = "Txt_RentCustomer";
            this.Txt_RentCustomer.ReadOnly = true;
            this.Txt_RentCustomer.Size = new System.Drawing.Size(134, 26);
            this.Txt_RentCustomer.TabIndex = 138;
            this.Txt_RentCustomer.Text = "0";
            this.Txt_RentCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdb_MoneyPatient
            // 
            this.rdb_MoneyPatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rdb_MoneyPatient.AutoSize = true;
            this.rdb_MoneyPatient.BackColor = System.Drawing.Color.Yellow;
            this.rdb_MoneyPatient.Checked = true;
            this.rdb_MoneyPatient.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_MoneyPatient.Location = new System.Drawing.Point(65, 19);
            this.rdb_MoneyPatient.Name = "rdb_MoneyPatient";
            this.rdb_MoneyPatient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rdb_MoneyPatient.Size = new System.Drawing.Size(47, 22);
            this.rdb_MoneyPatient.TabIndex = 123;
            this.rdb_MoneyPatient.TabStop = true;
            this.rdb_MoneyPatient.Text = "قيمة";
            this.rdb_MoneyPatient.UseVisualStyleBackColor = false;
            this.rdb_MoneyPatient.CheckedChanged += new System.EventHandler(this.rdb_MoneyPatient_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(143, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 19);
            this.label8.TabIndex = 137;
            this.label8.Text = "المتبقي على العميل";
            // 
            // Txt_addtionPaymentrate
            // 
            this.Txt_addtionPaymentrate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_addtionPaymentrate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_addtionPaymentrate.ForeColor = System.Drawing.SystemColors.Info;
            this.Txt_addtionPaymentrate.Location = new System.Drawing.Point(4, 51);
            this.Txt_addtionPaymentrate.Name = "Txt_addtionPaymentrate";
            this.Txt_addtionPaymentrate.Size = new System.Drawing.Size(134, 26);
            this.Txt_addtionPaymentrate.TabIndex = 115;
            this.Txt_addtionPaymentrate.Text = "0";
            this.Txt_addtionPaymentrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_addtionPaymentrate.Click += new System.EventHandler(this.Txt_addtionPaymentrate_Click);
            this.Txt_addtionPaymentrate.TextChanged += new System.EventHandler(this.Txt_addtionPayment_TextChanged);
            this.Txt_addtionPaymentrate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_addtionPayment_KeyDown);
            this.Txt_addtionPaymentrate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_addtionPayment_KeyPress);
            this.Txt_addtionPaymentrate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_addtionPayment_KeyUp);
            this.Txt_addtionPaymentrate.Leave += new System.EventHandler(this.Txt_addtionPaymentrate_Leave);
            this.Txt_addtionPaymentrate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Txt_addtionPayment_MouseDown);
            this.Txt_addtionPaymentrate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Txt_addtionPaymentrate_MouseMove);
            // 
            // Txt_PricePayment
            // 
            this.Txt_PricePayment.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_PricePayment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PricePayment.ForeColor = System.Drawing.SystemColors.Info;
            this.Txt_PricePayment.Location = new System.Drawing.Point(4, 86);
            this.Txt_PricePayment.Name = "Txt_PricePayment";
            this.Txt_PricePayment.Size = new System.Drawing.Size(134, 26);
            this.Txt_PricePayment.TabIndex = 131;
            this.Txt_PricePayment.Text = "0";
            this.Txt_PricePayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_PricePayment.Click += new System.EventHandler(this.Txt_PricePayment_Click);
            this.Txt_PricePayment.TextChanged += new System.EventHandler(this.Txt_PricePayment_TextChanged);
            this.Txt_PricePayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_PricePayment_KeyPress);
            this.Txt_PricePayment.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_PricePayment_KeyUp);
            this.Txt_PricePayment.Leave += new System.EventHandler(this.Txt_PricePayment_Leave);
            this.Txt_PricePayment.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Txt_PricePayment_MouseMove);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(7, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(134, 26);
            this.textBox2.TabIndex = 136;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(148, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 18);
            this.label7.TabIndex = 135;
            this.label7.Text = "المبلغ المفروض إسترداده للعميل";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Txt_LastPayOut
            // 
            this.Txt_LastPayOut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_LastPayOut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_LastPayOut.ForeColor = System.Drawing.SystemColors.Info;
            this.Txt_LastPayOut.Location = new System.Drawing.Point(8, 50);
            this.Txt_LastPayOut.Name = "Txt_LastPayOut";
            this.Txt_LastPayOut.ReadOnly = true;
            this.Txt_LastPayOut.Size = new System.Drawing.Size(134, 26);
            this.Txt_LastPayOut.TabIndex = 134;
            this.Txt_LastPayOut.Text = "0";
            this.Txt_LastPayOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_PayLast
            // 
            this.Txt_PayLast.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_PayLast.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_PayLast.ForeColor = System.Drawing.SystemColors.Info;
            this.Txt_PayLast.Location = new System.Drawing.Point(9, 17);
            this.Txt_PayLast.Name = "Txt_PayLast";
            this.Txt_PayLast.ReadOnly = true;
            this.Txt_PayLast.Size = new System.Drawing.Size(134, 26);
            this.Txt_PayLast.TabIndex = 133;
            this.Txt_PayLast.Text = "0";
            this.Txt_PayLast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_RentCompany
            // 
            this.Txt_RentCompany.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_RentCompany.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_RentCompany.ForeColor = System.Drawing.SystemColors.Info;
            this.Txt_RentCompany.Location = new System.Drawing.Point(469, 207);
            this.Txt_RentCompany.Name = "Txt_RentCompany";
            this.Txt_RentCompany.ReadOnly = true;
            this.Txt_RentCompany.Size = new System.Drawing.Size(134, 26);
            this.Txt_RentCompany.TabIndex = 132;
            this.Txt_RentCompany.Text = "0";
            this.Txt_RentCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_Total
            // 
            this.Txt_Total.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Txt_Total.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Total.ForeColor = System.Drawing.SystemColors.Info;
            this.Txt_Total.Location = new System.Drawing.Point(469, 13);
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.ReadOnly = true;
            this.Txt_Total.Size = new System.Drawing.Size(134, 26);
            this.Txt_Total.TabIndex = 130;
            this.Txt_Total.Text = "0";
            this.Txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(233, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 128;
            this.label4.Text = "المدفوع مسبقا";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(549, 130);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(46, 22);
            this.label5.TabIndex = 131;
            this.label5.Text = "خزينة";
            // 
            // cmb_Stock
            // 
            this.cmb_Stock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Stock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Stock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Stock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Stock.FormattingEnabled = true;
            this.cmb_Stock.Location = new System.Drawing.Point(229, 125);
            this.cmb_Stock.Name = "cmb_Stock";
            this.cmb_Stock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Stock.Size = new System.Drawing.Size(265, 27);
            this.cmb_Stock.TabIndex = 130;
            // 
            // txt_username
            // 
            this.txt_username.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_username.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(229, 43);
            this.txt_username.Name = "txt_username";
            this.txt_username.ReadOnly = true;
            this.txt_username.Size = new System.Drawing.Size(265, 32);
            this.txt_username.TabIndex = 133;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 132;
            this.label2.Text = "اسم المستخدم";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(229, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(265, 32);
            this.comboBox1.TabIndex = 137;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(537, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 135;
            this.label3.Text = "التاريخ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(561, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 24);
            this.label6.TabIndex = 134;
            this.label6.Text = "فرع";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(330, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 34);
            this.dateTimePicker1.TabIndex = 138;
            // 
            // txt_patientname
            // 
            this.txt_patientname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_patientname.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patientname.Location = new System.Drawing.Point(27, 89);
            this.txt_patientname.Name = "txt_patientname";
            this.txt_patientname.ReadOnly = true;
            this.txt_patientname.Size = new System.Drawing.Size(111, 32);
            this.txt_patientname.TabIndex = 139;
            this.txt_patientname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.simpleButton1.Location = new System.Drawing.Point(302, 520);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(178, 32);
            this.simpleButton1.TabIndex = 181;
            this.simpleButton1.Text = "حفظ التحويل";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Txt_IdCust
            // 
            this.Txt_IdCust.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_IdCust.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IdCust.Location = new System.Drawing.Point(27, 128);
            this.Txt_IdCust.Name = "Txt_IdCust";
            this.Txt_IdCust.ReadOnly = true;
            this.Txt_IdCust.Size = new System.Drawing.Size(111, 32);
            this.Txt_IdCust.TabIndex = 182;
            this.Txt_IdCust.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_IdCust.TextChanged += new System.EventHandler(this.Txt_IdCust_TextChanged);
            // 
            // txt_IdTeckit
            // 
            this.txt_IdTeckit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_IdTeckit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdTeckit.Location = new System.Drawing.Point(604, 94);
            this.txt_IdTeckit.Name = "txt_IdTeckit";
            this.txt_IdTeckit.ReadOnly = true;
            this.txt_IdTeckit.Size = new System.Drawing.Size(134, 32);
            this.txt_IdTeckit.TabIndex = 183;
            this.txt_IdTeckit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_OldRentBeforeTransfair
            // 
            this.Txt_OldRentBeforeTransfair.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_OldRentBeforeTransfair.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_OldRentBeforeTransfair.Location = new System.Drawing.Point(604, 135);
            this.Txt_OldRentBeforeTransfair.Name = "Txt_OldRentBeforeTransfair";
            this.Txt_OldRentBeforeTransfair.ReadOnly = true;
            this.Txt_OldRentBeforeTransfair.Size = new System.Drawing.Size(134, 32);
            this.Txt_OldRentBeforeTransfair.TabIndex = 184;
            this.Txt_OldRentBeforeTransfair.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_TotalBeforeTransfair
            // 
            this.Txt_TotalBeforeTransfair.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_TotalBeforeTransfair.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TotalBeforeTransfair.Location = new System.Drawing.Point(27, 167);
            this.Txt_TotalBeforeTransfair.Name = "Txt_TotalBeforeTransfair";
            this.Txt_TotalBeforeTransfair.ReadOnly = true;
            this.Txt_TotalBeforeTransfair.Size = new System.Drawing.Size(111, 32);
            this.Txt_TotalBeforeTransfair.TabIndex = 185;
            this.Txt_TotalBeforeTransfair.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_OldBranch
            // 
            this.Txt_OldBranch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_OldBranch.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_OldBranch.Location = new System.Drawing.Point(604, 12);
            this.Txt_OldBranch.Name = "Txt_OldBranch";
            this.Txt_OldBranch.ReadOnly = true;
            this.Txt_OldBranch.Size = new System.Drawing.Size(134, 32);
            this.Txt_OldBranch.TabIndex = 186;
            this.Txt_OldBranch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_IdOldBranch
            // 
            this.Txt_IdOldBranch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Txt_IdOldBranch.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_IdOldBranch.Location = new System.Drawing.Point(604, 53);
            this.Txt_IdOldBranch.Name = "Txt_IdOldBranch";
            this.Txt_IdOldBranch.ReadOnly = true;
            this.Txt_IdOldBranch.Size = new System.Drawing.Size(134, 32);
            this.Txt_IdOldBranch.TabIndex = 187;
            this.Txt_IdOldBranch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_TransferToCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(758, 560);
            this.Controls.Add(this.Txt_IdOldBranch);
            this.Controls.Add(this.Txt_OldBranch);
            this.Controls.Add(this.Txt_TotalBeforeTransfair);
            this.Controls.Add(this.Txt_OldRentBeforeTransfair);
            this.Controls.Add(this.txt_IdTeckit);
            this.Controls.Add(this.Txt_IdCust);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txt_patientname);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_Stock);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cmb_Company);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(774, 572);
            this.Name = "Frm_TransferToCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "شاشة تحويل إلى جهة أخرى";
            this.Load += new System.EventHandler(this.Frm_TransferToCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmb_Company;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_reasonAddition;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_addtionPaymentrate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Stock;
        public System.Windows.Forms.TextBox txt_username;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.TextBox txt_patientname;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        public System.Windows.Forms.TextBox Txt_IdCust;
        public System.Windows.Forms.TextBox txt_IdTeckit;
        public System.Windows.Forms.TextBox Txt_OldRentBeforeTransfair;
        private System.Windows.Forms.TextBox Txt_Total;
        private System.Windows.Forms.TextBox Txt_PricePayment;
        private System.Windows.Forms.TextBox Txt_RentCompany;
        public System.Windows.Forms.TextBox Txt_PayLast;
        public System.Windows.Forms.TextBox Txt_LastPayOut;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox Txt_TotalBeforeTransfair;
        private System.Windows.Forms.TextBox Txt_RentCustomer;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox Txt_OldBranch;
        public System.Windows.Forms.TextBox Txt_IdOldBranch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdb_discountPatient;
        private System.Windows.Forms.RadioButton rdb_MoneyPatient;
    }
}