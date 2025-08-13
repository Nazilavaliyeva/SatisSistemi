using POS.SatisSistemi.IsMantigi;
using System;
using System.Globalization; // Bunu əlavə edin
using System.Threading;      // Bunu əlavə edin
using System.Windows.Forms;

namespace POS.SatisSistemi.Arayuz
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Valyuta və tarix formatlarını Azərbaycan mədəniyyətinə uyğunlaşdır
            var cultureInfo = new CultureInfo("az-Latn-AZ");
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            // Standart Windows Forms tənzimləmələri
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Lokalizasiya üçün mövcud kodunuz
            LokalizasiyaManager.DiliDəyişdir("az");

            // Giriş formunu yarat
            using (var loginForm = new LoginForm())
            {
                // Giriş formunu göstər və nəticəni gözlə
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Giriş uğurlu olarsa, əsas formu işə sal
                    Application.Run(new AnaForm());
                }
                // Əgər giriş uğurlu olmazsa və ya pəncərə bağlanarsa, proqram sonlanır.
            }
        }
    }
}