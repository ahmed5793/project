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
    class Doctors
    {
        internal void AddDoctor(string name, string phone, string address, DateTime StartDate,int idDepartment)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[0].Value = name;

            param[1] = new SqlParameter("@phone", SqlDbType.VarChar, 50);
            param[1].Value = phone;

            param[2] = new SqlParameter("@address", SqlDbType.NVarChar, 250);
            param[2].Value = address;

            param[3] = new SqlParameter("@StartDate", SqlDbType.DateTime);
            param[3].Value = StartDate;
            param[4] = new SqlParameter("@IDDepartment", SqlDbType.Int);
            param[4].Value = idDepartment;



            da.excutequery("AddDoctor", param);

            da.close();

        }

        internal void AddDepartmentDoctor(string name)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[0].Value = name;




            da.excutequery("AddDepartmentDoctor", param);

            da.close();

        }
        internal DataTable SelectDoctor()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("SelectDoctor", null);
            da.close();
            return dt;
        }
        internal DataTable CompoDoctor()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("CompoDoctor", null);
            da.close();
            return dt;
        }
        internal DataTable CompoDoctorDepatrtment()
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            dt = da.selected("CompoDoctorDepatrtment", null);
            da.close();
            return dt;
        }

        internal DataTable SearchDoctor(string name)
        {
            DataTable dt = new DataTable();

            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 300);
            param[0].Value = name;

            dt = da.selected("SearchDoctor", param);
            da.close();
            return dt;
        }
        internal void UpdateDoctor(string name, string phone, int id, string address,int idDepartment)
        {
            DataAccessLayer da = new DataAccessLayer();
            da.open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 300);
            param[0].Value = name;

            param[1] = new SqlParameter("@phone", SqlDbType.VarChar, 100);
            param[1].Value = phone;

            param[2] = new SqlParameter("@id", SqlDbType.Int);
            param[2].Value = id;
            param[3] = new SqlParameter("@address", SqlDbType.NVarChar, 250);
            param[3].Value = address;
            param[4] = new SqlParameter("@IDDepartment", SqlDbType.Int);
            param[4].Value = idDepartment;
            da.excutequery("UpdateDoctor", param);
            da.close();


        }
    }
}