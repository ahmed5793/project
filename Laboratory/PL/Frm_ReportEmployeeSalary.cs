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
    public partial class Frm_ReportEmployeeSalary : Form
    {
        Employee E = new Employee();
        public Frm_ReportEmployeeSalary()
        {
            InitializeComponent();
            checkBox1.Checked = true;
        }

        private void Frm_ReportEmployeeSalary_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = E.SelectCompoEmployee();
            comboBox1.DisplayMember = "Emp_Name";
            comboBox1.ValueMember = "Emp_ID";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                comboBox1.Enabled = true;

                comboBox1.DataSource = E.SelectCompoEmployee();
                comboBox1.DisplayMember = "Emp_Name";
                comboBox1.ValueMember = "Emp_ID";
            }
            else
            {
                comboBox1.Enabled = false;

                comboBox1.DataSource = null;
                gridControl1.DataSource = null;
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (comboBox1.Text != "")
            {
                dt.Clear();
                dt = E.VildateEmployeeShift(Convert.ToInt32(comboBox1.SelectedValue));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("يرجي العلم بان اسم الموظف غير مسجل من قبل يرجي تسجيل هذا الاسم في شاشه الموظفين", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    comboBox1.Focus();
                    comboBox1.SelectAll();
                    return;
                }
                dt.Dispose();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                gridControl1.DataSource = E.RrportEmployeeSalary(Convert.ToInt32(comboBox1.SelectedValue), dateTimePicker1.Text, dateTimePicker2.Text);
            }
            else
            {
                gridControl1.DataSource = E.RrportEmployeeSalaryDate(dateTimePicker1.Text, dateTimePicker2.Text);

            }
            decimal total = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                total += Convert.ToDecimal(row[5].ToString());

            }
            textBox1.Text = total.ToString("₱ #,##0.0");
        }
    }
}
