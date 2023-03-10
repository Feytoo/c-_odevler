namespace metodlar_ders2;
class Program
{
    static void Main(string[] args)
    {
        //out parametreler
        string sayi = "999";
        int outSayi;

        bool sonuc = int.TryParse(sayi, out outSayi);
        if(sonuc)
        {
            Console.WriteLine("Basarili!");
            Console.WriteLine(outSayi);
        }
        else
        {
            Console.WriteLine("Basarisiz!");
        }

        Metotlar instance = new Metotlar();
        instance.Topla(4,5,out int toplamSonucu);
        Console.WriteLine(toplamSonucu);

        // metod asiri yukleme - overloading
        int ifade = 999;
        instance.EkranaYazdir(ifade);
        instance.EkranaYazdir("Fatih","Calik");
        
        //metod imzasi
        //metotAdı + parametresayisi + parametre tipleri
    }
}
class Metotlar
{
    public void Topla(int a, int b, out int toplam)
    {
        toplam = a+b;
    }
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(int veri)
    {
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(string veri1, string veri2)
    {
        Console.WriteLine(veri1+" "+ veri2);
    }
}
