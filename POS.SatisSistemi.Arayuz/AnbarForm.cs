using POS.SatisSistemi.IsMantigi;
using POS.SatisSistemi.Modeller;
using System;
using System.Windows.Forms;

namespace POS.SatisSistemi.Arayuz
{
    // Anbar əməliyyatları üçün istifadəçi interfeysi
    public partial class AnbarForm : BazaForm
    {
        private readonly MəhsulManager _məhsulManager;

        public AnbarForm()
        {
            InitializeComponent();
            _məhsulManager = new MəhsulManager();
            CədvəliHazırla();
            DiliTətbiqEt();
        }

        private void AnbarForm_Load(object sender, EventArgs e)
        {
            MəhsullarıYüklə();
        }

        protected override void DiliTətbiqEt()
        {
            this.Text = LokalizasiyaManager.GetirString("AnbarFormBasliq");
            btnYeniMəhsul.Text = LokalizasiyaManager.GetirString("YeniMəhsul");
            // Sütun başlıqları
            dgvMəhsullar.Columns["Ad"].HeaderText = LokalizasiyaManager.GetirString("MəhsulAdı");
            dgvMəhsullar.Columns["Artikul"].HeaderText = LokalizasiyaManager.GetirString("Artikul");
            dgvMəhsullar.Columns["Barkod"].HeaderText = LokalizasiyaManager.GetirString("Barkod");
            dgvMəhsullar.Columns["Qiymət"].HeaderText = LokalizasiyaManager.GetirString("Qiymət");
            dgvMəhsullar.Columns["MövcudMiqdar"].HeaderText = LokalizasiyaManager.GetirString("MövcudMiqdar");
        }

        private void CədvəliHazırla()
        {
            dgvMəhsullar.AutoGenerateColumns = false;
            dgvMəhsullar.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", DataPropertyName = "Id", Visible = false });
            dgvMəhsullar.Columns.Add(new DataGridViewTextBoxColumn { Name = "Ad", DataPropertyName = "Ad", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvMəhsullar.Columns.Add(new DataGridViewTextBoxColumn { Name = "Artikul", DataPropertyName = "Artikul", Width = 120 });
            dgvMəhsullar.Columns.Add(new DataGridViewTextBoxColumn { Name = "Barkod", DataPropertyName = "Barkod", Width = 120 });
            dgvMəhsullar.Columns.Add(new DataGridViewTextBoxColumn { Name = "Qiymət", DataPropertyName = "Qiymət", Width = 90, DefaultCellStyle = { Format = "C2" } });
            dgvMəhsullar.Columns.Add(new DataGridViewTextBoxColumn { Name = "MövcudMiqdar", DataPropertyName = "MövcudMiqdar", Width = 100 });

            // Miqdarı artırma/azaltma, redaktə və silmə düymələri
            var artırSütunu = new DataGridViewButtonColumn { Text = "+", UseColumnTextForButtonValue = true, Name = "Artır", Width = 30 };
            var azaltSütunu = new DataGridViewButtonColumn { Text = "-", UseColumnTextForButtonValue = true, Name = "Azalt", Width = 30 };
            var redakteSütunu = new DataGridViewButtonColumn { Text = "...", UseColumnTextForButtonValue = true, Name = "Redakte", Width = 40 };
            var silSütunu = new DataGridViewButtonColumn { Text = "X", UseColumnTextForButtonValue = true, Name = "Sil", Width = 30 };

            dgvMəhsullar.Columns.AddRange(artırSütunu, azaltSütunu, redakteSütunu, silSütunu);
        }

        private void MəhsullarıYüklə()
        {
            dgvMəhsullar.DataSource = _məhsulManager.HamısınıGetir();
        }

        private void btnYeniMəhsul_Click(object sender, EventArgs e)
        {
            // Yeni məhsul əlavə etmək üçün MəhsulRedakteForm-u açır
            using (var form = new MəhsulRedakteForm(null))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    MəhsullarıYüklə(); // Cədvəli yenilə
                }
            }
        }

        private void dgvMəhsullar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var məhsulId = (int)dgvMəhsullar.Rows[e.RowIndex].Cells["Id"].Value;

            // Düyməyə uyğun əməliyyatı yerinə yetirir
            if (e.ColumnIndex == dgvMəhsullar.Columns["Artır"].Index)
            {
                _məhsulManager.MiqdarıDəyiş(məhsulId, 1);
            }
            else if (e.ColumnIndex == dgvMəhsullar.Columns["Azalt"].Index)
            {
                _məhsulManager.MiqdarıDəyiş(məhsulId, -1);
            }
            else if (e.ColumnIndex == dgvMəhsullar.Columns["Redakte"].Index)
            {
                using (var form = new MəhsulRedakteForm(məhsulId))
                {
                    if (form.ShowDialog() == DialogResult.OK) MəhsullarıYüklə();
                }
            }
            else if (e.ColumnIndex == dgvMəhsullar.Columns["Sil"].Index)
            {
                var təsdiq = MessageBox.Show(LokalizasiyaManager.GetirString("SilməkİstədiyinizəƏminsiniz"),
                    LokalizasiyaManager.GetirString("Xəbərdarlıq"), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (təsdiq == DialogResult.Yes)
                {
                    _məhsulManager.Sil(məhsulId);
                }
            }
            MəhsullarıYüklə(); // Hər əməliyyatdan sonra cədvəli yenilə
        }
    }
}