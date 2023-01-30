namespace koleksiyonlar_2;
class Program
{
    static void Main(string[] args)
    {
        int[] sayi_dizisi = new int[20];
        int[] kucukler = new int[3];
        int[] buyukler = new int[3];
        int count = 0;
        while (count <20)
        {

            baslangic:
            try
            {
                Console.Write("Sayi giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayi_dizisi[count] = sayi;
                count++;
            }
            catch (Exception)
            {
                Console.WriteLine("Lutfen sayi giriniz!!");
                goto baslangic;
            }
        }
        Array.Sort(sayi_dizisi);
        for (int i = 0; i < 3;i++)
        {
            kucukler[i] = sayi_dizisi[i];
            buyukler[i] = sayi_dizisi[19-i];
        }
        int kucukToplam=0, buyukToplam=0;
        foreach (var sayi in kucukler)
            kucukToplam += sayi;
        foreach (var sayi in buyukler)
            buyukToplam += sayi;
        
        Console.WriteLine("En kucuk 3 sayinin ortalamasi: "+kucukToplam/3);
        Console.WriteLine("En buyuk 3 sayinin ortalamasi: "+buyukToplam/3);
    }
}
