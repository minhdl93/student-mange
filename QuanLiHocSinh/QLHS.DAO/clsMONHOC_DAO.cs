﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using QLHS.DTO;

namespace QLHS.DAO
{
    public class clsMONHOC_DAO
    {
        private clsConnectDatabase connection;
        private SqlConnection con;

        public clsMONHOC_DAO()
        {
            connection = new clsConnectDatabase();
            con = connection.KetNoi();
        }

        public DataTable danhSachMonhoc()
        {
            connection.kiemTraKetNoi(con);
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_ThongTinMonHoc", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public int soMonHoc()
        {
            int temp = -1;
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_ThongTinSoMon", con);
            command.CommandType = CommandType.StoredProcedure;
            connection.kiemTraKetNoi(con);
            if (command.ExecuteScalar().ToString() != "")
            {
                temp = int.Parse(command.ExecuteScalar().ToString());
            }
            else
            {
                temp = 0;
            }

            con.Close();
            return temp;
        }

        public void themMonHoc(clsMONHOC_DTO monHoc_DTO)
        {
            SqlCommand command = new SqlCommand("SP_ThemMonHoc", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAMH", SqlDbType.VarChar).Value = monHoc_DTO.Mamh;
            command.Parameters.Add("@TENMH", SqlDbType.NVarChar).Value = monHoc_DTO.Tenmh;
            command.Parameters.Add("@SOTIET", SqlDbType.Char).Value = monHoc_DTO.Sotiet;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        public void suaMonHoc(clsMONHOC_DTO monHoc_DTO)
        {
            SqlCommand command = new SqlCommand("SP_SuaMonHoc", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAMH", SqlDbType.VarChar).Value = monHoc_DTO.Mamh;
            command.Parameters.Add("@TENMH", SqlDbType.NVarChar).Value = monHoc_DTO.Tenmh;
            command.Parameters.Add("@SOTIET", SqlDbType.Char).Value = monHoc_DTO.Sotiet;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        public void xoaMonHoc(clsMONHOC_DTO monHoc_DTO)
        {
            SqlCommand command = new SqlCommand("SP_XoaMonHoc", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAMH", SqlDbType.VarChar).Value = monHoc_DTO.Mamh;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        //public int heSoMonHoc(clsMONHOC_DTO monHoc)
        //{
        //    int temp = -1;
        //    SqlCommand command = new SqlCommand("SP_HeSoMonHoc", con);
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.Parameters.Add("@MAMH", SqlDbType.VarChar).Value = monHoc.Mamh;
        //    connection.kiemTraKetNoi(con);
        //    if (command.ExecuteScalar()!= null)
        //    {
        //        temp = int.Parse(command.ExecuteScalar().ToString());
        //    }
        //    else
        //    {
        //        temp = 0;
        //    }

        //    con.Close();
        //    return temp;
        //}
    }
}
