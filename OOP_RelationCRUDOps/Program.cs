#region Kişi ve adres sınıfları oluşturun CRUD işlemleri yapın. 1 kişinin 1 adersi olur. 1 adresin 1 kişisi olur.
//Adres adres1 = new Adres()
//{
//    Country = "Ankara",
//    Id = 1
//};
//Kisi kisi1 = new Kisi()
//{
//    Id = 1,
//    Name = "Berkay",
//    Adres = adres1,
//    AdresId = 1
//};
//KisiAdresCRUD.AddKisi(kisi1, adres1);
//Console.WriteLine(kisi1.Adres.Country);

//static class KisiAdresCRUD
//{
//    private static List<Kisi> kisiler = new List<Kisi>();
//    public static void AddKisi(Kisi kisi, Adres adres)
//    {
//        kisiler.Add(kisi);
//    }
//}
//class Kisi
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public int AdresId { get; set; }
//    public Adres Adres { get; set; }
//}
//class Adres
//{
//    public int Id { get; set; }
//    public string Country { get; set; }
//    public int KisiId { get; set; }
//    public Kisi Kisi { get; set; }
//}
#endregion
#region Öğrenci ve KimlikKartı sınıfları oluşturun. 1 öğrencinin 1 kimlik kartı, 1 kimlik kartının 1 öğrencisi olur CRUD işlemlerini hazırlayın
//KimlikKarti kimlikKarti1 = new()
//{
//    KartId = 2,
//    KartNumarasi = "ANK123"
//};
//Ogrenci ogrenci1 = new()
//{
//    OgrenciId = 1,
//    OgrenciAdi = "Gökçe",
//    KartId = 2,
//    KimlikKarti = kimlikKarti1
//};
//Ogrenci ogrenci2 = new()
//{
//    OgrenciId = 2,
//    OgrenciAdi = "Melis",
//    KartId = 2,
//    KimlikKarti = kimlikKarti1
//};

//Ogrenci ogrenci3 = new()
//{
//    OgrenciId = 3,
//    OgrenciAdi = "Barış",
//    KartId = 2,
//    KimlikKarti = kimlikKarti1
//};
//OgrenciKimlikCRUD.OgrenciEkle(ogrenci1, kimlikKarti1);
//OgrenciKimlikCRUD.OgrenciEkle(ogrenci2, kimlikKarti1);
//Console.WriteLine($"{ogrenci1.OgrenciAdi} adlı öğrencinin kimlik nosu {ogrenci1.KimlikKarti.KartNumarasi}");

//Console.WriteLine($"{ogrenci2.OgrenciAdi} adlı öğrencinin kimlik nosu {ogrenci1.KimlikKarti.KartNumarasi}");

//Console.WriteLine("---------------");

//OgrenciKimlikCRUD.OgrenciGetir();

//Console.WriteLine("---------------");

//OgrenciKimlikCRUD.OgrenciGuncelle(1, ogrenci3);
//OgrenciKimlikCRUD.OgrenciGetir();

//static class OgrenciKimlikCRUD
//{
//    private static List<Ogrenci> ogrenciler = new List<Ogrenci>();
//    public static void OgrenciEkle(Ogrenci ogrenci, KimlikKarti kimlikKarti)
//    {
//        ogrenciler.Add(ogrenci);
//    }
//    public static void OgrenciGetir()
//    {
//        foreach (var ogrenci in ogrenciler)
//        {
//            Console.WriteLine(ogrenci.OgrenciAdi);
//        }
//    }
//    public static Ogrenci OgrenciGuncelle(int id, Ogrenci ogrenci)
//    {
//        for (int i = 0; i < ogrenciler.Count; i++)
//        {
//            if (ogrenciler[i].OgrenciId == id)
//            {
//                ogrenciler[i].OgrenciAdi = ogrenci.OgrenciAdi;
//            }
//        }
//        return null;
//    }
//}
//class Ogrenci
//{
//    public int OgrenciId { get; set; }
//    public string OgrenciAdi { get; set; }
//    public KimlikKarti KimlikKarti { get; set; }
//    public int KartId { get; set; }
//}
//class KimlikKarti
//{
//    public int KartId { get; set; }
//    public string KartNumarasi { get; set; }
//    public Ogrenci Ogrenci { get; set; }
//    public int OgrenciId { get; set; }
//}
#endregion
#region Kitap ve ISBN sınıflarını oluşturun. 1 e 1 ilişki olacak CRUD işlemleri yapın.
//ISBN iSBN1 = new()
//{
//    ISBNId = 1,
//    ISBNNo = "234-123-3145-67-1"
//};

//ISBN iSBN2 = new()
//{
//    ISBNId = 1,
//    ISBNNo = "123-234-3145-67-1"
//};

//Kitap kitap1 = new()
//{
//    KitapId = 1,
//    KitapAdi = "Solo Leveling",
//    ISBNId = 1,
//    ISBN = iSBN1
//};

//Kitap kitap2 = new()
//{
//    KitapId = 2,
//    KitapAdi = "Pandoranın Kutusu",
//    ISBNId = 2,
//    ISBN = iSBN2
//};

//Kitap kitap3 = new()
//{
//    KitapId = 3,
//    KitapAdi = "Suç ve Ceza",
//    ISBNId = 2,
//    ISBN = iSBN2
//};

//ISBNKitapCRUD.KitapEkle(kitap1, iSBN1);
//ISBNKitapCRUD.KitapEkle(kitap2, iSBN2);

//Console.WriteLine($"{kitap1.KitapAdi} adlı kitanın ISBN nosu: {iSBN1.ISBNNo}");
//Console.WriteLine($"{kitap2.KitapAdi} adlı kitanın ISBN nosu: {iSBN2.ISBNNo}");

//Console.WriteLine("---------------");

//ISBNKitapCRUD.KitapGetir();

//Console.WriteLine("---------------");

//ISBNKitapCRUD.KitapGuncelle(2, kitap3);
//ISBNKitapCRUD.KitapGetir();

//Console.WriteLine("---------------");

//ISBNKitapCRUD.KitapSil(2);
//ISBNKitapCRUD.KitapGetir();
//static class ISBNKitapCRUD
//{
//    private static List<Kitap> kitaplar = new List<Kitap>();
//    public static void KitapEkle(Kitap kitap, ISBN iSBN)
//    {
//        kitaplar.Add(kitap);
//    }
//    public static void KitapGetir()
//    {
//        foreach (var kitap in kitaplar)
//        {
//            Console.WriteLine(kitap.KitapAdi);
//        }
//    }
//    public static Kitap KitapGuncelle(int id, Kitap kitap)
//    {
//        for (int i = 0; i < kitaplar.Count; i++)
//        {
//            if (kitaplar[i].KitapId == id)
//            {
//                kitaplar[i].KitapAdi = kitap.KitapAdi;
//            }
//        }
//        return null;
//    }
//    public static void KitapSil(int id)
//    {
//        for(int i = 0;i < kitaplar.Count; i++)
//        {
//            if (kitaplar[i].KitapId == id)
//            {
//                kitaplar.Remove(kitaplar[i]);
//            }
//        }
//    }
//}    
//class Kitap
//{
//    public int KitapId { get; set; }
//    public string KitapAdi { get; set; }
//    public ISBN ISBN { get; set; }
//    public int ISBNId { get; set; }
//}

