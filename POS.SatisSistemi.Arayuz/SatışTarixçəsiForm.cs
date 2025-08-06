using POS.SatisSistemi.IsMantigi;
using POS.SatisSistemi.Modeller;
using System;
using System.Windows.Forms;

namespace POS.SatisSistemi.Arayuz
{
    // Keçmiş satış əməliyyatlarını göstərən forma
    public partial class SatışTarixçəsiForm : BazaForm
    {
        private readonly SatışManager _satışManager;

        public SatışTarixçəsiForm()
        {
            InitializeComponent();
            _satışManager = new SatışManager();
            CədvəlləriHazırla();
        }

        // Forma yüklənərkən satışları cədvələ doldurur
        private void SatışTarixçəsiForm_Load(object sender, EventArgs e)
        {
            dgvSatışlar.DataSource = _satışManager.HamısınıGetir();
        }

        // Cədvəllərin sütunlarını və formatlarını təyin edir
        private void CədvəlləriHazırla()
        {
            // Satışlar cədvəli
            dgvSatışlar.AutoGenerateColumns = false;
            dgvSatışlar.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", DataPropertyName = "Id", HeaderText = "Satış ID", Width = 80 });
            dgvSatışlar.Columns.Add(new DataGridViewTextBoxColumn { Name = "Tarix", DataPropertyName = "Tarix", HeaderText = "Tarix", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, DefaultCellStyle = { Format = "dd.MM.yyyy HH:mm" } });
            dgvSatışlar.Columns.Add(new DataGridViewTextBoxColumn { Name = "ÖdənişMetodu", DataPropertyName = "ÖdənişMetodu", HeaderText = "Ödəniş Növü", Width = 150 });
            dgvSatışlar.Columns.Add(new DataGridViewTextBoxColumn { Name = "ÜmumiMəbləğ", DataPropertyName = "ÜmumiMəbləğ", HeaderText = "Yekun Məbləğ", Width = 150, DefaultCellStyle = { Format = "C2" } });

            // Satış detalları cədvəli
            dgvSatışDetalları.AutoGenerateColumns = false;
            dgvSatışDetalları.Columns.Add(new DataGridViewTextBoxColumn { Name = "MəhsulAdı", DataPropertyName = "MəhsulAdı", HeaderText = "Məhsul Adı", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvSatışDetalları.Columns.Add(new DataGridViewTextBoxColumn { Name = "Miqdar", DataPropertyName = "Miqdar", HeaderText = "Miqdar", Width = 100 });
            dgvSatışDetalları.Columns.Add(new DataGridViewTextBoxColumn { Name = "Qiymət", DataPropertyName = "Qiymət", HeaderText = "Vahidin Qiyməti", Width = 150, DefaultCellStyle = { Format = "C2" } });
        }

        // Yuxarı cədvəldə sətir seçimi dəyişdikdə işə düşür
        private void dgvSatışlar_SelectionChanged(object sender, EventArgs e)
        {
            // Seçilmiş sətir varsa
            if (dgvSatışlar.CurrentRow != null)
            {
                // Seçilmiş sətrin bağlı olduğu Satış obyektini götürür
                var seçilmişSatış = dgvSatışlar.CurrentRow.DataBoundItem as Satış;
                if (seçilmişSatış != null)
                {
                    // Aşağıdakı cədvəli həmin satışın məhsulları ilə doldurur
                    dgvSatışDetalları.DataSource = seçilmişSatış.SatılanMəhsullar;
                }
            }
        }
    }
}