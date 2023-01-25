namespace generic_list;
class Program
{
    static void Main(string[] args)
    {
        //List<T> class
        //System.Collections.Generic
        //T -> object turundedir.

        List<int> sayiListesi = new List<int>();

        sayiListesi.Add(23);
        sayiListesi.Add(10);
        sayiListesi.Add(4);
        sayiListesi.Add(5);
        sayiListesi.Add(92);
        sayiListesi.Add(34);

        List<string> renkListesi = new List<string>();

        renkListesi.Add("Kirmizi");
        renkListesi.Add("Mavi");
        renkListesi.Add("Turuncu");
        renkListesi.Add("Sari");
        renkListesi.Add("Yesil");

        //Count
        Console.WriteLine(renkListesi.Count);
        Console.WriteLine(sayiListesi.Count);

        //foreach ve list.foreach ile liste elemanlarina erisim
        foreach(var sayi in sayiListesi)
            Console.WriteLine(sayi);
        
        foreach(var renk in renkListesi)
            Console.WriteLine(renk);

        sayiListesi.ForEach(sayi => Console.WriteLine(sayi)); 
        renkListesi.ForEach(renk => Console.WriteLine(renk));

        //Listeden eleman cikarma
        sayiListesi.Remove(4);
        renkListesi.Remove("Yesil");

        sayiListesi.RemoveAt(0);
        renkListesi.RemoveAt(1);

        //Liste icinde arama
        if(sayiListesi.Contains(10))
            Console.WriteLine("10 liste icerisnde bulundu!");
        
        //Eleman ile index'e erisme
        renkListesi.BinarySearch("Sari");

        //Diziyi listeye cevirme
        string[] hayvanlar = {"Kedi","Kopek","Kus"};
        List<string> hayvanlarListesi = new List<string>();

        //Listeyi temizleme
        hayvanlarListesi.Clear();

        //Liste icerisinde nesne tutmak icin
        List<Kullanici> kullaniciListesi = new List<Kullanici>();
        Kullanici kullanici1 = new Kullanici();
        kullanici1.Isim="Ayse";
        kullanici1.Soyisim="Yilmaz";
        kullanici1.Yas=26;

        Kullanici kullanici2 = new Kullanici();
        kullanici2.Isim= "Ozcan";
        kullanici2.Soyisim= "Caliskan";
        kullanici2.Yas=26;

        kullaniciListesi.Add(kullanici1);
        kullaniciListesi.Add(kullanici2);

        List<Kullanici> yeniListe = new List<Kullanici>();
        yeniListe.Add(new Kullanici()
        {
            Isim="Fatih",
            Soyisim="Calik",
            Yas=23
        });
        foreach (var kullanici in kullaniciListesi)
        {
            Console.WriteLine("Kullanici Adi: "+kullanici.Isim);
            Console.WriteLine("Kullanici Soy Adi: "+kullanici.Soyisim);
            Console.WriteLine("Kullanici Yasi: "+kullanici.Yas);
        }

    }
}

public class Kullanici
{
    private string isim;
    private string soyisim;
    private int yas;

    public string Isim {get => isim ; set => isim = value;}
    public string Soyisim {get => soyisim ; set => soyisim = value;}
    public int Yas {get => yas ; set => yas = value;}
}
