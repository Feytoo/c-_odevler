namespace diziler;
class Program
{
    static void Main(string[] args)
    {
        // dizi tanimlama
        string[] renkler = new string[5];

        string[] hayvanlar = {"kedí","kopek","koyun","inek"};

        int[] dizi;
        dizi = new int[5];

        // dizilere deger atama ve erisim 
        renkler[0] = "Mavi";
        dizi[3] = 10;

        Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(renkler[0]);
        Console.WriteLine(dizi[3]);

        //dongulerle dizi kullanimi
        Console.Write("Lutfen dizi boyutunu belirleyiniz: ");
        int boyut = int.Parse(Console.ReadLine());
        int[] dizim = new int[boyut];
        int toplam=0;
        for(int i =0;i<boyut;i++)
        {
            Console.Write("{0}. sayiyi giriniz: ", i+1);
            dizim[i]= int.Parse(Console.ReadLine());
        }
        foreach (var sayi in dizim)
        {
            toplam +=sayi;
        }
        Console.WriteLine("Ortalama: "+(toplam/boyut));
    }
}