//class ISBN
//{
//    public int ISBNId { get; set; }
//    public string ISBNNo { get; set; }
//    public Kitap Kitap { get; set; }
//    public int KitapId { get; set; }
//}
#endregion

#region Araç ve motor sınıfları oluşturun. 1 e 1 ilişki olacak. Bu sefer aracın motorunun adını çağırdığımda null gelmesini istemiyorum. Aynı zamanda motorun aracının adını çağırdığımda null gelmesini istemiyorum

//Motor motor1 = new()
//{
//    MotorId = 1,
//    MotorGucu = 10000
//};
//Motor motor2 = new()
//{
//    MotorId = 2,
//    MotorGucu = 9000
//};
//Arac arac1 = new()
//{
//    AracId = 1,
//    Markası = "Opel",
//    Modeli = "Corsa",
//    MotorId = 1,
//    Motor = motor1
//};
//Arac arac2 = new()
//{
//    AracId = 2,
//    Markası = "Hyundai",
//    Modeli = "i20",
//    MotorId = 1,
//    Motor = motor1
//};

//Arac arac3 = new()
//{
//    AracId = 3,
//    Markası = "Hyundai",
//    Modeli = "Getz",
//    MotorId = 2,
//    Motor = motor2
//};

//AracMotorCRUD.AracEkle(arac1, motor1);
//AracMotorCRUD.AracEkle(arac2, motor1);
//AracMotorCRUD.AracEkle(arac3, motor1);
//AracMotorCRUD.MotorEkle(motor1);
//Console.WriteLine($"{arac1.Markası} marka {arac1.Modeli} arabanın motor gücü {arac1.Motor.MotorGucu}");
//Console.WriteLine($"{arac2.Markası} marka {arac2.Modeli} arabanın motor gücü {arac2.Motor.MotorGucu}");

//Console.WriteLine("---------------");

//AracMotorCRUD.AracGuncelle(2, arac3);
//Console.WriteLine($"{arac2.Markası} markası olan aracın modeli {arac2.Modeli}");

//Console.WriteLine("---------------");

//AracMotorCRUD.AracSil(1);
//AracMotorCRUD.AracGetir();

//Console.WriteLine("---------------");

//Console.WriteLine(arac2.Motor.MotorGucu);
//static class AracMotorCRUD
//{
//    private static List<Arac> araclar = new List<Arac>();
//    private static List<Motor> motorlar = new List<Motor>();
//    public static void AracEkle(Arac arac, Motor motor)
//    {
//        araclar.Add(arac);
//    }
//    public static void MotorEkle(Motor motor)
//    {
//        motorlar.Add(motor);
//    }

//    public static Arac AracGetir()
//    {
//        foreach (var arac in araclar)
//        {
//            Console.WriteLine($"{arac.Markası} aracın modeli {arac.Modeli} ve motor gücü {arac.Motor.MotorGucu}");
//        }
//        return null;
//    }
//    public static Arac AracGuncelle(int id, Arac arac)
//    {
//        for (int i = 0; i < araclar.Count; i++)
//        {
//            if (araclar[i].AracId == id)
//            {
//                araclar[i].Modeli = arac.Modeli;
//            }
//        }
//        return null;
//    }
//    public static void AracSil(int id)
//    {
//        for (int i = 0; i < araclar.Count; i++)
//        {
//            if (araclar[i].AracId == id)
//            {
//                araclar.Remove(araclar[i]);
//            }
//        }
//    }
//}
//class Arac
//{
//    public int AracId { get; set; }
//    public string Markası { get; set; }
//    public string Modeli { get; set; }
//    public Motor Motor { get; set; }
//    public int MotorId { get; set; }
//}
//class Motor
//{
//    public int MotorId { get; set; }
//    public int MotorGucu { get; set; }
//    public Arac Arac { get; set; }
//    public int AracId { get; set; }
//}
#endregion
#region Sorulara devam
#endregion

#region Öğretmen ve ofis class ları 1 e 1 ilişkili hiç bir değerin null gelmesini istemiyorum
//Ofis ofis1 = new() { OfisId = 1, OfisNo = "A101" };
//Ofis ofis2 = new() { OfisId = 2, OfisNo = "A102" };

//Ogretmen ogretmen1 = new() { OgretmenId = 1, OgretmenAdi = "Gökçe", OgretmenSoyadi = "Spor Alagöz", Bransi = "Matematiik",Ofis = ofis1, OfisId = 1};
//Ogretmen ogretmen2 = new() { OgretmenId = 2, OgretmenAdi = "Cihan", OgretmenSoyadi = "Alagöz", Bransi = "Yazılım Geliştirme",Ofis = ofis2, OfisId = 2 };
//Ogretmen ogretmen3 = new() { OgretmenId = 3, OgretmenAdi = "Berkay", OgretmenSoyadi = "Çimendağ", Bransi = "Yazılım Geliştirme", Ofis = ofis1, OfisId = 1 };

//OgretmenOfisCRUD.OgretmenEkle(ogretmen1, ofis1);
//OgretmenOfisCRUD.OgretmenEkle(ogretmen2, ofis2);
//OgretmenOfisCRUD.OgretmenEkle(ogretmen3, ofis1);
//OgretmenOfisCRUD.OfisEkle(ofis1);
//OgretmenOfisCRUD.OfisEkle(ofis2);

//OgretmenOfisCRUD.OgretmenleriGetir();

//Console.WriteLine("---------------------------------");

//Console.WriteLine("---------------------------------");

//Console.WriteLine($"Id si 1 olan öğretmen {OgretmenOfisCRUD.OgretmenGetir(1).OgretmenAdi} {OgretmenOfisCRUD.OgretmenGetir(1).OgretmenSoyadi}. Branşı {OgretmenOfisCRUD.OgretmenGetir(1).Bransi}. Bulunduğu ofis {OgretmenOfisCRUD.OgretmenGetir(1).Ofis.OfisNo}dir");

//OgretmenOfisCRUD.OgretmenGuncelle(1, ogretmen3);
//Console.WriteLine($"Id si 1 olan öğretmen {ogretmen1.OgretmenAdi} {ogretmen1.OgretmenSoyadi} adlı, {ogretmen1.Bransi} branşı, {ogretmen1.Ofis.OfisNo} olarak güncellendi");


//Console.WriteLine("---------------------------------");

//OgretmenOfisCRUD.OgretmenleriGetir();

//Console.WriteLine("---------------------------------");
//OgretmenOfisCRUD.OgretmenSil(2);
//OgretmenOfisCRUD.OgretmenleriGetir();
//class OgretmenOfisCRUD
//{
//    private static List<Ofis> ofisler = new List<Ofis>();
//    private static List<Ogretmen> ogretmenler = new List<Ogretmen>();

