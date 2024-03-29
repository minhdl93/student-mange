﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using QLHS.BUS;
using QLHS.DTO;
using System.Configuration;

namespace QuanLiHocSinh
{   
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        private clsNGUOIDUNG_DTO nguoiDung_DTO;
        private clsNGUOIDUNG_BUS nguoiDung_BUS;
        private OpenFileDialog restoreDialog;
        private SaveFileDialog backupDialog;
        private SqlConnection connection;
        private frmLopHoc m_FrmLop = null;
        private frmGiaoVien m_FrmGiaoVien = null;
        private frmLoaiDiem m_FrmLoaiDiem = null;
        private frmNamHoc m_FrmNamHoc = null;
        private frmTiepNhanHocSinh m_FrmHocSinh = null;
        private frmNguoiDung m_FrmNguoiDung = null;
        private frmPhanLop m_FrmPhanLop = null;
        private frmThongSo m_FrmQuyDinh = null;
        private frmBaoCaoChung m_FrmBaoCaoChung = null;
        private frmBaoCaoHocTap m_FrmBaoCaoHocTap = null;
        private frmPhanCong m_FrmPhanCong = null;
        private frmHocSinhTheoLop m_FrmTimLop = null;
        private frmTimHocSinh m_FrmTimHocSinh = null;
        private frmMatKhau m_FrmMatKhau = null;
        private frmChuyenLop m_FrmChuyenLop = null;
        private frmDiem m_FrmDiem = null;
        private frmHanhKiem m_FrmHanhKiem = null;
        private frmDangNhap m_FrmLogin = null;
        private frmKetQua m_FrmKQ = null;
        private frmAbout m_FrmAbout = null;
        private frmNhatKy m_FrmNhatKy = null;
        private frmConnection m_Connection = null;

        public frmMain()
        {
            InitializeComponent();
            nguoiDung_DTO = new clsNGUOIDUNG_DTO();
            nguoiDung_BUS = new clsNGUOIDUNG_BUS();

            //thông tin cần thiết cho backup dialog
            backupDialog = new SaveFileDialog();
            this.backupDialog.DefaultExt = "*.BAK";
            this.backupDialog.FileName = "QLHocSinhTHPT";
            this.backupDialog.Filter = "Backup files (*.BAK)|*.BAK";
            this.backupDialog.FilterIndex = 2;
            this.backupDialog.Title = "SAO LƯU DỮ LIỆU";

            //thông tin cần thiết cho restore dialog
            restoreDialog = new OpenFileDialog();
            this.restoreDialog.DefaultExt = "*.BAK";
            this.restoreDialog.FileName = "QLHocSinhTHPT.BAK";
            this.restoreDialog.Filter = "Backup files (*.BAK)|*.BAK";
            this.restoreDialog.FilterIndex = 2;
            this.restoreDialog.Title = "PHỤC HỒI DỮ LIỆU";           
        }

        //giao diện
        private void btnThemeBlue_Click(object sender, EventArgs e)
        {
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
        }

        private void btnThemeVista_Click(object sender, EventArgs e)
        {
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
        }

        private void btnTheme8_Click(object sender, EventArgs e)
        {
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
        }

        private void btnThemeSilver_Click(object sender, EventArgs e)
        {
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Silver;
        }

        private void btnThemeBlack_Click(object sender, EventArgs e)
        {
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Black;
        }

        private void btnTheme7_Click(object sender, EventArgs e)
        {
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            if (m_FrmNguoiDung == null || m_FrmNguoiDung.IsDisposed)
            {
                m_FrmNguoiDung = new frmNguoiDung();
                m_FrmNguoiDung.FormBorderStyle = FormBorderStyle.None;
                m_FrmNguoiDung.MdiParent = frmMain.ActiveForm;
                m_FrmNguoiDung.Show();
            }
            else
                m_FrmNguoiDung.Activate();
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            if (m_FrmGiaoVien == null || m_FrmGiaoVien.IsDisposed)
            {
                m_FrmGiaoVien = new frmGiaoVien();
                m_FrmGiaoVien.FormBorderStyle = FormBorderStyle.None;     
                m_FrmGiaoVien.MdiParent = frmMain.ActiveForm;
                m_FrmGiaoVien.Show();
            }
            else
                m_FrmGiaoVien.Activate();
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            if (m_FrmLoaiDiem == null || m_FrmLoaiDiem.IsDisposed)
            {
                m_FrmLoaiDiem = new frmLoaiDiem();
                m_FrmLoaiDiem.FormBorderStyle = FormBorderStyle.None;
                m_FrmLoaiDiem.MdiParent = frmMain.ActiveForm;
                m_FrmLoaiDiem.Show();
            }
            else
                m_FrmLoaiDiem.Activate();
        }

