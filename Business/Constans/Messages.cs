using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constans
{
    public static class Messages
    {
        
        public static string NameInvalid = "İsim geçersiz";
        internal static string MainctenanceTime="Sistem bakımda";
        internal static string ProductListed = "Ürünler Listelendi";

        public static string CarAdded = "Araba Eklendi";
        public static string CarDeleted = "Araba Silindi";
        public static string CarUpdated = "Araba Güncellendi";
        
        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted = "Renk Silindi";
        public static string ColorUpdated = "Renk Güncellendi";


        public static string BrandAdded = "Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandUpdated = "Marak Güncellendi";
        
        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";

        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";

        public static string RentalAdded = "Kiralama kaydı eklendi";
        public static string RentalInvalid = "Kiralama geçersiz";

        public static string CarImageAdded="Araba Resmi Eklendi";
        public static string CarImageDeleted="Araba Resmi Silindi";

        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
    }
}
