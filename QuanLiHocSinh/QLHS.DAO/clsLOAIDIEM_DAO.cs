﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using QLHS.DTO;

namespace QLHS.DAO
{
    public class clsLOAIDIEM_DAO
    {
        private clsConnectDatabase connection;
        private SqlConnection con;

        public clsLOAIDIEM_DAO()
        {
            connection = new clsConnectDatabase();
            con = connection.KetNoi();
        }

        //thông tin loại điểm
        public DataTable danhSachLoaiDiem()
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand("SP_ThongTinLoaiDiem", con);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            connection.kiemTraKetNoi(con);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        //thêm loại điểm SP_ThemLoaiDiem
        public void themLoaiDiem(clsLOAIDIEM_DTO loaiDiem_DTO)
        {
            SqlCommand command = new SqlCommand("SP_ThemLoaiDiem", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MALD", SqlDbType.VarChar).Value = loaiDiem_DTO.Mald;
            command.Parameters.Add("@TENLD", SqlDbType.NVarChar).Value = loaiDiem_DTO.Tenld;
            command.Parameters.Add("@HESOLD", SqlDbType.Char).Value = loaiDiem_DTO.Hesold;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        //sửa loại điểm SP_SuaLoaiDiem
        public void suaLoaiDiem(clsLOAIDIEM_DTO loaiDiem_DTO)
        {
            SqlCommand command = new SqlCommand("SP_SuaLoaiDiem", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MALD", SqlDbType.VarChar).Value = loaiDiem_DTO.Mald;
            command.Parameters.Add("@TENLD", SqlDbType.NVarChar).Value = loaiDiem_DTO.Tenld;
            command.Parameters.Add("@HESOLD", SqlDbType.Char).Value = loaiDiem_DTO.Hesold;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        //xóa loại điểm SP_XoaLoaiDiem
        public void xoaLoaiDiem(clsLOAIDIEM_DTO loaiDiem_DTO)
        {
            SqlCommand command = new SqlCommand("SP_XoaLoaiDiem", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MALD", SqlDbType.VarChar).Value = loaiDiem_DTO.Mald;
            connection.kiemTraKetNoi(con);
            command.ExecuteNonQuery();
            con.Close();
        }

        //hệ số loại điểm SP_HeSoLoaiDiem
        public int heSoLoaiDiem(clsLOAIDIEM_DTO loaiDiem_DTO)
        {
            int temp = -1;
            SqlCommand command = new SqlCommand("SP_HeSoLoaiDiem", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MALD", SqlDbType.VarChar).Value = loaiDiem_DTO.Mald;
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
    }
}
