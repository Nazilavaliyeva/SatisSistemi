using POS.SatisSistemi.IsMantigi;
using POS.SatisSistemi.Modeller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace POS.SatisSistemi.Arayuz
{
    // Əsas satış ekranı
    public partial class AnaForm : BazaForm
    {
        private readonly MəhsulManager _məhsulManager;
        private readonly SatışManager _satışManager;
        private List<SatışDetalı> _səbət = new List<SatışDetalı>();

        public AnaForm()
        {
            InitializeComponent();
            _məhsulManager = new MəhsulManager();
            _satışManager = new SatışManager();
            SəbətiHazırla();
            DiliTətbiqEt();
        }

        // Formun yüklənməsi zamanı baş verən hadisə
        private void AnaForm_Load(object sender, EventArgs e)
        {
            // Axtarış listbox-unu gizlədir
            lbAxtarışNəticələri.Visible = false;
        }

        // Dil dəyişdirildikdə formadakı mətnləri yeniləyir
        protected override void DiliTətbiqEt()
        {
            this.Text = LokalizasiyaManager.GetirString("AnaFormBasliq");
            btnAnbar.Text = LokalizasiyaManager.GetirString("Anbar");
            txtAxtarış.PlaceholderText = LokalizasiyaManager.GetirString("Axtar");
            lblÜmumiYekunBaşlıq.Text = LokalizasiyaManager.GetirString("ÜmumiYekun");
            btnNəğd.Text = LokalizasiyaManager.GetirString("Nəğd");
            btnKartla.Text = LokalizasiyaManager.GetirString("Kartla");
            btnKöçürmə.Text = LokalizasiyaManager.GetirString("Köçürmə");
            btnNisyə.Text = LokalizasiyaManager.GetirString("Nisyə");

            // DataGridView başlıqlarını yeniləyir
            dgvSəbət.Columns["MəhsulAdı"].HeaderText = LokalizasiyaManager.GetirString("MəhsulAdı");
            dgvSəbət.Columns["Miqdar"].HeaderText = LokalizasiyaManager.GetirString("Miqdar");
            dgvSəbət.Columns["Qiymət"].HeaderText = LokalizasiyaManager.GetirString("Qiymət");
            dgvSəbət.Columns["Cəm"].HeaderText = LokalizasiyaManager.GetirString("Cəm");
            dgvSəbət.Columns["SilSütunu"].HeaderText = "";
        }

        #region Axtarış və Səbət Əməliyyatları

        // Axtarış qutusuna mətn daxil edildikdə işə düşür
        private void txtAxtarış_TextChanged(object sender, EventArgs e)
        {
            string axtarışMətni = txtAxtarış.Text;
            if (string.IsNullOrWhiteSpace(axtarışMətni))
            {
                lbAxtarışNəticələri.Visible = false;
                return;
            }

            var nəticələr = _məhsulManager.Axtar(axtarışMətni);
            lbAxtarışNəticələri.DataSource = nəticələr;
            lbAxtarışNəticələri.DisplayMember = "Ad";
            lbAxtarışNəticələri.ValueMember = "Id";
            lbAxtarışNəticələri.Visible = nəticələr.Any();
        }

        // Axtarış nəticələrindən bir məhsul seçildikdə işə düşür
        private void lbAxtarışNəticələri_DoubleClick(object sender, EventArgs e)
        {
            if (lbAxtarışNəticələri.SelectedItem is Məhsul seçilmişMəhsul)
            {
                MəhsuluSəbətəƏlavəEt(seçilmişMəhsul);
                txtAxtarış.Clear();
                txtAxtarış.Focus();
                lbAxtarışNəticələri.Visible = false;
            }
        }

        // Məhsulu səbətə əlavə edir
        private void MəhsuluSəbətəƏlavəEt(Məhsul məhsul, int miqdar = 1)
        {
            var səbətdəkiMəhsul = _səbət.FirstOrDefault(m => m.MəhsulId == məhsul.Id);

            if (səbətdəkiMəhsul != null)
            {
                // Məhsul artıq səbətdə varsa, miqdarını artır
                səbətdəkiMəhsul.Miqdar += miqdar;
            }
            else
            {
                // Yoxdursa, yeni detal kimi əlavə et
                _səbət.Add(new SatışDetalı
                {
                    MəhsulId = məhsul.Id,
                    MəhsulAdı = məhsul.Ad,
                    Miqdar = miqdar,
                    Qiymət = məhsul.Qiymət
                });
            }
            SəbətiYenilə();
        }

        #endregion

        #region DataGridView Əməliyyatları

        // Səbət cədvəlini (DataGridView) ilkin hazırlayır
        private void SəbətiHazırla()
        {
            dgvSəbət.AutoGenerateColumns = false;
            dgvSəbət.Columns.Clear();
            dgvSəbət.Columns.Add(new DataGridViewTextBoxColumn { Name = "MəhsulId", DataPropertyName = "MəhsulId", Visible = false });
            dgvSəbət.Columns.Add(new DataGridViewTextBoxColumn { Name = "MəhsulAdı", DataPropertyName = "MəhsulAdı", HeaderText = "Məhsul Adı", ReadOnly = true, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvSəbət.Columns.Add(new DataGridViewTextBoxColumn { Name = "Miqdar", DataPropertyName = "Miqdar", HeaderText = "Miqdar", Width = 70 });
            dgvSəbət.Columns.Add(new DataGridViewTextBoxColumn { Name = "Qiymət", DataPropertyName = "Qiymət", HeaderText = "Qiymət", Width = 90, DefaultCellStyle = { Format = "C2" } });
            dgvSəbət.Columns.Add(new DataGridViewTextBoxColumn { Name = "Cəm", HeaderText = "Cəm", Width = 100, ReadOnly = true, DefaultCellStyle = { Format = "C2" } });

            // Sil düyməsi üçün sütun
            var silSütunu = new DataGridViewButtonColumn
            {
                Name = "SilSütunu",
                Text = "X",
                UseColumnTextForButtonValue = true,
                Width = 40,
                FlatStyle = FlatStyle.Flat
            };
            dgvSəbət.Columns.Add(silSütunu);
            dgvSəbət.CellPainting += (sender, e) => {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvSəbət.Columns["SilSütunu"].Index)
                    e.CellStyle.BackColor = System.Drawing.Color.Tomato;
            };
        }

        // Səbəti və ümumi məbləği yeniləyir
        private void SəbətiYenilə()
        {
            dgvSəbət.DataSource = null;
            dgvSəbət.DataSource = _səbət;

            decimal ümumiYekun = 0;
            foreach (var item in _səbət)
            {
                ümumiYekun += item.Miqdar * item.Qiymət;
            }

            lblÜmumiYekun.Text = ümumiYekun.ToString("C2");
            SəbətCəminiHesabla();
        }

        // Səbətdəki hər sətir üçün cəmi hesablayır
        private void SəbətCəminiHesabla()
        {
            foreach (DataGridViewRow row in dgvSəbət.Rows)
            {
                if (row.DataBoundItem is SatışDetalı detal)
                {
                    row.Cells["Cəm"].Value = detal.Miqdar * detal.Qiymət;
                }
            }
        }

        // Cədvəldəki bir xanaya kliklənəndə işə düşür (silmə düyməsi üçün)
        private void dgvSəbət_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvSəbət.Columns["SilSütunu"].Index)
            {
                var silinəcəkMəhsul = _səbət[e.RowIndex];
                _səbət.Remove(silinəcəkMəhsul);
                SəbətiYenilə();
            }
        }

        // Miqdar xanası redaktə edildikdən sonra ümumi məbləği yeniləyir
        private void dgvSəbət_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvSəbət.Columns["Miqdar"].Index)
            {
                SəbətiYenilə();
            }
        }

        #endregion

        #region Düymə Hadisələri

        // Ödəniş düymələrindən birinə basıldıqda işə düşür
        private void btnÖdəniş_Click(object sender, EventArgs e)
        {
            if (!_səbət.Any())
            {
                MessageBox.Show(LokalizasiyaManager.GetirString("ZəhmətOlmasaMəhsulSeçin"), LokalizasiyaManager.GetirString("Xəbərdarlıq"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var düymə = sender as Button;
            ÖdənişMetodu metod = (ÖdənişMetodu)Enum.Parse(typeof(ÖdənişMetodu), düymə.Tag.ToString());

            var satış = new Satış
            {
                SatılanMəhsullar = _səbət,
                ÜmumiMəbləğ = _səbət.Sum(m => m.Miqdar * m.Qiymət),
                ÖdənişMetodu = metod
            };

            _satışManager.SatışıTamamla(satış);

            MessageBox.Show(LokalizasiyaManager.GetirString("SatışUğurluOldu"), LokalizasiyaManager.GetirString("Məlumat"), MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Formu təmizlə
            _səbət.Clear();
            SəbətiYenilə();
            txtAxtarış.Clear();
        }

        // Dil dəyişmə düymələri
        private void btnDil_Click(object sender, EventArgs e)
        {
            var düymə = sender as Button;
            LokalizasiyaManager.DiliDəyişdir(düymə.Tag.ToString());
            DiliTətbiqEt();
        }

        // Anbar formunu açır
        private void btnAnbar_Click(object sender, EventArgs e)
        {
            using (var anbarFormu = new AnbarForm())
            {
                anbarFormu.ShowDialog();
            }
        }

        #endregion
        // Satış tarixçəsi formunu açır
        private void btnSatışTarixçəsi_Click(object sender, EventArgs e)
        {
            using (var tarixçəFormu = new SatışTarixçəsiForm())
            {
                tarixçəFormu.ShowDialog();
            }
        }
    }
}