        private void btnKhaiBao_Click(object sender, EventArgs e)
        {
            if (m_FrmNamHoc == null || m_FrmNamHoc.IsDisposed)
            {
                m_FrmNamHoc = new frmNamHoc();
                m_FrmNamHoc.FormBorderStyle = FormBorderStyle.None;
                m_FrmNamHoc.MdiParent = frmMain.ActiveForm;
                m_FrmNamHoc.Show();
            }
            else
                m_FrmNamHoc.Activate();
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

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            if (m_FrmHocSinh == null || m_FrmHocSinh.IsDisposed)
            {
                m_FrmHocSinh = new frmTiepNhanHocSinh();
                m_FrmHocSinh.FormBorderStyle = FormBorderStyle.None;
                m_FrmHocSinh.MdiParent = frmMain.ActiveForm;
                m_FrmHocSinh.Show();
            }
            else
                m_FrmHocSinh.Activate();
        }

        private void btnThamSo_Click(object sender, EventArgs e)
        {
            if (m_FrmQuyDinh == null || m_FrmQuyDinh.IsDisposed)
            {
                
                m_FrmQuyDinh = new frmThongSo();
                m_FrmQuyDinh.Show();
                
            }
            else
                m_FrmQuyDinh.Activate();
        }

        private void btnPhanLop_Click(object sender, EventArgs e)
        {
            if (m_FrmPhanLop == null || m_FrmPhanLop.IsDisposed)
            {
                m_FrmPhanLop = new frmPhanLop();
                m_FrmPhanLop.FormBorderStyle = FormBorderStyle.None;
                m_FrmPhanLop.MdiParent = frmMain.ActiveForm;
                m_FrmPhanLop.Show();
            }
            else
                m_FrmPhanLop.Activate();
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            if (m_FrmPhanCong == null || m_FrmPhanCong.IsDisposed)
            {
                m_FrmPhanCong = new frmPhanCong();
                m_FrmPhanCong.FormBorderStyle = FormBorderStyle.None;
                m_FrmPhanCong.MdiParent = frmMain.ActiveForm;
                m_FrmPhanCong.Show();
            }
            else
                m_FrmPhanCong.Activate();
        }

        private void btnTimLop_Click(object sender, EventArgs e)
        {
            if (m_FrmTimLop == null || m_FrmTimLop.IsDisposed)
            {
                m_FrmTimLop = new frmHocSinhTheoLop();
                m_FrmTimLop.FormBorderStyle = FormBorderStyle.None;
                m_FrmTimLop.MdiParent = frmMain.ActiveForm;
                m_FrmTimLop.Show();
            }
            else
                m_FrmTimLop.Activate();
            
        }

        private void btnTimHocSinh_Click(object sender, EventArgs e)
        {
            if (m_FrmTimHocSinh == null || m_FrmTimHocSinh.IsDisposed)
            {
                m_FrmTimHocSinh = new frmTimHocSinh();
                m_FrmTimHocSinh.FormBorderStyle = FormBorderStyle.None;
                m_FrmTimHocSinh.MdiParent = frmMain.ActiveForm;
                m_FrmTimHocSinh.Show();
            }
            else
                m_FrmTimHocSinh.Activate();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (m_FrmLogin == null || m_FrmLogin.IsDisposed)
                m_FrmLogin = new frmDangNhap();

            m_FrmLogin.txtTenDN.Text = "";
            m_FrmLogin.txtMatKhau.Text = "";
            m_FrmLogin.lblUserError.Text = "";
            m_FrmLogin.lblPassError.Text = "";

            dangNhap();
        }

