 Öğrenci Not Kayıt ve Değerlendirme Sistemi (C# Console Application)

C# ile geliştirilmiş; dinamik veri girişi, ağırlıklı not hesaplaması, harf notu baremi ve istatistiksel sınıf analizi sunan konsol tabanlı otomasyon projesi.

 Proje Hakkında

Bu proje, bir sınıftaki öğrencilerin vize ve final notlarını işleyerek başarı durumlarını hesaplayan ve formatlı bir tablo halinde raporlayan bir C# Konsol Uygulamasıdır.

Hata yönetimi (try-catch), dinamik dizi yönetimi ve modüler metot yapısı kullanılarak geliştirilmiş olup grup/ödev projeleri ve portföy sunumları için temiz bir kod mimarisi sunar.

 Temel Özellikler

Dinamik Veri Girişi: Başlangıçta girilen öğrenci sayısına göre dinamik dizi boyutlandırması.

Güvenli Girdi Denetimi (Validation):

Öğrenci sayısında negatif ve sayı dışı girişlerin engellenmesi (try-catch kontrolü).

Vize ve final notlarının $0 - 100$ aralığı dışında girilmesini önleyen doğrulama döngüsü (do-while).

Ağırlıklı Ortalama Hesabı:


$$\text{Ortalama} = (\text{Vize} \times 0.40) + (\text{Final} \times 0.60)$$

Harf Notu Baremi: Hesaplanan ortalamalara göre otomatik harf notu ataması ($AA - FF$).

Sınıf İstatistikleri: Sınıf genel ortalaması, en yüksek ve en düşük not analizleri.

Formatlı Konsol Tablosu: Sütun hizalama ve metin sınırlandırma (substring) ile düzenli raporlama ekranı.



   Kullanılan Teknolojiler & Konseptler

Dil / Platform: C# (.NET Core / .NET Framework)

Temel Konseptler:

Metot Tasarımı (NotAl, HarfNotu)
 
Paralel Dizi (Parallel Arrays) Yönetimi

İstisna Yönetimi (try-catch-finally)

String Formatting & Konsol Hizalaması (Console.WriteLine("{0,-14}...", ...))


                                                                                                                                            Koray BAĞDU