//    public static void OgretmenEkle(Ogretmen ogretmen, Ofis ofis)
//    {
//        ogretmenler.Add(ogretmen);
//    }
//    public static void OfisEkle(Ofis ofis)
//    {
//        ofisler.Add(ofis);
//    }
//    public static Ogretmen OgretmenleriGetir()
//    {
//        foreach (var ogretmen in ogretmenler)
//        {
//            Console.WriteLine($"{ogretmen.OgretmenAdi} {ogretmen.OgretmenSoyadi} adlı öğretmenin bransi {ogretmen.Bransi}dır. Bu öğretmenin odası {ogretmen.Ofis.OfisNo} ofisindedir.\n");
//        }
//        return null;
//    }
//    public static Ogretmen OgretmenGetir(int id)
//    {
//        foreach (var ogretmen in ogretmenler)
//        {
//            if (ogretmen.OgretmenId == id)
//            {
//                return ogretmen;
//            }
//        }
//        return null;
//    }
//    public static Ogretmen OgretmenGuncelle(int id, Ogretmen ogretmen)
//    {
//        for (int i = 0; i < ogretmenler.Count; i++)
//        {
//            if (ogretmenler[i].OgretmenId == id)
//            {
//                ogretmenler[i].OgretmenAdi = ogretmen.OgretmenAdi;
//                ogretmenler[i].OgretmenSoyadi = ogretmen.OgretmenSoyadi;
//                ogretmenler[i].Bransi = ogretmen.Bransi;
//                ogretmenler[i].Ofis.OfisNo = ogretmen.Ofis.OfisNo;
//            }
//        }
//        return null;
//    }
//    public static void OgretmenSil(int id)
//    {
//        for (int i = 0; i < ogretmenler.Count; i++)
//        {
//            if (ogretmenler[i].OgretmenId == id)
//            {
//                ogretmenler.Remove(ogretmenler[i]);
//            }
//        }
//    }
//}
//class Ofis
//{
//    public int OfisId { get; set; }
//    public string OfisNo { get; set; }
//    public Ogretmen Ogretmen { get; set; }
//    public int OgretmenId { get; set; }
//}
//class Ogretmen
//{
//    public int OgretmenId { get; set; }
//    public string OgretmenAdi { get; set; }
//    public string OgretmenSoyadi { get; set; }
//    public string Bransi { get; set; }
//    public Ofis Ofis { get; set; }
//    public int OfisId { get; set; }
//}
#endregion

#region Film ve Yönetmen class ları arasında 1 e 1 ilişki vardır. Hiç bir değer null gelmeyecek
//Film film1 = new() { FilmeId = 1, FilmAdi = "Ateş Böceği Mezarlığı" };
//Film film2 = new() { FilmeId = 2, FilmAdi = "Ruhların Kaçışı"};

//Yonetmen yonetmen1 = new() { YonetmenId = 1, YonetmenAdi = "Hayao", YonetmenSoyadi = "Miyazaki", Film = film2 };
//Yonetmen yonetmen2 = new() { YonetmenId = 2, YonetmenAdi = "Isao", YonetmenSoyadi = "Takahata", Film = film1 };

//FilmYonetmenCRUD.YonetmenEkle(yonetmen1);
//FilmYonetmenCRUD.YonetmenEkle(yonetmen2);

//FilmYonetmenCRUD.FilmEkle(film1);
//FilmYonetmenCRUD.FilmEkle(film2);

//FilmYonetmenCRUD.YonetmenleriGetir();

//Console.WriteLine("----------------------------------------------");

//Console.WriteLine($"Id si 1 olan yönetmen {FilmYonetmenCRUD.YonetmenGetir(1).YonetmenAdi} {FilmYonetmenCRUD.YonetmenGetir(1).YonetmenSoyadi}, {FilmYonetmenCRUD.YonetmenGetir(1).Film.FilmAdi} filmini yönetmiştir.");

//Console.WriteLine("----------------------------------------------");

//FilmYonetmenCRUD.YonetmenleriGetir();

//Console.WriteLine("----------------------------------------------");

//FilmYonetmenCRUD.YonetmenGuncelle(1, yonetmen2);
//FilmYonetmenCRUD.YonetmenleriGetir();

//Console.WriteLine("----------------------------------------------");

//FilmYonetmenCRUD.YonetmenSil(1);
//FilmYonetmenCRUD.YonetmenleriGetir();
//class FilmYonetmenCRUD
//{
//    private static List<Film> filmler = new List<Film>();
//    private static List<Yonetmen> yonetmenler = new List<Yonetmen>();

//    public static void YonetmenEkle(Yonetmen yonetmen)
//    {
//        yonetmenler.Add(yonetmen);
//    }
//    public static void FilmEkle(Film film)
//    {
//        filmler.Add(film);
//    }
//    public static void YonetmenleriGetir()
//    {
//        foreach (var yonetmen in yonetmenler)
//        {
//            Console.WriteLine($"{yonetmen.YonetmenAdi} {yonetmen.YonetmenSoyadi}, {yonetmen.Film.FilmAdi} filmini yönetmiştir.\n");
//        }
//    }

//    public static Yonetmen YonetmenGetir(int id)
//    {
//        foreach (var yonetmen in yonetmenler)
//        {
//            if (yonetmen.YonetmenId == id)
//            {
//                return yonetmen;
//            }
//        }
//        return null;
//    }
//    public static void YonetmenGuncelle(int id, Yonetmen yonetmen)
//    {
//        for (int i = 0; i < yonetmenler.Count; i++)
//        {
//            if (yonetmenler[i].YonetmenId == id)
//            {
//                yonetmenler[i].YonetmenAdi = yonetmen.YonetmenAdi;
//                yonetmenler[i].YonetmenSoyadi = yonetmen.YonetmenSoyadi;
//            }
//        }
//    }
//    public static void YonetmenSil(int id)
//    {
//        for (int i = 0; i < yonetmenler.Count; i++)
//        {
//            if (yonetmenler[i].YonetmenId == id)
//            {
//                yonetmenler.Remove(yonetmenler[i]);
//            }
//        }
//    }
//}
//class Film
//{
//    public int FilmeId { get; set; }
//    public string FilmAdi { get; set; }
//    public Yonetmen Yonetmen { get; set; }
//    public int YonetmenId { get; set; }
//}
//class Yonetmen
//{
//    public int YonetmenId { get; set; }
//    public string YonetmenAdi { get; set; }
//    public string YonetmenSoyadi { get; set; }
//    public Film Film { get; set; }
//    public int FilmId { get; set; }
//}
#endregion

#region Şirket ve MerkezOfis Classları oluşturun 1 e 1 ilişki olacak nuul değer istemiyorum
//using System.Net.Sockets;
//using System.Reflection.Metadata;

