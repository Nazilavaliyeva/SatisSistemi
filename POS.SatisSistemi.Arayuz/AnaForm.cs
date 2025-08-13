using POS.SatisSistemi.IsMantigi;
using POS.SatisSistemi.Modeller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace POS.SatisSistemi.Arayuz
{
    public partial class AnaForm : BazaForm
    {
        private readonly MəhsulManager _məhsulManager;
        private readonly SatışManager _satışManager;
        private readonly İstifadəçi _cariİstifadəçi; // YENİ
        private List<SatışDetalı> _səbət = new List<SatışDetalı>();

        // DƏYİŞİKLİK: Konstruktor artıq daxil olan istifadəçini qəbul edir
        public AnaForm(İstifadəçi istifadəçi)
        {
            InitializeComponent();
            _məhsulManager = new MəhsulManager();
            _satışManager = new SatışManager();
            _cariİstifadəçi = istifadəçi; // YENİ: Cari istifadəçini təyin et

            SəbətiHazırla();
            DiliTətbiqEt();
            RolaGörəNəzarət(); // YENİ: İstifadəçi roluna görə interfeysi tənzimləyir
        }

        // YENİ: İstifadəçinin roluna görə düymələri aktiv/deaktiv edir
        private void RolaGörəNəzarət()
        {
            if (_cariİstifadəçi.Rol == İstifadəçiRolu.Kassir)
            {
                btnAnbar.Enabled = false;
                btnAnbar.BackColor = System.Drawing.Color.LightGray;
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            lbAxtarışNəticələri.Visible = false;
        }

        protected override void DiliTətbiqEt()
        {
            this.Text = LokalizasiyaManager.GetirString("AnaFormBasliq");
            btnAnbar.Text = LokalizasiyaManager.GetirString("Anbar");
            // YENİ: btnSatışTarixçəsi-nin mətni də lokallaşdırılır
            btnSatışTarixçəsi.Text = LokalizasiyaManager.GetirString("SatışTarixçəsi");
            txtAxtarış.PlaceholderText = LokalizasiyaManager.GetirString("Axtar");
            lblÜmumiYekunBaşlıq.Text = LokalizasiyaManager.GetirString("ÜmumiYekun");
            btnNəğd.Text = LokalizasiyaManager.GetirString("Nəğd");
            btnKartla.Text = LokalizasiyaManager.GetirString("Kartla");
            btnKöçürmə.Text = LokalizasiyaManager.GetirString("Köçürmə");
            btnNisyə.Text = LokalizasiyaManager.GetirString("Nisyə");

            dgvSəbət.Columns["MəhsulAdı"].HeaderText = LokalizasiyaManager.GetirString("MəhsulAdı");
            dgvSəbət.Columns["Miqdar"].HeaderText = LokalizasiyaManager.GetirString("Miqdar");
            dgvSəbət.Columns["Qiymət"].HeaderText = LokalizasiyaManager.GetirString("Qiymət");
            dgvSəbət.Columns["Cəm"].HeaderText = LokalizasiyaManager.GetirString("Cəm");
            dgvSəbət.Columns["SilSütunu"].HeaderText = "";
        }

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

        // DƏYİŞİKLİK: Məhsulu səbətə əlavə edərkən anbar yoxlaması əlavə edildi
        private void MəhsuluSəbətəƏlavəEt(Məhsul məhsul, int miqdar = 1)
        {
            var anbardakıMəhsul = _məhsulManager.IdGörəTap(məhsul.Id);
            var səbətdəkiMəhsul = _səbət.FirstOrDefault(m => m.MəhsulId == məhsul.Id);

            int səbətdəkiCariMiqdar = səbətdəkiMəhsul?.Miqdar ?? 0;

            if (anbardakıMəhsul.MövcudMiqdar < səbətdəkiCariMiqdar + miqdar)
            {
                MessageBox.Show($"Anbarda yalnız {anbardakıMəhsul.MövcudMiqdar} ədəd '{məhsul.Ad}' var.", "Anbar Nəzarəti", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (səbətdəkiMəhsul != null)
            {
                səbətdəkiMəhsul.Miqdar += miqdar;
            }
            else
            {
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

        // ... SəbətiHazırla, SəbətiYenilə, SəbətCəminiHesabla metodları olduğu kimi qalır ...
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

        // DƏYİŞİKLİK: Miqdar dəyişdirildikdə anbar yoxlaması
        private void dgvSəbət_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvSəbət.Columns["Miqdar"].Index)
            {
                var row = dgvSəbət.Rows[e.RowIndex];
                var detal = row.DataBoundItem as SatışDetalı;
                if (detal == null) return;

                int yeniMiqdar;
                if (!int.TryParse(row.Cells["Miqdar"].Value?.ToString(), out yeniMiqdar) || yeniMiqdar <= 0)
                {
                    MessageBox.Show("Düzgün miqdar daxil edin.", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    row.Cells["Miqdar"].Value = detal.Miqdar; // Köhnə dəyəri geri qaytar
                    return;
                }

                var anbardakıMəhsul = _məhsulManager.IdGörəTap(detal.MəhsulId);
                if (anbardakıMəhsul.MövcudMiqdar < yeniMiqdar)
                {
                    MessageBox.Show($"Anbarda yalnız {anbardakıMəhsul.MövcudMiqdar} ədəd '{detal.MəhsulAdı}' var.", "Anbar Nəzarəti", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    row.Cells["Miqdar"].Value = detal.Miqdar; // Köhnə dəyəri geri qaytar
                }
                else
                {
                    detal.Miqdar = yeniMiqdar;
                }

                SəbətiYenilə();
            }
        }

        #endregion

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
            _səbət.Clear();
            SəbətiYenilə();
            txtAxtarış.Clear();
        }

        private void btnDil_Click(object sender, EventArgs e)
        {
            var düymə = sender as Button;
            LokalizasiyaManager.DiliDəyişdir(düymə.Tag.ToString());
            DiliTətbiqEt();
        }

        private void btnAnbar_Click(object sender, EventArgs e)
        {
            using (var anbarFormu = new AnbarForm())
            {
                anbarFormu.ShowDialog();
            }
        }

        // YENİ: Satış tarixçəsi düyməsinin funksionallığı
        private void btnSatışTarixçəsi_Click(object sender, EventArgs e)
        {
            using (var tarixçəFormu = new SatışTarixçəsiForm())
            {
                tarixçəFormu.ShowDialog();
            }
        }
    }
}