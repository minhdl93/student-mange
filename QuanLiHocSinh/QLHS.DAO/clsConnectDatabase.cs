﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace QLHS.DAO
{
    public class clsConnectDatabase
    {
        public SqlConnection KetNoi() {
            string connectionStr = @"Data Source=ANHNHAT-PC\SQLEXPRESS;Initial Catalog=Quanlyhocsinh1;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
                SqlConnection connection = new SqlConnection(connectionStr);
                return connection;
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