//MerkezOfis merkezOfis1 = new() { MerkezOfisId = 1, Adres = "Maslak/İstanbul" };
//MerkezOfis merkezOfis2 = new() { MerkezOfisId = 2, Adres = "Fenerbahçe/İstanbul" };

//Sirket sirket1 = new() { SirketId = 1, SirketAdi = "Sabancı Holding", MerkezOfis = merkezOfis1 };
//Sirket sirket2 = new() { SirketId = 2, SirketAdi = "Koç Holding", MerkezOfis = merkezOfis2 };


//SirketMerkezOfisCRUD.SirketEkle(sirket1);
//SirketMerkezOfisCRUD.SirketEkle(sirket2);

//SirketMerkezOfisCRUD.MerkezOfisEkle(merkezOfis1);
//SirketMerkezOfisCRUD.MerkezOfisEkle(merkezOfis2);

//SirketMerkezOfisCRUD.SirketleriGetir();

//Console.WriteLine("------------------------------------");

//Console.WriteLine($"{SirketMerkezOfisCRUD.SirketGetir(2).SirketAdi} adlı şirketinin merkez ofisi {SirketMerkezOfisCRUD.SirketGetir(2).MerkezOfis.Adres} adresinde yer almaktadır.");

//Console.WriteLine("------------------------------------");

//SirketMerkezOfisCRUD.SirketleriGetir();

//Console.WriteLine("------------------------------------");

//SirketMerkezOfisCRUD.SirketGuncelle(1, sirket2);
//Console.WriteLine($"Id si 1 olan şirket {sirket1.SirketAdi} olarak güncellenmiştir.");

//Console.WriteLine("------------------------------------");

//SirketMerkezOfisCRUD.SirketleriGetir();
//SirketMerkezOfisCRUD.SirketSil(1);

//Console.WriteLine("------------------------------------");

//SirketMerkezOfisCRUD.SirketleriGetir();

//Console.WriteLine("------------------------------------");

//Console.WriteLine($"{IGetir.GetMerkezOfis(2).Adres}");

//class SirketMerkezOfisCRUD
//{
//    private static List<Sirket> sirketler = new List<Sirket>();
//    public static List<MerkezOfis> merkezOfisler = new List<MerkezOfis>();

//    public static void SirketEkle(Sirket sirket)
//    {
//        sirketler.Add(sirket);
//    }
//    public static void MerkezOfisEkle(MerkezOfis merkezOfis)
//    {
//        merkezOfisler.Add(merkezOfis);
//    }

//    public static void SirketleriGetir()
//    {
//        foreach (var sirket in sirketler)
//        {
//            Console.WriteLine($"{sirket.SirketAdi} adlı şirketin merkez ofisinin adresi {sirket.MerkezOfis.Adres}'dir.");
//        }
//    }
//    public static Sirket SirketGetir(int id)
//    {
//        foreach (var sirket in sirketler)
//        {
//            if (sirket.SirketId == id)
//            {
//                return sirket;
//            }
//        }
//        return null;
//    }
//    public static Sirket SirketGuncelle(int id, Sirket sirket)
//    {
//        for (int i = 0; i < sirketler.Count; i++)
//        {
//            if (sirketler[i].SirketId == id)
//            {
//                sirketler[i].SirketAdi = sirket.SirketAdi;
//            }
//        }
//        return null;
//    }
//    public static void SirketSil(int id)
//    {
//        for (int i = 0; i < sirketler.Count; i++)
//        {
//            if (sirketler[i].SirketId == id)
//            {
//                sirketler.Remove(sirketler[i]);
//            }
//        }
//    }
//}
//interface IGetir // interface in içine static bir metot tanımlarsak bu metodun içini doldurmalıyız bu .Net 8 ile gelen bir özellik
//{
//    static MerkezOfis GetMerkezOfis(int id)
//    {
//        foreach (var item in SirketMerkezOfisCRUD.merkezOfisler)
//        {
//            if (item.MerkezOfisId == id)
//            {
//                return item;
//            }
//        }
//        return null;
//    }
//}

//class Sirket
//{
//    public int SirketId { get; set; }
//    public string SirketAdi { get; set; }
//    public MerkezOfis MerkezOfis { get; set; }
//    public int MerkezOfisId { get; set; }
//}
//class MerkezOfis
//{
//    public int MerkezOfisId { get; set; }
//    public string Adres { get; set; }
//    public Sirket Sirket { get; set; }
//    public int SirketId { get; set; }
//}
#endregion

#region Doktor ve Lisans Classları istiyorum 1 e 1 ilişkili null gelmesini istemiyorum
//Lisans lisans1 = new() { LisansId = 1, Lisansi = "Pediatri" };
//Lisans lisans2 = new() { LisansId = 2, Lisansi = "Beyin Cerrahi" };

//Doktor doktor1 = new() { DoktorId = 1, DoktorAdi = "Recep Ali", DoktorSoyadi = "Brohi", Lisans = lisans2};
//Doktor doktor2 = new() { DoktorId = 2, DoktorAdi = "Zeliha", DoktorSoyadi = "Brohi", Lisans = lisans1 };
//Doktor doktor3 = new() { DoktorId = 3, DoktorAdi = "Fatma", DoktorSoyadi = "Kalkan", Lisans = lisans1 };

//DoktorLisansCRUD.DoktorEkle(doktor1);
//DoktorLisansCRUD.DoktorEkle(doktor2);
//DoktorLisansCRUD.DoktorEkle(doktor3);

//DoktorLisansCRUD.LisansEkle(lisans1);
//DoktorLisansCRUD.LisansEkle(lisans2);

//DoktorLisansCRUD.DoktorlariGetir();

//Console.WriteLine("---------------------------------------");

//Console.WriteLine($"Id si 1 olan doktor {DoktorLisansCRUD.DoktorGetir(1).DoktorAdi} {DoktorLisansCRUD.DoktorGetir(1).DoktorSoyadi} ve lisansı {DoktorLisansCRUD.DoktorGetir(1).Lisans.Lisansi}");

//Console.WriteLine("---------------------------------------");

//DoktorLisansCRUD.DoktorGuncelle(1, doktor3);
//Console.WriteLine($"Id si 1 olan doktor {DoktorLisansCRUD.DoktorGetir(1).DoktorAdi} {DoktorLisansCRUD.DoktorGetir(1).DoktorSoyadi} ve lisansı {DoktorLisansCRUD.DoktorGetir(1).Lisans.Lisansi} olarak güncellendi.");

//Console.WriteLine("---------------------------------------");

//DoktorLisansCRUD.DoktorSil(1);
//DoktorLisansCRUD.DoktorlariGetir();

//Console.WriteLine("---------------------------------------");


//class DoktorLisansCRUD : IDoktorCRUD
//{
//    private static List<Doktor> doktorlar = new List<Doktor>();
//    private static List<Lisans> lisanslar = new List<Lisans>();

