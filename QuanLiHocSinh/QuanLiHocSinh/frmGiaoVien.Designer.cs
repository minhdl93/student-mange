﻿namespace QuanLiHocSinh
{
    partial class frmGiaoVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navigationPane1 = new DevComponents.DotNetBar.NavigationPane();
            this.navigationPanePanel2 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.btnDongY = new DevComponents.DotNetBar.ButtonX();
            this.btnChonAnh = new DevComponents.DotNetBar.ButtonX();
            this.picGiaoVien = new System.Windows.Forms.PictureBox();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dtiNgaySinh = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cboBoMon = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cboGioiTinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.txtDienThoai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenGV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaGV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.btnItemNhap = new DevComponents.DotNetBar.ButtonItem();
            this.navigationPanePanel1 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.cboBoMon1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.optBoMon = new System.Windows.Forms.RadioButton();
            this.optTenGV = new System.Windows.Forms.RadioButton();
            this.optMaGV = new System.Windows.Forms.RadioButton();
            this.txtTim = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.btnTim = new DevComponents.DotNetBar.ButtonX();
            this.btnItemTim = new DevComponents.DotNetBar.ButtonItem();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.ctxMenu = new DevComponents.DotNetBar.ContextMenuBar();
            this.btnMenu = new DevComponents.DotNetBar.ButtonItem();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnRefesh = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.grdGiaoVien = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MAGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOMON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGSINHGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHIGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINHGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIENTHOAIGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MABM = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.HINHANHGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnaGiaoVien = new DevComponents.DotNetBar.Controls.BindingNavigatorEx(this.components);
            this.bindingNavigatorCountItem = new DevComponents.DotNetBar.LabelItem();
            this.bindingNavigatorMoveFirstItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorMovePreviousItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorPositionItem = new DevComponents.DotNetBar.TextBoxItem();
            this.bindingNavigatorMoveNextItem = new DevComponents.DotNetBar.ButtonItem();
            this.bindingNavigatorMoveLastItem = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.navigationPane1.SuspendLayout();
            this.navigationPanePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiNgaySinh)).BeginInit();
            this.navigationPanePanel1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGiaoVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnaGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.CanCollapse = true;
            this.navigationPane1.Controls.Add(this.navigationPanePanel2);
            this.navigationPane1.Controls.Add(this.navigationPanePanel1);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.navigationPane1.ItemPaddingBottom = 2;
            this.navigationPane1.ItemPaddingTop = 2;
            this.navigationPane1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnItemNhap,
            this.btnItemTim});
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.NavigationBarHeight = 102;
            this.navigationPane1.Padding = new System.Windows.Forms.Padding(1);
            this.navigationPane1.Size = new System.Drawing.Size(296, 538);
            this.navigationPane1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.navigationPane1.TabIndex = 4;
            // 
            // 
            // 
            this.navigationPane1.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPane1.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationPane1.TitlePanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationPane1.TitlePanel.Location = new System.Drawing.Point(1, 1);
            this.navigationPane1.TitlePanel.Name = "panelTitle";
            this.navigationPane1.TitlePanel.Size = new System.Drawing.Size(294, 24);
            this.navigationPane1.TitlePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPane1.TitlePanel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(56)))), ((int)(((byte)(148)))));
            this.navigationPane1.TitlePanel.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.navigationPane1.TitlePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPane1.TitlePanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.navigationPane1.TitlePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPane1.TitlePanel.Style.GradientAngle = 90;
            this.navigationPane1.TitlePanel.Style.MarginLeft = 4;
            this.navigationPane1.TitlePanel.TabIndex = 0;
            this.navigationPane1.TitlePanel.Text = "Nhập liệu thông tin";
            // 
            // navigationPanePanel2
            // 
            this.navigationPanePanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPanePanel2.Controls.Add(this.btnHuy);
            this.navigationPanePanel2.Controls.Add(this.btnDongY);
            this.navigationPanePanel2.Controls.Add(this.btnChonAnh);
            this.navigationPanePanel2.Controls.Add(this.picGiaoVien);
            this.navigationPanePanel2.Controls.Add(this.labelX5);
            this.navigationPanePanel2.Controls.Add(this.labelX1);
            this.navigationPanePanel2.Controls.Add(this.dtiNgaySinh);
            this.navigationPanePanel2.Controls.Add(this.cboBoMon);
            this.navigationPanePanel2.Controls.Add(this.cboGioiTinh);
            this.navigationPanePanel2.Controls.Add(this.btnSua);
            this.navigationPanePanel2.Controls.Add(this.btnXoa);
            this.navigationPanePanel2.Controls.Add(this.btnThem);
            this.navigationPanePanel2.Controls.Add(this.labelX2);
            this.navigationPanePanel2.Controls.Add(this.labelX3);
            this.navigationPanePanel2.Controls.Add(this.labelX4);
            this.navigationPanePanel2.Controls.Add(this.labelX13);
            this.navigationPanePanel2.Controls.Add(this.txtDienThoai);
            this.navigationPanePanel2.Controls.Add(this.txtDiaChi);
            this.navigationPanePanel2.Controls.Add(this.txtTenGV);
            this.navigationPanePanel2.Controls.Add(this.txtMaGV);
            this.navigationPanePanel2.Controls.Add(this.labelX14);
            this.navigationPanePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.navigationPanePanel2.Location = new System.Drawing.Point(1, 25);
            this.navigationPanePanel2.Name = "navigationPanePanel2";
            this.navigationPanePanel2.ParentItem = this.btnItemNhap;
            this.navigationPanePanel2.Size = new System.Drawing.Size(294, 410);
            this.navigationPanePanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPanePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPanePanel2.Style.GradientAngle = 90;
            this.navigationPanePanel2.TabIndex = 3;
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnHuy.Image = global::QuanLiHocSinh.Properties.Resources.Huybo;
            this.btnHuy.Location = new System.Drawing.Point(148, 360);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(92, 30);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDongY
            // 
            this.btnDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongY.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDongY.Image = global::QuanLiHocSinh.Properties.Resources.Dongy;
            this.btnDongY.Location = new System.Drawing.Point(45, 360);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(92, 30);
            this.btnDongY.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnDongY.TabIndex = 10;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnChonAnh
            // 
            this.btnChonAnh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChonAnh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChonAnh.Location = new System.Drawing.Point(186, 124);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(95, 32);
            this.btnChonAnh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChonAnh.TabIndex = 6;
            this.btnChonAnh.Tag = "";
            this.btnChonAnh.Text = "Chọn ảnh ...";
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);
            // 
            // picGiaoVien
            // 
            this.picGiaoVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picGiaoVien.Image = global::QuanLiHocSinh.Properties.Resources.no_image_found;
            this.picGiaoVien.Location = new System.Drawing.Point(182, 8);
            this.picGiaoVien.Name = "picGiaoVien";
            this.picGiaoVien.Size = new System.Drawing.Size(100, 110);
            this.picGiaoVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGiaoVien.TabIndex = 29;
            this.picGiaoVien.TabStop = false;
            this.picGiaoVien.Click += new System.EventHandler(this.picGiaoVien_Click);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(11, 260);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 28;
            this.labelX5.Text = "Tổ - Bộ môn:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(107, 160);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 28;
            this.labelX1.Text = "Giới tính";
            // 
            // dtiNgaySinh
            // 
            // 
            // 
            // 
            this.dtiNgaySinh.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.dtiNgaySinh.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.dtiNgaySinh.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.dtiNgaySinh.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.dtiNgaySinh.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtiNgaySinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiNgaySinh.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtiNgaySinh.ButtonDropDown.Visible = true;
            this.dtiNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtiNgaySinh.Format = DevComponents.Editors.eDateTimePickerFormat.Custom;
            this.dtiNgaySinh.IsPopupCalendarOpen = false;
            this.dtiNgaySinh.Location = new System.Drawing.Point(12, 130);
            // 
            // 
            // 
            this.dtiNgaySinh.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtiNgaySinh.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiNgaySinh.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtiNgaySinh.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtiNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtiNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtiNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtiNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtiNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtiNgaySinh.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiNgaySinh.MonthCalendar.DisplayMonth = new System.DateTime(2013, 10, 1, 0, 0, 0, 0);
            this.dtiNgaySinh.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtiNgaySinh.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtiNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtiNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtiNgaySinh.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiNgaySinh.MonthCalendar.TodayButtonVisible = true;
            this.dtiNgaySinh.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtiNgaySinh.Name = "dtiNgaySinh";
            this.dtiNgaySinh.Size = new System.Drawing.Size(154, 21);
            this.dtiNgaySinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtiNgaySinh.TabIndex = 2;
            // 
            // cboBoMon
            // 
            this.cboBoMon.DisplayMember = "Text";
            this.cboBoMon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBoMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoMon.FormattingEnabled = true;
            this.cboBoMon.ItemHeight = 15;
            this.cboBoMon.Location = new System.Drawing.Point(11, 283);
            this.cboBoMon.Name = "cboBoMon";
            this.cboBoMon.Size = new System.Drawing.Size(155, 21);
            this.cboBoMon.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.cboBoMon.TabIndex = 6;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DisplayMember = "Text";
            this.cboGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.ItemHeight = 15;
            this.cboGioiTinh.Location = new System.Drawing.Point(107, 183);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(59, 21);
            this.cboGioiTinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.cboGioiTinh.TabIndex = 4;
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSua.Image = global::QuanLiHocSinh.Properties.Resources.Sua;
            this.btnSua.Location = new System.Drawing.Point(188, 318);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 30);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Image = global::QuanLiHocSinh.Properties.Resources.Xoa;
            this.btnXoa.Location = new System.Drawing.Point(107, 318);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 30);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThem.Image = global::QuanLiHocSinh.Properties.Resources.Them;
            this.btnThem.Location = new System.Drawing.Point(26, 318);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 30);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(11, 209);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(124, 23);
            this.labelX2.TabIndex = 14;
            this.labelX2.Text = "Địa chỉ";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(11, 55);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(108, 23);
            this.labelX3.TabIndex = 17;
            this.labelX3.Text = "Tên giáo viên:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(11, 160);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(124, 23);
            this.labelX4.TabIndex = 16;
            this.labelX4.Text = "Điện thoại:";
            // 
            // labelX13
            // 
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Location = new System.Drawing.Point(11, 106);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(75, 23);
            this.labelX13.TabIndex = 15;
            this.labelX13.Text = "Ngày sinh:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtDienThoai.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtDienThoai.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtDienThoai.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtDienThoai.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtDienThoai.Border.Class = "TextBoxBorder";
            this.txtDienThoai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDienThoai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDienThoai.Location = new System.Drawing.Point(11, 183);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(90, 21);
            this.txtDienThoai.TabIndex = 3;
            this.txtDienThoai.Enter += new System.EventHandler(this.txt_Enter);
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            this.txtDienThoai.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtDiaChi.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtDiaChi.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtDiaChi.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtDiaChi.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtDiaChi.Border.Class = "TextBoxBorder";
            this.txtDiaChi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiaChi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDiaChi.Location = new System.Drawing.Point(11, 233);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(155, 21);
            this.txtDiaChi.TabIndex = 5;
            this.txtDiaChi.Enter += new System.EventHandler(this.txt_Enter);
            this.txtDiaChi.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtTenGV
            // 
            this.txtTenGV.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtTenGV.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtTenGV.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtTenGV.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtTenGV.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtTenGV.Border.Class = "TextBoxBorder";
            this.txtTenGV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenGV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenGV.Location = new System.Drawing.Point(11, 79);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(155, 21);
            this.txtTenGV.TabIndex = 1;
            this.txtTenGV.Enter += new System.EventHandler(this.txt_Enter);
            this.txtTenGV.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtMaGV
            // 
            this.txtMaGV.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.txtMaGV.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtMaGV.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtMaGV.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtMaGV.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtMaGV.Border.Class = "TextBoxBorder";
            this.txtMaGV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaGV.Enabled = false;
            this.txtMaGV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaGV.Location = new System.Drawing.Point(11, 25);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(155, 21);
            this.txtMaGV.TabIndex = 0;
            this.txtMaGV.Enter += new System.EventHandler(this.txt_Enter);
            this.txtMaGV.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // labelX14
            // 
            // 
            // 
            // 
            this.labelX14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX14.Location = new System.Drawing.Point(11, 2);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(108, 23);
            this.labelX14.TabIndex = 18;
            this.labelX14.Text = "Mã giáo viên:";
            // 
            // btnItemNhap
            // 
            this.btnItemNhap.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnItemNhap.Checked = true;
            this.btnItemNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnItemNhap.Image")));
            this.btnItemNhap.Name = "btnItemNhap";
            this.btnItemNhap.OptionGroup = "navBar";
            this.btnItemNhap.Text = "Nhập liệu thông tin";
            // 
            // navigationPanePanel1
            // 
            this.navigationPanePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navigationPanePanel1.Controls.Add(this.cboBoMon1);
            this.navigationPanePanel1.Controls.Add(this.optBoMon);
            this.navigationPanePanel1.Controls.Add(this.optTenGV);
            this.navigationPanePanel1.Controls.Add(this.optMaGV);
            this.navigationPanePanel1.Controls.Add(this.txtTim);
            this.navigationPanePanel1.Controls.Add(this.labelX7);
            this.navigationPanePanel1.Controls.Add(this.btnTim);
            this.navigationPanePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.navigationPanePanel1.Location = new System.Drawing.Point(1, 1);
            this.navigationPanePanel1.Name = "navigationPanePanel1";
            this.navigationPanePanel1.ParentItem = this.btnItemTim;
            this.navigationPanePanel1.Size = new System.Drawing.Size(294, 434);
            this.navigationPanePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPanePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPanePanel1.Style.GradientAngle = 90;
            this.navigationPanePanel1.TabIndex = 2;
            // 
            // cboBoMon1
            // 
            this.cboBoMon1.DisplayMember = "Text";
            this.cboBoMon1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBoMon1.FormattingEnabled = true;
            this.cboBoMon1.ItemHeight = 15;
            this.cboBoMon1.Location = new System.Drawing.Point(14, 34);
            this.cboBoMon1.Name = "cboBoMon1";
            this.cboBoMon1.Size = new System.Drawing.Size(233, 21);
            this.cboBoMon1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboBoMon1.TabIndex = 16;
            this.cboBoMon1.Visible = false;
            // 
            // optBoMon
            // 
            this.optBoMon.AutoSize = true;
            this.optBoMon.ForeColor = System.Drawing.Color.Blue;
            this.optBoMon.Location = new System.Drawing.Point(43, 114);
            this.optBoMon.Name = "optBoMon";
            this.optBoMon.Size = new System.Drawing.Size(124, 19);
            this.optBoMon.TabIndex = 15;
            this.optBoMon.TabStop = true;
            this.optBoMon.Tag = "";
            this.optBoMon.Text = "Bộ môn giảng dạy";
            this.optBoMon.UseVisualStyleBackColor = true;
            this.optBoMon.CheckedChanged += new System.EventHandler(this.optBoMon_CheckedChanged);
            // 
            // optTenGV
            // 
            this.optTenGV.AutoSize = true;
            this.optTenGV.ForeColor = System.Drawing.Color.Blue;
            this.optTenGV.Location = new System.Drawing.Point(42, 87);
            this.optTenGV.Name = "optTenGV";
            this.optTenGV.Size = new System.Drawing.Size(98, 19);
            this.optTenGV.TabIndex = 15;
            this.optTenGV.TabStop = true;
            this.optTenGV.Tag = "";
            this.optTenGV.Text = "Tên giáo viên";
            this.optTenGV.UseVisualStyleBackColor = true;
            this.optTenGV.CheckedChanged += new System.EventHandler(this.optTenGV_CheckedChanged);
            // 
            // optMaGV
            // 
            this.optMaGV.AutoSize = true;
            this.optMaGV.ForeColor = System.Drawing.Color.Blue;
            this.optMaGV.Location = new System.Drawing.Point(42, 60);
            this.optMaGV.Name = "optMaGV";
            this.optMaGV.Size = new System.Drawing.Size(95, 19);
            this.optMaGV.TabIndex = 14;
            this.optMaGV.TabStop = true;
            this.optMaGV.Tag = "";
            this.optMaGV.Text = "Mã giáo viên";
            this.optMaGV.UseVisualStyleBackColor = true;
            this.optMaGV.CheckedChanged += new System.EventHandler(this.optTenGV_CheckedChanged);
            // 
            // txtTim
            // 
            this.txtTim.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtTim.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtTim.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtTim.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtTim.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.txtTim.Border.Class = "TextBoxBorder";
            this.txtTim.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTim.Location = new System.Drawing.Point(14, 34);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(233, 21);
            this.txtTim.TabIndex = 12;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(14, 11);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(171, 23);
            this.labelX7.TabIndex = 11;
            this.labelX7.Text = "Nhập thông tin tìm kiếm:";
            // 
            // btnTim
            // 
            this.btnTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnTim.Image = global::QuanLiHocSinh.Properties.Resources.Timkiem;
            this.btnTim.Location = new System.Drawing.Point(58, 159);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(155, 37);
            this.btnTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTim.TabIndex = 13;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnItemTim
            // 
            this.btnItemTim.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnItemTim.Image = ((System.Drawing.Image)(resources.GetObject("btnItemTim.Image")));
            this.btnItemTim.Name = "btnItemTim";
            this.btnItemTim.OptionGroup = "navBar";
            this.btnItemTim.Text = "Tìm kiếm thông tin";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.ctxMenu);
            this.groupPanel1.Controls.Add(this.grdGiaoVien);
            this.groupPanel1.Controls.Add(this.bnaGiaoVien);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(296, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1066, 538);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 5;
            this.groupPanel1.Text = "DANH SÁCH GIÁO VIÊN";
            // 
            // ctxMenu
            // 
            this.ctxMenu.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.ctxMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxMenu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMenu});
            this.ctxMenu.Location = new System.Drawing.Point(494, 246);
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(75, 25);
            this.ctxMenu.Stretch = true;
            this.ctxMenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ctxMenu.TabIndex = 16;
            this.ctxMenu.TabStop = false;
            this.ctxMenu.Text = "ctxMenu";
            // 
            // btnMenu
            // 
            this.btnMenu.AutoExpandOnClick = true;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnMenu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAdd,
            this.btnRefesh,
            this.btnDelete,
            this.btnClose});
            this.btnMenu.Text = "Menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::QuanLiHocSinh.Properties.Resources.add;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Image = global::QuanLiHocSinh.Properties.Resources.refresh;
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnRefesh.Text = "Làm tươi danh dách";
            this.btnRefesh.Click += new System.EventHandler(this.frmGiaoVien_Load);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::QuanLiHocSinh.Properties.Resources.delete;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.btnDelete.Text = "Xóa dòng được chọn";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::QuanLiHocSinh.Properties.Resources.exit;
            this.btnClose.Name = "btnClose";
            this.btnClose.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltF4);
            this.btnClose.Text = "Đóng cửa sổ này";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grdGiaoVien
            // 
            this.grdGiaoVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdGiaoVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGiaoVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAGV,
            this.BOMON,
            this.TENGV,
            this.NGSINHGV,
            this.DIACHIGV,
            this.GIOITINHGV,
            this.DIENTHOAIGV,
            this.MABM,
            this.HINHANHGV});
            this.ctxMenu.SetContextMenuEx(this.grdGiaoVien, this.btnMenu);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdGiaoVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdGiaoVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdGiaoVien.EnableHeadersVisualStyles = false;
            this.grdGiaoVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grdGiaoVien.Location = new System.Drawing.Point(0, 25);
            this.grdGiaoVien.Name = "grdGiaoVien";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdGiaoVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdGiaoVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdGiaoVien.Size = new System.Drawing.Size(1060, 492);
            this.grdGiaoVien.TabIndex = 9;
            this.grdGiaoVien.TabStop = false;
            this.grdGiaoVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdGiaoVien_CellClick);
            // 
            // MAGV
            // 
            this.MAGV.DataPropertyName = "MAGV";
            this.MAGV.HeaderText = "Mã giáo viên";
            this.MAGV.Name = "MAGV";
            // 
            // BOMON
            // 
            this.BOMON.DataPropertyName = "MABM";
            this.BOMON.HeaderText = "MABM";
            this.BOMON.Name = "BOMON";
            this.BOMON.Visible = false;
            // 
            // TENGV
            // 
            this.TENGV.DataPropertyName = "TENGV";
            this.TENGV.HeaderText = "Tên giáo viên";
            this.TENGV.Name = "TENGV";
            // 
            // NGSINHGV
            // 
            this.NGSINHGV.DataPropertyName = "NGSINHGV";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.NGSINHGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.NGSINHGV.HeaderText = "Ngày sinh";
            this.NGSINHGV.Name = "NGSINHGV";
            // 
            // DIACHIGV
            // 
            this.DIACHIGV.DataPropertyName = "DIACHIGV";
            this.DIACHIGV.HeaderText = "Địa chỉ";
            this.DIACHIGV.Name = "DIACHIGV";
            // 
            // GIOITINHGV
            // 
            this.GIOITINHGV.DataPropertyName = "GIOITINHGV";
            this.GIOITINHGV.HeaderText = "Giới tính";
            this.GIOITINHGV.Name = "GIOITINHGV";
            // 
            // DIENTHOAIGV
            // 
            this.DIENTHOAIGV.DataPropertyName = "DIENTHOAIGV";
            this.DIENTHOAIGV.HeaderText = "Điện thoại";
            this.DIENTHOAIGV.Name = "DIENTHOAIGV";
            // 
            // MABM
            // 
            this.MABM.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.MABM.HeaderText = "Bộ môn";
            this.MABM.Name = "MABM";
            // 
            // HINHANHGV
            // 
            this.HINHANHGV.DataPropertyName = "HINHANHGV";
            this.HINHANHGV.HeaderText = "Hình ảnh";
            this.HINHANHGV.Name = "HINHANHGV";
            this.HINHANHGV.Visible = false;
            // 
            // bnaGiaoVien
            // 
            this.bnaGiaoVien.AntiAlias = true;
            this.bnaGiaoVien.CountLabel = this.bindingNavigatorCountItem;
            this.bnaGiaoVien.CountLabelFormat = "of {0}";
            this.bnaGiaoVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.bnaGiaoVien.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.bnaGiaoVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bnaGiaoVien.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.buttonItem2,
            this.buttonItem3,
            this.buttonItem1});
            this.bnaGiaoVien.Location = new System.Drawing.Point(0, 0);
            this.bnaGiaoVien.MoveFirstButton = this.bindingNavigatorMoveFirstItem;
            this.bnaGiaoVien.MoveLastButton = this.bindingNavigatorMoveLastItem;
            this.bnaGiaoVien.MoveNextButton = this.bindingNavigatorMoveNextItem;
            this.bnaGiaoVien.MovePreviousButton = this.bindingNavigatorMovePreviousItem;
            this.bnaGiaoVien.Name = "bnaGiaoVien";
            this.bnaGiaoVien.PositionTextBox = this.bindingNavigatorPositionItem;
            this.bnaGiaoVien.Size = new System.Drawing.Size(1060, 25);
            this.bnaGiaoVien.Stretch = true;
            this.bnaGiaoVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bnaGiaoVien.TabIndex = 21;
            this.bnaGiaoVien.TabStop = false;
            this.bnaGiaoVien.Text = "bindingNavigatorEx1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Text = "of {0}";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.move_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.move_Click);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.BeginGroup = true;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.TextBoxWidth = 54;
            this.bindingNavigatorPositionItem.WatermarkColor = System.Drawing.SystemColors.GrayText;
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.BeginGroup = true;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.move_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.move_Click);
            // 
            // buttonItem2
            // 
            this.buttonItem2.Image = global::QuanLiHocSinh.Properties.Resources.add;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "buttonItem2";
            this.buttonItem2.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // buttonItem3
            // 
            this.buttonItem3.Image = global::QuanLiHocSinh.Properties.Resources.delete;
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.Text = "buttonItem3";
            this.buttonItem3.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // buttonItem1
            // 
            this.buttonItem1.Image = global::QuanLiHocSinh.Properties.Resources.refresh;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "buttonItem1";
            this.buttonItem1.Click += new System.EventHandler(this.frmGiaoVien_Load);
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 538);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.navigationPane1);
            this.DoubleBuffered = true;
            this.Name = "frmGiaoVien";
            this.Text = "QUẢN LÝ GIÁO VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGiaoVien_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGiaoVien_KeyDown);
            this.navigationPane1.ResumeLayout(false);
            this.navigationPanePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiNgaySinh)).EndInit();
            this.navigationPanePanel1.ResumeLayout(false);
            this.navigationPanePanel1.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdGiaoVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnaGiaoVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.NavigationPane navigationPane1;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel1;
        private System.Windows.Forms.RadioButton optTenGV;
        private System.Windows.Forms.RadioButton optMaGV;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTim;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.ButtonX btnTim;
        private DevComponents.DotNetBar.ButtonItem btnItemTim;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel2;
        private DevComponents.DotNetBar.ButtonX btnHuy;
        private DevComponents.DotNetBar.ButtonX btnDongY;
        private DevComponents.DotNetBar.ButtonX btnChonAnh;
        private System.Windows.Forms.PictureBox picGiaoVien;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtiNgaySinh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboGioiTinh;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDienThoai;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiaChi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenGV;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaGV;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.ButtonItem btnItemNhap;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX grdGiaoVien;
        private DevComponents.DotNetBar.ContextMenuBar ctxMenu;
        private DevComponents.DotNetBar.ButtonItem btnMenu;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnRefesh;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private DevComponents.DotNetBar.Controls.BindingNavigatorEx bnaGiaoVien;
        private DevComponents.DotNetBar.LabelItem bindingNavigatorCountItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveFirstItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMovePreviousItem;
        private DevComponents.DotNetBar.TextBoxItem bindingNavigatorPositionItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveNextItem;
        private DevComponents.DotNetBar.ButtonItem bindingNavigatorMoveLastItem;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboBoMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn BOMON;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGSINHGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHIGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINHGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIENTHOAIGV;
        private System.Windows.Forms.DataGridViewComboBoxColumn MABM;
        private System.Windows.Forms.DataGridViewTextBoxColumn HINHANHGV;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboBoMon1;
        private System.Windows.Forms.RadioButton optBoMon;
    }
}