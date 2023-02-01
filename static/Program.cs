namespace static_sinif;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calisan sayisi: {0}",Calisan.CalisanSayisi);

        Calisan calisan1 = new Calisan("Ayse","Yilmaz","IK");
        Console.WriteLine("Calisan sayisi: {0}",Calisan.CalisanSayisi);

        Console.WriteLine("Toplama isleminin sonucu: {0}",Islemler.Toplam(100,200));
        Console.WriteLine("Cikarma isleminin sonucu: {0}",Islemler.Cikarma(540,210));

    }
}

class Calisan
{
    private static int calisanSayisi;

    public static int CalisanSayisi {get => calisanSayisi;}

    private string Isim;
    private string Soyisim;
    private string Departman;

    static Calisan()
    {
        calisanSayisi = 0;
    }
    public Calisan(string isim, string soyisim, string departman)
    {
        this.Isim = isim;
        this.Soyisim = soyisim;
        this.Departman = departman;
        calisanSayisi++;
    }
}

static class Islemler
{
    public static long Toplam(int sayi1,int sayi2)
    {
        return sayi1 + sayi2;
    } 
    public static long Cikarma(int sayi1,int sayi2)
    {
        return sayi1 - sayi2;
    }
}
