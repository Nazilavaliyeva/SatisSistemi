using POS.SatisSistemi.IsMantigi;
using POS.SatisSistemi.Modeller; // YENİ
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace POS.SatisSistemi.Arayuz
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var cultureInfo = new CultureInfo("az-Latn-AZ");
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LokalizasiyaManager.DiliDəyişdir("az");

            // DƏYİŞİKLİK: AnaForm-a istifadəçi ötürmək üçün bütün blok dəyişdirildi
            using (var loginForm = new LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    // Giriş uğurlu olarsa, daxil olan istifadəçini AnaForm-a ötür
                    Application.Run(new AnaForm(loginForm.DaxilOlanİstifadəçi));
                }
            }
        }
    }
}