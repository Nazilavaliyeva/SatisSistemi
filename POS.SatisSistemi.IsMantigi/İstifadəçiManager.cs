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
            if (istifadəçilər.Any(i => i.İstifadəçiAdı.ToLower() == yeniİstifadəçi.İstifadəçiAdı.ToLower()))
            {
                return false;
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

            // Dəyişənin adı düzgün yazıldı
            var daxilOlanİstifadəçi = istifadəçilər.FirstOrDefault(i => i.İstifadəçiAdı.ToLower() == istifadəçiAdı.ToLower());

            if (daxilOlanİstifadəçi != null)
            {
                // Dəyişənin adı düzgün yazıldı
                if (daxilOlanİstifadəçi.ŞifrəHash == ŞifrəniHashlə(şifrə))
                {
                    // Dəyişənin adı düzgün yazıldı
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