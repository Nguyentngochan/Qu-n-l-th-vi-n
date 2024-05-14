﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenLibrary.Bussiness;
using WindowsFormsApp1;

namespace OpenLibrary.Prenstation
{
    
    public partial class frmMain : Form
    {
        CtrTrangchu ctr = new CtrTrangchu();
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (LoginInfo.MaNV == -1)
            {
                frmDangnhap f = new frmDangnhap();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
            else
            {
                ctr.logout();
                xuLyLogin();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmChuyenNganh f = (frmChuyenNganh)this.MdiChildren.FirstOrDefault(k => k is frmChuyenNganh);
            if (f == null)
            {
                f = new frmChuyenNganh();
                f.MdiParent = this;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void xuLyLogin()
        {
            this.Text = (LoginInfo.HoTenNV != "") ? "OpenLibrary" : "Open Library – Xin Chao " + LoginInfo.HoTenNV;
            btnDangnhap.Caption = LoginInfo.MaNV == -1 ? "DangNhap" : "DangXuat";
            btnDangnhap.ImageOptions.LargeImage = (LoginInfo.MaNV != -1) ? Properties.Resources.next_32x32 : Properties.Resources.close_16x16;
            btnThongtincanhan.Enabled = LoginInfo.MaNV == 1;
            btnDoimatkhau.Enabled = LoginInfo.MaNV == 1;
            rpgphanquyen.Visible = LoginInfo.MaLoaiNV == 1;
            rpgQuanlyTN.Visible = LoginInfo.MaLoaiNV == 1;
            rpgQuanlymuon.Visible = LoginInfo.MaLoaiNV == -1;
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            xuLyLogin();
        }
    }
}
