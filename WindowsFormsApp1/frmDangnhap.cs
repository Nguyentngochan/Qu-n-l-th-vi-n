using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenLibrary.Bussiness;
using OpenLibrary.Prenstation;

namespace WindowsFormsApp1
{
    public partial class frmDangnhap : Form
    {
        CtrDangNhap ctrDangNhap = new CtrDangNhap();
        public frmDangnhap()
        {
            InitializeComponent();
        }
        private bool validateData()
        {
            errorProvider1.SetError(txtuername, (txtuername.Text == "") ? "Please enter username  " : "");
            errorProvider2.SetError(txtMK, (txtMK.Text == "") ? "Please enter Password  " : "");
            return (txtuername.Text != "" && txtMK.Text != "");
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void txtDN_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!validateData())
                return;
            bool isAutherticated = ctrDangNhap.login(txtuername.Text, txtMK.Text);
            if (isAutherticated)
            {
                var f = (frmMain)this.ParentForm;
                f.xuLyLogin();
                this.Close();
            }

            else
                MessageBox.Show("Wrong username and password", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {

        }
    }
}
