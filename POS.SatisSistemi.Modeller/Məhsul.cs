namespace POS.SatisSistemi.Modeller
{
    // Məhsul məlumatlarını saxlamaq üçün istifadə olunan model
    public class Məhsul
    {
        // Məhsulun unikal identifikatoru
        public int Id { get; set; }

        // Məhsulun adı
        public string Ad { get; set; }

        // Məhsulun artikul kodu (SKU)
        public string Artikul { get; set; }

        // Məhsulun barkodu
        public string Barkod { get; set; }

        // Məhsulun satış qiyməti
        public decimal Qiymət { get; set; }

        // Anbarda olan məhsul miqdarı
        public int MövcudMiqdar { get; set; }
    }
}