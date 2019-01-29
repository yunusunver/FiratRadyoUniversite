
# Kullanılan Teknolojiler
- Asp.net MVC Core
- Entity Framework
- MS SQL Server

# Kullanılan Özel Geliştirme Araçları ve Ortamları
Bu projede yazılım dili olarak C# , geliştirme ortamı olarak Visual Studio , veritabanı olarak MS Sql Server, arayüz kütüphanesi olarak Bootstrap kullanılmıştır. Veritabanı işlemlerini daha kolay ve düzenli yapabilmek için Entity Framework kütüphanesi kullandım. Entity Framework ,nesne tabanlı programlamada veritabanındaki  tablolara uygun nesneler oluşturma tekniğidir. Entity Framework’te sorgulamaları Linq ile kullanarak yaptım. Linq nesneleri sorgulamada kullanılan sorgulama dilidir. 
Bu projeyi katmanlı mimari yapısı kullanarak geliştirdim. Katmanlı mimariyi kullanmamın sebebi projemin daha derli toplu olması, kodun okunabilirliğini artırması ve hata yönetimini kolaylaştırmasıdır. Projem Entities Katmanı, DataAccess Katmanı, Business Katmanı ,Core Katmanı,ve WebUI katmanı olarak 5 tane katmandan oluşmaktadır. 

# Veri Tabanı Şeması
![erradyo](https://user-images.githubusercontent.com/24482512/51919152-e6570b00-23f3-11e9-985e-ccdbb6d52c14.png)


## 4.2 Veri Sözlüğü

**Kurumsal Tablosu**

| **Değişken Adı** | **Veri Tipi** | **Uzunluk** | **Açıklama** |
| --- | --- | --- | --- |
| Id | int |   | Kurumsal Id No |
| Baslik | varchar | 50 | Başlık |
| Tanim | varchar | max | Kurumsal Açıklama |
| CreatedDate | datetime |   | Oluşturulma Tarihi |

**Vitrin Tablosu**

| **Değişken Adı** | **Veri Tipi** | **Uzunluk** | **Açıklama** |
| --- | --- | --- | --- |
| Id | İnt |   | Vitrin Id No |
| ImageUrl | Varchar | max | Resim Url Adresi |
| CreatedDate | datetime |   | Oluşturulma Tarihi |

**İletişim Tablosu**

| **Değişken Adı** | **Veri Tipi** | **Uzunluk** | **Açıklama** |
| --- | --- | --- | --- |
| Id | İnt |   | İletişim Id No |
| Ozellik | Varchar | 250 | İletişim Adresinin Tanımı |
| Deger | Varchar | 250 | İletişim Adresi |

**Yayın Tablosu**

| **Değişken Adı** | **Veri Tipi** | **Uzunluk** | **Açıklama** |
| --- | --- | --- | --- |
| Id | İnt |   | Yayın Id No |
| YayinAdi | Varchar | 50 | Yayın Adı |
| BaslangicSaati | Varchar | 50 | Yayın Başlangıç Saati |
| BitisSaati | Varchar | 50 | Yayın Bitiş Saati |
| Tanim | Varchar | max | Yayın Açıklaması |
| Gun | Varchar | 50 | Yayın Günü |
| ProgramciId | İnt |   | Programcı Id No |

**Roles Tablosu**

| **Değişken Adı** | **Veri Tipi** | **Uzunluk** | **Açıklama** |
| --- | --- | --- | --- |
| Id | İnt |   | Role Id No |
| Unvani | Varchar | 100 | Ünvan Tanımı |





**Programcı Tablosu**

| **Değişken Adı** | **Veri Tipi** | **Uzunluk** | **Açıklama** |
| --- | --- | --- | --- |
| Id | int |   | Programcı Id No |
| AdSoyad | Varchar | 50 | Programcı Adı Soyadı |
| ImageUrl | Varchar | Max | Resim Url Adresi |
| CreatedDate | Datetime |   | Oluşturulma Tarihi |

**Künye Tablosu**

| **Değişken Adı** | **Veri Tipi** | **Uzunluk** | **Açıklama** |
| --- | --- | --- | --- |
| Id | İnt |   | Kunye Id No |
| Isim | Varchar | 50 | İsim |
| RoleId | int |   | Role Id No |

**Top 30 Tablosu**

| **Değişken Adı** | **Veri Tipi** | **Uzunluk** | **Açıklama** |
| --- | --- | --- | --- |
| Id | İnt |   | Top 30 Id No |
| TopSirasi | İnt |   | Şarkının Sırası |
| SanatciAdi | varchar | 50 | Sanatçının Adı |
| SarkiAdi | varchar | 50 | Şarkının Adı |

**Admin Tablosu**

| **Değişken Adı** | **Veri Tipi** | **Uzunluk** | **Açıklama** |
| --- | --- | --- | --- |
| KullaniciAdi | varchar | 50 | Kullanıcı Adı |
| Email | Varchar | 50 | Mail Adresi |
| Sifre | Varchar | 50 | Sifresi |
| AdSoyad | varchar | 50 | Adı Soyadı |

**Mesaj Tablosu**

| **Değişken Adı** | **Veri Tipi** | **Uzunluk** | **Açıklama** |
| --- | --- | --- | --- |
| Id | int |   | Mesaj Id No |
| Ad | varchar | 50 | Gönderenin Adı |
| MesajIcerigi | varchar | MAX | Mesajın İçeriği |

# Admin Use Case 
![usecaseadmin](https://user-images.githubusercontent.com/24482512/51919276-23bb9880-23f4-11e9-9ff0-6aff6f60a527.png)

# Kullanıcı(User) Use Case
![usecasekullanici](https://user-images.githubusercontent.com/24482512/51919343-464db180-23f4-11e9-9d70-716408ebe530.png)


# Radyo Fırat 89.2

![ekran alintisi1](https://user-images.githubusercontent.com/24482512/51410011-71264300-1b74-11e9-9418-df436174433d.PNG)
![ekran alintisi2](https://user-images.githubusercontent.com/24482512/51410012-71264300-1b74-11e9-8660-ad1650ea2392.PNG)
![ekran alintisi3](https://user-images.githubusercontent.com/24482512/51410013-71bed980-1b74-11e9-8222-203c80ad6b8b.PNG)

