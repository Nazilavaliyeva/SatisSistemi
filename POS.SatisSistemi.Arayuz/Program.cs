using POS.SatisSistemi.IsMantigi;
using System;
using System.Globalization; // Valyuta və mədəniyyət ayarları üçün əlavə edildi
using System.Threading;      // Valyuta və mədəniyyət ayarları üçün əlavə edildi
using System.Windows.Forms;

namespace POS.SatisSistemi.Arayuz
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Proqramın valyuta və tarix formatlarını Azərbaycan mədəniyyətinə uyğunlaşdırır.
            // Bu, bütün "C2" formatlı məbləğlərin sonunda "₼" (Manat) işarəsini göstərəcək.
            var cultureInfo = new CultureInfo("az-Latn-AZ");
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            // Standart Windows Forms tənzimləmələri
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Lokalizasiya üçün mövcud kodunuz
            LokalizasiyaManager.DiliDəyişdir("az");

            // Giriş formunu yarat və işə sal
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