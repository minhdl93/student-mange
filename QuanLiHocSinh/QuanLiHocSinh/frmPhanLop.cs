﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using QLHS.DTO;
using QLHS.BUS;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;

namespace QuanLiHocSinh
{
    public partial class frmPhanLop : DevComponents.DotNetBar.Office2007Form
    {
        private clsLOP_BUS lop_BUS;
        private clsKHOI_BUS khoi_BUS;
        private clsNAMHOC_BUS namHoc_BUS;
        private clsHOCSINH_BUS hocSinh_BUS;
        clsQUYDINH_BUS quyDinh_BUS;

        public frmPhanLop()
        {
            InitializeComponent();
            lop_BUS = new clsLOP_BUS();
            khoi_BUS = new clsKHOI_BUS();
            namHoc_BUS = new clsNAMHOC_BUS();
            hocSinh_BUS = new clsHOCSINH_BUS();
            quyDinh_BUS = new clsQUYDINH_BUS();
        }

        private void frmPhanLop_Load(object sender, EventArgs e)
        {
            //if (cboKhoiLopCu.SelectedValue!=null&&cboNamHocCu.SelectedValue!=null)
            //{
               
                namHoc_BUS.hienThiComboBox(cboNamHocCu);
                namHoc_BUS.hienThiComboBox(cboNamHocMoi);
                namHoc_BUS.hienThiComboBox(cboNamHocCu1);
                namHoc_BUS.hienThiComboBox(cboNamHocMoi1);
                khoi_BUS.hienThiComboBox(cboKhoiLopCu);
                khoi_BUS.hienThiComboBoxKhoi10(cboKhoiLopMoi1);
                khoi_BUS.hienThiComboBox(cboKhoiLopCu, cboKhoiLopMoi);
            
                
            //}
            
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            IEnumerator ie = lstLopCu.SelectedItems.GetEnumerator();
            while (ie.MoveNext())
            {
                ListViewItem oldItem = (ListViewItem)ie.Current;
                ListViewItem newItem = new ListViewItem();

                //Trạng thái học sinh đã được chuyển lớp hay chưa?
                bool state = false;

                foreach (ListViewItem item in lstLopMoi.Items)
                {
                    if (item.SubItems[0].Text == oldItem.SubItems[0].Text)
                    {
                        MessageBox.Show("Học sinh " + item.SubItems[1].Text + " hiện đang học trong lớp " + cboLopMoi.Text, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        state = true;
                        goto Cont;
                    }
                }

                DataTable dT = new DataTable();
                if (cboNamHocMoi.SelectedValue != null)
                {
                    dT = hocSinh_BUS.danhSachPhanLop(cboNamHocMoi);
                }

                foreach (DataRow row in dT.Rows)
                {
                    if (oldItem.SubItems[0].Text.ToString() == row["MAHS"].ToString())
                    {
                        MessageBox.Show("Học sinh " + row["TENHS"].ToString() + " hiện đang học trong lớp " + row["TENLOP"].ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        state = true;
                        goto Cont;
                    }
                }

                newItem.SubItems.Add(oldItem.SubItems[1].Text);
                newItem.SubItems.Add(oldItem.SubItems[2].Text);
                newItem.Tag = oldItem.Tag;

                lstLopMoi.Items.Add(newItem);
                lstLopMoi.Items[lstLopMoi.Items.IndexOf(newItem)].Text = (lstLopMoi1.Items.Count).ToString();
                lstLopCu.Items.Remove(oldItem);

            Cont:
                if (state == true)
                    break;
            }
        }

        private void cboNamHocCu_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboKhoiLopCu.SelectedValue != null)
            {
                lop_BUS.hienThiCbLopTheoNamHocKhoi(cboNamHocCu.SelectedValue.ToString(), cboLopCu, cboKhoiLopCu.SelectedValue.ToString());
            }
        }

