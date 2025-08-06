using POS.SatisSistemi.IsMantigi;
using System.Windows.Forms;

namespace POS.SatisSistemi.Arayuz
{
    // Bütün formalar üçün ortaq xüsusiyyətləri təmin edən baza klass
    public partial class BazaForm : Form
    {
        public BazaForm()
        {
            InitializeComponent();
            // Formun şriftini təyin edir
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        // Formun üzərindəki bütün idarəetmə elementlərinin (controls) mətnini yeniləyir
        protected virtual void DiliTətbiqEt()
        {
            // Forma daxilindəki hər bir control üçün dil resursunu tətbiq edir
            foreach (Control c in this.Controls)
            {
                // Tag xüsusiyyətində saxlanılan resurs adını oxuyur
                if (c.Tag != null && !string.IsNullOrEmpty(c.Tag.ToString()))
                {
                    c.Text = LokalizasiyaManager.GetirString(c.Tag.ToString());
                }
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BazaForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "BazaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }
    }
}