﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QLHS.BUS;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;

namespace QuanLiHocSinh
{
    public partial class frmDiem : DevComponents.DotNetBar.Office2007Form
    {
        private int flag = 0;
        private BindingSource bsChung;
        private BindingSource bsRieng;
        private frmLoaiDiem frm_LoaiDiem=null;
        private clsNAMHOC_BUS namHoc_BUS;
        private clsLOP_BUS lop_BUS;
        private clsHOCKY_BUS hocKy_BUS;
        private clsLOAIDIEM_BUS loaiDiem_BUS;
        private clsMONHOC_BUS monHoc_BUS;
        private clsHOCSINH_BUS hocSinh_BUS;
        private clsDIEM_BUS diem_BUS;

        public frmDiem()
        {
            InitializeComponent();
            namHoc_BUS=new clsNAMHOC_BUS();
            lop_BUS=new clsLOP_BUS();
            hocKy_BUS=new clsHOCKY_BUS();
            loaiDiem_BUS = new clsLOAIDIEM_BUS();
            monHoc_BUS = new clsMONHOC_BUS();
            hocSinh_BUS = new clsHOCSINH_BUS();
            diem_BUS=new clsDIEM_BUS();
            bsChung = new BindingSource();
            bsRieng = new BindingSource();

            monHoc_BUS.HienThiDataGridViewComboBoxColumn(MAMH1);
            loaiDiem_BUS.HienThiDataGridViewComboBoxColumn(MALD1);
            namHoc_BUS.HienThiDataGridViewComboBoxColumn(MANH1);
            lop_BUS.hienThiDataGridViewComboBoxColumn(MALOP1);
            hocKy_BUS.HienThiDataGridViewComboBoxColumn(MAHK1);
            this.KeyPreview = true;
            datagridMakeUp(grdDiemRieng);

            grdDiemChung.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
        }

        //Trang trí datagrid như nền, canh chỉnh các hàng, ...
        private void datagridMakeUp(DataGridViewX temp)
        {
            temp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            temp.AutoResizeRows();
            temp.AllowUserToResizeColumns = true;
            temp.DefaultCellStyle.WrapMode = DataGridViewTriState.NotSet;
            temp.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            temp.ReadOnly = true;
        }