        private void cboKhoiLopCu_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboNamHocCu.SelectedValue!=null)
            {
                lop_BUS.hienThiCbLopTheoNamHocKhoi(cboNamHocCu.SelectedValue.ToString(), cboLopCu, cboKhoiLopCu.SelectedValue.ToString());
                if (cboLopCu.Items.Count<=0)
                {
                    cboLopCu.Text = "";
                }
                khoi_BUS.hienThiComboBox(cboKhoiLopCu, cboKhoiLopMoi);
            }
            
        }

        private void cboNamHocMoi_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboKhoiLopMoi.SelectedValue != null)
            {
                lop_BUS.hienThiCbLopTheoNamHocKhoi(cboNamHocMoi.SelectedValue.ToString(), cboLopMoi, cboKhoiLopMoi.SelectedValue.ToString());
            }
        }

  
        private void cboKhoiLopMoi_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboNamHocMoi.SelectedValue != null)
            {
                lop_BUS.hienThiCbLopTheoNamHocKhoi(cboNamHocMoi.SelectedValue.ToString(), cboLopMoi, cboKhoiLopMoi.SelectedValue.ToString());
                if (cboLopMoi.Items.Count <= 0)
                {
                    cboLopMoi.Text = "";
                }
            }
        }

        private void cboLopCu_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboNamHocCu.SelectedValue != null && cboLopCu.SelectedValue != null)
            {
                hocSinh_BUS.danhSachHocSinhTheoLop(cboNamHocCu, cboLopCu, lstLopCu);
              
            }
        }

        private void cboLopMoi_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboNamHocMoi.SelectedValue != null && cboLopMoi.SelectedValue != null)
            {
                hocSinh_BUS.danhSachHocSinhTheoLop(cboNamHocMoi, cboLopMoi, lstLopMoi);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa học sinh này khỏi lớp mới không?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IEnumerator ie = lstLopMoi.SelectedItems.GetEnumerator();
                while (ie.MoveNext())
                {
                    ListViewItem item = (ListViewItem)ie.Current;
                    lstLopMoi.Items.Remove(item);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboNamHocCu.SelectedValue != null &&
                cboKhoiLopCu.SelectedValue != null &&
                cboLopCu.SelectedValue != null &&
                cboNamHocMoi.SelectedValue != null &&
                cboKhoiLopMoi.SelectedValue != null &&
                cboLopMoi.SelectedValue != null)
            {
                hocSinh_BUS.xoaPhanLop(cboNamHocMoi, cboLopMoi, lstLopMoi);
                hocSinh_BUS.themPhanLop(cboNamHocCu, cboLopCu, lstLopMoi);
                MessageBox.Show("Đã lưu vào bảng phân lớp!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Giá trị của các ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboNamHocCu1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboNamHocCu1.SelectedValue != null)
            {
                hocSinh_BUS.danhSachHocSinhChuaPhanLop(cboNamHocCu1, lstHocSinh);
            }
        }

        private void cboNamHocMoi1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboKhoiLopMoi1.SelectedValue != null)
            {
                lop_BUS.hienThiCbLopTheoNamHocKhoi(cboNamHocMoi1.SelectedValue.ToString(), cboLopMoi1, cboKhoiLopMoi1.SelectedValue.ToString());
            }
        }

        private void cboKhoiLopMoi1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboNamHocMoi1.SelectedValue != null)
            {
                lop_BUS.hienThiCbLopTheoNamHocKhoi(cboNamHocMoi1.SelectedValue.ToString(), cboLopMoi1, cboKhoiLopMoi1.SelectedValue.ToString());
                if (cboLopMoi1.Items.Count <= 0)
                {
                    cboLopMoi1.Text = "";
                }
            }
        }

        private void cboLopMoi1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboNamHocMoi1.SelectedValue != null && cboLopMoi1.SelectedValue != null)
            {
                hocSinh_BUS.danhSachHocSinhTheoLop(cboNamHocMoi1, cboLopMoi1, lstLopMoi1);

            }
        }

        private void btnChuyen1(object sender, EventArgs e)
        {
            IEnumerator ie = lstHocSinh.SelectedItems.GetEnumerator();
            while (ie.MoveNext())
            {
                ListViewItem oldItem = (ListViewItem)ie.Current;
                ListViewItem newItem = new ListViewItem();
                newItem.SubItems.Add(oldItem.SubItems[1].Text);
                newItem.SubItems.Add(oldItem.SubItems[2].Text);
                newItem.Tag = oldItem.Tag;
                
                lstLopMoi1.Items.Add(newItem);
                lstLopMoi1.Items[lstLopMoi1.Items.IndexOf(newItem)].Text = (lstLopMoi1.Items.Count).ToString();
                lstHocSinh.Items.Remove(oldItem);
               
            }
        }

        private void btnLuu1_Click(object sender, EventArgs e)
        {
            if (lstLopMoi1.Items.Count>quyDinh_BUS.siSoToiDa())
            {
                MessageBox.Show("Số lượng học sinh đã vượt quá sỉ số tối đa của lớp");
            }
            else
            {
                if (cboNamHocMoi1.SelectedValue != null &&
                cboKhoiLopMoi1.SelectedValue != null &&
                cboLopMoi1.SelectedValue != null 
                )
                {

                    hocSinh_BUS.phanLopHocSinhLop10(cboNamHocMoi1, cboLopMoi1, lstLopMoi1);
                    MessageBox.Show("Đã lưu vào bảng phân lớp!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Giá trị của các ô không được rỗng!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
