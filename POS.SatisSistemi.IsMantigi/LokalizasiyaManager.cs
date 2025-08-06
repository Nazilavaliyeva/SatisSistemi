using POS.SatisSistemi.Arayuz.Properties; // Arayüz layihəsindəki Resources'a referans
using System.Globalization;
using System.Resources;
using System.Threading;

namespace POS.SatisSistemi.IsMantigi
{
    // Proqramın dilini idarə etmək üçün mərkəzi klass
    public static class LokalizasiyaManager
    {
        // Seçilmiş dilə uyğun mətni qaytarır
        public static string GetirString(string ad)
        {
            return Resources.ResourceManager.GetString(ad, Thread.CurrentThread.CurrentUICulture);
        }

        // Proqramın dilini dəyişir
        public static void DiliDəyişdir(string dilKodu) // "az" və ya "en"
        {
            var cultureInfo = new CultureInfo(dilKodu);
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
        }
    }
}