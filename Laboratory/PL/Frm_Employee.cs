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
    public partial class Frm_Employee : Form
    {
        Employee E = new Employee();
        DataTable dt = new DataTable();
        Branches b = new Branches();
        private static Frm_Employee farm;

        static void STATUESCllosed(object sender, FormClosedEventArgs e)
        {
            farm = null;
        }
        public static Frm_Employee getmain
        {
            get
            {
                if (farm == null)
                {
                    farm = new Frm_Employee();
                    farm.FormClosed += new FormClosedEventHandler(STATUESCllosed);
                }
                return farm;
            }
        }

        public Frm_Employee()
        {
            InitializeComponent();
            if (farm == null)
            {
                farm = this;
            }
            clears();
            dataGridView1.DataSource = E.SelectEmployee();

            cmb_department.DataSource = E.SelectEmpRoleCompo();
            cmb_department.DisplayMember = "Roles";
            cmb_department.ValueMember = "ID_EmpRole";

            cmb_branch.DataSource = b.SelectCompBranches();
            cmb_branch.DisplayMember = "Name";
            cmb_branch.ValueMember = "Branch_ID";

        }
        void clears()
        {
            Btn_Add.Enabled = true;
            Btn_Update.Enabled = false;
            txt_address.Clear();
            txt_name.Clear();
            txt_NationalID.Clear();
            txt_phone.Clear();
            Txt_Salary.Clear();           
        }
        private void btn_GenderJob_Click(object sender, EventArgs e)
        {
            Frm_GenderJob fg = new Frm_GenderJob();
            fg.ShowDialog();
            cmb_department.DataSource = E.SelectEmpRoleCompo();
        }

        private void Frm_Employee_Load(object sender, EventArgs e)
        {
            Txt_Salary.Hide();
            checkBox1.Checked = false;
            cmb_branch.DataSource = b.SelectCompBranches();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count>0)
            {
                Txt_Salary.Show();           
                Btn_Update.Enabled = true;
                Btn_Add.Enabled = false;
                txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                cmb_department.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
                dateTimePicker1.Text= dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_phone.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_address.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_NationalID.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
                if (dataGridView1.CurrentRow.Cells[8].Value.ToString()== "شيفت")
                {
                    Txt_Salary.Hide();
                }
                else if(dataGridView1.CurrentRow.Cells[8].Value.ToString() == "مرتب شهرى")
                {
                    Txt_Salary.Show();
                    Txt_Salary.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

                }
                comboBox1.Text= dataGridView1.CurrentRow.Cells[8].Value.ToString();
                if (dataGridView1.CurrentRow.Cells[9].Value.ToString()=="")
                {
                    cmb_branch.SelectedIndex = -1;
                    checkBox1.Checked = false;
                    cmb_branch.Enabled = false;
                }
                else if (dataGridView1.CurrentRow.Cells[9].Value.ToString() != null)
                {
                    cmb_branch.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                    checkBox1.Checked = true;
                    cmb_branch.Enabled = true;
                    cmb_branch.DataSource = b.SelectCompBranches();

                }
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dt.Clear();
            dt = E.SearchEmployes(txt_search.Text);
            dataGridView1.DataSource = dt;
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_NationalID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Txt_Salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && Txt_Salary.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar((System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)))
            {
                e.Handled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
   
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.Text == "شيفت")
            {
                Txt_Salary.Hide();
                Txt_Salary.Text = "0";
            }
            else if (comboBox1.Text == "مرتب شهرى")
            {
                Txt_Salary.Show();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            clears();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("من فضلك قم بااختيار نوع الراتب");
                    return;
                }

                if (txt_name.Text == "")
                {
                    MessageBox.Show("من فضلك قم بكتابة اسم الموظف");
                    return;
                }

                if (cmb_department.Text == "")
                {
                    MessageBox.Show("من فضلك قم بااختيار التخصص");
                    return;

                }
                if (Txt_Salary.Text == "")
                {
                    MessageBox.Show("من فضلك قم بتحديد المرتب");
                    Txt_Salary.Focus();
                    return;
                }
              
                else
                {
                    E.AddEmployee(txt_name.Text, Convert.ToDecimal(Txt_Salary.Text), comboBox1.Text,
                        txt_NationalID.Text, txt_phone.Text, txt_address.Text, dateTimePicker1.Value, Convert.ToInt32(cmb_department.SelectedValue));
                    dt.Clear();
                    dt = E.Select_LastId_Employee();
                    if (checkBox1.Checked==true)
                    {
                        E.AddEmployeeBranch(Convert.ToInt32(cmb_branch.SelectedValue), Convert.ToInt32(dt.Rows[0][0]));
                    }

                    MessageBox.Show("تم تسجيل الموظف بنجاح");
                    clears();
                    dataGridView1.DataSource = E.SelectEmployee();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("من فضلك قم بااختيار نوع الراتب");
                    return;
                }
                if (txt_name.Text == "")
                {
                    MessageBox.Show("من فضلك قم بكتابة اسم الموظف");
                    return;
                }
                if (cmb_department.Text == "")
                {
                    MessageBox.Show("من فضلك قم بااختيار التخصص");
                    return;
                }
              
                else
                {
                    E.UpdateEmployee(txt_name.Text, Convert.ToDecimal(Txt_Salary.Text), comboBox1.Text,
                        txt_NationalID.Text, txt_phone.Text, txt_address.Text, dateTimePicker1.Value, Convert.ToInt32(cmb_department.SelectedValue), Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    if (checkBox1.Checked==true)
                    {
                        E.UpdateEmployeeBranch(Convert.ToInt32(cmb_branch.SelectedValue),
                            Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                    }
                    MessageBox.Show("تم تعديل بيانات الموظف بنجاح");
                    clears();
                    dataGridView1.DataSource = E.SelectEmployee();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                cmb_branch.Enabled = true;
                cmb_branch.DataSource = b.SelectCompBranches();
            }
            else if(checkBox1.Checked==false)
            {
                cmb_branch.Enabled = false;
                cmb_branch.SelectedIndex = -1;
            }
        }
    }
}
