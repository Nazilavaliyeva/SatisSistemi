using POS.SatisSistemi.IsMantigi;
using POS.SatisSistemi.Modeller;
using System;
using System.Windows.Forms;

namespace POS.SatisSistemi.Arayuz
{
    // Yeni məhsul əlavə etmək və ya mövcud olanı redaktə etmək üçün forma
    public partial class MəhsulRedakteForm : BazaForm
    {
        private readonly MəhsulManager _məhsulManager;
        private Məhsul _cariMəhsul;

        // Konstruktor: məhsulId null isə yeni, əks halda redaktə rejimi
        public MəhsulRedakteForm(int? məhsulId)
        {
            InitializeComponent();
            _məhsulManager = new MəhsulManager();

            if (məhsulId.HasValue)
            {
                _cariMəhsul = _məhsulManager.IdGörəTap(məhsulId.Value);
            }
            DiliTətbiqEt();
            MəlumatlarıDoldur();
        }

        protected override void DiliTətbiqEt()
        {
            this.Text = LokalizasiyaManager.GetirString("MəhsulRedakteFormBasliq");
            lblAd.Text = LokalizasiyaManager.GetirString("MəhsulAdı");
            lblArtikul.Text = LokalizasiyaManager.GetirString("Artikul");
            lblBarkod.Text = LokalizasiyaManager.GetirString("Barkod");
            lblQiymət.Text = LokalizasiyaManager.GetirString("Qiymət");
            lblMövcudMiqdar.Text = LokalizasiyaManager.GetirString("MövcudMiqdar");
            btnYaddaSaxla.Text = LokalizasiyaManager.GetirString("YaddaSaxla");
            btnLəğvEt.Text = LokalizasiyaManager.GetirString("LəğvEt");
        }

        // Formdakı sahələri məhsul məlumatları ilə doldurur (redaktə rejimi üçün)
        private void MəlumatlarıDoldur()
        {
            if (_cariMəhsul != null)
            {
                txtAd.Text = _cariMəhsul.Ad;
                txtArtikul.Text = _cariMəhsul.Artikul;
                txtBarkod.Text = _cariMəhsul.Barkod;
                txtQiymət.Text = _cariMəhsul.Qiymət.ToString("F2");
                txtMövcudMiqdar.Text = _cariMəhsul.MövcudMiqdar.ToString();
            }
        }

        private void btnYaddaSaxla_Click(object sender, EventArgs e)
        {
            // Validasiya (sadə)
            if (string.IsNullOrWhiteSpace(txtAd.Text) || !decimal.TryParse(txtQiymət.Text, out _) || !int.TryParse(txtMövcudMiqdar.Text, out _))
            {
                MessageBox.Show("Məlumatları düzgün daxil edin.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_cariMəhsul == null) // Yeni məhsul rejimi
            {
                _cariMəhsul = new Məhsul();
            }

            // Dəyərləri təyin et
            _cariMəhsul.Ad = txtAd.Text;
            _cariMəhsul.Artikul = txtArtikul.Text;
            _cariMəhsul.Barkod = txtBarkod.Text;
            _cariMəhsul.Qiymət = decimal.Parse(txtQiymət.Text);
            _cariMəhsul.MövcudMiqdar = int.Parse(txtMövcudMiqdar.Text);

            if (_cariMəhsul.Id > 0) // Redaktə rejimi
            {
                _məhsulManager.Yenilə(_cariMəhsul);
            }
            else // Əlavə etmə rejimi
            {
                _məhsulManager.ƏlavəEt(_cariMəhsul);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnLəğvEt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}