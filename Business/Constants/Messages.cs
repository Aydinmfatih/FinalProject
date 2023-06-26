using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductsListed = "ürün listelendi";
        public static string MaintenanceTime = "Ürünler listelendi";
        public static string? AuthorizationDenied = "yetkiniz yok";
        public static string UserRegistered ="Kayıt olundu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Giriş Başarılı";
        public static string UserAlreadyExists = "kullanıcı zaten mevcut";

        public static string AccessTokenCreated = "Erişim oluşturuldu";
    }
}