//    public static void DoktorEkle(Doktor doktor)
//    {
//        doktorlar.Add(doktor);
//    }
//    public static void LisansEkle(Lisans lisans)
//    {
//        lisanslar.Add(lisans);
//    }
//    public void GetAllDoctors()
//    {
//        foreach (var doktor in doktorlar)
//        {
//            Console.WriteLine(doktor.DoktorAdi);
//        }
//    }

//    public static void DoktorlariGetir()
//    {
//        foreach (var doktor in doktorlar)
//        {
//            Console.WriteLine($"{doktor.DoktorAdi} {doktor.DoktorSoyadi} doktorunun lisansı {doktor.Lisans.Lisansi}dır.");
//        }
//    }
//    public static Doktor DoktorGetir(int id)
//    {
//        foreach (var doktor in doktorlar)
//        {
//            if (doktor.DoktorId == id)
//            {
//                return doktor;
//            }
//        }
//        return null;
//    }
//    public static Doktor DoktorGuncelle(int id, Doktor doktor)
//    {
//        for (int i = 0; i < doktorlar.Count; i++)
//        {
//            if (doktorlar[i].DoktorId == id)
//            {
//                doktorlar[i].DoktorAdi = doktor.DoktorAdi;
//                doktorlar[i].DoktorSoyadi = doktor.DoktorSoyadi;
//                doktorlar[i].Lisans.Lisansi = doktor.Lisans.Lisansi;
//            }
//        }
//        return null;
//    }
//    public static void DoktorSil(int id)
//    {
//        for (int i = 0; i < doktorlar.Count; i++)
//        {
//            if (doktorlar[i].DoktorId == id)
//            {
//                doktorlar.Remove(doktorlar[i]);
//            }
//        }
//    }

//    public void DeleteDoctor()
//    {

//    }
//}

//interface IDoktorCRUD
//{
//    void GetAllDoctors();
//    void DeleteDoctor();
//}

//class Doktor
//{
//    public int DoktorId { get; set; }
//    public string DoktorAdi { get; set; }
//    public string DoktorSoyadi { get; set; }
//    public Lisans Lisans { get; set; }
//    public int LisansId { get; set; }
//}
//class Lisans
//{
//    public int LisansId { get; set; }
//    public string Lisansi { get; set; }
//    public Doktor Doktor { get; set; }
//    public int DoktorId { get; set; }
//}
#endregion


//Doktor doktor1 = new Doktor()

//{

//    Id=1,

//    Name="Berkay"

//};

//Doktor doktor2 = new Doktor()

//{

//    Id = 2,

//    Name = "Demet"

//};

//DoktorCrud doktorCrud = new DoktorCrud();

//doktorCrud.AddDoctor(doktor1);

//doktorCrud.AddDoctor(doktor2);

//doktorCrud.GetAllDoctors();

//Console.WriteLine("-------------------------------------------------");

//doktorCrud.DeleteDoctor(1);

//doktorCrud.GetAllDoctors();

//class DoktorCrud : IDoktorCrud

//{

//    private List<Doktor> doktorlar = new List<Doktor>();

//    public void AddDoctor(Doktor doktor)

//    {

//        doktorlar.Add(doktor);

//    }

//    public void DeleteDoctor(int id)

//    {

//        foreach (var item in doktorlar)

//        {

//            if (item.Id == id)

//            {

//                doktorlar.Remove(item);

//            }

//        }

//    }

//    public void GetAllDoctors()

//    {

//        foreach (var item in doktorlar)

//        {

//            Console.WriteLine(item.Name);

//        }

//    }

//}

//interface IDoktorCrud

//{

//    void GetAllDoctors();

//    void AddDoctor(Doktor doktor);

//    void DeleteDoctor(int id);  

//}


//class Doktor

//{

//    public int Id { get; set; }

//    public string Name { get; set; }

//    public Lisans? Lisans { get; set; }

//    public int LisansId { get; set; }

//}

//class Lisans

//{

//    public int Id { get; set; }

//    public string Number { get; set; }

//    public Doktor Doktor { get; set; }

//    public int DoktorId { get; set; }

//}

#region Kullanıcı ve profil 1 e 1 ilişkili interface ile beraber CRUD işlemlerini yapın
//Profil profil1 = new() { ProfilId = 1, ProfilAdresi = "www.facebook.com" };
//Profil profil2 = new() { ProfilId = 2, ProfilAdresi = "www.instagram.com" };

//Kullanici kullanici1 = new() { KullaniciId = 1, KullaniciAdi = "gokcespor", ProfilId = 1, Profil = profil1 };
//Kullanici kullanici2 = new() { KullaniciId = 2, KullaniciAdi = "melissubaysal", ProfilId = 2, Profil = profil2 };
//Kullanici kullanici3 = new() { KullaniciId = 3, KullaniciAdi = "cihanalagoz", ProfilId = 2, Profil = profil2 };

//KullaniciCRUD kullaniciCRUD = new KullaniciCRUD();
//ProfilCRUD profilCRUD = new ProfilCRUD();

//kullaniciCRUD.KullaniciEkle(kullanici1);
//kullaniciCRUD.KullaniciEkle(kullanici2);


//profilCRUD.ProfilEkle(profil1);
//profilCRUD.ProfilEkle(profil2);


//kullaniciCRUD.KullanicilariGetir();


//Console.WriteLine($"Id si 1 olan kullanıcı {kullaniciCRUD.KullaniciGetir(1).KullaniciAdi}");

//kullaniciCRUD.KullaniciGuncelle(1, kullanici3);
//kullaniciCRUD.KullaniciGetir(1);

//kullaniciCRUD.KullaniciSil(1);
//kullaniciCRUD.KullanicilariGetir();

//class ProfilCRUD : IProfil
//{
//    private static List<Profil> profiller = new List<Profil>();
//    public void ProfilEkle(Profil profil)
//    {
//        profiller.Add(profil);
//    }
//}
//class KullaniciCRUD : IKullanici
//{
//    private static List<Kullanici> kullanicilar = new List<Kullanici>();

//    public void KullaniciEkle(Kullanici kullanici)
//    {
//        kullanicilar.Add(kullanici);
//    }

//    public void KullanicilariGetir()
//    {
//        for (int i = 0; i < kullanicilar.Count; i++)
//        {
//            Console.WriteLine($"{kullanicilar[i].KullaniciAdi} kullanıcı adına sahip kişinin profiline giriş için: {kullanicilar[i].Profil.ProfilAdresi}");
//        }
//        Console.WriteLine("-------------------------------------------");
//    }
//    public Kullanici KullaniciGetir(int id)
//    {
//        foreach (var kullanici in kullanicilar)
//        {
//            if (kullanici.KullaniciId == id)
//            {
//                return kullanici;
//            }
//        }
//        return null;
//        Console.WriteLine("-------------------------------------------");
//    }
//    public Kullanici KullaniciGuncelle(int id, Kullanici kullanici)
//    {
//        for (int i = 0; i < kullanicilar.Count; i++)
//        {
//            if (kullanicilar[i].KullaniciId == id)
//            {
//                kullanicilar[i].KullaniciAdi = kullanici.KullaniciAdi;
//            }
//        }
//        return null;
//        Console.WriteLine("-------------------------------------------");
//    }
//    public void KullaniciSil(int id)
//    {
//        for (int i = 0; i < kullanicilar.Count; i++)
//        {
//            if (kullanicilar[i].KullaniciId == id)
//            {
//                kullanicilar.Remove(kullanicilar[i]);
//            }
//        }
//        Console.WriteLine("-------------------------------------------");
//    }
//}

