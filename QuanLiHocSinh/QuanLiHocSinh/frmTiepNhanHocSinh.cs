﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLHS.BUS;
using QLHS.DTO;
using System.IO;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;

namespace QuanLiHocSinh
{
    public partial class frmTiepNhanHocSinh : DevComponents.DotNetBar.Office2007Form
    {
        private frmLopHoc m_FrmLop = null;
        private clsLOP_BUS lop_bus;
        private clsHOCSINH_BUS hocsinh_bus;
        private clsNAMHOC_BUS namhoc_bus;
        private clsHOCSINH_DTO hocsinh_dto;
        private clsKHOI_BUS khoi_bus;
        private Boolean flagInsert;
        private Boolean flagUpdate;
        private Boolean flagDelete;
        private Boolean flagChonAnh;
        private string linkgoc;
        private int vitri;
        private int Tong;
        public frmTiepNhanHocSinh()
        {
            InitializeComponent();
            hocsinh_bus = new clsHOCSINH_BUS();
            namhoc_bus = new clsNAMHOC_BUS();
            hocsinh_dto = new clsHOCSINH_DTO();
            lop_bus = new clsLOP_BUS();
            khoi_bus = new clsKHOI_BUS();
            flagInsert = false;
            flagUpdate = false;
            flagDelete = false;
            flagChonAnh = false;
        }

        private void btnItemTim_Click(object sender, EventArgs e)
        {

        }
        private void frmHocSinh_Load(object sender, EventArgs e)
        {
            anHienButton(true);
            hocsinh_bus.cboGioiTinh(cboGioiTinh);
            namhoc_bus.hienThiComboBox(cboNamHoc);
           //hocsinh_bus.cboNamhoc(cboNamHoc);
            //khoi_bus.hienThiComboBox(cboKhoi);
            lop_bus.chonLop10(cboLop,cboNamHoc.SelectedValue.ToString());
            //txtMaHS.Text = hocsinh_bus.staoMaHocSinh();
            txtMaHS.Text = hocsinh_bus.taoMaHocSinh(cboNamHoc);
            dtiNgaySinh.Value = DateTime.Now;
            dtiNgayNhapHoc.Value = DateTime.Now;
            grdHocSinh.DataSource = hocsinh_bus.danhSachHocSinh(cboNamHoc);
            datagridMakeUp(grdHocSinh);
        }

