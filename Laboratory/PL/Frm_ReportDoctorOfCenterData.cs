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
    public partial class Frm_ReportDoctorOfCenterData : Form
    {
        DoctorOfCenter d = new DoctorOfCenter();

        public Frm_ReportDoctorOfCenterData()
        {
            InitializeComponent();
            dataGridView1.DataSource = d.SelectDoctor_OFCENTER();

        }
    }
}
