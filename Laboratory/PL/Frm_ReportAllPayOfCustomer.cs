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
    public partial class Frm_ReportAllPayOfCustomer : Form
    {
        Customer C = new Customer();
        DataTable dt5 = new DataTable();
        DataTable dt = new DataTable();
        public Frm_ReportAllPayOfCustomer()
        {
            InitializeComponent();
            comboBox2.DataSource = C.SelectCompoCustomerN2dy();
            comboBox2.DisplayMember = "Cust_Name";
            comboBox2.ValueMember = "Cust_ID";
            gridControl1.DataSource = C.Select_AllPayCustomer(Convert.ToInt32(comboBox2.SelectedValue));
            dt5.Clear();
            dt5 = C.Select_CustomertotalBAlance(Convert.ToInt32(comboBox2.SelectedValue));
            textBox1.Text = dt5.Rows[0][0].ToString();
        }
        //void Calc()
        //{
        //    Decimal total = 0;
        //    for (int i = 0; i < gridView1.DataRowCount; i++)
        //    {
        //        DataRow row = gridView1.GetDataRow(i);

        //        total += Convert.ToDecimal(row[2].ToString());
        //    }
        //    txt_TotalPurshacing.Text = Math.Round(total, 1).ToString();
        //}
     
        private void comboBox2_Leave(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.Text != "")
                {
                    dt.Clear();
                    dt = C.validate_CustomerName(Convert.ToInt32(comboBox2.SelectedValue));
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("إسم العميل غير موجود لا بد من إختيار إسم العميل من القائمة");
                        comboBox2.Focus();
                        textBox1.Clear();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            gridControl1.DataSource = C.Select_AllPayCustomer(Convert.ToInt32(comboBox2.SelectedValue));
            dt5.Clear();
            dt5 = C.Select_CustomertotalBAlance(Convert.ToInt32(comboBox2.SelectedValue));
            textBox1.Text = dt5.Rows[0][0].ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.Text != "")
                {
                    dt5.Clear();
                    dt5 = C.Search_AllPayCustomerNameanddate(Convert.ToInt32(comboBox2.SelectedValue), DateFrom.Value, DateTo.Value);
                    if (dt5.Rows.Count > 0)
                    {
                        gridControl1.DataSource = dt5;
                    }
                    else
                    {
                        gridControl1.DataSource = null;
                        MessageBox.Show("لا يوجد معاملات فى هذه الفتره");
                        return;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void Frm_ReportAllPayOfCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
