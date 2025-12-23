                                         // GRUP PROJE ÖDEVİ
using System;

class Program
{
    static void Main()
    {
        int ogrenciSayisi;
        while(true)
        {
                    Console.Write("Öğrenci sayısını giriniz: ");

    try
            {
                ogrenciSayisi = int.Parse(Console.ReadLine());
                
    if (ogrenciSayisi>0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Öğrenci sayısı 0 dan büyük olmalıdır.");
                }
            }
            catch
            {
                Console.WriteLine("Hatalı giriş yaptınız lütfen sayısal bir değer giriniz");
            }    
            }
        
        
        
        string[] numaralar = new string[ogrenciSayisi];
        string[] adSoyadlar = new string[ogrenciSayisi];
        int[] vizeler = new int[ogrenciSayisi];
        int[] finaller = new int[ogrenciSayisi];
        double[] ortalamalar = new double[ogrenciSayisi];
        string[] harfNotlari = new string[ogrenciSayisi];

        double toplamOrtalama = 0;
        double enYuksek = 0;
        double enDusuk = 100;

        for (int i = 0; i < ogrenciSayisi; i++)
        {
            Console.WriteLine($"\n{i + 1}. öğrencinin bilgileri");

            Console.Write("Numara: ");
            numaralar[i] = Console.ReadLine();

            Console.Write("Ad Soyad: ");
            adSoyadlar[i] = Console.ReadLine();

            vizeler[i] = NotAl("Vize");
            finaller[i] = NotAl("Final");

            ortalamalar[i] = vizeler[i] * 0.4 + finaller[i] * 0.6;
            harfNotlari[i] = HarfNotu(ortalamalar[i]);

            toplamOrtalama += ortalamalar[i];

            if (ortalamalar[i] > enYuksek)
                enYuksek = ortalamalar[i];

            if (ortalamalar[i] < enDusuk)
                enDusuk = ortalamalar[i];
        }

        // TABLO
        Console.WriteLine("\n==================== ÖĞRENCİ TABLOSU ====================");
        Console.WriteLine(
            "{0,-3} {1,-14} {2,-20} {3,6} {4,6} {5,7} {6,6}",
            "No", "Numara", "Ad Soyad", "Vize", "Final", "Ort", "Harf"
        );
        Console.WriteLine("---------------------------------------------------------");

        for (int i = 0; i < ogrenciSayisi; i++)
        {
            string isim = adSoyadlar[i].Length > 20
                ? adSoyadlar[i].Substring(0, 20)
                : adSoyadlar[i];

            Console.WriteLine(
                "{0,-3} {1,-14} {2,-20} {3,6} {4,6} {5,7:F2} {6,6}", 
                i + 1,
                numaralar[i],
                isim,
                vizeler[i],
                finaller[i],
                ortalamalar[i],
                harfNotlari[i]
            );
        }

        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine($"Sınıf Ortalaması : {toplamOrtalama / ogrenciSayisi:F2}");
        Console.WriteLine($"En Yüksek Not    : {enYuksek:F2}");
        Console.WriteLine($"En Düşük Not     : {enDusuk:F2}");

        Console.ReadLine();
    }

    static int NotAl(string tur)
    {
        int not;
        do
        {
            Console.Write($"{tur} notu (0-100): ");
            not = int.Parse(Console.ReadLine());

            if (not < 0 || not > 100)
                Console.WriteLine("Hatalı giriş! 0-100 arası giriniz.");

        } while (not < 0 || not > 100);

        return not;
    }

    static string HarfNotu(double ort)
    {
        if (ort >= 85) return "AA";
        else if (ort >= 70) return "BA";
        else if (ort >= 60) return "BB";
        else if (ort >= 50) return "CB";
        else if (ort >= 40) return "CC";
        else if (ort >= 30) return "DC";
        else if (ort >= 20) return "DD";
        else if (ort >= 10) return "FD";
        else return "FF";
    }
}







