//interface IKullanici
//{
//    void KullaniciEkle(Kullanici kullanici);
//    void KullanicilariGetir();
//    Kullanici KullaniciGetir(int id);
//    Kullanici KullaniciGuncelle(int id, Kullanici kullanici);
//    void KullaniciSil(int id);
//}
//interface IProfil
//{
//    void ProfilEkle(Profil profil);
//}
//class Kullanici
//{
//    public int KullaniciId { get; set; }
//    public string KullaniciAdi { get; set; }
//    public Profil Profil { get; set; }
//    public int ProfilId { get; set; }
//}

//class Profil
//{
//    public int ProfilId { get; set; }
//    public string ProfilAdresi { get; set; }
//    public Kullanici Kullanici { get; set; }
//    public int KullaniciId { get; set; }
//}
#endregion

#region Şirket ve Çalışanlar classları oluşturun. bir şirketin birden çok çalışanı olur bir çalışanın 1 tane çalıştığı şirket vardır. Interface ve crud işlemleri yap
//Sirket sirket1 = new() { SirketId = 1, SirketAdi = "Sabancı" };
//Sirket sirket2 = new() { SirketId = 2, SirketAdi = "Koç Holding" };

//Calisan calisan1 = new() { CalisanId = 1, CalisanFullname = "Gökçe Spor Alagöz", Sirket = sirket1 };
//Calisan calisan2 = new() { CalisanId = 2, CalisanFullname = "Cihan Alagöz", Sirket = sirket2 };
//Calisan calisan3 = new() { CalisanId = 3, CalisanFullname = "Melis Su Baysal", Sirket = sirket2 };

//SirketCRUD sirketCRUD = new();
//CalisanCRUD calisanCRUD = new();

//sirketCRUD.SirketEkle(sirket1);
//sirketCRUD.SirketEkle(sirket2);

//calisanCRUD.CalisanEkle(calisan1);
//calisanCRUD.CalisanEkle(calisan2);

//calisanCRUD.CalisanlariGetir();

//Console.WriteLine($"-------------------------------------------\nId si 1 olan çalışan {calisanCRUD.CalisanGetir(1).CalisanFullname} {calisanCRUD.CalisanGetir(1).Sirket.SirketAdi} şirketinde çalışmaktadır.\n-------------------------------------------");

//calisanCRUD.CalisanGuncelle(2, calisan3);
//Console.WriteLine($"Id si 2 olan çalışan {calisanCRUD.CalisanGetir(2).CalisanFullname} olarak güncellenmiştir.\n-------------------------------------------");

//calisanCRUD.CalisanSil(1);
//calisanCRUD.CalisanlariGetir();
//class SirketCRUD : ISirket
//{
//    private static List<Sirket> sirketler = new();
//    public void SirketEkle(Sirket sirket)
//    {
//        sirketler.Add(sirket);
//    }

//}

//class CalisanCRUD : ICalisan
//{
//    private static List<Calisan> calisanlar = new();
//    public void CalisanEkle(Calisan calisan)
//    {
//        calisanlar.Add(calisan);
//    }

//    public Calisan CalisanGetir(int id)
//    {
//        foreach (var calisan in calisanlar)
//        {
//            if (calisan.CalisanId == id)
//            {
//                return calisan;
//            }
//        }
//        return null;
//    }

//    public Calisan CalisanGuncelle(int id, Calisan calisan)
//    {
//        for (int i = 0; i < calisanlar.Count; i++)
//        {
//            if (calisanlar[i].CalisanId == id)
//            {
//                calisanlar[i].CalisanFullname = calisan.CalisanFullname;
//                calisanlar[i].Sirket.SirketAdi = calisan.Sirket.SirketAdi;
//            }
//        }
//        return null;
//    }

//    public void CalisanlariGetir()
//    {
//        for (int i = 0; i < calisanlar.Count; i++)
//        {
//            Console.WriteLine($"{calisanlar[i].CalisanFullname}\n");
//        }
//    }

//    public void CalisanSil(int id)
//    {
//        for (int i = 0; i < calisanlar.Count; i++)
//        {
//            if (calisanlar[i].CalisanId == id)
//            {
//                calisanlar.Remove(calisanlar[i]);
//            }
//        }
//    }
//}

//interface ISirket
//{
//    void SirketEkle(Sirket sirket);

//}
//interface ICalisan
//{
//    void CalisanEkle(Calisan calisan);
//    void CalisanlariGetir();
//    Calisan CalisanGetir(int id);
//    Calisan CalisanGuncelle(int id, Calisan calisan);
//    void CalisanSil(int id);
//}
//class Sirket
//{
//    public int SirketId { get; set; }
//    public string SirketAdi { get; set; }
//    public List<Calisan> Calisanlar { get; set; }
//}

//class Calisan
//{
//    public int CalisanId { get; set; }
//    public string CalisanFullname { get; set; }
//    public Sirket Sirket { get; set; }
//    public int SirketId { get; set; }
//}
#endregion
#region Kitap ve YayınEvi classları oluşturun 1 e çok ilişki olsun kitabın 1 yayınevinin 1 den fazla kitabı olur. interface ile crud işlemleri yaparak yapınız.
//Yayinevi yayinevi1 = new() { YayineviId = 1, YayineviAdi = "Türkiye İş Bankası Kültür Yayınları" };
//Yayinevi yayinevi2 = new() { YayineviId = 2, YayineviAdi = "Destek Yayınları" };

//Kitap kitap1 = new() { KitapId = 1, KitapAdi = "Coğrafya Kaderdir", Yazar = "İbni Haldun", Yayinevi = yayinevi2};
//Kitap kitap2 = new() { KitapId = 2, KitapAdi = "Monte Cristo Kontu", Yazar = "Alexsandre Dumas", Yayinevi = yayinevi1 };
//Kitap kitap3 = new() { KitapId = 3, KitapAdi = "Savaş Sanatı", Yazar = "Sun Zi", Yayinevi = yayinevi1 };

//KitapCRUD kitapCRUD = new();
//YayineviCRUD yayineviCRUD = new();

//kitapCRUD.KitapEkle(kitap1);
//kitapCRUD.KitapEkle(kitap2);

//yayineviCRUD.YayineviEkle(yayinevi1);
//yayineviCRUD.YayineviEkle(yayinevi2);

//kitapCRUD.KitaplariGetir();

