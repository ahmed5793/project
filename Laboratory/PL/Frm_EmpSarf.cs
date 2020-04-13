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
    public partial class Frm_EmpSarf : Form
    {
        Employee E = new Employee();

        DataTable dt = new DataTable();
        Users U = new Users();
        Branches b = new Branches();

        public Frm_EmpSarf()
        {
            InitializeComponent();
        
            txt_UserName.Text = Program.salesman;
            Permision();
       


        }
        void Permision()
        {
            try
            {
            dt.Clear();
            dt = U.SelectUserBranch(txt_UserName.Text);
            if (dt.Rows.Count > 0)
            {
                cmb_Branch.DataSource = U.SelectUserBranch(txt_UserName.Text);
                cmb_Branch.DisplayMember = "Name";
                cmb_Branch.ValueMember = "Branch_ID";
            }
            else
            {
                cmb_Branch.DataSource = b.SelectCompBranches();
                cmb_Branch.DisplayMember = "Name";
                cmb_Branch.ValueMember = "Branch_ID";
            }
            cmb_employeeName.DataSource = E.Select_EmployeeFromBranchToAddShift(Convert.ToInt32(cmb_Branch.SelectedValue));
            cmb_employeeName.DisplayMember = "Emp_Name";
            cmb_employeeName.ValueMember = "id_employee";
            cmb_employeeName.SelectedIndex = -1;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void Frm_EmpSarf_Load(object sender, EventArgs e)
        {
        
        }

        private void cmb_employeeName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void calc()
        {
            if (txt_salf.Text == "" )
            {
               
                txt_salf.Text = "0";
            }
            if ( txt_discount.Text == "" )
            {
             
                txt_discount.Text = "0";
             
            }
            if (Txt_salary.Text == "" )
            {
                Txt_salary.Text = "0";
         
            }

            decimal x = 0;
                x = Convert.ToDecimal(Txt_salary.Text) - (Convert.ToDecimal(txt_salf.Text) + Convert.ToDecimal(txt_discount.Text));
                label6.Text = x.ToString();
            
        }
        private void cmb_employeeName_SelectionChangeCommitted(object sender, EventArgs e)
        {
          

            



          

        }
        


    

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
          
            
        }

        private void Txt_salary_TextChanged(object sender, EventArgs e)
        {
            if (Txt_salary.Text=="")
            {
                Txt_salary.Text = "0";
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
      


        }

        private void Txt_salary_KeyUp(object sender, KeyEventArgs e)
        {
            calc();
        }

        private void Txt_salary_Leave(object sender, EventArgs e)
        {
            if (Txt_salary.Text=="")
            {
                Txt_salary.Text = "0";
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void txt_discount_Leave(object sender, EventArgs e)
        {
            if (txt_discount.Text == "")
            {
                txt_discount.Text = "0";
            }
        }

        private void txt_salf_Leave(object sender, EventArgs e)
        {
            if (txt_salf.Text == "")
            {
                txt_salf.Text = "0";
            }
        }

        private void txt_discount_KeyUp(object sender, KeyEventArgs e)
        {
            calc();
        }

        private void txt_salf_KeyUp(object sender, KeyEventArgs e)
        {
            calc();
        }

        private void txt_total_KeyUp(object sender, KeyEventArgs e)
        {
            calc();
        }

        private void Txt_salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && Txt_salary.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void txt_salf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_salf.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void txt_discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_discount.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void cmb_employeeName_Leave(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_employeeName.Text == "")
                {
                    MessageBox.Show("قم بااختيار اسم الموظف");
                    return;
                }
                if (Txt_salary.Text == "0" || Txt_salary.Text == "")
                {
                    MessageBox.Show("قم بكتابه المرتب الذي تريد صرفة ");
                    return;
                }
                dt.Clear();
                dt = E.vildateEmployeeSalary(Convert.ToInt32(cmb_employeeName.SelectedValue), dateTimePicker2.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("عزيزي المستخدم يرجي العلم بان هذا الموظف تم صرف مرتبة في هذا الشهر لايمكن اتمام العمليه", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                E.AddEmp_Salary(Convert.ToInt32(cmb_employeeName.SelectedValue), Convert.ToDecimal(Txt_salary.Text),
                   Convert.ToDecimal(txt_salf.Text), Convert.ToDecimal(label6.Text), dateTimePicker1.Value,
                   txt_note.Text, txt_UserName.Text, dateTimePicker2.Text, Convert.ToDecimal(txt_discount.Text));

                MessageBox.Show("تم تسجيل البيانات بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


                txt_note.Clear();
                Txt_salary.Text = "0";
                txt_salf.Text = "0";
                txt_discount.Text = "0";
                label6.Text = "0.00";



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);

            }
        }

        private void cmb_Branch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txt_note.Clear();
            Txt_salary.Text = "0";
            txt_salf.Text = "0";
            txt_discount.Text = "0";
            label6.Text = "0.00";
            cmb_employeeName.DataSource = E.Select_EmployeeFromBranchToAddShift(Convert.ToInt32(cmb_Branch.SelectedValue));
            cmb_employeeName.DisplayMember = "Emp_Name";
            cmb_employeeName.ValueMember = "id_employee";
            cmb_employeeName.SelectedIndex = -1;
        }

        private void cmb_Branch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
