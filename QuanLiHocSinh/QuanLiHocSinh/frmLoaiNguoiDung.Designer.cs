﻿namespace QuanLiHocSinh
{
    partial class frmLoaiNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiNguoiDung));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navigationPane1 = new DevComponents.DotNetBar.NavigationPane();
            this.navigationPanePanel2 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.txtTenLND = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaLND = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.btnDongY = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnItemNhap = new DevComponents.DotNetBar.ButtonItem();
            this.navigationPanePanel1 = new DevComponents.DotNetBar.NavigationPanePanel();
            this.txtTim = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.btnTim = new DevComponents.DotNetBar.ButtonX();
            this.btnItemTim = new DevComponents.DotNetBar.ButtonItem();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.grdLoaiND = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MALND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCuoi = new DevComponents.DotNetBar.ButtonX();
            this.btnSau = new DevComponents.DotNetBar.ButtonX();
            this.btnTruoc = new DevComponents.DotNetBar.ButtonX();
            this.btnDau = new DevComponents.DotNetBar.ButtonX();
            this.txtHienTai = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.navigationPane1.SuspendLayout();
            this.navigationPanePanel2.SuspendLayout();
            this.navigationPanePanel1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLoaiND)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.CanCollapse = true;
            this.navigationPane1.Controls.Add(this.navigationPanePanel2);
            this.navigationPane1.Controls.Add(this.navigationPanePanel1);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPane1.ItemPaddingBottom = 2;
            this.navigationPane1.ItemPaddingTop = 2;
            this.navigationPane1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnItemNhap,
            this.btnItemTim});
            this.navigationPane1.Location = new System.Drawing.Point(0, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.NavigationBarHeight = 102;
            this.navigationPane1.Padding = new System.Windows.Forms.Padding(1);
            this.navigationPane1.Size = new System.Drawing.Size(187, 548);
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
            this.navigationPane1.TitlePanel.Size = new System.Drawing.Size(185, 24);
            this.navigationPane1.TitlePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPane1.TitlePanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
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
            this.navigationPanePanel2.Controls.Add(this.txtTenLND);
            this.navigationPanePanel2.Controls.Add(this.txtMaLND);
            this.navigationPanePanel2.Controls.Add(this.labelX1);
            this.navigationPanePanel2.Controls.Add(this.labelX2);
            this.navigationPanePanel2.Controls.Add(this.btnSua);
            this.navigationPanePanel2.Controls.Add(this.btnXoa);
            this.navigationPanePanel2.Controls.Add(this.btnHuy);
            this.navigationPanePanel2.Controls.Add(this.btnDongY);
            this.navigationPanePanel2.Controls.Add(this.btnThem);
            this.navigationPanePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel2.Location = new System.Drawing.Point(1, 25);
            this.navigationPanePanel2.Name = "navigationPanePanel2";
            this.navigationPanePanel2.ParentItem = this.btnItemNhap;
            this.navigationPanePanel2.Size = new System.Drawing.Size(185, 420);
            this.navigationPanePanel2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPanePanel2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPanePanel2.Style.GradientAngle = 90;
            this.navigationPanePanel2.TabIndex = 3;
            // 
            // txtTenLND
            // 
            // 
            // 
            // 
            this.txtTenLND.Border.Class = "TextBoxBorder";
            this.txtTenLND.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenLND.Location = new System.Drawing.Point(11, 83);
            this.txtTenLND.Name = "txtTenLND";
            this.txtTenLND.Size = new System.Drawing.Size(137, 20);
            this.txtTenLND.TabIndex = 2;
            this.txtTenLND.Enter += new System.EventHandler(this.txt_Enter);
            this.txtTenLND.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txtMaLND
            // 
            // 
            // 
            // 
            this.txtMaLND.Border.Class = "TextBoxBorder";
            this.txtMaLND.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaLND.Location = new System.Drawing.Point(11, 35);
            this.txtMaLND.Name = "txtMaLND";
            this.txtMaLND.Size = new System.Drawing.Size(137, 20);
            this.txtMaLND.TabIndex = 1;
            this.txtMaLND.Enter += new System.EventHandler(this.txt_Enter);
            this.txtMaLND.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(11, 60);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(127, 23);
            this.labelX1.TabIndex = 19;
            this.labelX1.Text = "Tên loại người dùng:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(11, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(124, 23);
            this.labelX2.TabIndex = 19;
            this.labelX2.Text = "Mã loại người dùng:";
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Location = new System.Drawing.Point(127, 120);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(53, 23);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Location = new System.Drawing.Point(64, 120);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(57, 23);
            this.btnXoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Location = new System.Drawing.Point(92, 154);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(45, 23);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDongY
            // 
            this.btnDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongY.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDongY.Location = new System.Drawing.Point(32, 154);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(45, 23);
            this.btnDongY.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDongY.TabIndex = 8;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Location = new System.Drawing.Point(5, 120);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(53, 23);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.navigationPanePanel1.Controls.Add(this.txtTim);
            this.navigationPanePanel1.Controls.Add(this.labelX7);
            this.navigationPanePanel1.Controls.Add(this.btnTim);
            this.navigationPanePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPanePanel1.Location = new System.Drawing.Point(1, 1);
            this.navigationPanePanel1.Name = "navigationPanePanel1";
            this.navigationPanePanel1.ParentItem = this.btnItemTim;
            this.navigationPanePanel1.Size = new System.Drawing.Size(185, 444);
            this.navigationPanePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navigationPanePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navigationPanePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navigationPanePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navigationPanePanel1.Style.GradientAngle = 90;
            this.navigationPanePanel1.TabIndex = 2;
            // 
            // txtTim
            // 
            // 
            // 
            // 
            this.txtTim.Border.Class = "TextBoxBorder";
            this.txtTim.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTim.Location = new System.Drawing.Point(11, 34);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(155, 20);
            this.txtTim.TabIndex = 3;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(11, 11);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(145, 23);
            this.labelX7.TabIndex = 2;
            this.labelX7.Text = "Nhập thông tin tìm kiếm";
            // 
            // btnTim
            // 
            this.btnTim.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTim.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTim.Location = new System.Drawing.Point(34, 65);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(101, 23);
            this.btnTim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTim.TabIndex = 8;
            this.btnTim.Text = "Tìm kiếm";
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
            this.groupPanel1.Controls.Add(this.grdLoaiND);
            this.groupPanel1.Controls.Add(this.btnCuoi);
            this.groupPanel1.Controls.Add(this.btnSau);
            this.groupPanel1.Controls.Add(this.btnTruoc);
            this.groupPanel1.Controls.Add(this.btnDau);
            this.groupPanel1.Controls.Add(this.txtHienTai);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(187, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(469, 548);
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
            this.groupPanel1.TabIndex = 6;
            this.groupPanel1.Text = "DANH SÁCH LOẠI NGƯỜI DÙNG";
            // 
            // grdLoaiND
            // 
            this.grdLoaiND.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdLoaiND.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdLoaiND.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdLoaiND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLoaiND.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MALND,
            this.TENLND});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdLoaiND.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdLoaiND.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdLoaiND.EnableHeadersVisualStyles = false;
            this.grdLoaiND.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grdLoaiND.Location = new System.Drawing.Point(0, 48);
            this.grdLoaiND.Name = "grdLoaiND";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdLoaiND.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdLoaiND.Size = new System.Drawing.Size(463, 479);
            this.grdLoaiND.TabIndex = 14;
            this.grdLoaiND.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLoaiND_CellClick);
            // 
            // MALND
            // 
            this.MALND.DataPropertyName = "MALND";
            this.MALND.HeaderText = "Mã loại người dùng";
            this.MALND.Name = "MALND";
            // 
            // TENLND
            // 
            this.TENLND.DataPropertyName = "TENLND";
            this.TENLND.HeaderText = "Tên loại người dùng";
            this.TENLND.Name = "TENLND";
            // 
            // btnCuoi
            // 
            this.btnCuoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCuoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCuoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCuoi.Location = new System.Drawing.Point(337, 9);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(64, 23);
            this.btnCuoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCuoi.TabIndex = 13;
            this.btnCuoi.Text = ">|";
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // btnSau
            // 
            this.btnSau.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSau.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSau.Location = new System.Drawing.Point(265, 9);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(64, 23);
            this.btnSau.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSau.TabIndex = 12;
            this.btnSau.Text = ">";
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTruoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTruoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTruoc.Location = new System.Drawing.Point(112, 9);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(64, 23);
            this.btnTruoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTruoc.TabIndex = 11;
            this.btnTruoc.Text = "<";
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnDau
            // 
            this.btnDau.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDau.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDau.Location = new System.Drawing.Point(42, 9);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(64, 23);
            this.btnDau.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDau.TabIndex = 10;
            this.btnDau.Text = "|<";
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // txtHienTai
            // 
            this.txtHienTai.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtHienTai.Border.Class = "TextBoxBorder";
            this.txtHienTai.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtHienTai.Location = new System.Drawing.Point(187, 11);
            this.txtHienTai.Name = "txtHienTai";
            this.txtHienTai.ReadOnly = true;
            this.txtHienTai.Size = new System.Drawing.Size(69, 20);
            this.txtHienTai.TabIndex = 4;
            // 
            // frmLoaiNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 548);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.navigationPane1);
            this.DoubleBuffered = true;
            this.Name = "frmLoaiNguoiDung";
            this.Text = "Quản lý loại người dùng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLoaiNguoiDung_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLoaiNguoiDung_KeyDown);
            this.navigationPane1.ResumeLayout(false);
            this.navigationPanePanel2.ResumeLayout(false);
            this.navigationPanePanel1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdLoaiND)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.NavigationPane navigationPane1;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenLND;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaLND;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnHuy;
        private DevComponents.DotNetBar.ButtonX btnDongY;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.ButtonItem btnItemNhap;
        private DevComponents.DotNetBar.NavigationPanePanel navigationPanePanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTim;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.ButtonX btnTim;
        private DevComponents.DotNetBar.ButtonItem btnItemTim;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX grdLoaiND;
        private DevComponents.DotNetBar.ButtonX btnCuoi;
        private DevComponents.DotNetBar.ButtonX btnSau;
        private DevComponents.DotNetBar.ButtonX btnTruoc;
        private DevComponents.DotNetBar.ButtonX btnDau;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHienTai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALND;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLND;
    }
}