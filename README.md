# Code First Relationship - EF Core ile Kullanıcı ve Post İlişkisi

Bu proje, **Entity Framework Core** kullanılarak **Code First** yaklaşımıyla geliştirilmiş bir örnek uygulamadır. Projede `User` ve `Post` tabloları arasında **bire çok (one-to-many)** ilişki kurulmuştur.

## 🛠 Kullanılan Teknolojiler

- .NET 6 / .NET 7
- Entity Framework Core
- SQL Server (LocalDB veya Express)
- Visual Studio 2022
- C#
- Code First Yaklaşımı

---

## 📁 Proje Yapısı

### 1. **Entities**

- `UserEntity`: Kullanıcı bilgilerini içerir.
- `PostEntity`: Kullanıcılara ait gönderileri içerir. Her post bir kullanıcıya bağlıdır.

### 2. **DbContext**

`PatikaSecondDbContext` sınıfı, EF Core'un `DbContext`'inden türetilmiştir ve ilişkisel yapı aşağıdaki şekilde kurulmuştur:

```csharp
modelBuilder.Entity<PostEntity>()
    .HasOne(p => p.User)
    .WithMany(u => u.Posts)
    .HasForeignKey(p => p.UserId);
```
 ###  **Veritabanı Bağlantısı**
`appsettings.json` dosyasında bağlantı cümlesi şu şekilde yapılandırılmıştır:
```json
 "ConnectionStrings": {
  "DefaultConnection": "Server=HPLAPTOP;Database=PatikaCodeFirstDb2;Trusted_Connection=True;TrustServerCertificate=True"
}
```


