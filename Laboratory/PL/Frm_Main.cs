﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laboratory.BL;

namespace Laboratory.PL
{
    public partial class Frm_Main : Form
    {
        Users u = new Users();
        public Frm_Main()
        {
            InitializeComponent();


        }

        private void hghjvmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void إضافةاصنافلمخزنToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void تحويلأصنافمنمخزنلمخزنToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Add_Store_Click(object sender, EventArgs e)
        {
            Frm_AddStore frm_AddStore = new Frm_AddStore();
            frm_AddStore.ShowDialog();
        }

        private void Add_Product_Click(object sender, EventArgs e)
        {
            Add_Product ap = new Add_Product();
            ap.ShowDialog();
        }

        private void Add_customer_Click(object sender, EventArgs e)
        {

        }

        private void Add_masrof_Click(object sender, EventArgs e)
        {
            Frm_Masrofat fm = new Frm_Masrofat();
            fm.ShowDialog();
        }

        private void Add_Stock_Click(object sender, EventArgs e)
        {
            frm_AddStock fas = new frm_AddStock();
            fas.ShowDialog();
        }

        private void Stock_Pull_Click(object sender, EventArgs e)
        {
            Frm_StockPull fsp = new Frm_StockPull();
            fsp.ShowDialog();
        }

        private void Insert_Stock_Click(object sender, EventArgs e)
        {
            frm_AddStockMoney fasm = new frm_AddStockMoney();
            fasm.ShowDialog();
        }

        private void Stock_Transfair_Click(object sender, EventArgs e)
        {
            Frm_StockTransfair fst = new Frm_StockTransfair();
            fst.ShowDialog();
        }

        private void Add_Customer_Click_1(object sender, EventArgs e)
        {
            Frm_Customer fc = new Frm_Customer();
            fc.ShowDialog();
        }

        private void إضافةشركةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Company frm_Company = new Frm_Company();
            frm_Company.ShowDialog();

        }

        private void Add_Doctor_Click(object sender, EventArgs e)
        {
            Frm_Doctor frm_Doctor = new Frm_Doctor();

            frm_Doctor.Show();
        }

        private void Store_Management_ButtonClick(object sender, EventArgs e)
        {

        }

        private void Add_Employee_Click(object sender, EventArgs e)
        {
            Frm_Employee frm_Employee = new Frm_Employee();
            frm_Employee.Show();

        }

        private void السلفياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Salf frm_Salf = new Frm_Salf();

            frm_Salf.Show();

        }

        private void صرفالمرتباتToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Add_XRays_Click(object sender, EventArgs e)
        {
            Frm_ItemsXRaya frm_ItemsXRaya = new Frm_ItemsXRaya();

            frm_ItemsXRaya.Show();

        }

        private void Category_XRay_Click(object sender, EventArgs e)
        {
            Frm_CategoryXRaya frm_CategoryX = new Frm_CategoryXRaya();

            frm_CategoryX.Show();

        }

        private void Main_data_Click(object sender, EventArgs e)
        {

        }

        private void Add_Branche_Click(object sender, EventArgs e)
        {
            Frm_Branches frm_Branches = new Frm_Branches();
            frm_Branches.Show();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void Add_Masrof_Click_1(object sender, EventArgs e)
        {
            Frm_Masrofat frm_Masrofat = new Frm_Masrofat();
            frm_Masrofat.Show();
        }

        private void Report_Masrofat_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            label2.Text = Program.salesman;
            label1.Text = u.SelectUserBranch(label2.Text).Rows[0][1].ToString();
        }

        private void AddStore_Click(object sender, EventArgs e)
        {
            Frm_AddStore frm_AddStore = new Frm_AddStore();
            frm_AddStore.Show();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            Add_Product add_Product = new Add_Product();
            add_Product.Show();
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {

        }

        private void Teicket_Click(object sender, EventArgs e)
        {
            Frm_Tickets frm_Tickets = new Frm_Tickets();
            frm_Tickets.ShowDialog();
        }

        private void Add_StoreProduct_Click(object sender, EventArgs e)
        {
            Add_StoreProduct Asp = new Add_StoreProduct();
            Asp.ShowDialog();
        }

        private void TransFairProduct_Click(object sender, EventArgs e)
        {
            Tranfair_product tranfair_Product = new Tranfair_product();
            tranfair_Product.ShowDialog();
        }

        private void Doctoer_Management_Click(object sender, EventArgs e)
        {

        }

        private void إنشاءحسابللموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ManagmentUser frm_ManagmentUser = new Frm_ManagmentUser();
            frm_ManagmentUser.ShowDialog();
        }

        private void AddSupplier_Click(object sender, EventArgs e)
        {
            Frm_Suppliers frm_Suppliers = new Frm_Suppliers();
            frm_Suppliers.ShowDialog();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Sarf_Mortbat_Click(object sender, EventArgs e)
        {
            Frm_EmpSarf frm_EmpSarf = new Frm_EmpSarf();
            frm_EmpSarf.Show();
        }

        private void Doctors_Center_Click(object sender, EventArgs e)
        {
            Frm_DoctorOfCenter frm_DoctorOfCenter = new Frm_DoctorOfCenter();
            frm_DoctorOfCenter.ShowDialog();
        }

        private void Techniqual_Click(object sender, EventArgs e)
        {
            Frm_Techincal frm_Techincal = new Frm_Techincal();
            frm_Techincal.ShowDialog();
        }

        private void Pay_Customer_Click(object sender, EventArgs e)
        {
            Frm_PayClient frm_PayClient = new Frm_PayClient();
            frm_PayClient.ShowDialog();

        }

        private void Pay_Suppliers_Click(object sender, EventArgs e)
        {
            Frm_PaySuppliers frm_PaySuppliers = new Frm_PaySuppliers();
            frm_PaySuppliers.ShowDialog();
        }

        private void مديونيةالموردينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_DebitSuppliers frm_Debit = new Frm_DebitSuppliers();
            frm_Debit.ShowDialog();
        }

        private void Report_PaySupplier_Click(object sender, EventArgs e)
        {
            Frm_ReportPaySuppliers frm_ReportPaySuppliers = new Frm_ReportPaySuppliers();
            frm_ReportPaySuppliers.ShowDialog();
        }

        private void pay_company_Click(object sender, EventArgs e)
        {
            Frm_PayCompany pc = new Frm_PayCompany();
            pc.ShowDialog();
        }

        private void ConsumingProduct_Click(object sender, EventArgs e)
        {
            Frm_Order frm_Order = new Frm_Order();
            frm_Order.ShowDialog();


        }

        private void اضافةالموظفينللفروعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_AddEmployeeBranch employeeBranch = new Frm_AddEmployeeBranch();
            employeeBranch.ShowDialog();
        }

        private void PurshaseProduct_Click(object sender, EventArgs e)
        {
            Frm_Purshasing frm_Purshasing = new Frm_Purshasing();
            frm_Purshasing.ShowDialog();
        }
    }
}
