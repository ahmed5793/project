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
    public partial class Frm_Payouts : Form
    {
      
        Users u = new Users();
      
        Stock s = new Stock();
        Tickets t = new Tickets();
        Customer c = new Customer();
        Company cm = new Company();
        //DataTable dt6 = new DataTable();

        public Frm_Payouts()
           
        {
            InitializeComponent();
            Function();
        }
        void Function()
        {
            try
            {
                txt_username.Text = Program.salesman;
                Permision();
                Txt_IdCust.Hide();
                Txt_IdCompany.Hide();
                Txt_RentCompany.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void Permision()
        {
            Branches b = new Branches();
            dt.Clear();
            dt = u.SelectUserBranch(txt_username.Text);

            if (dt.Rows.Count > 0)
            {
                comboBox1.DataSource = u.SelectUserBranch(txt_username.Text);
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Branch_ID";

                cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(comboBox1.SelectedValue));
                cmb_Stock.DisplayMember = "Name_Stock";
                cmb_Stock.ValueMember = "ID_Stock";
            }
            else
            {
                comboBox1.DataSource = b.SelectCompBranches();
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "Branch_ID";

                cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(comboBox1.SelectedValue));
                cmb_Stock.DisplayMember = "Name_Stock";
                cmb_Stock.ValueMember = "ID_Stock";
            }
        }

        DataTable dt = new DataTable();
        DataTable dt4 = new DataTable();
        DataTable dt5 = new DataTable();

        private void Frm_Payouts_Load(object sender, EventArgs e)
        {
            txt_prise.Enabled = false;

        }

        private void rdbPartPay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPartPay.Checked == true)
            {
                txt_prise.Enabled = true;
            }
        }

        private void RdbAllPay_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbAllPay.Checked == true)
            {
                txt_prise.Enabled = false;
                txt_prise.Text = "0";
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DataTable dt10 = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txt_prise_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && txt_prise.Text.ToString().IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator))
            {
                e.Handled = true;
            }
        }

        private void txt_prise_TextChanged(object sender, EventArgs e)
        {
            if (txt_prise.Text==".")
            {
                txt_prise.Text = "";
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txt_prise.Text) > Convert.ToDecimal(txt_pay.Text))
                {
                    MessageBox.Show("عزيزى المستخدم يرجي العلم باان المبلغ المراد سحبة اكبر من المدفوع  ", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return;
                }
              
                dt5.Clear();
                dt5 = t.vildateReturnTickets(Convert.ToInt32(txt_num.Text));
                if (dt5.Rows.Count > 0)
                {
                    if (Convert.ToDecimal(txt_prise.Text) > (Convert.ToDecimal(txt_pay.Text) - Convert.ToDecimal(dt5.Rows[0][1])))
                    {
                        MessageBox.Show("عزيزى المستخدم يرجي العلم باان المبلغ المردود اكبر من المدفوع  ", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        return;
                    }
                }
                dt4 = s.Select_moneyStock(Convert.ToInt32(cmb_Stock.SelectedValue));
                if (cmb_Stock.Text == "")
                {
                    MessageBox.Show("لا بد من تحديد خزنة");
                    return;
                }
                if (dataGridView1.Rows.Count >= 1)
                {

                    if (RdbAllPay.Checked == true)
                    {

                        if (dt5.Rows.Count > 0)
                        {
                            if (Convert.ToDecimal(dt5.Rows[0][1]) == Convert.ToDecimal(txt_pay.Text))
                            {
                                MessageBox.Show("عزيزى المستخدم يرجي العلم باان تم استرداد مبلغ الفاتورة من قبل لايمكن استرداها مرة اخرى   ", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                                return;
                            }
                            if (Convert.ToDecimal(dt5.Rows[0][1]) > 0)
                            {
                                MessageBox.Show("عزيزى المستخدم يرجي العلم بانه تم استرداد مبلغ" + "(" + Convert.ToDecimal(dt5.Rows[0][1]) + ")" + "لهذه الفاتورة من قبل", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        if (Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value) > Convert.ToDecimal(dt4.Rows[0][0]))
                        {
                            MessageBox.Show("رصيد الخزنة الحالى غير كافى لسحب هذا المبلغ");
                            return;
                        }

                        if (MessageBox.Show("هل تريد سحب المبلغ بالكامل", "عمليه السحب", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                        {
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                t.addticketsReturn(Convert.ToInt32(txt_num.Text), Convert.ToInt32(cmb_Stock.SelectedValue), comboBox1.Text,
                                    txt_name.Text, txt_statues.Text, dataGridView1.Rows[i].Cells[1].Value.ToString(), dateTimePicker2.Value
                                    , Convert.ToDecimal(txt_pay.Text), textBox2.Text, Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value), Convert.ToDecimal(txt_pay.Text), txt_username.Text);
                            }

                            dt.Clear();
                            dt = c.Select_CustomertotalBAlance(Convert.ToInt32(Txt_IdCust.Text));
                            decimal mno1 = Convert.ToDecimal(dt.Rows[0][0]) - Convert.ToDecimal(txt_pay.Text);
                            c.Update_CustomerTotalBalance(Convert.ToInt32(Txt_IdCust.Text), mno1);
                            c.Add_CustomerAccountStatment(Convert.ToInt32(Txt_IdCust.Text), Convert.ToDecimal(txt_pay.Text),
                                Convert.ToDecimal(txt_pay.Text)
                                 , dateTimePicker2.Value, mno1, Convert.ToInt32(cmb_Stock.SelectedValue)
                                 , txt_username.Text, Convert.ToInt32(comboBox1.SelectedValue), " مردود  أشعة ورقم الحجز" + " " + txt_num.Text);
                            s.Add_StockPull(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_pay.Text), dateTimePicker2.Value, txt_username.Text, txt_name.Text + " مردودات");

                            MessageBox.Show("تم سحب المبلغ بنجاح");
                        }
                        else
                        {
                            MessageBox.Show("تم إلغاء العملية بنجاح");
                        }
                    }
                    else if (rdbPartPay.Checked == true)
                    {


                        if (Convert.ToDecimal(txt_prise.Text) > Convert.ToDecimal(dt4.Rows[0][0]))
                        {
                            MessageBox.Show("رصيد الخزنة الحالى غير كافى لسحب هذا المبلغ");
                            return;
                        }

                        if (Convert.ToDecimal(txt_prise.Text) > Convert.ToDecimal(txt_pay.Text))
                        {
                            MessageBox.Show("الرصيد المحدد أكبر من المبلغ المدفوع لحجز الاشعة");
                            return;
                        }
                        if (MessageBox.Show("هل تريد سحب المبلغ المحدد", "عمليه السحب", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                        {
                            decimal x = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value) - Convert.ToDecimal(txt_prise.Text);

                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {

                                t.addticketsReturn(Convert.ToInt32(txt_num.Text), Convert.ToInt32(cmb_Stock.SelectedValue), comboBox1.Text,
                   txt_name.Text, txt_statues.Text, dataGridView1.Rows[i].Cells[1].Value.ToString(), dateTimePicker2.Value
                   , Convert.ToDecimal(txt_prise.Text), textBox2.Text, Convert.ToDecimal(dataGridView1.Rows[i].Cells[2].Value), Convert.ToDecimal(txt_pay.Text), txt_username.Text);
                            }

                            dt.Clear();
                            dt = c.Select_CustomertotalBAlance(Convert.ToInt32(Txt_IdCust.Text));
                            decimal mno1 = Convert.ToDecimal(dt.Rows[0][0]) - Convert.ToDecimal(txt_prise.Text);
                            c.Update_CustomerTotalBalance(Convert.ToInt32(Txt_IdCust.Text), mno1);
                            c.Add_CustomerAccountStatment(Convert.ToInt32(Txt_IdCust.Text), Convert.ToDecimal(txt_prise.Text),
                                Convert.ToDecimal(txt_prise.Text)
                                 , dateTimePicker2.Value, mno1, Convert.ToInt32(cmb_Stock.SelectedValue)
                                 , txt_username.Text, Convert.ToInt32(comboBox1.SelectedValue), " مردود  أشعة ورقم الحجز" + " " + txt_num.Text);
                            s.Add_StockPull(Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToDecimal(txt_prise.Text), dateTimePicker2.Value, txt_username.Text, txt_name.Text + " مردودات");

                            MessageBox.Show("تم سحب المبلغ بنجاح");



                        }
                        else
                        {
                            MessageBox.Show("تم إلغاء العملية بنجاح");


                        }
                    }
                    if (txt_statues.Text=="شركات")
                    {
                        dt.Clear();
                        dt = cm.Select_CompanyTotalMoney(Convert.ToInt32(Txt_IdCompany.Text));
                        decimal mno = Convert.ToDecimal(dt.Rows[0][0]) - Convert.ToDecimal(Txt_RentCompany.Text);

                        cm.Update_CompanyTotalMoney(Convert.ToInt32(Txt_IdCompany.Text), mno);

                        cm.ADD_Company_TotalRent(Convert.ToInt32(Txt_IdCompany.Text), Convert.ToDecimal(Txt_RentCompany.Text),0
                        , dateTimePicker2.Value, mno, "مردود أشعة ورقم الحجز   " + " " + txt_num.Text, 
                        Convert.ToInt32(cmb_Stock.SelectedValue), Convert.ToInt32(comboBox1.SelectedValue), txt_username.Text);
                    }
                   
                    Txt_IdCust.Clear();
                    txt_prise.Text = "0";
                    this.Close();
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_Stock.DataSource = s.SelectStockBranch(Convert.ToInt32(comboBox1.SelectedValue));
            cmb_Stock.DisplayMember = "Name_Stock";
            cmb_Stock.ValueMember = "ID_Stock";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
