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
            dataGridView1.DataSource = null;
            this.Close();
        }

        private void Btn_selectProduct_Click(object sender, EventArgs e)
        {

        }

        private void btn_prod_MouseClick(object sender, MouseEventArgs e)
        {
            dataGridView1.DataSource = null;
            this.Close();
        }
    }
}
