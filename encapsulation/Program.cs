namespace encapsulation;
class Program
{
    static void Main(string[] args)
    {
        Ogrenci ogrenci = new();
        ogrenci.Isim="Ayse";
        ogrenci.Soyisim="Yilmaz";
        ogrenci.OgrenciNo=293;
        ogrenci.Sinif=3;
        ogrenci.ogrenciBilgisiGetir();

        ogrenci.sinifAtlat();
        ogrenci.ogrenciBilgisiGetir();

        Ogrenci ogrenci1 = new Ogrenci("Deniz","Arda",256,1);
        ogrenci1.ogrenciBilgisiGetir();

        ogrenci1.sinifDusur();
        ogrenci1.ogrenciBilgisiGetir();
    }
}

class Ogrenci
{
    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;
    public string Isim
    {
        get { return isim; }
        set { isim = value; }
    }
    public string Soyisim{ get => soyisim; set => soyisim = value; }

    public int OgrenciNo{ get => ogrenciNo; set => ogrenciNo = value;}

    public int Sinif{ 
        get => sinif; 
        set
        {
            if (value<1)
            {
                Console.WriteLine("Sinif En Kucuk 1 Olabilir!");
                sinif = 1;
            }
            else
                sinif = value;
        }
    }
    public Ogrenci(string isim,string soyisim,int ogrenciNo,int sinif)
    {
        Isim = isim;
        Soyisim = soyisim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }
    public Ogrenci(){}

    public void ogrenciBilgisiGetir()
    {
        Console.WriteLine("********** Ogrenci Bilgisi **********");
        Console.WriteLine("Ogrenci Adi: {0}",Isim);
        Console.WriteLine("Ogrenci SoyAdi: {0}",Soyisim);
        Console.WriteLine("Ogrenci No: {0}",OgrenciNo);
        Console.WriteLine("Ogrenci Sinifi: {0}",Sinif);
    }
    
    public void sinifAtlat()
    {
        this.Sinif += 1;
    }
    public void sinifDusur()
    {
        this.Sinif = this.Sinif - 1;
    }
}