//Console.WriteLine($"Id si 1 olan kitap {kitapCRUD.KitapGetir(1).KitapAdi} yazarı {kitapCRUD.KitapGetir(1).Yazar} ve yayın evi {kitapCRUD.KitapGetir(1).Yayinevi.YayineviAdi}dir.\n-----------------------------------------");

//kitapCRUD.KitapGuncelle(2, kitap3);

//Console.WriteLine($"Id si 2 olan kitap {kitapCRUD.KitapGetir(2).KitapAdi} yazarı {kitapCRUD.KitapGetir(2).Yazar} ve yayın evi {kitapCRUD.KitapGetir(2).Yayinevi.YayineviAdi} olarak güncellendi.\n-----------------------------------------");

//kitapCRUD.KitapSil(1);
//kitapCRUD.KitaplariGetir();
//class KitapCRUD : IKitap
//{
//    private static List<Kitap> kitaplar = new List<Kitap>();

//    public void KitapEkle(Kitap kitap)
//    {
//        kitaplar.Add(kitap);
//    }

//    public void KitaplariGetir()
//    {
//        for (int i = 0; i < kitaplar.Count; i++)
//        {
//            Console.WriteLine($"{kitaplar[i].KitapAdi} kitabının yazarı {kitaplar[i].Yazar} ve yayınevi {kitaplar[i].Yayinevi.YayineviAdi}dir.\n-----------------------------------------");
//        }
//    }

//    public Kitap KitapGetir(int id)
//    {
//        foreach (var kitap in kitaplar)
//        {
//            if (kitap.KitapId == id)
//            {
//                return kitap;
//            }
//        }
//        return null;
//    }

//    public Kitap KitapGuncelle(int id, Kitap kitap)
//    {
//        for (int i = 0; i < kitaplar.Count; i++)
//        {
//            if (kitaplar[i].KitapId == id)
//            {
//                kitaplar[i].KitapAdi = kitap.KitapAdi;
//                kitaplar[i].Yazar = kitap.Yazar;
//            }
//        }
//        return null;
//    }

//    public void KitapSil(int id)
//    {
//        for (int i = 0; i < kitaplar.Count; i++)
//        {
//            if (kitaplar[i].KitapId == id)
//            {
//                kitaplar.Remove(kitaplar[i]);
//            }
//        }
//    }
//}
//class YayineviCRUD : IYayinevi
//{
//    private static List<Yayinevi> yayinevleri = new List<Yayinevi>();

//    public void YayineviEkle(Yayinevi yayinevi)
//    {
//        yayinevleri.Add(yayinevi);
//    }
//}

//interface IKitap
//{
//    void KitapEkle(Kitap kitap);
//    void KitaplariGetir();
//    Kitap KitapGetir(int id);
//    Kitap KitapGuncelle(int id, Kitap kitap);
//    void KitapSil(int id);
//}

//interface IYayinevi
//{
//    void YayineviEkle(Yayinevi yayinevi);
//}

//class Kitap
//{
//    public int KitapId { get; set; }
//    public string KitapAdi { get; set; }
//    public string Yazar { get; set; }
//    public Yayinevi Yayinevi { get; set; }
//    public int YayineviId { get; set; }
//}

//class Yayinevi
//{
//    public int YayineviId { get; set; }
//    public string YayineviAdi { get; set; }
//    public List<Kitap> Kitaplar { get; set; }
//}
#endregion
#region Market uygulaması giriş similasyonu, Kullanıcı class ı olacak. ürün class ı ve kategori classları olacak 1 ürünün 1 kategorisi olsun. 1 kategorinin 1 ürünü olsun 1 e 1 ilişki. kullanıcı uygulamayı açtığında kayıt için 1, çıkış için 2 ye basacak eğer 2 ye basarsa uygulamaan çıkacak 1 e basrsa Kullanıcı bilgilerini girip kayıt olacak. Kayıt olurken verdiği doğum tarihine göre kategorileri görüntülerken 18 den küçükse alkollü içecekleri görmeyecek. Önüne açılan kategori menülerinden istediği tuşa basınca kategorideki ürünler açılacak daha sonra ürün numarasına göre yine tuşa basınca siparişiniz alındı afiyet olsun yazacak.
Kategori kategori1 = new() { KategoriId = 1, KategoriAdi = "Alkol ve Sigara" };
Kategori kategori2 = new() { KategoriId = 2, KategoriAdi = "Sağlıklı Atıştırmalıklar" };
Kategori kategori3 = new() { KategoriId = 3, KategoriAdi = "İçecekler" };

Urun urun1 = new() { UrunId = 1, UrunAdi = "Protein Bar", Kategori = kategori2 };
Urun urun2 = new() { UrunId = 2, UrunAdi = "Bailey's", Kategori = kategori1 };
Urun urun3 = new() { UrunId = 3, UrunAdi = "Cappy Karışık", Kategori = kategori3 };
Urun urun4 = new() { UrunId = 4, UrunAdi = "Marlboro", Kategori = kategori1 };


KullaniciCRUD kullaniciCRUD = new();
UrunCRUD urunCRUD = new();
KategoriCRUD kategoriCRUD = new();


kategoriCRUD.KategoriEkle(kategori1);
kategoriCRUD.KategoriEkle(kategori2);
kategoriCRUD.KategoriEkle(kategori3);

urunCRUD.UrunEkle(urun1);
urunCRUD.UrunEkle(urun2);
urunCRUD.UrunEkle(urun3);
urunCRUD.UrunEkle(urun4);

kullaniciCRUD.KullaniciKayit();


class KullaniciCRUD : IKullanici
{
    private static List<Kullanici> kullanicilar = new();
    

    public Kullanici KullaniciGetir(int id)
    {
        foreach (var kullanici in kullanicilar)
        {
            if (kullanici.KullaniciId == id)
            {
                return kullanici;
            }
        }
        return null;
    }

    public Kullanici KullaniciKayit()
    {
        Kullanici kullanici = new Kullanici();
        Kategori kategori = new Kategori();
        KategoriCRUD kategoriCRUD1 = new KategoriCRUD();
        UrunCRUD urunCRUD1 = new UrunCRUD();

        Console.Write("Market uygulamasına hoşgeldiniz. Kayıt olmak için 1 e, çıkış yapmak için 2 ye basılınız: ");
        string secim = Console.ReadLine();

        if (secim == "2")
        {
            Console.WriteLine("Uygulamadan çıkılıyor...");
            Console.ReadKey();
        }
        else if (secim == "1")
        {
            Console.Write("Kullanıcı adınızı giriniz: ");
            kullanici.KullaniciAdi = Console.ReadLine();

            Console.Write("Doğum tarihinizi giriniz: ");
            kullanici.BirthDate = Convert.ToDateTime(Console.ReadLine());

            Console.Write("Kaydınız başarılı bir şekilde sonuçlandı. Hoşgeldiniz!!\n\n");
            DateTime date = DateTime.Now;
            DateTime birthday = kullanici.BirthDate;

            List<string> kullanicilar = new();

            kullanicilar.Add(kullanici.KullaniciAdi);
            Console.Write("Lütfen kullanıcı adı giriniz: ");
            string kullaniciAdi = Console.ReadLine();

            if (kullanicilar.Contains(kullanici.KullaniciAdi))
            {
                Console.Write($"Hoşgeldiniz {kullanici.KullaniciAdi}\n\n");
            }

            int gunFarki = date.Year - birthday.Year;
            if (gunFarki < 18)
            {
                Console.Write($"Sayın {kullanici.KullaniciAdi} alabileceğiniz ürünler:\n\n");
                urunCRUD1.UrunleriGetir(true);
                
                return kullanici;
            }
            else if (gunFarki > 18)
            {
                Console.Write($"Sayın {kullanici.KullaniciAdi} alabileceğiniz ürünler:\n\n");
                urunCRUD1.UrunleriGetir(false);
                return kullanici;
            }
        }
        return null;
    }
}

