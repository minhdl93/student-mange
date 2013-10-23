﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using QLHS.DTO;

namespace QLHS.DAO
{
    public class clsHOCKY_DAO
    {
        private clsConnectDatabase connection;
        private SqlConnection con;

        public clsHOCKY_DAO()
        {
            connection = new clsConnectDatabase();
            con = connection.KetNoi();
        }

        public DataTable danhSachHocKy()
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_ThongTinHocKy", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.kiemTraKetNoi(con);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public void themHocKy(clsHOCKY_DTO hocKy)
        {
            SqlCommand command = new SqlCommand("SP_ThemHocKy", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAHK", SqlDbType.Char).Value = hocKy.Mahk;
            command.Parameters.Add("@TENHK", SqlDbType.NVarChar).Value = hocKy.Tenhk;
            command.Parameters.Add("@HESOHK", SqlDbType.Char).Value = hocKy.Hesohk;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        public void suaHocKy(clsHOCKY_DTO hocKy)
        {
            SqlCommand command = new SqlCommand("SP_SuaHocKy", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAHK", SqlDbType.Char).Value = hocKy.Mahk;
            command.Parameters.Add("@TENHK", SqlDbType.NVarChar).Value = hocKy.Tenhk;
            command.Parameters.Add("@HESOHK", SqlDbType.Char).Value = hocKy.Hesohk;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        public void xoaHocKy(clsHOCKY_DTO hocKy)
        {
            SqlCommand command = new SqlCommand("SP_XoaHocKy", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAHK", SqlDbType.Char).Value = hocKy.Mahk;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}
