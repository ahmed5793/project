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
    public partial class Frm_TransProductList : Form
    {
        Product Product = new Product();

        public Frm_TransProductList()
        {
            InitializeComponent();
        }

        private void Btn_selectProduct_MouseClick(object sender, MouseEventArgs e)
        {
  
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_selectProduct_MouseClick_1(object sender, MouseEventArgs e)
        {
          
        }

        private void Btn_selectProduct_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Update_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.DataSource = null;
            this.Close();
        }

        private void Frm_TransProductList_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

              
            BL.Product p = new Product();

           
              dataGridView1.DataSource=  p.Search_ComboTransfairProductT(textBox1.Text);

           
            }
            catch (Exception EX)
            {

                MessageBox.Show(EX.Message);
            }
        }
    }
}