class UrunCRUD : IUrun
{
    private static List<Urun> urunler = new();
    public void UrunEkle(Urun urun)
    {
        urunler.Add(urun);
    }


    public void UrunleriGetir(bool kategoridekiUrunVarMi)
    {
        for (int i = 0; i < urunler.Count; i++)
        {
            if (kategoridekiUrunVarMi && urunler[i].Kategori.KategoriId == 1)
            {
                continue;
            }
            else
            Console.WriteLine($"{urunler[i].UrunAdi} ürünü {urunler[i].Kategori.KategoriAdi} kategorisinde yer almaktadır.\n-----------------------------------------");
        }
    }
}

class KategoriCRUD : IKategori
{
    private static List<Kategori> kategoriler = new();
    public void KategoriEkle(Kategori kategori)
    {
        kategoriler.Add(kategori);
    }

    public Kategori KategoriGetir(int id)
    {
        foreach (var kategori in kategoriler)
        {
            if (kategori.KategoriId == id)
            {
                return kategori;
            }
        }
        return null;
    }

    public void KategorileriGetir(bool onsekizYasindanKucukMu)
    {
        for (int i = 0; i < kategoriler.Count; i++)
        {
            if (onsekizYasindanKucukMu && kategoriler[i].KategoriId == 1)
                continue;
            else
                Console.WriteLine($"{kategoriler[i].KategoriAdi} kategorisine ait ürünler \n-----------------------------------------");
        }
    }
}

interface IKullanici
{
    Kullanici KullaniciGetir(int id);
    Kullanici KullaniciKayit();
}
interface IUrun
{
    void UrunEkle(Urun urun);
    void UrunleriGetir(bool kategoridekiUrunVarMi);
}
interface IKategori
{
    void KategoriEkle(Kategori kategori);
    void KategorileriGetir(bool onsekizYasindaMi);
    Kategori KategoriGetir(int id);
}
class Kullanici
{
    public int KullaniciId { get; set; }
    public string KullaniciAdi { get; set; }
    public DateTime BirthDate { get; set; }
}

class Urun
{
    public int UrunId { get; set; }
    public string UrunAdi { get; set; }
    public Kategori Kategori { get; set; }
    public int KategoriId { get; set; }
}

class Kategori
{
    public int KategoriId { get; set; }
    public string KategoriAdi { get; set; }
    public Urun Urun { get; set; }
    public int UrunId { get; set; }
}
#endregion

#region hocanın yaptığı
//Console.WriteLine("KAYIT İÇİN 1 E VE ÇIKIŞ İÇİN 2 YE BASINIZ");
//string kullaniciHamlesi = Console.ReadLine();
//if (kullaniciHamlesi != "1")
//{
//    //Environment.Exit(0);
//    return;
//}

//Console.WriteLine("Kayıt için sırasıyla Kullanıcı adı ve doğum tarih yılınızı giriniz.");

//User user = new User();
//Console.WriteLine("Lütfen kullanıcı adı giriniz");
//user.Username = Console.ReadLine();
//Console.WriteLine("Lütfen doğum tarih yılınızı giriniz");
//user.BirthDate = Convert.ToDateTime(Console.ReadLine());


//List<string> users = new();

//users.Add(user.Username);
//Console.WriteLine("Lütfen kullanıcı adı giriniz. ");
//string kullaniciAdi = Console.ReadLine();

//if (users.Contains(kullaniciAdi))
//{
//    Console.WriteLine("HOŞGELDİNİZZZZZZ");
//}


//Console.WriteLine(user.BirthDate.Year);
//Console.WriteLine(user.BirthDate.Month);
//Console.WriteLine(user.BirthDate.Day);
//Product product = new Product()
//{
//    Id = 1,
//    Name = "Kola"
//};
//Product product2 = new Product()
//{
//    Id = 2,
//    Name = "Bira"
//};
//Category category = new Category()
//{
//    Id = 1,
//    Name = "Alkolsüz İçecekler",
//    Product = product
//};
//Category category2 = new Category()
//{
//    Id = 2,
//    Name = "Alkollü içecekler",
//    Product = product2
//};


//if (18 < DateTime.Now.Year - user.BirthDate.Year)
//{
//    //burda alkollü içecekler gözükür
//    Console.WriteLine(category.Id + " " + category.Name);
//    Console.WriteLine(category2.Id + " " + category2.Name);

//    Console.WriteLine("Lütfen alış veriş yapmak istediğiniz kategoriyi seçiniz...");
//    string kategoriBilgisi = Console.ReadLine();
//    if (kategoriBilgisi == category.Id.ToString())
//    {
//        Console.WriteLine(category.Product.Name + " hazırlanıyor efendim");
//    }
//    else if (kategoriBilgisi == category2.Id.ToString())
//    {
//        Console.WriteLine(category2.Product.Name + " hazırlanıyor efendim");
//    }
//}
//else
//{
//    Console.WriteLine(category.Id + " " + category.Name);
//    Console.WriteLine("Lütfen alış veriş yapmak istediğiniz kategoriyi seçiniz...");
//    string kategoriBilgisi = Console.ReadLine();
//    if (kategoriBilgisi == category.Id.ToString())
//    {
//        Console.WriteLine(category.Product.Name + " hazırlanıyor efendim");
//    }
//}

////ilk önce kayıt ol daha sonra ana ekran kodlarını bidaha yaz uygulama çalışırkenki kodları kullanıcı adını yazdığında sistem eskisi gibi çalışıyo mu kontrol et

////ana menüye girerken kayıtlıysa kullanıcı 3'e bassın kullanıcı adını ve şifresini girsin
//class User
//{
//    public int Id { get; set; }
//    public string Username { get; set; }
//    public DateTime BirthDate { get; set; }
//}

//class Product
//{
//    public int Id { get; set; }
//    public string Name { get; set; }

//    public int CategoryId { get; set; }
//    public Category Category { get; set; }
//}
//class Category
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public int ProductId { get; set; }
//    public Product Product { get; set; }
//}
#endregion