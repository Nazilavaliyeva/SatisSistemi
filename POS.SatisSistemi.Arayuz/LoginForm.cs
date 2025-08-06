using POS.SatisSistemi.IsMantigi;
using System;
using System.Windows.Forms;

namespace POS.SatisSistemi.Arayuz
{
    public partial class LoginForm : Form
    {
        private readonly İstifadəçiManager _istifadəçiManager;

        public LoginForm()
        {
            InitializeComponent();
            _istifadəçiManager = new İstifadəçiManager();
        }

        private void btnGiriş_Click(object sender, EventArgs e)
        {
            var istifadəçi = _istifadəçiManager.GirişEt(txtİstifadəçiAdı.Text, txtŞifrə.Text);
            if (istifadəçi != null)
            {
                // Giriş uğurludur
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("İstifadəçi adı və ya şifrə yanlışdır!", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkQeydiyyat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var qeydiyyatFormu = new QeydiyyatForm())
            {
                qeydiyyatFormu.ShowDialog();
            }
        }

        private void linkŞifrəBərpa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var bərpaFormu = new ŞifrəBərpaForm())
            {
                bərpaFormu.ShowDialog();
            }
        }
    }
}