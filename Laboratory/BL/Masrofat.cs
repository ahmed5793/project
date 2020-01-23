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
    class Masrofat
    {
        internal void AddReserve(string TypeReserve)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            da.open();
            param[0] = new SqlParameter("@TypeReserve", SqlDbType.NVarChar, 200);
            param[0].Value = TypeReserve;

            da.excutequery("AddReserve", param);
            da.close();
        }
        internal DataTable SelectReserve()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();

            dt = da.selected("SelectReserve", null);
            da.close();
            return dt;
        }

        internal void AddReserveDetails(int IdReserve, string decription, decimal amount, DateTime date, int Id_Stock , string Sales_Man)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[6];
            da.open();
            param[0] = new SqlParameter("@idReserve", SqlDbType.Int);
            param[0].Value = IdReserve;
            param[1] = new SqlParameter("@decraiption", SqlDbType.NVarChar, 500);
            param[1].Value = decription;
            param[2] = new SqlParameter("@amount", SqlDbType.Decimal);
            param[2].Value = amount;
            param[3] = new SqlParameter("@date", SqlDbType.DateTime);
            param[3].Value = date;
            param[4] = new SqlParameter("@ID_Stock", SqlDbType.Int);
            param[4].Value = Id_Stock;
            param[5] = new SqlParameter("@Sales_man", SqlDbType.NVarChar,100);
            param[5].Value = Sales_Man;

            da.excutequery("AddReserveDetails", param);
            da.close();
        }

        internal void DeleteReserveDetails(int id)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            da.open();
            param[0] = new SqlParameter("@id_ReserveDetails", SqlDbType.Int);
            param[0].Value = id;
            da.excutequery("DeleteReserveDetails", param);
            da.close();
        }
        internal void UpdateResrveDetails(int id, int IdReserve, string decription, decimal amount, DateTime date, int Id_Stock , string Sales_Man)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[7];
            da.open();
            param[0] = new SqlParameter("@idReserve", SqlDbType.Int);
            param[0].Value = IdReserve;
            param[1] = new SqlParameter("@decraiption", SqlDbType.NVarChar, 400);
            param[1].Value = decription;
            param[2] = new SqlParameter("@amount", SqlDbType.Decimal);
            param[2].Value = amount;
            param[3] = new SqlParameter("@date", SqlDbType.DateTime);
            param[3].Value = date;
            param[4] = new SqlParameter("@id", SqlDbType.Int);
            param[4].Value = id;
            param[5] = new SqlParameter("@ID_Stock", SqlDbType.Int);
            param[5].Value = Id_Stock;
            param[6] = new SqlParameter("@Sales_man", SqlDbType.Int);
            param[6].Value = Sales_Man;
            da.excutequery("UpdateResrveDetails", param);
            da.close();
        }
        internal DataTable SelectReserveDetails()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();

            dt = da.selected("SelectReserveDetails", null);
            da.close();
            return dt;
        }
        internal DataTable SelectTotallReserve()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();

            dt = da.selected("SelectTotallReserve", null);
            da.close();
            return dt;
        }
        internal DataTable search_Masrofat(DateTime FromDate, DateTime ToDate)
        {
            DataAccessLayer da = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            DataTable dt = new DataTable();
            param[0] = new SqlParameter("@Date_From", SqlDbType.DateTime);
            param[0].Value = FromDate;
            param[1] = new SqlParameter("@Date_to", SqlDbType.DateTime);
            param[1].Value = ToDate;
            dt = da.selected("search_Masrofat", param);
            return dt;

        }
        internal DataTable select_Masrofat()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();

            dt = da.selected("select_Masrofat", null);
            da.close();
            return dt;
        }

    }
}
