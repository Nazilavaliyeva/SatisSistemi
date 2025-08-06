using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace POS.SatisSistemi.VeriErisim
{
    // Hər hansı bir model növü (T) üçün JSON faylına məlumat yazmaq və oxumaq üçün ümumi (generic) depo klassı
    public class JsonVeriAmbari<T> where T : class
    {
        private readonly string _faylYolu;

        // Konstruktor, məlumatların saxlanacağı fayl yolunu təyin edir
        public JsonVeriAmbari(string faylAdi)
        {
            // Proqramın işlədiyi qovluqda "Veri" adlı bir alt qovluq yaradırıq
            string veriQovluğu = Path.Combine(Directory.GetCurrentDirectory(), "Veri");
            Directory.CreateDirectory(veriQovluğu);
            _faylYolu = Path.Combine(veriQovluğu, faylAdi);
        }

        // Fayldan bütün məlumatları oxuyur
        public List<T> HamısınıGetir()
        {
            // Fayl mövcud deyilsə, boş bir siyahı qaytarır
            if (!File.Exists(_faylYolu))
            {
                return new List<T>();
            }

            // Faylın məzmununu oxuyur
            string json = File.ReadAllText(_faylYolu);

            // JSON mətnini obyektlərin siyahısına çevirir
            return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }

        // Məlumatların tam siyahısını fayla yazır
        public void HamısınıYaz(List<T> məlumatlar)
        {
            // Obyektlərin siyahısını formatlı (oxunaqlı) JSON mətninə çevirir
            var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(məhsullar, jsonOptions);

            // JSON mətnini fayla yazır
            File.WriteAllText(_faylYolu, json);
        }
    }
}