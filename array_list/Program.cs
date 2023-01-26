using System.Collections;

namespace array_list;
class Program
{
    static void Main(string[] args)
    {
        //System.Collections namespace

        ArrayList liste =new ArrayList();

        liste.Add("Ayse");
        liste.Add(5);
        liste.Add(true);
        liste.Add('K');

        //icerisinden veriye erisme
        Console.WriteLine(liste[1]);
        foreach(var eleman in liste)
            Console.WriteLine(eleman);
        
        //AddRange
        Console.WriteLine("****** AddRange ******");
        string[] renkler = {"kirmizi","sari","yesil"};
        List<int> sayilar = new List<int>(){1,8,3,7,9,92,5};
        liste.AddRange(renkler);
        liste.AddRange(sayilar);
        foreach ( var item in liste)
            Console.WriteLine(item);
        
        //Sort
        //liste.Sort();

        //BinarySerach
        //liste.BinarySearch(9);

        //Reverse
        //liste.Reverse() ---> Listeyi ters cevirecek

        //Clear
        liste.Clear();
}
