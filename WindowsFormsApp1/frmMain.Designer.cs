﻿
namespace OpenLibrary.Prenstation
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangnhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnThongtincanhan = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoimatkhau = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpjHeThong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgQuanlyTN = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgQuanlymuon = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgphanquyen = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(45, 46, 45, 46);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDangnhap,
            this.btnThongtincanhan,
            this.btnDoimatkhau,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 495;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1876, 219);
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Caption = "Đăng Nhập";
            this.btnDangnhap.Id = 1;
            this.btnDangnhap.ImageOptions.Image = global::OpenLibrary.Prenstation.Properties.Resources.next_16x161;
            this.btnDangnhap.ImageOptions.LargeImage = global::OpenLibrary.Prenstation.Properties.Resources.next_32x321;
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnThongtincanhan
            // 
            this.btnThongtincanhan.Caption = "Thông Tin Cá Nhân";
            this.btnThongtincanhan.Id = 2;
            this.btnThongtincanhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThongtincanhan.ImageOptions.Image")));
            this.btnThongtincanhan.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThongtincanhan.ImageOptions.LargeImage")));
            this.btnThongtincanhan.Name = "btnThongtincanhan";
            // 
            // btnDoimatkhau
            // 
            this.btnDoimatkhau.Caption = "Đổi Mật Khẩu";
            this.btnDoimatkhau.Id = 3;
            this.btnDoimatkhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoimatkhau.ImageOptions.Image")));
            this.btnDoimatkhau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDoimatkhau.ImageOptions.LargeImage")));
            this.btnDoimatkhau.Name = "btnDoimatkhau";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Quản Lý Chi Nhánh";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Quản Lý Chuyên Ngành";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Quản Lý Sách";
            this.barButtonItem6.Id = 6;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Phân Bổ Sách";
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.Image")));
            this.barButtonItem7.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem7.ImageOptions.LargeImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Thống Kê Yêu Cầu Mua Sách";
            this.barButtonItem8.Id = 8;
            this.barButtonItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.barButtonItem8.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.LargeImage")));
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Quản Lý Độc Giả";
            this.barButtonItem9.Id = 9;
            this.barButtonItem9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.Image")));
            this.barButtonItem9.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.LargeImage")));
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_ItemClick);
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Quản Lý Mượn Trả Sách";
            this.barButtonItem10.Id = 10;
            this.barButtonItem10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.Image")));
            this.barButtonItem10.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.LargeImage")));
            this.barButtonItem10.Name = "barButtonItem10";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Quản Lý Loại Nhân Viên";
            this.barButtonItem11.Id = 11;
            this.barButtonItem11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.ImageOptions.Image")));
            this.barButtonItem11.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.ImageOptions.LargeImage")));
            this.barButtonItem11.Name = "barButtonItem11";
            this.barButtonItem11.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem11_ItemClick);
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Quản Lý Nhân Viên";
            this.barButtonItem12.Id = 12;
            this.barButtonItem12.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem12.ImageOptions.Image")));
            this.barButtonItem12.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem12.ImageOptions.LargeImage")));
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpjHeThong,
            this.rpgQuanlyTN,
            this.rpgQuanlymuon,
            this.rpgphanquyen});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ Thống";
            // 
            // rpjHeThong
            // 
            this.rpjHeThong.ItemLinks.Add(this.btnDangnhap);
            this.rpjHeThong.ItemLinks.Add(this.btnThongtincanhan);
            this.rpjHeThong.ItemLinks.Add(this.btnDoimatkhau);
            this.rpjHeThong.Name = "rpjHeThong";
            this.rpjHeThong.Text = "Hệ Thống";
            // 
            // rpgQuanlyTN
            // 
            this.rpgQuanlyTN.ItemLinks.Add(this.barButtonItem4);
            this.rpgQuanlyTN.ItemLinks.Add(this.barButtonItem5);
            this.rpgQuanlyTN.ItemLinks.Add(this.barButtonItem6);
            this.rpgQuanlyTN.ItemLinks.Add(this.barButtonItem7);
            this.rpgQuanlyTN.ItemLinks.Add(this.barButtonItem8);
            this.rpgQuanlyTN.Name = "rpgQuanlyTN";
            this.rpgQuanlyTN.Text = "Quản Lý Tài Nguyên";
            // 
            // rpgQuanlymuon
            // 
            this.rpgQuanlymuon.ItemLinks.Add(this.barButtonItem9);
            this.rpgQuanlymuon.ItemLinks.Add(this.barButtonItem10);
            this.rpgQuanlymuon.Name = "rpgQuanlymuon";
            this.rpgQuanlymuon.Text = "Quản Lý Mượn Trả Sách";
            // 
            // rpgphanquyen
            // 
            this.rpgphanquyen.ItemLinks.Add(this.barButtonItem11);
            this.rpgphanquyen.ItemLinks.Add(this.barButtonItem12);
            this.rpgphanquyen.Name = "rpgphanquyen";
            this.rpgphanquyen.Text = "Phân Quyền Hệ THống";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1876, 692);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpjHeThong;
        private DevExpress.XtraBars.BarButtonItem btnDangnhap;
        private DevExpress.XtraBars.BarButtonItem btnThongtincanhan;
        private DevExpress.XtraBars.BarButtonItem btnDoimatkhau;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgQuanlyTN;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgQuanlymuon;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgphanquyen;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
    }
}

