﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraGrid.Views.Grid;
using Laboratory.BL;
using Laboratory.RPT;
using Laboratory.RPT_Order;
using DevExpress.XtraReports.UI;

namespace Laboratory.PL
{
    public partial class Frm_ManagmentTickets : Form
    {
        Users u = new Users();
        Branches b = new Branches();
        Tickets t = new Tickets();
        Frm_Payouts pa = new Frm_Payouts();
        DataTable dt10 = new DataTable();
        DataTable dt5 = new DataTable();
        DataTable dt7 = new DataTable();
        DataTable dt1 = new DataTable();

        public Frm_ManagmentTickets()
        {
            InitializeComponent();
            txt_username.Text = Program.salesman;
            Permision();

        }

        private void dgv_visit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void Permision()
        {
            try
            {
                dt10.Clear();
                dt10 = u.SelectUserBranch(txt_username.Text);

                if (dt10.Rows.Count > 0)
                {
                    cmb_branches.DataSource = u.SelectUserBranch(txt_username.Text);
                    cmb_branches.DisplayMember = "Name";
                    cmb_branches.ValueMember = "Branch_ID";
                }
                else
                {
                    cmb_branches.DataSource = b.SelectCompBranches();
                    cmb_branches.DisplayMember = "Name";
                    cmb_branches.ValueMember = "Branch_ID";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Hide();
            label3.Hide();
            FromDate.Hide();
            ToDate.Hide();
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {

            gridControl1.DataSource = t.SelectSearchticketsBranchDate(Convert.ToInt32(cmb_branches.SelectedValue), FromDate.Value, ToDate.Value);
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                //Frm_DetailsTickets fd = new Frm_DetailsTickets();
                if (gridView1.RowCount > 0)
                {
                    dt5.Clear();
                    dt5 = t.vildateReturnTickets(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                    if (dt5.Rows.Count > 0)
                    {
                        if (Convert.ToDecimal(gridView1.GetFocusedRowCellValue("المدفوع")) == Convert.ToDecimal(dt5.Rows[0][1]))
                        {
                            MessageBox.Show("عزيزى المستخدم يرجي العلم باان تم استرداد مبلغ الفاتورة من قبل لايمكن استرداها مرة اخرى   ", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    //dt10.Clear();
                    //dt10 = t.vildateTransferForCompany(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                    //if (dt10.Rows.Count > 0)
                    //{
                    //    MessageBox.Show("عزيزى المستخدم يرجي العلم باان تم تحويل الفاتورة الي جهه اخري واسترداد المبلغ   ", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    //    return;
                    //}
                    dt7.Clear();
                    dt7 = t.TicketDetailsSelectTickets(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                    foreach (DataRow dr in dt7.Rows)
                    {
                        pa.txt_name.Text = dr[1].ToString();
                        pa.txt_date.Text = dr[5].ToString();
                        pa.txt_total.Text = dr[12].ToString();
                        pa.txt_pay.Text = dr[13].ToString();
                        pa.txt_rent.Text = dr[14].ToString();
                        pa.txt_statues.Text = dr[15].ToString();
                        pa.textBox1.Text = dr[20].ToString();
                        pa.txt_num.Text = dr[0].ToString();
                        pa.Txt_IdCust.Text = dr[26].ToString();
                    }
                    dt10.Clear();
                    dt10 = t.Select_IdCompanyAndRentFromTicket(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                    if (gridView1.GetFocusedRowCellValue("طريقه التعامل").ToString() == "شركات")
                    {
                        foreach (DataRow dr in dt10.Rows)
                        {
                            pa.Txt_IdCompany.Text = dr[0].ToString();
                            pa.Txt_RentCompany.Text = dr[2].ToString();
                        }
                    }
                    dt5.Clear();
                    dt5 = t.vildateReturnTickets(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                    foreach (DataRow item in dt5.Rows)
                    {
                        pa.Txt_ReturnMoney.Text = item[1].ToString();
                    }
                    dt1.Clear();
                    dt1 = t.TicketDetailsSelectTicketsDetAILS(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                    pa.dataGridView1.DataSource = dt1;
                    pa.dataGridView1.Columns[0].Visible = false;
                    pa.dataGridView1.Columns[3].Visible = false;

                    pa.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_DetailsTickets fd = new Frm_DetailsTickets();
                if (gridView1.RowCount > 0)
                {
                    dt10.Clear();
                    dt10 = t.vildateTicketCompany(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                    if (dt10.Rows.Count > 0)
                    {
                        fd.Txt_PricePayment.Hide();
                        fd.Txt_addtionPayment.Hide();
                        fd.txt_idcompany.Hide();
                        fd.label26.Hide();
                        fd.label27.Hide();
                        fd.txt_company.Hide();
                        fd.label21.Hide();
                        dt5.Clear();
                        dt5 = t.TicketDetailsSelectTickets(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                        foreach (DataRow dr in dt5.Rows)
                        {
                            fd.txt_name.Text = dr[1].ToString();
                            fd.txt_phone.Text = dr[2].ToString();
                            fd.txt_address.Text = dr[3].ToString();
                            fd.txt_age.Text = dr[4].ToString();
                            fd.txt_dateVisit.Text = dr[5].ToString();
                            fd.txt_dateRecive.Text = dr[6].ToString();
                            fd.txt_doctorOfCenter.Text = dr[7].ToString();
                            fd.txt_doctor.Text = dr[8].ToString();
                            fd.txt_branch.Text = dr[9].ToString();
                            fd.txt_techincal.Text = dr[10].ToString();
                            fd.txt_stock.Text = dr[11].ToString();
                            fd.txt_total.Text = dr[12].ToString();
                            fd.txt_pay.Text = dr[13].ToString();
                            fd.txt_rent.Text = dr[14].ToString();
                            fd.txt_statues.Text = dr[15].ToString();
                            fd.txt_username.Text = dr[16].ToString();
                            fd.txt_compint.Text = dr[17].ToString();
                            fd.txt_timeKa4f.Text = dr[18].ToString();
                            fd.txt_discount.Text = dr[19].ToString();
                            fd.txt_place.Text = dr[20].ToString();
                            fd.txt_afterDiscount.Text = dr[21].ToString();
                            fd.txt_reasonAddition.Text = dr[22].ToString();
                            fd.txt_idnationa.Text = dr[23].ToString();
                            fd.txt_idtickets.Text = dr[0].ToString();
                            fd.txt_idstock.Text = dr[24].ToString();
                            fd.txt_idbranche.Text = dr[25].ToString();
                        }
                    }
                    else
                    {
                        fd.txt_company.Show();
                        fd.label21.Show();
                        fd.Txt_PricePayment.Show();
                        fd.Txt_addtionPayment.Show();
                        fd.txt_afterDiscount.Hide();
                        fd.txt_discount.Hide();
                        fd.label9.Hide();
                        fd.label24.Hide();
                        fd.label26.Show();
                        fd.label27.Show();
                        fd.txt_idcompany.Show();
                        dt10.Clear();
                        dt10 = t.TicketDetailsSelectTicketsCompany(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));

                        foreach (DataRow dr in dt10.Rows)
                        {
                            fd.txt_name.Text = dr[1].ToString();
                            fd.txt_phone.Text = dr[2].ToString();
                            fd.txt_address.Text = dr[3].ToString();
                            fd.txt_age.Text = dr[4].ToString();
                            fd.txt_dateVisit.Text = dr[5].ToString();
                            fd.txt_dateRecive.Text = dr[6].ToString();
                            fd.txt_doctorOfCenter.Text = dr[7].ToString();
                            fd.txt_doctor.Text = dr[8].ToString();
                            fd.txt_branch.Text = dr[9].ToString();
                            fd.txt_techincal.Text = dr[10].ToString();
                            fd.txt_stock.Text = dr[11].ToString();
                            fd.txt_total.Text = dr[12].ToString();
                            fd.txt_pay.Text = dr[13].ToString();
                            fd.txt_rent.Text = dr[14].ToString();
                            fd.txt_statues.Text = dr[15].ToString();
                            fd.txt_username.Text = dr[16].ToString();
                            fd.txt_company.Text = dr[17].ToString();
                            fd.txt_compint.Text = dr[18].ToString();
                            fd.txt_timeKa4f.Text = dr[19].ToString();
                            fd.txt_place.Text = dr[20].ToString();
                            fd.txt_afterDiscount.Text = dr[21].ToString();
                            fd.txt_reasonAddition.Text = dr[22].ToString();
                            fd.Txt_PricePayment.Text = dr[23].ToString();
                            fd.Txt_addtionPayment.Text = dr[24].ToString();
                            fd.txt_idnationa.Text = dr[25].ToString();
                            fd.txt_idtickets.Text = dr[0].ToString();
                            fd.txt_idstock.Text = dr[26].ToString();
                            fd.txt_idbranche.Text = dr[27].ToString();
                            fd.txt_idcompany.Text = dr[28].ToString();
                        }
                    }
                    dt1.Clear();
                    dt1 = t.TicketDetailsSelectTicketsDetAILS(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                    fd.dgv_order.DataSource = dt1;
                    fd.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }
        frm_SingelReport sr = new frm_SingelReport();

        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount > 0)
                {
                    if (gridView1.GetFocusedRowCellValue("طريقه التعامل").ToString() == "نقدى")
                    {
                        Rpt_OrderPay report = new Rpt_OrderPay();
                        RPT.Order.DataSetOrderPay dso = new RPT.Order.DataSetOrderPay();
                        DataTable dt1 = new DataTable();
                        sr.documentViewer1.Refresh();
                        dt1.Clear();
                        dt1 = t.ReportInvoiceTicketPay(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة").ToString()));
                        dso.Tables["DataTable1"].Clear();
                        for (int i = 0; i < dt1.Rows.Count; i++)
                        {
                            dso.Tables["DataTable1"].Rows.Add(Convert.ToInt32(dt1.Rows[0][0]), dt1.Rows[0][1], dt1.Rows[0][2],
                                Convert.ToDecimal(dt1.Rows[0][3]), dt1.Rows[0][4], dt1.Rows[0][5], Convert.ToInt32(dt1.Rows[0][6]), Convert.ToDateTime(dt1.Rows[0][7]),
                                Convert.ToDateTime(dt1.Rows[0][8]), dt1.Rows[0][9], dt1.Rows[0][10], dt1.Rows[0][11], dt1.Rows[0][12], dt1.Rows[0][13],
                                Convert.ToDecimal(dt1.Rows[0][14]), Convert.ToDecimal(dt1.Rows[0][15]), Convert.ToDecimal(dt1.Rows[0][16]),
                                dt1.Rows[0][17], dt1.Rows[0][18], dt1.Rows[0][19], Convert.ToDateTime(dt1.Rows[0][20]), Convert.ToDecimal(dt1.Rows[0][21]),
                                dt1.Rows[0][22], Convert.ToDecimal(dt1.Rows[0][23]), dt1.Rows[0][24], Convert.ToInt32(dt1.Rows[0][25]), Convert.ToInt32(dt1.Rows[0][26]),
                                Convert.ToInt32(dt1.Rows[0][27]));
                        }
                        report.DataSource = dso;
                        report.Parameters["idTicket"].Value = Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة").ToString());
                        sr.documentViewer1.DocumentSource = report;
                        report.Parameters["idTicket"].Visible = false;
                        sr.documentViewer1.Enabled = true;
                        sr.ShowDialog();
                    }
                    else if (gridView1.GetFocusedRowCellValue("طريقه التعامل").ToString() == "شركات")
                    {
                        RPT.Order.Rpt_TeckietCompanyOrder oc = new RPT.Order.Rpt_TeckietCompanyOrder();
                        RPT.Order.DataSetOrderPay dso = new RPT.Order.DataSetOrderPay();
                        DataTable dt1 = new DataTable();
                        dt1.Clear();
                        dt1 = t.ReportInvoiceTicketCompany(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة").ToString()));
                        dso.Tables["dataCompany"].Clear();
                        for (int i = 0; i < dt1.Rows.Count; i++)
                        {
                            dso.Tables["dataCompany"].Rows.Add(Convert.ToInt32(dt1.Rows[0][0]), dt1.Rows[0][1], dt1.Rows[0][2],
                                Convert.ToDecimal(dt1.Rows[0][3]), dt1.Rows[0][4], dt1.Rows[0][5], Convert.ToInt32(dt1.Rows[0][6]), Convert.ToDateTime(dt1.Rows[0][7]),
                                Convert.ToDateTime(dt1.Rows[0][8]), dt1.Rows[0][9], dt1.Rows[0][10], dt1.Rows[0][11], dt1.Rows[0][12], dt1.Rows[0][13],
                                Convert.ToDecimal(dt1.Rows[0][14]), Convert.ToDecimal(dt1.Rows[0][15]), Convert.ToDecimal(dt1.Rows[0][16]),
                                dt1.Rows[0][17], dt1.Rows[0][18], dt1.Rows[0][19], dt1.Rows[0][20], Convert.ToDateTime(dt1.Rows[0][21]), Convert.ToDecimal(dt1.Rows[0][22]),
                                dt1.Rows[0][23], Convert.ToDecimal(dt1.Rows[0][24]), dt1.Rows[0][25], Convert.ToDecimal(dt1.Rows[0][26]),
                                Convert.ToDecimal(dt1.Rows[0][27]), Convert.ToInt32(dt1.Rows[0][28]), Convert.ToInt32(dt1.Rows[0][29]),
                                Convert.ToInt32(dt1.Rows[0][30]), Convert.ToInt32(dt1.Rows[0][31]));
                        }
                        sr.documentViewer1.Refresh();
                        oc.DataSource = dso;
                        oc.Parameters["idTicket"].Value = Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة").ToString());
                        sr.documentViewer1.DocumentSource = oc;
                        oc.Parameters["idTicket"].Visible = false;
                        sr.documentViewer1.Enabled = true;

                        //string printerName = Properties.Settings.Default.PrintNameInvoice;




                        ////Specify the printer name.
                        //oc.PrinterName = printerName;

                        ////Create the document.
                        //oc.CreateDocument();
                     
                      
                      
                        sr.ShowDialog();

                    }


                    // ReportPrintTool tool = new ReportPrintTool(report);
                    //tool.ShowRibbonPreview();
                    //  report.RequestParameters = false;
                    //XtraReport1 x = new XtraReport1();
                    //s.documentViewer1.Refresh();
                    //    x.Parameters["@idTicket"].Value = Convert.ToInt32(dgv_visit.CurrentRow.Cells[0].Value);
                    //x.DataSource = t.ReportInvoiceTicketPay(Convert.ToInt32(dgv_visit.CurrentRow.Cells[0].Value));
                    //s.documentViewer1.DocumentSource = x;
                    //x.Parameters["@idTicket"].Visible = false;
                    //  x.RequestParameters = false;
                    //s.ShowDialog();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount > 0)
                {
                    DataSet1 ds1 = new DataSet1();
                    DataTable dt = new DataTable();
                    dt.Clear();
                    dt = t.PrintBarcode(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة").ToString()));
                    RPT.RPT_Barcode rb = new RPT.RPT_Barcode();
                    sr.documentViewer1.Refresh();

                    ds1.Tables["DataTable1"].Clear();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ds1.Tables["DataTable1"].Rows.Add(Convert.ToInt32(dt.Rows[i][0]), dt.Rows[i][1], dt.Rows[i][2],
                            dt.Rows[i][3], Convert.ToDateTime(dt.Rows[i][4]));
                    }
                    rb.DataSource = ds1;
                    rb.Parameters["idTicket"].Value = Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة").ToString());

                    sr.documentViewer1.DocumentSource = rb;
                    rb.Parameters["idTicket"].Visible = false;



        string printerName = Properties.Settings.Default.PrintNameBarcode;
       
        
    

            //Specify the printer name.
            rb.PrinterName = printerName;

            //Create the document.
            rb.CreateDocument();

            ReportPrintTool pt = new ReportPrintTool(rb);
            pt.Print();
                  
                
                 




          
        }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridView1.RowCount > 0)
                {

                    if (gridView1.GetFocusedRowCellValue("طريقه التعامل").ToString() == "شركات")
                    {
                        MessageBox.Show("لا يصلح تحويل الفحص من شركة إلى شركة اخرى يرجى إرتجاع المبلغ بالكامل لهذا الفحص ثم عمل حجز جديد للشركة الجديدة");
                        return;
                    }
                    dt10.Clear();
                    dt10 = t.vildateTransferForCompany(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة").ToString()));
                    if (dt10.Rows.Count > 0)
                    {
                        MessageBox.Show("تم تحويل هذا الفحص من قبل ");
                        return;
                    }

                    Frm_TransferToCompany tc = new Frm_TransferToCompany();
                    dt1.Clear();
                    dt1 = t.TicketDetailsSelectTicketsDetAILS(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));

                    tc.dataGridView1.DataSource = dt1;

                    tc.dataGridView1.Columns[0].Visible = false;
                    tc.dataGridView1.Columns[3].Visible = false;

                    dt10.Clear();
                    dt10 = t.TicketDetailsSelectTickets(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                    foreach (DataRow dr in dt10.Rows)
                    {
                        tc.txt_IdTeckit.Text = dr[0].ToString();
                        tc.Txt_PayLast.Text = dr[13].ToString();
                        tc.txt_patientname.Text = dr[1].ToString();
                        tc.Txt_IdCust.Text = dr[26].ToString();
                        tc.Txt_TotalBeforeTransfair.Text = dr[14].ToString();
                    }
                    dt5.Clear();
                    dt5 = t.vildateReturnTickets(Convert.ToInt32(gridView1.GetFocusedRowCellValue("رقم الفاتورة")));
                    foreach (DataRow item in dt5.Rows)
                    {
                        tc.Txt_RentCustomer.Text = item[1].ToString();
                    }
                    tc.ShowDialog();
                    //this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_ManagmentTickets_Load(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
