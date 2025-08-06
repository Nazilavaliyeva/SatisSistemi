using POS.SatisSistemi.IsMantigi;
using POS.SatisSistemi.Modeller;
using System;
using System.Windows.Forms;

namespace POS.SatisSistemi.Arayuz
{
    public partial class QeydiyyatForm : Form
    {
        private readonly İstifadəçiManager _istifadəçiManager;
        public QeydiyyatForm()
        {
            InitializeComponent();
            _istifadəçiManager = new İstifadəçiManager();
        }

        private void btnQeydiyyat_Click(object sender, EventArgs e)
        {
            // Validasiyalar
            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtİstifadəçiAdı.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtŞifrə.Text))
            {
                MessageBox.Show("Bütün xanalar doldurulmalıdır.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtŞifrə.Text != txtŞifrəTəkrar.Text)
            {
                MessageBox.Show("Şifrələr eyni deyil.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var yeniİstifadəçi = new İstifadəçi
            {
                AdSoyad = txtAdSoyad.Text,
                İstifadəçiAdı = txtİstifadəçiAdı.Text,
                Email = txtEmail.Text,
                Rol = İstifadəçiRolu.Kassir // Standart olaraq kassir rolu verilir
            };

            bool nəticə = _istifadəçiManager.QeydiyyatdanKeçir(yeniİstifadəçi, txtŞifrə.Text);

            if (nəticə)
            {
                MessageBox.Show("Qeydiyyat uğurla tamamlandı!", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Bu istifadəçi adı artıq mövcuddur. Fərqli bir ad seçin.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}