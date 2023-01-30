namespace sinif_kavrami;
class Program
{
    static void Main(string[] args)
    {
        Calisan calisan1 = new();
        calisan1.Ad = "Ayse";
        calisan1.Soyad= "Kara";
        calisan1.No = 2124356789;
        calisan1.Departman="Insan Kaynaklari";

        Calisan calisan2 = new();
        calisan2.Ad = "Deniz";
        calisan2.Soyad= "Arda";
        calisan2.No = 2121345673;
        calisan2.Departman = "Satin Alim";

        calisan2.CalisanBilgiler();
    }
}

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgiler()
    {
        Console.WriteLine("Calisanin adi: {0}",Ad);
        Console.WriteLine("Calisanin soyadadi: {0}",Soyad);
        Console.WriteLine("Calisanin numarasi: {0}",No);
        Console.WriteLine("Calisanin departmani: {0}",Departman);
    }
}
