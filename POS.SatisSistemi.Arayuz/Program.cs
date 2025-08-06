using POS.SatisSistemi.IsMantigi;
using System;
using System.Windows.Forms;

namespace POS.SatisSistemi.Arayuz
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Standart Windows Forms tənzimləmələri
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Standart dili təyin et
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