        private void btnMatKhau_Click(object sender, EventArgs e)
        {
            if (m_FrmMatKhau == null || m_FrmMatKhau.IsDisposed)
                m_FrmMatKhau = new frmMatKhau();

            m_FrmMatKhau.txtMkCu.Text = "";
            m_FrmMatKhau.txtMkMoi.Text = "";
            m_FrmMatKhau.txtMkNhapLai.Text = "";
            m_FrmMatKhau.lblOldPassError.Text = "";
            m_FrmMatKhau.lblNewPassError.Text = "";
            m_FrmMatKhau.lblReNPassError.Text = "";
            m_FrmMatKhau.txtMkCu.Focus();
            doiMatKhau();
        }

        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            if (m_FrmNguoiDung == null || m_FrmNguoiDung.IsDisposed)
            {
                m_FrmNguoiDung = new frmNguoiDung();
                m_FrmNguoiDung.MdiParent = this;
                m_FrmNguoiDung.Show();
            }
            else
                m_FrmNguoiDung.Activate();
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            if (m_FrmDiem == null || m_FrmDiem.IsDisposed)
            {
                m_FrmDiem = new frmDiem();
                m_FrmDiem.FormBorderStyle = FormBorderStyle.None;
                m_FrmDiem.MdiParent = frmMain.ActiveForm;
                m_FrmDiem.Show();
            }
            else
                m_FrmDiem.Activate();
        }

        private void btnHanhKiem_Click(object sender, EventArgs e)
        {
            if (m_FrmHanhKiem == null || m_FrmHanhKiem.IsDisposed)
            {
                m_FrmHanhKiem = new frmHanhKiem();
                m_FrmHanhKiem.FormBorderStyle = FormBorderStyle.None;
                m_FrmHanhKiem.MdiParent = frmMain.ActiveForm;
                m_FrmHanhKiem.Show();
            }
            else
            {
                m_FrmHanhKiem.Activate();
            }
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            if (m_FrmKQ == null || m_FrmKQ.IsDisposed)
            {
                m_FrmKQ = new frmKetQua();
                m_FrmKQ.FormBorderStyle = FormBorderStyle.None;
                m_FrmKQ.MdiParent = frmMain.ActiveForm;
                m_FrmKQ.Show();
            }
            else
            {
                m_FrmKQ.Activate();
            }
        }

        private void btnNhom_Click(object sender, EventArgs e)
        {
            if (m_FrmAbout == null || m_FrmAbout.IsDisposed)
            {
                m_FrmAbout = new frmAbout();
                m_FrmAbout.Show();
            }
            else
                m_FrmAbout.Activate();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (m_FrmBaoCaoChung == null || m_FrmBaoCaoChung.IsDisposed)
            {
                m_FrmBaoCaoChung = new frmBaoCaoChung(nguoiDung_DTO.Tennd);
                m_FrmBaoCaoChung.FormBorderStyle = FormBorderStyle.None;
                m_FrmBaoCaoChung.MdiParent = frmMain.ActiveForm;
                m_FrmBaoCaoChung.Show();
            }
            else
            {
                m_FrmBaoCaoChung.Activate();
            }
        }

        private void btnNhatKy_Click(object sender, EventArgs e)
        {
            if (m_FrmNhatKy == null || m_FrmNhatKy.IsDisposed)
            {
                m_FrmNhatKy = new frmNhatKy();
                m_FrmNhatKy.FormBorderStyle = FormBorderStyle.None;
                m_FrmNhatKy.MdiParent = frmMain.ActiveForm;
                m_FrmNhatKy.Show();
            }
            else
            {
                m_FrmNhatKy.Activate();
            }
        }

        private void btnChuyenLop_Click(object sender, EventArgs e)
        {
            if (m_FrmChuyenLop == null || m_FrmChuyenLop.IsDisposed)
            {
                m_FrmChuyenLop = new frmChuyenLop();
                m_FrmChuyenLop.FormBorderStyle = FormBorderStyle.None;
                m_FrmChuyenLop.MdiParent = frmMain.ActiveForm;
                m_FrmChuyenLop.Show();
            }
            else
            {
                m_FrmChuyenLop.Activate();
            }
        }

        private void btnBaoCaoHocTap_Click(object sender, EventArgs e)
        {
            if (m_FrmBaoCaoHocTap == null || m_FrmBaoCaoHocTap.IsDisposed)
            {
                m_FrmBaoCaoHocTap = new frmBaoCaoHocTap(nguoiDung_DTO.Tennd);
                m_FrmBaoCaoHocTap.FormBorderStyle = FormBorderStyle.None;
                m_FrmBaoCaoHocTap.MdiParent = frmMain.ActiveForm;
                m_FrmBaoCaoHocTap.Show();
            }
            else
            {
                m_FrmBaoCaoHocTap.Activate();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (clsKhoiTaoCSDL.OpenConnection())
            {
                //sự kiện khi form được load lên vô hiệu hóa các button và bắt người dùng đăng nhập
                macDinh();
                dangNhap();

                //thêm các mục thường dùng vào ribbon quickaccess toolbar menu
                ribbonControl1.QatFrequentCommands.Add(btnDangNhap);
                ribbonControl1.QatFrequentCommands.Add(btnDangXuat);
                ribbonControl1.QatFrequentCommands.Add(btnThoat);

                //tải các toolbar mà người dùng thường sử dụng ra ngoài thanh công cụ truy xuất nhanh
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey(@"Software\DevComponents\Ribbon");
                if (key != null)
                {
                    try
                    {
                        string layout = key.GetValue("RibbonPadCSLayout", "").ToString();
                        if (layout != "" && layout != null)
                            ribbonControl1.QatLayout = layout;
                    }
                    finally
                    {
                        key.Close();
                    }
                }
            }
            else
            {
                macDinh();
                ReConnection();
            }
        }

        private void ReConnection()
        {
            if (m_Connection == null || m_Connection.IsDisposed)
                m_Connection = new frmConnection();

            if (m_Connection.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Đã thiết lập kết nối cho lần chạy đầu tiên.\nHãy khởi động lại chương trình để thực thi kết nối!", "SUCCESSED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clsKhoiTaoCSDL.OpenConnection();
                this.Close();
            }
            else
                return;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            lblName.Text = "Không có";
            macDinh();
        }

        //lưu thông tin các nút  người dùng thường dùng ở phiên làm việc trước
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save Quick Access Toolbar layout if it has changed
            if (ribbonControl1.QatLayoutChanged)
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\DevComponents\Ribbon");
                try
                {
                    key.SetValue("RibbonPadCSLayout", ribbonControl1.QatLayout);
                }
                finally
                {
                    key.Close();
                }
            }
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            if (backupDialog.ShowDialog() == DialogResult.OK)
            {
                clsKhoiTaoCSDL khoiTao=new clsKhoiTaoCSDL();
                string connectionStr = khoiTao.layKetNoi();
                connection = new SqlConnection(connectionStr);
                //SqlCommand cmd = new System.Data.SqlClient.SqlCommand("BACKUP DATABASE " + "QuanLyHocSinh" + " TO DISK = '" + backupDialog.FileName.ToString() + "'", connection);
                SqlCommand cmd = new System.Data.SqlClient.SqlCommand("BACKUP DATABASE " + "QuanLyHocSinh4" + " TO DISK = '" + backupDialog.FileName.ToString() + "'", connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Sao lưu dữ liệu thành công!", "BACKUP COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                return;
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            if (restoreDialog.ShowDialog() == DialogResult.OK)
            {
                clsKhoiTaoCSDL khoiTao = new clsKhoiTaoCSDL();
                string connectionStr = khoiTao.layKetNoi();
                connection = new SqlConnection(connectionStr);
                //SqlCommand cmd = new System.Data.SqlClient.SqlCommand("alter database  QuanLyHocSinh set offline with rollback immediate alter database QuanLyHocSinh set online " +
                //"USE master RESTORE DATABASE " + "QuanLyHocSinh" + " FROM DISK = '" + restoreDialog.FileName.ToString() + "'WITH REPLACE", connection);
                SqlCommand cmd = new System.Data.SqlClient.SqlCommand("alter database  QuanLyHocSinh4 set offline with rollback immediate alter database QuanLyHocSinh4 set online " +
                "USE master RESTORE DATABASE " + "QuanLyHocSinh4" + " FROM DISK = '" + restoreDialog.FileName.ToString() + "'WITH REPLACE", connection);
                connection.Open();
                connection.ChangeDatabase("master");
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Phục hồi dữ liệu thành công!", "RESTORE COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                return;
        }

        private void dangNhap()
        {
        Cont:
            if (m_FrmLogin == null || m_FrmLogin.IsDisposed)
            {
                m_FrmLogin = new frmDangNhap();
            }

            if (m_FrmLogin.ShowDialog() == DialogResult.OK)
            {
                if (m_FrmLogin.txtTenDN.Text == "")
                {
                    m_FrmLogin.lblPassError.Text = "";
                    m_FrmLogin.lblUserError.Text = "Bạn chưa nhập tên!";
                    goto Cont;
                }

                if (m_FrmLogin.txtMatKhau.Text == "")
                {
                    m_FrmLogin.lblUserError.Text = "";
                    m_FrmLogin.lblPassError.Text = "Bạn chưa nhập mật khẩu!";
                    goto Cont;
                }
                
                int ketQua = nguoiDung_BUS.DangNhap(m_FrmLogin.txtTenDN.Text, m_FrmLogin.txtMatKhau.Text, nguoiDung_DTO);

                switch (ketQua)
                {
                    case 0:
                        m_FrmLogin.lblPassError.Text = "";
                        m_FrmLogin.lblUserError.Text = "Người dùng này không tồn tại!";
                        goto Cont;
                    case 1:
                        m_FrmLogin.lblUserError.Text = "";
                        m_FrmLogin.lblPassError.Text = "Mật khẩu không hợp lệ!";
                        goto Cont;
                    case 2:
                        lblName.Text += " " + nguoiDung_DTO.Tennd;
                        //phân quyền theo mã loại người dùng
                        phanQuyen(nguoiDung_DTO.Malnd);
                        //ghi file log
                        using (StreamWriter writer = new StreamWriter(Application.StartupPath + @"\log.txt", true))
                        {
                            writer.WriteLine(nguoiDung_DTO.Mand + "," + nguoiDung_DTO.Malnd + "," + nguoiDung_DTO.Tennd + "," + DateTime.Now.ToString());
                        }
                        break;
                }
            }
            else
            {
                return;
            }
        }

        private void doiMatKhau() 
        {
        Cont:
            if (m_FrmMatKhau.ShowDialog() == DialogResult.OK)
            {
                if (m_FrmMatKhau.txtMkCu.Text == "")
                {
                    m_FrmMatKhau.lblOldPassError.Text = "Chưa nhập mật khẩu hiện tại!";
                    m_FrmMatKhau.lblNewPassError.Text = "";
                    m_FrmMatKhau.Text = "";
                    goto Cont;
                }

                if (m_FrmMatKhau.txtMkMoi.Text == "")
                {
                    m_FrmMatKhau.lblOldPassError.Text = "";
                    m_FrmMatKhau.lblNewPassError.Text = "Chưa nhập mật khẩu mới!";
                    m_FrmMatKhau.lblReNPassError.Text = "";
                    goto Cont;
                }

                if (m_FrmMatKhau.txtMkNhapLai.Text == "")
                {
                    m_FrmMatKhau.lblOldPassError.Text = "";
                    m_FrmMatKhau.lblNewPassError.Text = "";
                    m_FrmMatKhau.lblReNPassError.Text = "Chưa nhập xác nhận mật khẩu!";
                    goto Cont;
                }

                String m_Username = m_FrmLogin.txtTenDN.Text;
                String m_Password = m_FrmLogin.txtMatKhau.Text;

                String m_OldPassword = m_FrmMatKhau.txtMkCu.Text;
                String m_NewPassword = m_FrmMatKhau.txtMkMoi.Text;
                String m_ReNPassword = m_FrmMatKhau.txtMkNhapLai.Text;

                if (m_Password != m_OldPassword)
                {
                    m_FrmMatKhau.lblOldPassError.Text = "Nhập sai mật khẩu cũ!";
                    m_FrmMatKhau.lblNewPassError.Text = "";
                    m_FrmMatKhau.lblReNPassError.Text = "";
                    goto Cont;
                }
                else if (m_NewPassword != m_ReNPassword)
                {
                    m_FrmMatKhau.lblOldPassError.Text = "";
                    m_FrmMatKhau.lblNewPassError.Text = "";
                    m_FrmMatKhau.lblReNPassError.Text = "Nhập xác nhận không khớp!";
                    goto Cont;
                }
                else
                {
                    nguoiDung_BUS.suaMatKhau(m_Username, m_NewPassword);
                    MessageBox.Show("Đổi mật khẩu thành công!", "Đổi mật khẩu thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                return;
        }

        public void phanQuyen(String quyen)
        {
            switch (quyen)
            {
                case "ADMIN": quyenAdmin(); break;
                case "GIAOVU": quyenGiaoVu(); break;
                case "GIAOVIEN":quyenGiaoVien(); break;
                default: macDinh(); break;
            }
        }

        //mặc định thì kích hoạt nút đăng nhập, thoát, hướng dẫn
        public void macDinh()
        {
            //True
            btnDangNhap.Enabled = true;
            btnThoat.Enabled = true;
            btnHuongDan.Enabled = true;

            //False
            btnDangXuat.Enabled = false;
            btnBaoCaoChung.Enabled = false;
            btnNhatKy.Enabled = false;
            btnMatKhau.Enabled = false;
            btnNguoiDung.Enabled = false;
            btnSaoLuu.Enabled = false;
            btnPhucHoi.Enabled = false;
            btnLop.Enabled = false;
            btnKhaiBao.Enabled = false;
            btnLoaiDiem.Enabled = false;
            btnDiem.Enabled = false;
            btnHanhKiem.Enabled = false;
            btnHocSinh.Enabled = false;
            btnGiaoVien.Enabled = false;
            btnPhanLop.Enabled = false;
            btnGiaoVien.Enabled = false;
            btnPhanCong.Enabled = false;
            btnChuyenLop.Enabled = false;
            btnTimHocSinh.Enabled = false;
            btnTimLop.Enabled = false;
            btnThamSo.Enabled = false;
            btnKQ.Enabled = false;
            btnBaoCaoHocTap.Enabled = false;
            rbGiaoDien.Enabled = false;
        }

        //Admin thì kích hoạt tất cả các nút và vô hiệu hóa nút đăng nhập
        public void quyenAdmin()
        {
            //False
            btnDangNhap.Enabled = false;
            //True
            btnDangXuat.Enabled = true;
            btnNhatKy.Enabled = true;
            btnMatKhau.Enabled = true;
            btnNguoiDung.Enabled = true;
            btnSaoLuu.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnLop.Enabled = true;
            btnKhaiBao.Enabled = true;
            btnLoaiDiem.Enabled = true;
            btnDiem.Enabled = true;
            btnHanhKiem.Enabled = true;
            btnHocSinh.Enabled = true;
            btnGiaoVien.Enabled = true;
            btnPhanLop.Enabled = true;
            btnGiaoVien.Enabled = true;
            btnPhanCong.Enabled = true;
            btnChuyenLop.Enabled = true;
            btnTimHocSinh.Enabled = true;
            btnTimLop.Enabled = true;
            btnThamSo.Enabled = true;
            btnKQ.Enabled = true;
            btnBaoCaoHocTap.Enabled = true;
            btnBaoCaoChung.Enabled = true;
            rbGiaoDien.Enabled = true;
        }

        //giáo viên thì vô hiệu hóa các nút đăng nhập, nhật ký, sao lưu, phục hồi
        //học sinh, phân lớp, giáo viên, phân công, lớp, khai báo
        public void quyenGiaoVien()
        {
            //True
            btnDangXuat.Enabled = true;
            btnMatKhau.Enabled = true;
            btnThoat.Enabled = true;
            btnLoaiDiem.Enabled = true;
            btnDiem.Enabled = true;
            btnHanhKiem.Enabled = true;
            btnTimLop.Enabled = true;
            btnTimHocSinh.Enabled = true;
            rbGiaoDien.Enabled = true;
            btnBaoCaoChung.Enabled = true;
            btnKQ.Enabled = true;
            btnBaoCaoHocTap.Enabled = true;
            //False
            btnDangNhap.Enabled = false;
            btnNhatKy.Enabled = false;
            btnSaoLuu.Enabled = false;
            btnPhucHoi.Enabled = false;
            btnKhaiBao.Enabled = false;
            btnHocSinh.Enabled = false;
            btnPhanLop.Enabled = false;
            btnGiaoVien.Enabled = false;
            btnPhanCong.Enabled = false;
            btnLop.Enabled = false;
        }

        //giáo vụ thì vô hiệu hóa các nút đăng nhập, nhật ký, sao lưu, phục hồi, người dùng
        public void quyenGiaoVu()
        {
            //True
            btnDangXuat.Enabled = true;
            btnMatKhau.Enabled = true;
            btnThoat.Enabled = true;
            btnKhaiBao.Enabled = true;
            btnDangXuat.Enabled = true;
            btnMatKhau.Enabled = true;
            btnLop.Enabled = true;
            btnLoaiDiem.Enabled = true;
            btnDiem.Enabled = false;
            btnHanhKiem.Enabled = false;
            btnHocSinh.Enabled = true;
            btnChuyenLop.Enabled = true;
            btnTimHocSinh.Enabled = true;
            btnTimLop.Enabled = true;
            btnPhanLop.Enabled = true;
            rbGiaoDien.Enabled = true;
            btnGiaoVien.Enabled = false;
            btnPhanCong.Enabled = false;
            btnThamSo.Enabled = false;
            btnKQ.Enabled = false;
            btnBaoCaoHocTap.Enabled = false;
            btnBaoCaoChung.Enabled = false;
            //False
            btnDangNhap.Enabled = false;
            btnNguoiDung.Enabled = false;
            btnSaoLuu.Enabled = false;
            btnPhucHoi.Enabled = false;
            btnNhatKy.Enabled = false;        
        }
       
        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace);
        }
    }
}
