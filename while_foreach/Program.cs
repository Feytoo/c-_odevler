namespace while_foreach;
class Program
{
    static void Main(string[] args)
    {
        //while
        // 1 den baslayarak console dan girilen sayiya kadar olan sayilarin ortalama heaplayip console a yazdirma.
        Console.Write("Sayi giriniz: ");
        int sayi = int.Parse(Console.ReadLine());
        int sayac= 1, toplam=0;
        while(sayac <= sayi)
        {
            toplam += sayac;
            sayac++;
        }
        Console.WriteLine("Ortalama: "+(toplam/sayi));

        // a dan z ye kadar butun alfabeyi yazdirma
        char character = 'a';
        while(character <= 'z')
        {
            Console.Write(character);
            character++;
        }
        //Foreach
        Console.WriteLine("***** Foreach *****");
        string[] arabalar = {"BMW","Ford","Nissan","Toyota"};

        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);            
        }
    }
}
