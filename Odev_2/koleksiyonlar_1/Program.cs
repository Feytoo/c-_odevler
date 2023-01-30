using System.Collections;

namespace koleksiyonlar_1;
class Program
{
    static void Main(string[] args)
    {
        ArrayList asalListe = new ArrayList();
        ArrayList asalOlmayan = new ArrayList();
        List<int> arr = new List<int>();
        while(arr.Count <20)
        {
            baslangic:
            try
            {
                Console.Write("Sayi giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi < 0)
                {
                    Console.WriteLine("Luften pozitif bir sayi giriniz!");
                    goto baslangic;   
                }
                else
                    arr.Add(sayi);
            }
            catch (Exception)
            {
                Console.WriteLine("Dogru formatta sayi giriniz!");
                goto baslangic;
            }
            
        }
        
        foreach (var item in arr)
        {
            int count =0;
            for ( int i=2; i < item;i++)
            {
                if (item % i == 0)
                    count++;
                else
                    continue;
            }
            if (count == 0)
                asalListe.Add(item);
            else
                asalOlmayan.Add(item);
        }

        asalListe.Sort();
        asalListe.Reverse();
        asalOlmayan.Sort();
        asalOlmayan.Reverse();
        int asalToplam=0, notasalToplam=0;

        Console.Write("Asal sayilar: ");
        foreach(var sayi in asalListe)
        {
            Console.Write(sayi + " ");
        }
        Console.WriteLine();
        Console.Write("Asal olmayan sayilar: ");
        foreach(var sayi in asalOlmayan)
        {
            Console.Write(sayi+" ");
        }
        Console.WriteLine();
        Console.WriteLine("Asal sayilarin sayisi: "+ asalListe.Count);
        Console.WriteLine("Asal olmayan sayilarin sayisi: "+ asalOlmayan.Count);

        for(int j = 0; j<asalListe.Count; j++)
        {
            asalToplam = Convert.ToInt32(asalListe[j]) + asalToplam;
        }
        for(int j = 0; j<asalOlmayan.Count; j++)
        {
            notasalToplam = Convert.ToInt32(asalOlmayan[j]) + notasalToplam;
        }
        Console.WriteLine("Asal sayilarin ortalamasi: "+ asalToplam/asalListe.Count);
        Console.WriteLine("Asal olmayan sayilarin ortalamasi: "+ notasalToplam/asalOlmayan.Count);
    }
}
