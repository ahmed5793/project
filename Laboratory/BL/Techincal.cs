﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratory.DAL;
using System.Data;
using System.Data.SqlClient;


namespace Laboratory.BL
{
    class Techincal
    {
        internal void AddTechincal(string name, string phone, string address)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[0].Value = name;
            param[1] = new SqlParameter("@phone", SqlDbType.VarChar, 50);
            param[1].Value = phone;
            param[2] = new SqlParameter("@address", SqlDbType.NVarChar, 250);
            param[2].Value = address;
            da.excutequery("AddTechincal", param);
            da.close();
        }


        internal DataTable SelectTechincal()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectTechincal", null);
            da.close();
            return dt;
        }
        internal DataTable CompoTechibncal()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("CompoTechibncal", null);
            da.close();
            return dt;
        }

        internal DataTable SearchTechincal(string name)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 300);
            param[0].Value = name;

            dt = da.selected("SearchTechincal", param);
            da.close();
            return dt;
        }
        internal void UpdateTechincal(string name, string phone, int id, string address)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 300);
            param[0].Value = name;

            param[1] = new SqlParameter("@phone", SqlDbType.VarChar, 100);
            param[1].Value = phone;

            param[2] = new SqlParameter("@id", SqlDbType.Int);
            param[2].Value = id;
            param[3] = new SqlParameter("@address", SqlDbType.NVarChar, 250);
            param[3].Value = address;

            da.excutequery("UpdateTechincal", param);
            da.close();
        }
        internal DataTable Select_ComboTechnical()
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("Select_ComboTechnical", null);
            da.close();
            return dt;
        }
        internal DataTable Select_ReportTechnical(int id)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("Select_ReportTechnical", param);
            da.close();
            return dt;
        }
        internal DataTable Search_ReportTechnical(int id, DateTime Date_From, DateTime Date_To)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@Date_From", SqlDbType.Date);
            param[1].Value = Date_From;
            param[2] = new SqlParameter("@Date_To", SqlDbType.Date);
            param[2].Value = Date_To;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("Search_ReportTechnical", param);
            da.close();
            return dt;
        }
        internal DataTable vildateTechincal(int id)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("vildateTechincal", param);
            da.close();
            return dt;
        }
        internal DataTable Technical_ItemXray(int id)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_Technical", SqlDbType.Int);
            param[0].Value = id;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("Technical_ItemXray", param);
            da.close();
            return dt;
        }
        internal DataTable Search_Technical_ItemXray( DateTime Date_From, DateTime Date_To)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
           
            param[0] = new SqlParameter("@Date_from", SqlDbType.Date);
            param[0].Value = Date_From;
            param[1] = new SqlParameter("@Date_To", SqlDbType.Date);
            param[1].Value = Date_To;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("Search_Technical_ItemXray", param);
            da.close();
            return dt;
        }
        internal DataTable Search_Technical_ItemXrayPay(DateTime Date_From, DateTime Date_To)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Date_from", SqlDbType.Date);
            param[0].Value = Date_From;
            param[1] = new SqlParameter("@Date_To", SqlDbType.Date);
            param[1].Value = Date_To;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("Search_Technical_ItemXrayPay", param);
            da.close();
            return dt;
        }
        internal DataTable Search_Technical_ItemXrayCompany(DateTime Date_From, DateTime Date_To)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Date_from", SqlDbType.Date);
            param[0].Value = Date_From;
            param[1] = new SqlParameter("@Date_To", SqlDbType.Date);
            param[1].Value = Date_To;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("Search_Technical_ItemXrayCompany", param);
            da.close();
            return dt;
        }
        internal void Add_TechnicalShift(int Technical_Id, int Id_Shift, string Date_shift , string StartTime_Shift , 
                                          string EndTime_Shift , decimal Amount,string Sales_Man , int Id_Branch )
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@Techincal_ID", SqlDbType.Int);
            param[0].Value = Technical_Id;
            param[1] = new SqlParameter("@ID_Shift1", SqlDbType.Int);
            param[1].Value = Id_Shift;
            param[2] = new SqlParameter("@Date_Shift", SqlDbType.NVarChar,100);
            param[2].Value = Date_shift;
            param[3] = new SqlParameter("@Start_Time_Shift", SqlDbType.NVarChar, 100);
            param[3].Value = StartTime_Shift;
            param[4] = new SqlParameter("@End_Time_Shift", SqlDbType.NVarChar, 100);
            param[4].Value = EndTime_Shift;
            param[5] = new SqlParameter("@Amount", SqlDbType.Decimal);
            param[5].Value = Amount;
            param[6] = new SqlParameter("@User_Name", SqlDbType.NVarChar,100);
            param[6].Value = Sales_Man;
            param[7] = new SqlParameter("@Id_Branch", SqlDbType.Int);
            param[7].Value = Id_Branch;
            da.excutequery("Add_TechnicalShift", param);
            da.close();
        }
        internal void Update_TechnicalShift(int ID_Shift,int Technical_Id, int Id_Shift, string Date_shift, 
            string StartTime_Shift, string EndTime_Shift, decimal Amount ,string Sales_Man , int Id_Branch)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@ID_Shift", SqlDbType.Int);
            param[0].Value = ID_Shift;
            param[1] = new SqlParameter("@Techincal_ID", SqlDbType.Int);
            param[1].Value = Technical_Id;
            param[2] = new SqlParameter("@ID_Shift1", SqlDbType.Int);
            param[2].Value = Id_Shift;
            param[3] = new SqlParameter("@Date_Shift", SqlDbType.NVarChar, 100);
            param[3].Value = Date_shift;
            param[4] = new SqlParameter("@Start_Time_Shift", SqlDbType.NVarChar, 100);
            param[4].Value = StartTime_Shift;
            param[5] = new SqlParameter("@End_Time_Shift", SqlDbType.NVarChar, 100);
            param[5].Value = EndTime_Shift;
            param[6] = new SqlParameter("@Amount", SqlDbType.Decimal);
            param[6].Value = Amount;
            param[7] = new SqlParameter("@User_Name", SqlDbType.NVarChar, 100);
            param[7].Value = Sales_Man;
            param[8] = new SqlParameter("@Id_Branch", SqlDbType.Int);
            param[8].Value = Id_Branch;
            da.excutequery("Update_TechnicalShift", param);
            da.close();
        }
        internal void Delete_TechnicalShift(int Id_Shift)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID_Shift", SqlDbType.Int);
            param[0].Value = Id_Shift;
            da.excutequery("Delete_TechnicalShift", param);
            da.close();
        }
        internal void Add_TypeShift(string Type_Shift)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Type_Shift", SqlDbType.NVarChar,100);
            param[0].Value = Type_Shift;

            da.excutequery("Add_TypeShift", param);
            da.close();
        }
        internal DataTable Select_ComboTypeShift()
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("Select_ComboTypeShift", null);
            da.close();
            return dt;
        }
        internal DataTable Select_TechnicalShift()
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("Select_TechnicalShift", null);
            da.close();
            return dt;
        }
        internal DataTable Search_TechnicalShift(string id)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.NVarChar,50);
            param[0].Value = id;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("Search_TechnicalShift", param);
            da.close();
            return dt;
        }
        internal DataTable Validate_TypeShift(int id)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id_type", SqlDbType.Int);
            param[0].Value = id;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("Validate_TypeShift", param);
            da.close();
            return dt;
        }
        internal DataTable Report_TechnicalShift(int Id_Technical , DateTime Date_From ,DateTime Date_To)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id_Technical", SqlDbType.Int);
            param[0].Value = Id_Technical;
            param[1] = new SqlParameter("@Date_from", SqlDbType.Date);
            param[1].Value = Date_From;
            param[2] = new SqlParameter("@Date_to", SqlDbType.Date);
            param[2].Value = Date_To;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("Report_TechnicalShift", param);
            da.close();
            return dt;
        }

        internal DataTable SelectDateCountTechincal(int idTechincal, DateTime Date_From, DateTime Date_To)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@idTechincal", SqlDbType.Int);
            param[0].Value = idTechincal;
            param[1] = new SqlParameter("@Date_From", SqlDbType.Date);
            param[1].Value = Date_From;
            param[2] = new SqlParameter("@Date_To", SqlDbType.Date);
            param[2].Value = Date_To;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("SelectDateCountTechincal", param);
            da.close();
            return dt;
        }
        internal DataTable SelectDateCountTechincalPay(int idTechincal, DateTime Date_From, DateTime Date_To)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@idTechincal", SqlDbType.Int);
            param[0].Value = idTechincal;
            param[1] = new SqlParameter("@Date_From", SqlDbType.Date);
            param[1].Value = Date_From;
            param[2] = new SqlParameter("@Date_To", SqlDbType.Date);
            param[2].Value = Date_To;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("SelectDateCountTechincalPay", param);
            da.close();
            return dt;
        }
        internal DataTable SelectDateCountTechincalCompany(int idTechincal, DateTime Date_From, DateTime Date_To)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@idTechincal", SqlDbType.Int);
            param[0].Value = idTechincal;
            param[1] = new SqlParameter("@Date_From", SqlDbType.Date);
            param[1].Value = Date_From;
            param[2] = new SqlParameter("@Date_To", SqlDbType.Date);
            param[2].Value = Date_To;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("SelectDateCountTechincalCompany", param);
            da.close();
            return dt;
        }
        internal void add_TechnicalShiftPrice(int Id_Technical, int  Id_TypeShift, decimal Price)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@TID_TypeShift", SqlDbType.Int);
            param[0].Value = Id_Technical;
            param[1] = new SqlParameter("@Id_Technical", SqlDbType.Int);
            param[1].Value = Id_TypeShift;
            param[2] = new SqlParameter("@Price", SqlDbType.Int );
            param[2].Value = Price;
            da.excutequery("add_TechnicalShiftPrice", param);
            da.close();
        }
        internal void Update_TechnicalShiftPrice(int Id_Technical, int Id_TypeShift, decimal Price)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@TID_TypeShift", SqlDbType.Int);
            param[0].Value = Id_Technical;
            param[1] = new SqlParameter("@Id_Technical", SqlDbType.Int);
            param[1].Value = Id_TypeShift;
            param[2] = new SqlParameter("@Price", SqlDbType.Int);
            param[2].Value = Price;
            da.excutequery("Update_TechnicalShiftPrice", param);
            da.close();
        }

        internal DataTable Select_TechnicalShiftPrice(int  Id_Technical)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id_Technical", SqlDbType.Int);
            param[0].Value = Id_Technical;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("Select_TechnicalShiftPrice", param);
            da.close();
            return dt;
        }
        internal DataTable TechnicalShiftPrice(int Id_Technical,int Id_Type)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Id_Technical", SqlDbType.Int);
            param[0].Value = Id_Technical;
            param[1] = new SqlParameter("@Id_ShiftType", SqlDbType.Int);
            param[1].Value = Id_Type;
            da.open();
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.selected("TechnicalShiftPrice", param);
            da.close();
            return dt;
        }
    }
}
