﻿using System;
using System.Collections.Generic;
using System.Text;
using QLHS.DTO;
using System.Data;
using System.Data.SqlClient;
namespace QLHS.DAO
{
    public class clsHOCSINH_DAO
    {
        private clsConnectDatabase connection;
        private SqlConnection con;
        public clsHOCSINH_DAO()
        {
            connection = new clsConnectDatabase();
            con = connection.KetNoi();
        }

        public DataTable danhSachHocSinh(string maNH)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_ThongTinHocSinh", con);
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = maNH;
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public void themHocSinh(clsHOCSINH_DTO hocsinh)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_ThemHocSinh", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = hocsinh.Manh;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = hocsinh.Malop;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = hocsinh.Mahs;
            command.Parameters.Add("@TENHS", SqlDbType.NVarChar).Value = hocsinh.Tenhs;
            command.Parameters.Add("@NGSINHHS", SqlDbType.SmallDateTime).Value = hocsinh.Ngaysinhhs;
            command.Parameters.Add("@GIOITINHHS", SqlDbType.Char).Value = hocsinh.Gioitinh;
            command.Parameters.Add("@DIACHIHS", SqlDbType.NVarChar).Value = hocsinh.Diachihs;
            command.Parameters.Add("@DIENTHOAIHS", SqlDbType.VarChar).Value = hocsinh.Dienthoaihs;
            command.Parameters.Add("@NGNHAPHOC", SqlDbType.SmallDateTime).Value = hocsinh.Ngnhaphoc;
            command.Parameters.Add("@HINHANHHS", SqlDbType.VarChar).Value = hocsinh.Hinhanhhs;
            command.Parameters.Add("@DANTOC", SqlDbType.NVarChar).Value = hocsinh.Dantoc;
            command.ExecuteNonQuery();
            con.Close();
        }
        public void suaHocSinh(clsHOCSINH_DTO hocsinh,string maNHTruoc,string maLopTruoc)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_SuaHocSinh", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MANHTRUOC", SqlDbType.VarChar).Value = maNHTruoc;
            command.Parameters.Add("@MALOPTRUOC", SqlDbType.VarChar).Value = maLopTruoc;
            command.Parameters.Add("@MANH", SqlDbType.VarChar).Value = hocsinh.Manh;
            command.Parameters.Add("@MALOP", SqlDbType.VarChar).Value = hocsinh.Malop;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = hocsinh.Mahs;
            command.Parameters.Add("@TENHS", SqlDbType.NVarChar).Value = hocsinh.Tenhs;
            command.Parameters.Add("@NGSINHHS", SqlDbType.SmallDateTime).Value = hocsinh.Ngaysinhhs;
            command.Parameters.Add("@GIOITINHHS", SqlDbType.Char).Value = hocsinh.Gioitinh;
            command.Parameters.Add("@DIACHIHS", SqlDbType.NVarChar).Value = hocsinh.Diachihs;
            command.Parameters.Add("@DIENTHOAIHS", SqlDbType.VarChar).Value = hocsinh.Dienthoaihs;
            command.Parameters.Add("@NGNHAPHOC", SqlDbType.SmallDateTime).Value = hocsinh.Ngnhaphoc;
            command.Parameters.Add("@HINHANHHS", SqlDbType.VarChar).Value = hocsinh.Hinhanhhs;
            command.Parameters.Add("@DANTOC", SqlDbType.NVarChar).Value = hocsinh.Dantoc;
            command.ExecuteNonQuery();
            con.Close();
        }
        public void xoaHocSinh(clsHOCSINH_DTO hocsinh)
        {
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_XoaHocSinh", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = hocsinh.Mahs;
            command.ExecuteNonQuery();
            con.Close();
        }
        public DataTable timHocSinhMaHS(clsHOCSINH_DTO hocsinh)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_TimHocSinhMaHS", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MAHS", SqlDbType.VarChar).Value = hocsinh.Mahs;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public DataTable timHocSinhTenHS(clsHOCSINH_DTO hocsinh)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_TimHocSinhTenHS", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@TENHS", SqlDbType.VarChar).Value = hocsinh.Tenhs;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public DataTable timHocSinhDanToc(clsHOCSINH_DTO hocsinh)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_TimHocSinhDanToc", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@DANTOC", SqlDbType.VarChar).Value = hocsinh.Dantoc;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public DataTable timHocSinhNgNhapHoc(clsHOCSINH_DTO hocsinh)
        {
            DataTable table = new DataTable();
            connection.kiemTraKetNoi(con);
            SqlCommand command = new SqlCommand("SP_TimHocSinhNgNhapHoc", con);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@NGNHAPHOC", SqlDbType.SmallDateTime).Value = hocsinh.Ngnhaphoc;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public  DataTable timHocSinhNangCao(clsHOCSINH_DTO hocsinh,string dieuKien)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            string STRCMD = "";
            string Temp = "";
            if (hocsinh.Mahs != "")
            {
                Temp = " WHERE MAHS=" + "'" + hocsinh.Mahs + "' ";
                if (hocsinh.Tenhs != "")
                {
                    Temp += dieuKien + " TENHS=" + "N'" + hocsinh.Tenhs + "' ";
                }
                if (hocsinh.Dantoc != "")
                {
                    Temp += dieuKien + " DANTOC=" + "N'" + hocsinh.Dantoc + "' ";
                }
                if (hocsinh.Ngnhaphoc.GetHashCode()!=0)
                {
                    Temp += dieuKien + " NGNHAPHOC=" + "'" + hocsinh.Ngnhaphoc + "' ";
                }
            }
           else if (hocsinh.Tenhs != "")
            {
                Temp = " WHERE TENHS=" + "N'" + hocsinh.Tenhs + "' ";
                if (hocsinh.Mahs != "")
                {
                    Temp += dieuKien + " MAHS=" + "'" + hocsinh.Mahs + "' ";
                }
                if (hocsinh.Dantoc != "")
                {
                    Temp += dieuKien + " DANTOC=" + "N'" + hocsinh.Dantoc + "' ";
                }
                if (hocsinh.Ngnhaphoc.GetHashCode()!=0)
                {
                    Temp += dieuKien + " NGNHAPHOC=" + "'" + hocsinh.Ngnhaphoc + "' ";
                }
            }
            else if (hocsinh.Dantoc != "")
            {
                Temp = " WHERE DANTOC=" + "N'" + hocsinh.Dantoc + "' ";
                if (hocsinh.Mahs != "")
                {
                    Temp += dieuKien + " MAHS=" + "'" + hocsinh.Mahs + "' ";
                }
                if (hocsinh.Tenhs != "")
                {
                    Temp += dieuKien + " TENHS=" + "N'" + hocsinh.Tenhs + "' ";
                }
                if (hocsinh.Ngnhaphoc.GetHashCode()!=0)
                {
                    Temp += dieuKien + " NGNHAPHOC=" + "'" + hocsinh.Ngnhaphoc + "' ";
                }
            }
            else
            {
                Temp = " WHERE NGNHAPHOC=" + "'" + hocsinh.Ngnhaphoc + "' ";
                if (hocsinh.Mahs != "")
                {
                    Temp += dieuKien + " MAHS=" + "'" + hocsinh.Mahs + "' ";
                }
                if (hocsinh.Tenhs != "")
                {
                    Temp += dieuKien + " TENHS=" + "N'" + hocsinh.Tenhs + "' ";
                }
               if (hocsinh.Dantoc != "")
                {
                    Temp += dieuKien + " DANTOC=" + "N'" + hocsinh.Dantoc + "' ";
                }
            }
	
                STRCMD = @"SELECT * FROM HOCSINH" + Temp;
                connection.kiemTraKetNoi(con);
                SqlCommand sqlcmd = new SqlCommand(STRCMD,con);
                da = new SqlDataAdapter(sqlcmd);
                da.Fill(dt);
                con.Close();
                return dt;
            }
        }
}
