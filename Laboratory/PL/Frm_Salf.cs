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
    public partial class Frm_Salf : Form
    {
        Users U = new Users();
        Branches b = new Branches();
        Employee E = new Employee();
        DataTable dt = new DataTable();
        public Frm_Salf()
        {
            InitializeComponent();
            gridControl1.DataSource = E.SelectEmployeeSalf(Convert.ToInt32(cmb_branch.SelectedValue));
            gridView1.Columns[0].Visible = false;
            txt_userName.Text = Program.salesman;
            Permision();
            btn_save.Show();
            btn_Update.Enabled = false;
        }
        DataTable dt1 = new DataTable();

        private void btn_save_Click(object sender, EventArgs e)
        {
        }
        void Permision()
        {

            dt.Clear();
            dt = U.SelectUserBranch(txt_userName.Text);
            if (dt.Rows.Count > 0)
            {
                cmb_branch.DataSource = U.SelectUserBranch(txt_userName.Text);
                cmb_branch.DisplayMember = "Name";
                cmb_branch.ValueMember = "Branch_ID";
            }
            else
            {
                cmb_branch.DataSource = b.SelectCompBranches();
                cmb_branch.DisplayMember = "Name";
                cmb_branch.ValueMember = "Branch_ID";
            }
            cmb_employeeName.DataSource = E.Select_EmployeeFromBranchToAddShift(Convert.ToInt32(cmb_branch.SelectedValue));
            cmb_employeeName.DisplayMember = "Emp_Name";
            cmb_employeeName.ValueMember = "id_employee";
            cmb_employeeName.SelectedIndex = -1;
         
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
        //    if (cmb_employeeName.Text == "")
        //    {
        //        MessageBox.Show("قم بااختيار اسم الموظف");
        //        return;

        //    }

        //    if (txt_userName.Text == "")
        //    {
        //        MessageBox.Show("قم بااختيار اسم الداين");
        //        return;

        //    }

        //    if (Txt_money.Text == "")
        //    {
        //        MessageBox.Show("من فضلك قم بكتابة المبلغ");
        //        return;

        //    }
        //    else
        //    {
        //        E.UpdateEmployee_Salf(txt_userName.Text, dateTimePicker1.Value, dateTimePicker2.Value, txt_note.Text, Convert.ToDecimal(Txt_money.Text), Convert.ToInt32(cmb_employeeName.SelectedValue)
        //            ,Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
        //        MessageBox.Show("تم التعديل بنجاح");
        //        txt_note.Clear();
        //        txt_userName.Clear();
        //        Txt_money.Clear();
          
        //        btn_save.Show();
           


        //    }
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txt_note.Clear();
            txt_userName.Clear();
            Txt_money.Clear();
     
            btn_save.Show();
         
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
          
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
           
            //dt = E.SearchEmployeeSalf(txt_search.Text);
            //gridControl1.DataSource = dt;
        }

        private void Txt_money_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && Txt_money.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }
      

        private void Frm_Salf_Load(object sender, EventArgs e)
        {
        //    cmb_employeeName.DataSource = E.SelectCompoEmployee();
        //    cmb_employeeName.DisplayMember = "Emp_Name";
        //    cmb_employeeName.ValueMember = "Emp_ID";       
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmb_employeeName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_employeeName_SelectionChangeCommitted(object sender, EventArgs e)
        {
      
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Txt_money_KeyDown(object sender, KeyEventArgs e)
        {
           
         
        }

        private void Txt_money_MouseLeave(object sender, EventArgs e)
        {
            if (Txt_money.Text=="")
            {
                Txt_money.Text = "0";
               
            }
            
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
         
        }

        private void Txt_money_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void cmb_employeeName_Leave(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (cmb_employeeName.Text != "")
            {
                dt.Clear();
                dt = E.VildateEmployeeShift(Convert.ToInt32(cmb_employeeName.SelectedValue));
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("يرجي العلم بان اسم الموظف غير مسجل من قبل يرجي تسجيل هذا الاسم في شاشه الموظفين", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    cmb_employeeName.Focus();
                    cmb_employeeName.SelectAll();
                    return;
                }
                dt.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (Txt_money.Text == "" || Txt_money.Text == "0")
            {
                MessageBox.Show("من فضلك قم بكتابة المبلغ");
                return;

            }




            if (cmb_employeeName.Text == "")
            {
                MessageBox.Show("قم بااختيار اسم الموظف");
                return;

            }

            if (txt_userName.Text == "")
            {
                MessageBox.Show("قم بااختيار اسم الداين");
                return;

            }


            //dt1.Clear();
            //dt1 = E.SelectCHECKSalaryEmployee(Convert.ToInt32(cmb_employeeName.SelectedValue));
            //if (dt1.Rows.Count > 0)
            //{
            //    MessageBox.Show("عزيزى المستخدم يرجي العلم بان هذا الموظف قام بعمليه استلاف من قبل لايمكن اتمام هذا العمليه مرتين");


            //    txt_NameDaen.Clear();
            //    txt_note.Clear();
            //    Txt_money.Clear();
            //    return;

            //}

            //dt.Clear();
            //dt = E.SelectSalary(Convert.ToInt32(cmb_employeeName.SelectedValue), Convert.ToDecimal(Txt_money.Text));

            //if (dt.Rows.Count > 0)
            //{

            E.AddEmployee_Salf(txt_userName.Text, dateTimePicker1.Value, dateTimePicker2.Value, txt_note.Text,
                Convert.ToDecimal(Txt_money.Text), Convert.ToInt32(cmb_employeeName.SelectedValue),Convert.ToInt32(cmb_branch.SelectedValue));
            MessageBox.Show("تم التسجيل بنجاح");

            gridControl1.DataSource = E.SelectEmployeeSalf(Convert.ToInt32(cmb_branch.SelectedValue)); txt_note.Clear();
            txt_userName.Clear();
            Txt_money.Clear();

            txt_note.Clear();
            txt_userName.Clear();
            Txt_money.Clear();

            btn_save.Show();


            // }

            //else
            //{
            //    MessageBox.Show("عزيزى المستخدم يرجي العلم بان مبلغ الاستلاف اكبر من الراتب الشهرى للموظف لايسمح بقيام العمليه");



            //}










        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (Txt_money.Text == "" || Txt_money.Text == "0")
            {
                MessageBox.Show("من فضلك قم بكتابة المبلغ");
                return;

            }







            E.UpdateEmployee_Salf( Convert.ToDecimal(Txt_money.Text), Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID_Salf")));
          

          
            MessageBox.Show("تم التعديل بنجاح");
            txt_note.Clear();
           
            Txt_money.Clear();

            btn_save.Show();

            btn_Update.Enabled = false;
            cmb_branch.Enabled = true;
            txt_note.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            cmb_employeeName.Enabled = true;
            gridControl1.DataSource = E.SelectEmployeeSalf(Convert.ToInt32(cmb_branch.SelectedValue));
        }

        private void cmb_branch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            gridControl1.DataSource = E.SelectEmployeeSalf(Convert.ToInt32(cmb_branch.SelectedValue));
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount > 0 && gridView1.SelectedRowsCount > 0)
                {
                    cmb_branch.Enabled = false;
                    txt_note.Enabled = false;
                    dateTimePicker1.Enabled = false;
                    dateTimePicker2.Enabled = false;
                    cmb_employeeName.Enabled = false;

                    cmb_employeeName.Text = gridView1.GetFocusedRowCellValue("اسم الموظف").ToString();
                    cmb_branch.Text = gridView1.GetFocusedRowCellValue("فرع").ToString();
                    dateTimePicker1.Text = gridView1.GetFocusedRowCellValue("تاريخ السلف").ToString();
                    Txt_money.Text = gridView1.GetFocusedRowCellValue("المبلغ").ToString();
                    dateTimePicker2.Text = gridView1.GetFocusedRowCellValue("تاريخ الاستحقاق").ToString();
                    txt_note.Text = gridView1.GetFocusedRowCellValue("ملاحظات").ToString();
                    //txt_userName.Text = gridView1.GetFocusedRowCellValue("اسم المستخدم").ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
    }
    }

