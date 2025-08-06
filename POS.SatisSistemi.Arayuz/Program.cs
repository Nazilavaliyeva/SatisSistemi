using POS.SatisSistemi.IsMantigi; // Əlavə edildi
using System;
using System.Windows.Forms;

namespace POS.SatisSistemi.Arayuz
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Standart dili təyin et
            LokalizasiyaManager.DiliDəyişdir("az");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AnaForm()); // Düzəliş
        }
    }
}