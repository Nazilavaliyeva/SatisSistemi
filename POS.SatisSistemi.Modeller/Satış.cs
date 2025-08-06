using System.Collections.Generic;
using System;

namespace POS.SatisSistemi.Modeller
{
    // Hər bir satış əməliyyatını təmsil edən model
    public class Satış
    {
        public Satış()
        {
            // Hər satış yaradıldıqda satılan məhsulların siyahısı avtomatik yaradılır
            SatılanMəhsullar = new List<SatışDetalı>();
        }

        // Satışın unikal identifikatoru
        public int Id { get; set; }

        // Satışın baş verdiyi tarix və saat
        public DateTime Tarix { get; set; }

        // Satışın ümumi məbləği
        public decimal ÜmumiMəbləğ { get; set; }

        // İstifadə olunan ödəniş metodu
        public ÖdənişMetodu ÖdənişMetodu { get; set; }

        // Bu satışda satılan məhsulların siyahısı
        public List<SatışDetalı> SatılanMəhsullar { get; set; }
    }

    // Satış içərisindəki hər bir məhsulun detalını saxlayan alt model
    public class SatışDetalı
    {
        // Satılan məhsulun Id-si
        public int MəhsulId { get; set; }

        // Satılan məhsulun adı (hesabatlar üçün faydalıdır)
        public string MəhsulAdı { get; set; }

        // Satılan miqdar
        public int Miqdar { get; set; }

        // Satış anındakı qiymət
        public decimal Qiymət { get; set; }
    }
}