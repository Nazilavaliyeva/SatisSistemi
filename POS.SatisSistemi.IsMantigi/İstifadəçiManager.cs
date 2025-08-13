using POS.SatisSistemi.Modeller;
using POS.SatisSistemi.VeriErisim;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace POS.SatisSistemi.IsMantigi
{
    // İstifadəçilərlə bağlı qeydiyyat, giriş və digər əməliyyatları idarə edir
    public class İstifadəçiManager
    {
        private readonly JsonVeriAmbari<İstifadəçi> _istifadəçiAmbari;

        public İstifadəçiManager()
        {
            _istifadəçiAmbari = new JsonVeriAmbari<İstifadəçi>("istifadeciler.json");
            // YENİ: Başlanğıcda admin istifadəçisinin olub-olmadığını yoxlayır
            AdminİstifadəçisiYarat();
        }

        // YENİ: Əgər heç bir istifadəçi yoxdursa, defolt admin yaradır
        private void AdminİstifadəçisiYarat()
        {
            var istifadəçilər = _istifadəçiAmbari.HamısınıGetir();
            if (!istifadəçilər.Any())
            {
                var admin = new İstifadəçi
                {
                    Id = 1,
                    AdSoyad = "System Admin",
                    İstifadəçiAdı = "admin",
                    Email = "admin@pos.local",
                    ŞifrəHash = ŞifrəniHashlə("admin123"), // Real layihədə daha mürəkkəb şifrə istifadə edin
                    Rol = İstifadəçiRolu.Admin
                };
                istifadəçilər.Add(admin);
                _istifadəçiAmbari.HamısınıYaz(istifadəçilər);
            }
        }

        // Verilmiş şifrəni SHA256 alqoritmi ilə hash-ləyir
        private string ŞifrəniHashlə(string şifrə)
        {
            using (var sha256 = SHA256.Create())
            {
                var şifrəBytes = Encoding.UTF8.GetBytes(şifrə);
                var hashBytes = sha256.ComputeHash(şifrəBytes);
                return System.BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        // Yeni istifadəçini qeydiyyatdan keçirir
        public bool QeydiyyatdanKeçir(İstifadəçi yeniİstifadəçi, string şifrə)
        {
            var istifadəçilər = _istifadəçiAmbari.HamısınıGetir();

            // DƏYİŞİKLİK: İstifadəçi adı VƏ ya e-poçtun mövcud olub-olmadığını yoxlayır
            if (istifadəçilər.Any(i => i.İstifadəçiAdı.ToLower() == yeniİstifadəçi.İstifadəçiAdı.ToLower() ||
                                     i.Email.ToLower() == yeniİstifadəçi.Email.ToLower()))
            {
                return false; // İstifadəçi adı və ya email artıq mövcuddur
            }

            yeniİstifadəçi.Id = istifadəçilər.Any() ? istifadəçilər.Max(i => i.Id) + 1 : 1;
            yeniİstifadəçi.ŞifrəHash = ŞifrəniHashlə(şifrə);

            istifadəçilər.Add(yeniİstifadəçi);
            _istifadəçiAmbari.HamısınıYaz(istifadəçilər);
            return true;
        }

        // İstifadəçinin sistemə daxil olmasını yoxlayır
        public İstifadəçi GirişEt(string istifadəçiAdı, string şifrə)
        {
            var istifadəçilər = _istifadəçiAmbari.HamısınıGetir();
            var daxilOlanİstifadəçi = istifadəçilər.FirstOrDefault(i => i.İstifadəçiAdı.ToLower() == istifadəçiAdı.ToLower());

            if (daxilOlanİstifadəçi != null)
            {
                if (daxilOlanİstifadəçi.ŞifrəHash == ŞifrəniHashlə(şifrə))
                {
                    return daxilOlanİstifadəçi; // Giriş uğurludur
                }
            }
            return null; // Giriş uğursuzdur
        }

        // E-poçta görə istifadəçini tapır (şifrə bərpası üçün ilk addım)
        public İstifadəçi EpoçtaGörəTap(string email)
        {
            return _istifadəçiAmbari.HamısınıGetir().FirstOrDefault(i => i.Email.ToLower() == email.ToLower());
        }
    }
}