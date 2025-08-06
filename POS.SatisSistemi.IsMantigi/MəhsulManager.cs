using POS.SatisSistemi.Modeller;
using POS.SatisSistemi.VeriErisim;
using System.Collections.Generic;
using System.Linq;

namespace POS.SatisSistemi.IsMantigi
{
    // Məhsullarla bağlı bütün biznes məntiqi əməliyyatlarını idarə edir
    public class MəhsulManager
    {
        private readonly JsonVeriAmbari<Məhsul> _məhsulAmbari;

        // Konstruktor, məhsul deposunu (JSON faylı) yaradır
        public MəhsulManager()
        {
            _məhsulAmbari = new JsonVeriAmbari<Məhsul>("mehsullar.json");
        }

        // Bütün məhsulların siyahısını qaytarır
        public List<Məhsul> HamısınıGetir()
        {
            return _məhsulAmbari.HamısınıGetir();
        }

        // ID-yə görə bir məhsulu tapır
        public Məhsul IdGörəTap(int id)
        {
            return HamısınıGetir().FirstOrDefault(m => m.Id == id);
        }

        // Yeni məhsul əlavə edir
        public void ƏlavəEt(Məhsul yeniMəhsul)
        {
            var məhsullar = HamısınıGetir();
            // Yeni məhsul üçün unikal ID təyin edir
            yeniMəhsul.Id = məhsullar.Any() ? məhsullar.Max(m => m.Id) + 1 : 1;
            məhsullar.Add(yeniMəhsul);
            _məhsulAmbari.HamısınıYaz(məhsullar);
        }

        // Mövcud məhsulu yeniləyir
        public void Yenilə(Məhsul yenilənmişMəhsul)
        {
            var məhsullar = HamısınıGetir();
            var mövcudMəhsul = məhsullar.FirstOrDefault(m => m.Id == yenilənmişMəhsul.Id);
            if (mövcudMəhsul != null)
            {
                mövcudMəhsul.Ad = yenilənmişMəhsul.Ad;
                mövcudMəhsul.Artikul = yenilənmişMəhsul.Artikul;
                mövcudMəhsul.Barkod = yenilənmişMəhsul.Barkod;
                mövcudMəhsul.Qiymət = yenilənmişMəhsul.Qiymət;
                mövcudMəhsul.MövcudMiqdar = yenilənmişMəhsul.MövcudMiqdar;
                _məhsulAmbari.HamısınıYaz(məhsullar);
            }
        }

        // Məhsulu ID-sinə görə silir
        public void Sil(int məhsulId)
        {
            var məhsullar = HamısınıGetir();
            var silinəcəkMəhsul = məhsullar.FirstOrDefault(m => m.Id == məhsulId);
            if (silinəcəkMəhsul != null)
            {
                məhsullar.Remove(silinəcəkMəhsul);
                _məhsulAmbari.HamısınıYaz(məhsullar);
            }
        }

        // Məhsulun anbardakı miqdarını artırıb/azaldır
        public void MiqdarıDəyiş(int məhsulId, int dəyişim) // dəyişim müsbət (artım) və ya mənfi (azalma) ola bilər
        {
            var məhsullar = HamısınıGetir();
            var məhsul = məhsullar.FirstOrDefault(m => m.Id == məhsulId);
            if (məhsul != null)
            {
                məhsul.MövcudMiqdar += dəyişim;
                _məhsulAmbari.HamısınıYaz(məhsullar);
            }
        }

        // Ad, artikul və ya barkoda görə məhsul axtarır
        public List<Məhsul> Axtar(string axtarışMətni)
        {
            var məhsullar = HamısınıGetir();
            if (string.IsNullOrWhiteSpace(axtarışMətni))
            {
                return məhsullar;
            }

            axtarışMətni = axtarışMətni.ToLower();
            return məhsullar.Where(m =>
                m.Ad.ToLower().Contains(axtarışMətni) ||
                m.Artikul.ToLower().Contains(axtarışMətni) ||
                m.Barkod.ToLower().Contains(axtarışMətni))
                .ToList();
        }
    }
}