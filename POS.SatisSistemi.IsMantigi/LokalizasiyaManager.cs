// POS.SatisSistemi.IsMantigi/LokalizasiyaManager.cs

using POS.SatisSistemi.IsMantigi.Properties; // Diqqət: Artıq öz layihəsinə işarə edir!
using System.Globalization;
using System.Resources;
using System.Threading;

namespace POS.SatisSistemi.IsMantigi
{
    /// <summary>
    /// Proqramın dilini idarə etmək üçün mərkəzi klass.
    /// Artıq bütün resurslar bu layihənin içindədir.
    /// </summary>
    public static class LokalizasiyaManager
    {
        /// <summary>
        /// Seçilmiş dilə uyğun mətn resursunu qaytarır.
        /// </summary>
        /// <param name="ad">Resursun açar sözü (adı)</param>
        /// <returns>Tərcümə edilmiş mətn</returns>
        public static string GetirString(string ad)
        {
            // 'Resources' artıq POS.SatisSistemi.IsMantigi.Properties'dən gəlir
            return Resources.ResourceManager.GetString(ad, Thread.CurrentThread.CurrentUICulture);
        }

        /// <summary>
        /// Proqramın mövcud işləmə dilini dəyişir.
        /// </summary>
        /// <param name="dilKodu">"az" və ya "en" kimi dil kodu</param>
        public static void DiliDəyişdir(string dilKodu)
        {
            var cultureInfo = new CultureInfo(dilKodu);
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
        }
    }
}