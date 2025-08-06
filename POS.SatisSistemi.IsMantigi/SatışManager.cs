using POS.SatisSistemi.Modeller;
using POS.SatisSistemi.VeriErisim;
using System.Collections.Generic;
using System.Linq;
using System;

namespace POS.SatisSistemi.IsMantigi
{
    // Satışla bağlı bütün biznes məntiqi əməliyyatlarını idarə edir
    public class SatışManager
    {
        private readonly JsonVeriAmbari<Satış> _satışAmbari;
        private readonly MəhsulManager _məhsulManager;

        public SatışManager()
        {
            _satışAmbari = new JsonVeriAmbari<Satış>("satislar.json");
            _məhsulManager = new MəhsulManager();
        }

        // Yeni satış əməliyyatı yaradır
        public void SatışıTamamla(Satış yeniSatış)
        {
            // Satışın anbardakı məhsul miqdarına təsirini yoxlayır və tətbiq edir
            foreach (var detal in yeniSatış.SatılanMəhsullar)
            {
                // Satılan məhsul qədər anbardakı miqdarı azaldır
                _məhsulManager.MiqdarıDəyiş(detal.MəhsulId, -detal.Miqdar);
            }

            var satışlar = _satışAmbari.HamısınıGetir();
            yeniSatış.Id = satışlar.Any() ? satışlar.Max(s => s.Id) + 1 : 1;
            yeniSatış.Tarix = DateTime.Now; // Satış tarixini sistem vaxtına görə təyin edir

            satışlar.Add(yeniSatış);
            _satışAmbari.HamısınıYaz(satışlar);
        }
        // Bütün qeydə alınmış satışların siyahısını qaytarır
        public List<Satış> HamısınıGetir()
        {
            // Satışları tarixinə görə azalan sıra ilə qaytarır (ən son satışlar yuxarıda)
            return _satışAmbari.HamısınıGetir().OrderByDescending(s => s.Tarix).ToList();
        }
    }
}