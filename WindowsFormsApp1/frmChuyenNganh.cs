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

namespace OpenLibrary.Prenstation
{
    public partial class frmChuyenNganh : Form
    {
        CtrCN Ctr = new CtrCN();
        public frmChuyenNganh()
        {
            InitializeComponent();
        }

        private void frmChuyenNganh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oPENLIBRARYDataSet.CHUYENNGANH' table. You can move, or remove it, as needed.
            this.cHUYENNGANHTableAdapter.Fill(this.oPENLIBRARYDataSet.CHUYENNGANH);
            dgvChuyenNganh.DataSource = Ctr.laydschuyennganh();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtChuyenNganh.Text == "")
                errorProvider1.SetError(txtChuyenNganh, "Hãy nhập tên chuyên ngành ");
            else
            {
                if (Ctr.ThemtenchuyenNganh(txtChuyenNganh.Text) == false)
                    MessageBox.Show("Thêm thất bại");
                ;

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            String s = dgvChuyenNganh.CurrentRow.Cells[0].Value.ToString();
            if (s != null && s != "")
            {
                txtChuyenNganh.Text = s;
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi có mã là " + s + " hay không?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (txtChuyenNganh.Text == "") errorProvider1.SetError(txtChuyenNganh, "Hãy nhập tên chuyên ngành ");
                    else
                    {
                        if (!Ctr.XoaChuyenNganh(txtChuyenNganh.Text = dgvChuyenNganh.CurrentRow.Cells[0].Value.ToString())) MessageBox.Show("Xóa Chuyên Ngành thất bại!");

                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                  
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtChuyenNganh.Text == "")
                errorProvider1.SetError(txtChuyenNganh, "Hãy nhập tên cần sửa chuyên ngành!");
            else
            {
                String s = dgvChuyenNganh.CurrentRow.Cells[0].Value.ToString();

                if (Ctr.SuachuyenNganh(txtChuyenNganh.Text, s) == false)
                    MessageBox.Show("Sửa thất bại");
                ;

            }
        }

        private void dgvChuyenNganh_SelectionChanged(object sender, EventArgs e)
        {
            String s = dgvChuyenNganh.CurrentRow.Cells[1].Value.ToString();
            if (s != null && s != "") txtChuyenNganh.Text = s;
        }
    }
}