        //bật cờ hiển thị button đồng ý và hủy, các button thêm, sửa, xóa bị mờ đi
        private void FlagEnable()
        {
            btnDongY.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        //tắt cờ hiển thị button đồng ý và hủy, các button thêm, sửa, xóa sáng lên
        private void FlagDisable()
        {
            btnDongY.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void cbNamHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            treLop.Nodes.Clear();
            if (cboNamHoc.SelectedValue!=null)
            {
                lop_BUS.hienThiTreeLopTheoNamHoc(cboNamHoc.SelectedValue.ToString(), treLop);
            }     
        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            //load dữ liệu vào comboBox 
            namHoc_BUS.hienThiComboBox(cboNamHoc);
            namHoc_BUS.hienThiComboBox(cboNamHoc1);
            hocKy_BUS.hienThiComboBox(cboHocKy1);
            hocKy_BUS.hienThiComboBox(cboHocKy);
            monHoc_BUS.hienThiComboBox(cboMonHoc);
            monHoc_BUS.hienThiComboBox(cboMonHoc1);
            loaiDiem_BUS.hienThiComboBox(cboLoaiDiem1);

            FlagDisable();
            flag = 0;
        }

        private void insert()
        {
            //cờ kiểm tra số điểm tối đa của một loại điểm
            int test = 1;
            int count=0;

            if (cboHocSinh1.SelectedValue==null||cboLoaiDiem1.SelectedValue==null||cboHocKy1.SelectedItem==null||cboNamHoc1.SelectedValue==null||cboMonHoc1.SelectedValue==null||txtDiem1.Text=="")
            {
                MessageBox.Show("Xin chọn dữ liệu đầy đủ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                count = grdDiemRieng.Rows.Count-1;
                switch (cboLoaiDiem1.SelectedValue.ToString())
                {
                    case "LD01":
                        {
                            if (count>=2)
                            {
                                test = -1;
                            }
                            break;
                        }
                    case "LD02":
                        {
                            if (count >= 5)
                            {
                                test = -1;
                            }
                            break;
                        }
                    case "LD03":
                        {
                            if (count >= 5)
                            {
                                test = -1;
                            }
                            break;
                        }
                    case "LD04":
                        {
                            if (count >= 1)
                            {
                                test = -1;
                            }
                            break;
                        }
                       
                    default:
                        break;
                }
                if (test!=-1)
                {
                    diem_BUS.themDiemTheoHS(cboNamHoc1, cboHocKy1, cboLoaiDiem1, cboMonHoc1, cboHocSinh1, txtDiem1);
                    MessageBox.Show("Thêm điểm thành công");
                    bsRieng = new BindingSource();
                    bsRieng.DataSource = diem_BUS.thongTinDiemTheoHS(cboNamHoc1, cboHocKy1, cboLoaiDiem1, cboMonHoc1, cboHocSinh1);
                    grdDiemRieng.DataSource = bsRieng;
                    bnaDiemRieng.BindingSource = bsRieng;
                    FlagDisable();
                }
                else
                {
                    MessageBox.Show("Loại điểm  "+cboLoaiDiem1.SelectedValue.ToString()+" đã vượt quá số lượng cho phép thêm");
                }
            }
        }

        private void delete()
        {
            if (grdDiemRieng.SelectedRows.Count >= 1)
            {
                if (MessageBox.Show("Bạn có chắc muốn xóa điểm đã được lựa chọn ", "Xóa điểm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    diem_BUS.xoaDiemTheoHS(grdDiemRieng.CurrentRow.Cells["STT"].Value.ToString());
                    diem_BUS.xoaDong(grdDiemRieng, grdDiemRieng.CurrentRow.Cells["STT"].Value.ToString());
                    resetAll();
                    FlagDisable();
                    flag = 0;
                }
            }
            else
            {
                MessageBox.Show("Bạn phải lựa chọn một hàng để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void resetAll()
        {
            txtDiem1.Text = "";
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            if (treLop.SelectedNode == null||treLop.SelectedNode.Parent==null)
            {
                MessageBox.Show("Bạn phải chon một lớp");
            }
            else
            {
                //.biding navigator
                bsChung = new BindingSource();
                bsChung.DataSource = hocSinh_BUS.danhSachMaHSTheoLop(cboNamHoc, treLop);
                grdDiemChung.DataSource = bsChung;
                bnaDiem.BindingSource = bsChung;
                diem_BUS.thongTinDiemTheoMaLD(cboNamHoc, cboHocKy, cboMonHoc, grdDiemChung);
            }
        }

        private void btnLoaiDiem_Click(object sender, EventArgs e)
        {
            if (frm_LoaiDiem == null || frm_LoaiDiem.IsDisposed)
            {
                frm_LoaiDiem = new frmLoaiDiem();
                frm_LoaiDiem.FormBorderStyle = FormBorderStyle.None;
                frm_LoaiDiem.MdiParent = frmMain.ActiveForm;
                frm_LoaiDiem.Show();
            }
            else
                frm_LoaiDiem.Activate(); 
        }

        private void cboNamHoc1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboNamHoc1.SelectedValue!=null)
            {
                lop_BUS.hienThiCboLopTheoNamHoc(cboNamHoc1.SelectedValue.ToString(), cboLop1);
            }
        }

        private void cboLop1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboLop1.SelectedValue!=null && cboNamHoc1.SelectedValue!=null)
            {
                hocSinh_BUS.danhSachHocSinhTheoLop(cboNamHoc1, cboLop1, cboHocSinh1);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FlagEnable();
            flag = 1;
            txtDiem1.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            flag = 2;
            FlagEnable();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 3;
            FlagEnable();
            txtDiem1.Focus();
        }

        private void update()
        {
            if (grdDiemRieng.SelectedRows.Count >= 1)
            {
                diem_BUS.suaDiemTheoHS(grdDiemRieng.CurrentRow.Cells["STT"].Value.ToString(), txtDiem1);
                MessageBox.Show("Bạn đã sửa thành công!");

                //sửa trong datagrid view
                diem_BUS.suaDataGrid(grdDiemRieng);

                FlagDisable();
                flag = 0;
            }
            else
            {
                MessageBox.Show("Bạn phải lựa chọn một hàng để sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (flag == 1) insert();
            if (flag == 2) delete();
            if (flag == 3) update();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            FlagDisable();
            flag = 0;
        }

        private void dataBinding_DiemRieng()
        {
            bsRieng = new BindingSource();
            bsRieng.DataSource = hocSinh_BUS.danhSachMaHSTheoLop(cboNamHoc, treLop);
            grdDiemChung.DataSource = bsRieng;
            bnaDiem.BindingSource = bsRieng;
            diem_BUS.thongTinDiemTheoMaLD(cboNamHoc, cboHocKy, cboMonHoc, grdDiemChung);
        }

        private void cboLoaiDiem1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboLoaiDiem1.SelectedValue != null && cboHocSinh1.SelectedValue!=null)
            {
                bsRieng = new BindingSource();
                bsRieng.DataSource = diem_BUS.thongTinDiemTheoHS(cboNamHoc1, cboHocKy1, cboLoaiDiem1, cboMonHoc1, cboHocSinh1);
                grdDiemRieng.DataSource = bsRieng;
                bnaDiemRieng.BindingSource = bsRieng;
            }
        }

        private void cboHocSinh1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboLoaiDiem1.SelectedValue != null && cboHocSinh1.SelectedValue != null)
            {
                bsRieng = new BindingSource();
                bsRieng.DataSource = diem_BUS.thongTinDiemTheoHS(cboNamHoc1, cboHocKy1, cboLoaiDiem1, cboMonHoc1, cboHocSinh1);
                grdDiemRieng.DataSource = bsRieng;
                bnaDiemRieng.BindingSource = bsRieng;
            }
        }

        private void grdDiemRieng_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            controlValue();
            FlagDisable();
        }

