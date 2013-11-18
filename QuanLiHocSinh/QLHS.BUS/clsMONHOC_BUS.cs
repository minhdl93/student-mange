﻿using System;
using System.Collections.Generic;
using System.Text;
using QLHS.DAO;
using QLHS.DTO;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
using System.Windows.Forms;
using System.Data;

namespace QLHS.BUS
{
    public class clsMONHOC_BUS
    {
        clsMONHOC_DAO monHoc_DAO;
        clsMONHOC_DTO monHoc_DTO;
        DataTable tblMonHoc;
        private DataRow dr;

        public clsMONHOC_BUS()
        {
            monHoc_DAO = new clsMONHOC_DAO();
            tblMonHoc = new DataTable();
        }

        public DataTable hienThiDanhSach()
        {
            tblMonHoc= monHoc_DAO.danhSachMonhoc();
            return tblMonHoc;
        }

        //tạo mã môn học 
        public string hienThiSoMon()
        {
            string result;
            int temp = monHoc_DAO.soMonHoc() + 1;
            if (temp < 10)
            {
                result = "0" + temp.ToString();
            }
            else
            {
                result = temp.ToString();
            }
            return result;
        }

        public void HienThiDataGridViewComboBoxColumn(DataGridViewComboBoxColumn cboColumn)
        {
            cboColumn.DataSource = monHoc_DAO.danhSachMonhoc();
            cboColumn.DisplayMember = "TENMH";
            cboColumn.ValueMember = "MAMH";
            cboColumn.DataPropertyName = "MAMH";
        }

        public void hienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = monHoc_DAO.danhSachMonhoc();
            comboBox.DisplayMember = "TENMH";
            comboBox.ValueMember = "MAMH";
        }

        public void hienThiComboBoxHeSo(ComboBoxEx comboBox)
        {
            comboBox.Items.Add("1");
            comboBox.Items.Add("2");
            comboBox.SelectedItem = "1";
        }

        public void themMonHoc(string maMH, string tenMH,string soTiet,string heSo)
        {
            monHoc_DTO = new clsMONHOC_DTO();
            monHoc_DTO.Mamh = maMH;
            monHoc_DTO.Tenmh = tenMH;
            monHoc_DTO.Sotiet = soTiet;
            monHoc_DTO.Hesomh = heSo;
            monHoc_DAO.themMonHoc(monHoc_DTO);
        }

        public void suaMonHoc(string maMH, string tenMH, string soTiet, string heSo)
        {
            monHoc_DTO = new clsMONHOC_DTO();
            monHoc_DTO.Mamh = maMH;
            monHoc_DTO.Tenmh = tenMH;
            monHoc_DTO.Sotiet = soTiet;
            monHoc_DTO.Hesomh = heSo;
            monHoc_DAO.suaMonHoc(monHoc_DTO);
        }

        public void xoaMonHoc(string maMH)
        {
            monHoc_DTO = new clsMONHOC_DTO();
            monHoc_DTO.Mamh = maMH;
            monHoc_DAO.xoaMonHoc(monHoc_DTO);
        }

        private DataRow getDatarow()
        {
            dr = tblMonHoc.NewRow();
            dr["MAMH"] = monHoc_DTO.Mamh;
            dr["TENMH"] = monHoc_DTO.Tenmh;
            dr["SOTIET"] = monHoc_DTO.Sotiet;
            dr["HESOMH"] = monHoc_DTO.Hesomh;
           
            return dr;
        }

        //thêm dòng vừa được thêm vào table môn học
        public void themDong()
        {
            tblMonHoc.Rows.Add(getDatarow());
        }

        public void suaDataGrid()
        {
            foreach (DataRow row1 in tblMonHoc.Rows)
            {
                if (row1["MAMH"] != null)
                {
                    if (string.Compare(row1["MAMH"].ToString().Trim(), monHoc_DTO.Mamh.Trim()) == 0)
                    {
                        row1["TENMH"] = monHoc_DTO.Tenmh;
                        row1["SOTIET"]= monHoc_DTO.Sotiet;
                        row1["HESOMH"] = monHoc_DTO.Hesomh;
                    }
                }
            }
            //foreach (DataGridViewRow row1 in grdMonHoc.Rows)
            //{
            //    if (row1.Cells["MAMH"].Value != null)
            //    {
            //        if (string.Compare(row1.Cells["MAMH"].Value.ToString().Trim(), monHoc_DTO.Mamh.Trim()) == 0)
            //        {
            //            row1.Cells["TENMH"].Value = monHoc_DTO.Tenmh;
            //            row1.Cells["SOTIET"].Value = monHoc_DTO.Sotiet;
            //            row1.Cells["HESOMH"].Value = monHoc_DTO.Hesomh;
            //        }
            //    }
            //}
        }

        public void xoaDong(string maMH)
        {
            DataRow row = tblMonHoc.Select("MAMH='" + maMH + "'")[0];
            row.Delete();
        }

        public int heSoMonHoc(string maMH)
        {
            monHoc_DTO = new clsMONHOC_DTO();
            monHoc_DTO.Mamh = maMH;
            return monHoc_DAO.heSoMonHoc(monHoc_DTO);
        }
    }
}
