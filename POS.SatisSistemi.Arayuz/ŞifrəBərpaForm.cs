using POS.SatisSistemi.IsMantigi;
using System;
using System.Windows.Forms;

namespace POS.SatisSistemi.Arayuz
{
    public partial class ŞifrəBərpaForm : Form
    {
        private readonly İstifadəçiManager _istifadəçiManager;
        public ŞifrəBərpaForm()
        {
            InitializeComponent();
            _istifadəçiManager = new İstifadəçiManager();
        }

        private void btnGöndər_Click(object sender, EventArgs e)
        {
            var istifadəçi = _istifadəçiManager.EpoçtaGörəTap(txtEmail.Text);
            if (istifadəçi != null)
            {
                // Real proyektlərdə burada e-poçt göndərmə xidməti işə düşür.
                // Biz isə sadəcə təsdiq mesajı göstəririk.
                MessageBox.Show($"Bərpa təlimatları {istifadəçi.Email} ünvanına göndərildi.", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Bu e-poçt ünvanı ilə qeydiyyatdan keçmiş istifadəçi tapılmadı.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblTəlimat_Click(object sender, EventArgs e)
        {

        }
    }
}