        private void frmDiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnLuuDiem_Click(object sender, EventArgs e)
        {
            if (grdDiemChung.RowCount>1)
            {
                //xóa đồng thời chỉnh lại điểm mới
                diem_BUS.xoaDiemTheoMaLD(cboNamHoc, cboHocKy, cboMonHoc, grdDiemChung);

                //.biding navigator
                bsChung = new BindingSource();
                bsChung.DataSource = hocSinh_BUS.danhSachMaHSTheoLop(cboNamHoc, treLop);
                grdDiemChung.DataSource = bsChung;
                bnaDiem.BindingSource = bsChung;
                diem_BUS.thongTinDiemTheoMaLD(cboNamHoc, cboHocKy, cboMonHoc, grdDiemChung);
                MessageBox.Show("Chỉnh sửa điểm thành công!");
            }
            else
            {
                MessageBox.Show("Chưa có dữ liệu");
            }
            
        }

        private void treLop_NodeDoubleClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            if (treLop.SelectedNode.Parent==null)
            {   
            }
            else
            {
                //.biding navigator
                bsChung = new BindingSource();
                bsChung.DataSource = hocSinh_BUS.danhSachMaHSTheoLop(cboNamHoc, treLop);
                grdDiemChung.DataSource = bsChung;
                bnaDiem.BindingSource = bsChung;
                diem_BUS.thongTinDiemTheoMaLD(cboNamHoc, cboHocKy, cboMonHoc, grdDiemChung);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void move_Click(object sender, EventArgs e)
        {
            controlValue();
        }

        private void controlValue()
        {
            if ( grdDiemRieng.CurrentRow.Cells["MALD1"].Value!=null)
            {
                cboLoaiDiem1.SelectedValue = grdDiemRieng.CurrentRow.Cells["MALD1"].Value.ToString();
                cboNamHoc1.SelectedValue = grdDiemRieng.CurrentRow.Cells["MANH1"].Value.ToString();
                cboHocSinh1.SelectedValue = grdDiemRieng.CurrentRow.Cells["MAHS1"].Value.ToString();
                cboMonHoc1.SelectedValue = grdDiemRieng.CurrentRow.Cells["MAMH1"].Value.ToString();
                cboLop1.SelectedValue = grdDiemRieng.CurrentRow.Cells["MALOP1"].Value.ToString();
                cboHocKy1.SelectedValue = grdDiemRieng.CurrentRow.Cells["MAHK1"].Value.ToString();
                txtDiem1.Text = grdDiemRieng.CurrentRow.Cells["DIEMSO1"].Value.ToString();
            }
        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar)&&e.KeyChar!='.')
            {
                e.Handled = true;
                MessageBox.Show("Chỉ nhập số, không nhập chữ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboHocKy_SelectedValueChanged(object sender, EventArgs e)
        {
            if (treLop.SelectedNode != null)
            {
                //.biding navigator
                bsChung = new BindingSource();
                bsChung.DataSource = hocSinh_BUS.danhSachMaHSTheoLop(cboNamHoc, treLop);
                grdDiemChung.DataSource = bsChung;
                bnaDiem.BindingSource = bsChung;
                diem_BUS.thongTinDiemTheoMaLD(cboNamHoc, cboHocKy, cboMonHoc, grdDiemChung);
            }
            
        }

        private void cboMonHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            if (treLop.SelectedNode != null )
            {
                //.biding navigator
                bsChung = new BindingSource();
                bsChung.DataSource = hocSinh_BUS.danhSachMaHSTheoLop(cboNamHoc, treLop);
                grdDiemChung.DataSource = bsChung;
                bnaDiem.BindingSource = bsChung;
                diem_BUS.thongTinDiemTheoMaLD(cboNamHoc, cboHocKy, cboMonHoc, grdDiemChung);
            }
        }

        private void cboHocKy1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboLoaiDiem1.SelectedValue != null && cboHocSinh1.SelectedValue != null && cboMonHoc1.SelectedValue != null && cboLop1.SelectedValue != null && cboNamHoc1.SelectedValue != null)
            {
                bsRieng = new BindingSource();
                bsRieng.DataSource = diem_BUS.thongTinDiemTheoHS(cboNamHoc1, cboHocKy1, cboLoaiDiem1, cboMonHoc1, cboHocSinh1);
                grdDiemRieng.DataSource = bsRieng;
                bnaDiemRieng.BindingSource = bsRieng;
            }
        }

        private void cboMonHoc1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboLoaiDiem1.SelectedValue != null && cboHocSinh1.SelectedValue != null && cboHocKy1.SelectedValue != null && cboLop1.SelectedValue != null && cboNamHoc1.SelectedValue != null)
            {
                bsRieng = new BindingSource();
                bsRieng.DataSource = diem_BUS.thongTinDiemTheoHS(cboNamHoc1, cboHocKy1, cboLoaiDiem1, cboMonHoc1, cboHocSinh1);
                grdDiemRieng.DataSource = bsRieng;
                bnaDiemRieng.BindingSource = bsRieng;
            }
        }
    }
}

