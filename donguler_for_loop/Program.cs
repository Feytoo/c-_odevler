namespace donguler_for_loop;
class Program
{
    static void Main(string[] args)
    {
        // ekrandan girilen sayiya kadar olan tek sayiları ekrana yazdir.
        Console.Write("Lutfen bir sayi giriniz: ");
        int sayac = int.Parse(Console.ReadLine());
        for(int i=1; i<=sayac; i++)
        {
            if(i%2 == 1)
            {
                Console.WriteLine(i);
            }
        }
        // 1 ile 1000 arasindaki tek ve cift sayilarin toplamini yazdir.
        int tekToplam = 0;
        int ciftToplam = 0;
        for(int i=1; i<=1000;i++)
        {
            if(i%2 == 1)
            {
                tekToplam += i; // tekToplam = tekToplam + i
            }
            else
            {
                ciftToplam += i; // ciftToplam = ciftToplam + i
            }
        }
        Console.WriteLine("Tek toplam: "+ tekToplam);
        Console.WriteLine("Cift toplam: "+ ciftToplam);
        // break , continue
        for(int i=1; i<10;i++)
        {
            if (i==4)
                break;
            Console.WriteLine(i);
        }
    }
}