        private void datagridMakeUp(DataGridViewX temp)
        {
            temp.AutoResizeRows();
            temp.AllowUserToResizeColumns = true;
            temp.DefaultCellStyle.WrapMode = DataGridViewTriState.NotSet;
            temp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            temp.ReadOnly = true;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            flagChonAnh = true;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn hình ảnh";
            ofd.Filter = "jpg files (*.jpg)|*.jpg|png file (*.png)|*.png|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picHocSinh.Image = Image.FromFile(ofd.FileName);
                linkgoc = ofd.FileName;
                string linkimage;
                linkimage = Directory.GetCurrentDirectory() + @"\hinhAnh\" + ofd.SafeFileName;
                hocsinh_dto.Hinhanhhs = linkimage;
            }
        }
        public void anHienButton(Boolean b)
        {
            btnThem.Enabled = b;
            btnSua.Enabled = b;
            btnXoa.Enabled = b;
            if (b == true)
            {
                btnDongy.Enabled = false;
                btnHuy.Enabled = false;
            }
            else
            {
                btnDongy.Enabled = true;
                btnHuy.Enabled = true;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaHS.Text = hocsinh_bus.taoMaHocSinh(cboNamHoc);
            txtTenHS.Focus();
            anHienButton(false);
            flagInsert = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            anHienButton(false);
            flagDelete = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtTenHS.Focus();
            anHienButton(false);
            flagUpdate = true;
        }
        private void btnDongy_Click(object sender, EventArgs e)
        {
            anHienButton(true);
            if (flagInsert == true)
            {
                Insert();
            }
            else
            {
                if (flagDelete == true)
                {
                    Delete();
                }
                else
                {
                    Update();
                }
            }
            hienThiDuLieu();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            anHienButton(true);
        }
        private void btnDau_Click(object sender, EventArgs e)
        {
            vitri = this.BindingContext[grdHocSinh.DataSource].Position;
            this.BindingContext[grdHocSinh.DataSource].Position = 0;
            hienThiDuLieu();
            btnTruoc.Enabled = false;
            btnDau.Enabled = false;
            btnCuoi.Enabled = true;
            btnSau.Enabled = true;
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            vitri = this.BindingContext[grdHocSinh.DataSource].Position;
            btnCuoi.Enabled = true;
            btnSau.Enabled = true;
            this.BindingContext[grdHocSinh.DataSource].Position = vitri - 1;
            hienThiDuLieu();
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            vitri = this.BindingContext[grdHocSinh.DataSource].Position;
            btnDau.Enabled = true;
            btnTruoc.Enabled = true;
            this.BindingContext[grdHocSinh.DataSource].Position = vitri + 1;
            hienThiDuLieu();
        }

        private void btnCuoi_Click(object sender, EventArgs e)
        {
            vitri = this.BindingContext[grdHocSinh.DataSource].Position;
            this.BindingContext[grdHocSinh.DataSource].Position = this.BindingContext[grdHocSinh.DataSource].Count - 1;
            hienThiDuLieu();
            btnCuoi.Enabled = false;
            btnSau.Enabled = false;
            btnTruoc.Enabled = true;
            btnDau.Enabled = true;
        }
        private void grdHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cboNamHoc.SelectedValue = grdHocSinh.CurrentRow.Cells["MANH"].Value.ToString();
            cboLop.SelectedValue = grdHocSinh.CurrentRow.Cells["MALOP"].Value.ToString();
            cboGioiTinh.SelectedValue = grdHocSinh.CurrentRow.Cells["GIOITINHHS"].Value.ToString();
            txtMaHS.Text = grdHocSinh.CurrentRow.Cells["MAHS"].Value.ToString();
            txtTenHS.Text = grdHocSinh.CurrentRow.Cells["TENHS"].Value.ToString();
            txtDiaChi.Text = grdHocSinh.CurrentRow.Cells["DIACHIHS"].Value.ToString();
            txtDantoc.Text = grdHocSinh.CurrentRow.Cells["DANTOC"].Value.ToString();
            txtDienThoai.Text = grdHocSinh.CurrentRow.Cells["DIENTHOAIHS"].Value.ToString();
            dtiNgaySinh.Text = grdHocSinh.CurrentRow.Cells["NGSINHHS"].Value.ToString();
            dtiNgayNhapHoc.Text = grdHocSinh.CurrentRow.Cells["NGNHAPHOC"].Value.ToString();
            if (grdHocSinh.CurrentRow.Cells["HINHANHHS"].Value.ToString() != "")
            {
                FileStream fs = new FileStream(grdHocSinh.CurrentRow.Cells["HINHANHHS"].Value.ToString(), FileMode.Open, FileAccess.Read);
                picHocSinh.Image = Image.FromStream(fs);
                fs.Close();
            }
        }
        public void resetALL()
        {
            picHocSinh.Image = null;
            txtMaHS.Text = "";
            txtTenHS.Text = "";
            txtDiaChi.Text = "";
            txtDantoc.Text = "";
            txtDienThoai.Text = "";
            dtiNgayNhapHoc.Value = DateTime.Now;
            dtiNgaySinh.Value = DateTime.Now;
        }
        public int kiemTraDulieu()
        {
            int dem = 0;
            if (picHocSinh.Image == null)
            {
                MessageBox.Show("Chưa Chọn hình ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dem++;
            }
            if (txtTenHS.Text == "")
            {
                MessageBox.Show("Chưa nhập Họ và Tên Học Sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dem++;
            }
            if (txtDantoc.Text == "")
            {
                MessageBox.Show("Chưa nhập Dân tộc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dem++;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Chưa nhập Địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dem++;
            }
            if (txtDantoc.Text == "")
            {
                MessageBox.Show("Chưa nhập Dân tộc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dem++;
            }
            if (linkgoc == "")
            {
                MessageBox.Show("Chưa Chọn hình ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dem++;
            }

            return dem;
        }
        public void Insert()
        {
            if (kiemTraDulieu() == 0)
            {
                hocsinh_dto.Mahs = txtMaHS.Text;
                hocsinh_dto.Tenhs = txtTenHS.Text;
                hocsinh_dto.Ngaysinhhs = DateTime.Parse(dtiNgaySinh.Text);
                if (cboGioiTinh.SelectedItem.ToString() == "Nam")
                {
                    hocsinh_dto.Gioitinh = "1";
                }
                else
                {
                    hocsinh_dto.Gioitinh = "0";
                }
                hocsinh_dto.Dantoc = txtDantoc.Text;
                hocsinh_dto.Dienthoaihs = txtDienThoai.Text;
                hocsinh_dto.Diachihs = txtDiaChi.Text;
                hocsinh_dto.Ngnhaphoc = DateTime.Parse(dtiNgayNhapHoc.Text);
                hocsinh_dto.Manh = cboNamHoc.SelectedValue.ToString();
                hocsinh_dto.Malop = cboLop.SelectedValue.ToString();
                try
                {
                    File.Copy(linkgoc, hocsinh_dto.Hinhanhhs);
                    hocsinh_bus.themHocSinh(hocsinh_dto);
                    resetALL();
                    grdHocSinh.DataSource = hocsinh_bus.danhSachHocSinh(cboNamHoc);//tải lại danh sách sau khi thêm
                    flagChonAnh = false;
                    flagInsert = false;
                    MessageBox.Show("Đã thêm học sinh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    flagInsert = false;
                    MessageBox.Show("Lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void Delete()
        {
            hocsinh_dto.Mahs = txtMaHS.Text;
            if (grdHocSinh.SelectedRows.Count >= 1 && txtMaHS.Text != "")
            {
                try
                {
                    hocsinh_bus.xoaHocSinh(hocsinh_dto);
                    File.Delete(grdHocSinh.CurrentRow.Cells["HINHANHHS"].Value.ToString());
                    grdHocSinh.DataSource = hocsinh_bus.danhSachHocSinh(cboNamHoc);//tải lại danh sách sau khi xóa
                    flagDelete = false;
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    flagDelete = false;

                    MessageBox.Show("Lỗi " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn Dòng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Update()
        {
            if (kiemTraDulieu() == 0)
            {
                hocsinh_dto.Mahs = txtMaHS.Text;
                hocsinh_dto.Tenhs = txtTenHS.Text;
                hocsinh_dto.Ngaysinhhs = DateTime.Parse(dtiNgaySinh.Text);
                if (cboGioiTinh.SelectedItem.ToString() == "Nam")
                {
                    hocsinh_dto.Gioitinh = "1";
                }
                else
                {
                    hocsinh_dto.Gioitinh = "0";
                }
                hocsinh_dto.Dantoc = txtDantoc.Text;
                hocsinh_dto.Dienthoaihs = txtDienThoai.Text;
                hocsinh_dto.Diachihs = txtDiaChi.Text;
                hocsinh_dto.Ngnhaphoc = DateTime.Parse(dtiNgayNhapHoc.Text);
                hocsinh_dto.Manh = cboNamHoc.SelectedValue.ToString();
                //hocsinh_dto.Makhoi = cboLop.SelectedValue.ToString();
                hocsinh_dto.Malop = cboLop.SelectedValue.ToString(); 
                try
                {
                    if (flagChonAnh == true)
                    {
                        File.Copy(linkgoc, hocsinh_dto.Hinhanhhs);
                        File.Delete(grdHocSinh.CurrentRow.Cells["HINHANHHS"].Value.ToString());
                        flagChonAnh = false;
                    }
                    else
                    {
                        hocsinh_dto.Hinhanhhs = grdHocSinh.CurrentRow.Cells["HINHANHHS"].Value.ToString();
                    }
                    hocsinh_bus.suaHocSinh(hocsinh_dto,grdHocSinh);
                    flagUpdate = false;
                    resetALL();
                    grdHocSinh.DataSource = hocsinh_bus.danhSachHocSinh(cboNamHoc);//tải lại danh sách sau khi thêm
                    MessageBox.Show("Đã sửa học sinh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flagUpdate = false;
                }
            }
        }
        public void hienThiDuLieu()
        {
            //int Tong;
            //int vitri;
            vitri = this.BindingContext[grdHocSinh.DataSource].Position;
            Tong = this.BindingContext[grdHocSinh.DataSource].Count;
            if (vitri != -1)
            {
                txtHienTai.Text = (vitri + 1).ToString() + "/" + Tong.ToString();
                txtMaHS.Text = grdHocSinh.Rows[vitri].Cells["MAHS"].Value.ToString();
                txtTenHS.Text = grdHocSinh.Rows[vitri].Cells["TENHS"].Value.ToString();
                txtDantoc.Text = grdHocSinh.Rows[vitri].Cells["DANTOC"].Value.ToString();
                txtDienThoai.Text = grdHocSinh.Rows[vitri].Cells["DIENTHOAIHS"].Value.ToString();
                txtDiaChi.Text = grdHocSinh.Rows[vitri].Cells["DIACHIHS"].Value.ToString();
                cboGioiTinh.SelectedValue = grdHocSinh.Rows[vitri].Cells["GIOITINHHS"].Value.ToString();
                cboLop.SelectedValue = grdHocSinh.Rows[vitri].Cells["MALOP"].Value.ToString();
                cboNamHoc.SelectedValue = grdHocSinh.Rows[vitri].Cells["MANH"].Value.ToString();
                dtiNgaySinh.Text = grdHocSinh.Rows[vitri].Cells["NGSINHHS"].Value.ToString();
                dtiNgayNhapHoc.Text = grdHocSinh.Rows[vitri].Cells["NGNHAPHOC"].Value.ToString();
                FileStream fs = new FileStream(grdHocSinh.Rows[vitri].Cells["HINHANHHS"].Value.ToString(), FileMode.Open, FileAccess.Read);
                picHocSinh.Image = Image.FromStream(fs);
                fs.Close();
            }
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhập số,không nhập chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        //private void btnTimKiem_Click(object sender, EventArgs e)
        //{
        //    if (txtTim.Text != "")
        //    {
        //        if (optMaHS.Checked == true)
        //        {
        //            hocsinh_dto.Mahs = txtTim.Text;
        //            if (hocsinh_bus.timHocsinhMahs(hocsinh_dto).Rows.Count == 0)
        //            {
        //                MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //            else
        //            {
        //                grdHocSinh.DataSource = hocsinh_bus.timHocsinhMahs(hocsinh_dto);
        //            }
        //        }
        //        if (optTenHS.Checked == true)
        //        {
        //            hocsinh_dto.Tenhs = txtTim.Text;
        //            if (hocsinh_bus.timHocsinhTenhs(hocsinh_dto).Rows.Count == 0)
        //            {
        //                MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //            else
        //            {
        //                grdHocSinh.DataSource = hocsinh_bus.timHocsinhTenhs(hocsinh_dto);
        //            }
        //        }
        //        if (optMaHS.Checked == false && optTenHS.Checked == false)
        //        {
        //            MessageBox.Show("Chưa chọn tìm kiếm theo Tên Học Sinh hoặc theo Mã học sinh ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Chưa nhập từ khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void cboNamHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            resetALL();
            grdHocSinh.DataSource = hocsinh_bus.danhSachHocSinh(cboNamHoc);
            lop_bus.chonLop10(cboLop, cboNamHoc.SelectedValue.ToString());
            
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            txtTenHS.BackColor = Color.White;
            txtDiaChi.BackColor = Color.White;
            txtDienThoai.BackColor = Color.White;
            txtDantoc.BackColor = Color.White;
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            if (m_FrmLop == null || m_FrmLop.IsDisposed)
            {
                m_FrmLop = new frmLopHoc();
                m_FrmLop.FormBorderStyle = FormBorderStyle.None;
                m_FrmLop.MdiParent = frmMain.ActiveForm;
                m_FrmLop.Show();
            }
            else
                m_FrmLop.Activate();
        }


    }
}