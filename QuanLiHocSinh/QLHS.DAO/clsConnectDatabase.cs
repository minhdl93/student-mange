﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace QLHS.DAO
{
    public class clsConnectDatabase
    {
        private string connectionStr = "";
        public SqlConnection KetNoi()
        {
            //string connectionStr = @"Data Source=ANHNHAT-PC\SQLEXPRESS;Initial Catalog=QuanLyHocSinh4;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            //string connectionStr = @"Data Source=DANGLIENMINH\SQLEXPRESS;Initial Catalog=QuanLyHocSinh4;Integrated Security=True";
            
            //string connectionStr = "";
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["con"];
            // nếu tìm thấy connection string thì trả lại connection string
            if (settings != null)
                connectionStr = settings.ConnectionString;
            SqlConnection connection = new SqlConnection(connectionStr);
            return connection;
        }

        public string layKetNoi()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["con"];
            // nếu tìm thấy connection string thì trả lại connection string
            if (settings != null)
                connectionStr = settings.ConnectionString;
            return connectionStr;
        }

        public void kiemTraKetNoi(SqlConnection con)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
    }
}
