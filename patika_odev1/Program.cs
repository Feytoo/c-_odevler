namespace patika_odev1;
class Program
{
    static void Main(string[] args)
    {
        Odevler odev = new();
        //odev.odev1();
        //odev.odev2();
        //odev.odev3();
        odev.odev4();
    }
}
class Odevler
{
    public void odev1()
    {
        Console.Write("Lutfen bir sayi giriniz: ");
        int boyut= int.Parse(Console.ReadLine());

        int[] liste = new int[boyut];
        for(int i=1;i<=boyut;i++)
        {
            Console.Write("{0}. sayiyi giriniz: ",i);
            liste[i-1]= int.Parse(Console.ReadLine());
        }
        Console.Write("Sonuc: ");
        foreach (var item in liste)
        {
            if (item%2==0)
            {
                Console.Write(item+" ");
            }
        }
    }
    public void odev2()
    {
        Console.Write("Lutfen boyut belirleyin: ");
        int boyut = int.Parse(Console.ReadLine());
        int[] liste = new int[boyut];

        Console.Write("Belirleyici sayiyi giriniz: ");
        int sayi = int.Parse(Console.ReadLine());

        for(int i=1;i<=boyut;i++)
        {
            Console.Write("{0}. sayiyi giriniz: ",i);
            liste[i-1]= int.Parse(Console.ReadLine());
        }

        Console.Write("Sonuc: ");
        foreach (var item in liste)
        {
            if(item==sayi)
                Console.Write(item+" ");
            else if(item%sayi==0)
                Console.Write(item+" ");
            
        }
    }

    public void odev3()
    {
        Console.Write("Lutfen listenin boyutunu belirleyiniz: ");
        int boyut = int.Parse(Console.ReadLine());
        string[] liste = new string[boyut];

        for(int i=1; i<=boyut;i++)
        {
            Console.Write("{0}. kelimeyi giriniz: ",i);
            liste[i-1]= Console.ReadLine();
        }
        Console.Write("Sonuc: ");
        Array.Reverse(liste);
        foreach (var item in liste)
        {
            Console.Write(item+" ");
        }
    }

    public void odev4()
    {
        Console.Write("Lutfen bir cumle girin: ");
        string cumle = Console.ReadLine();

        string[] liste = cumle.Split(' ');
        int kelime = liste.Count();
        string tamCumle=string.Join("",liste);
        int harf = tamCumle.Count();

        Console.WriteLine("Kelime sayisi: "+kelime);
        Console.WriteLine("Harf sayisi: "+harf);
    }
    
}
