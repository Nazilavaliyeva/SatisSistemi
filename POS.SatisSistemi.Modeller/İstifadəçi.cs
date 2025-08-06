namespace POS.SatisSistemi.Modeller
{
    // Sistem istifadəçilərinin məlumatlarını saxlayan model
    public class İstifadəçi
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string İstifadəçiAdı { get; set; }
        public string Email { get; set; }

        // Şifrənin təhlükəsiz hash-lənmiş versiyası burada saxlanılır
        public string ŞifrəHash { get; set; }

        public İstifadəçiRolu Rol { get; set; }
    }
}