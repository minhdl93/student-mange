﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using QLHS.BUS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace QuanLiHocSinh
{
    public partial class frmBaoCaoChung : DevComponents.DotNetBar.Office2007Form
    {
        private clsNAMHOC_BUS namHoc_BUS;
        private clsHOCSINH_BUS hocSinh_BUS;
        private clsHANHKIEM_BUS hanhkiem_BUS;
        private clsHOCKY_BUS hocKy_BUS;
        private clsBAOCAO_BUS baoCao_BUS;
        private clsLOP_BUS lop_BUS;

        private string tenND;

        public frmBaoCaoChung()
        {
            InitializeComponent();
            namHoc_BUS = new clsNAMHOC_BUS();
            hocSinh_BUS = new clsHOCSINH_BUS();
            hanhkiem_BUS = new clsHANHKIEM_BUS();
            hocKy_BUS = new clsHOCKY_BUS();
            baoCao_BUS = new clsBAOCAO_BUS();
            lop_BUS = new clsLOP_BUS();
        }

        public frmBaoCaoChung(string TenND)
        {
            this.tenND = TenND;
            InitializeComponent();
            namHoc_BUS = new clsNAMHOC_BUS();
            hocSinh_BUS = new clsHOCSINH_BUS();
            hanhkiem_BUS = new clsHANHKIEM_BUS();
            hocKy_BUS = new clsHOCKY_BUS();
            baoCao_BUS = new clsBAOCAO_BUS();
            lop_BUS = new clsLOP_BUS();
        }

        private void frmBaoCaoChung_Load(object sender, EventArgs e)
        {
            namHoc_BUS.hienThiComboBox(cboNamHocDSLop);
            namHoc_BUS.hienThiComboBox(cboNamHocTheHS);
            namHoc_BUS.hienThiComboBox(cboNamHoc);
            btnDshocsinh.Enabled = false;
            namHoc_BUS.hienThiComboBox(cboNamHocHocBa);
        }

        private void btnInDSGiaoVien_Click(object sender, EventArgs e)
        {
            ReportDocument document = new ReportDocument();
            DataSet ds = baoCao_BUS.reportDanhSachGiaoVien();
            ds.WriteXmlSchema(Application.StartupPath + @"\DSGiaoVien.xsd");

            document.Load((Application.StartupPath.ToString()) + @"\report\DSGiaoVien.rpt");
            document.SetDataSource(ds.Tables["GiaoVien"]);
            TextObject text = (TextObject)document.ReportDefinition.ReportObjects["NguoiLap"];
            text.Text = tenND;
            rptView.ReportSource = document;
            rptView.RefreshReport();
        }

        private void btnInTheHS_Click(object sender, EventArgs e)
        {
            if (treLopTheHS.SelectedNode == null || treLopTheHS.SelectedNode.Parent == null)
            {
                MessageBox.Show("Phải chọn một lớp");
            }
            else
            {
                ReportDocument document = new ReportDocument();
                DataSet ds = baoCao_BUS.reportTheHS(hocSinh_BUS.layMaLop(cboNamHocTheHS, treLopTheHS));
                ds.WriteXmlSchema(Application.StartupPath + @"\TheHocSinh.xsd");

                document.Load((Application.StartupPath.ToString()) + @"\report\TheHocSinh.rpt");
                document.SetDataSource(ds.Tables["TheHocSinh"]);
                rptView.ReportSource = document;
                rptView.RefreshReport();
            }
        }

        private void btnInDSLop_Click(object sender, EventArgs e)
        {
            if (cboNamHocDSLop.SelectedValue != null)
            {
                ReportDocument document = new ReportDocument();
                DataSet ds = baoCao_BUS.reportDanhSachLop();
                ds.WriteXmlSchema(Application.StartupPath + @"\DSLop.xsd");

                document.Load((Application.StartupPath.ToString()) + @"\report\DSLop.rpt");
                if (ds.Tables["Lop"].Select("MANH='" + cboNamHocDSLop.SelectedValue+"'").Length!=0)
                {
                    document.SetDataSource(ds.Tables["Lop"].Select("MANH='" + cboNamHocDSLop.SelectedValue + "'").CopyToDataTable());
                    TextObject text = (TextObject)document.ReportDefinition.ReportObjects["NguoiLap1"];
                    text.Text = tenND;
                    rptView.ReportSource = document;
                    rptView.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu");
                }
                
            }
        }

        private void btnDshocsinh_Click(object sender, EventArgs e)
        {
            if (cboNamHoc.SelectedValue != null)
            {
                if (treLop.SelectedNode.Name.ToString().Substring(0, 1).ToString() == "L")
                {
                    ReportDocument document = new ReportDocument();
                    DataSet ds = hocSinh_BUS.danhSachHocSinh_NH_LOP(cboNamHoc.SelectedValue.ToString(), treLop.SelectedNode.Name.ToString());
                    ds.WriteXmlSchema(Application.StartupPath + @"\DanhSachHocSinh.xsd");
                    document.Load((Application.StartupPath.ToString()) + @"\report\DSHS_Lop.rpt");
                    document.SetDataSource(ds.Tables["DanhSachHocSinh"]);
                    rptView.ReportSource = document;
                    rptView.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Chưa chọn lớp học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn năm học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboNamHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            treLop.Nodes.Clear();
            hanhkiem_BUS.hienThiLopHoc(treLop, cboNamHoc);
        }

        private void treLop_NodeClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            btnDshocsinh.Enabled = true;
        }

        private void treLop_NodeDoubleClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            if (treLop.SelectedNode.Parent == null)
            {
            }
            else
            {
                if (cboNamHoc.SelectedValue != null)
                {
                    if (treLop.SelectedNode.Name.ToString().Substring(0, 1).ToString() == "L")
                    {
                        ReportDocument document = new ReportDocument();
                        DataSet ds = hocSinh_BUS.danhSachHocSinh_NH_LOP(cboNamHoc.SelectedValue.ToString(), treLop.SelectedNode.Name.ToString());
                        ds.WriteXmlSchema(Application.StartupPath + @"\DanhSachHocSinh.xsd");
                        document.Load((Application.StartupPath.ToString()) + @"\report\DSHS_Lop.rpt");
                        document.SetDataSource(ds.Tables["DanhSachHocSinh"]);
                        rptView.ReportSource = document;
                        rptView.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Chưa chọn lớp học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Chưa chọn năm học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cboNamHocTheHS_Click(object sender, EventArgs e)
        {

        }

        private void treLopTheHS_NodeDoubleClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            if (treLopTheHS.SelectedNode.Parent == null)
            {
            }
            else
            {
                ReportDocument document = new ReportDocument();
                DataSet ds = baoCao_BUS.reportTheHS(hocSinh_BUS.layMaLop(cboNamHocTheHS, treLopTheHS));
                ds.WriteXmlSchema(Application.StartupPath + @"\TheHocSinh.xsd");

                document.Load((Application.StartupPath.ToString()) + @"\report\TheHocSinh.rpt");
                document.SetDataSource(ds.Tables["TheHocSinh"]);
                rptView.ReportSource = document;
                rptView.RefreshReport();
            }
        }

        private void cboNamHocTheHS_SelectedValueChanged(object sender, EventArgs e)
        {
            treLopTheHS.Nodes.Clear();
            if (cboNamHocTheHS.SelectedValue != null)
            {
                lop_BUS.hienThiTreeLopTheoNamHoc(cboNamHocTheHS.SelectedValue.ToString(), treLopTheHS);
            }
        }

        private void cboNamHocHocBa_SelectedValueChanged(object sender, EventArgs e)
        {
            treLopHocBa.Nodes.Clear();
            if (cboNamHocHocBa.SelectedValue != null)
            {
                lop_BUS.hienThiTreeLopTheoNamHoc(cboNamHocHocBa.SelectedValue.ToString(), treLopHocBa);
            }
        }

        private void treLopHocBa_NodeClick(object sender, DevComponents.AdvTree.TreeNodeMouseEventArgs e)
        {
            if (treLopHocBa.SelectedNode.Parent == null)
            {
            }
            else
            {
                if (cboNamHocHocBa.SelectedValue != null)
                {
                    hocSinh_BUS.HienThicbodsHocSinh(cboHocSinhHocBa, cboNamHocHocBa.SelectedValue.ToString(), lop_BUS.layMaLopTrenTree(cboNamHocHocBa, treLopHocBa));
                }
            }
        }

        private void btnInHocBa_Click(object sender, EventArgs e)
        {
            DataSet ds = baoCao_BUS.hocBaTheoNamHoc(cboNamHocHocBa, cboHocSinhHocBa, lop_BUS.layMaLopTrenTree(cboNamHocHocBa, treLopHocBa));
            if (ds.Tables.Count < 4)
            {
                MessageBox.Show("Học sinh chưa hoàn thành 3 năm học tại trường");
            }
            else
            {
                ReportDocument document = new ReportDocument();

                ds.WriteXmlSchema(Application.StartupPath + @"\HocBa.xsd");
                document.Load((Application.StartupPath.ToString()) + @"\report\rptHocBa.rpt");
                document.SetDataSource(ds);
                rptView.ReportSource = document;
                rptView.RefreshReport();

            }
        }
    }
}
