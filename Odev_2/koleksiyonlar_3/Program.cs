using System.Collections;

namespace koleksiyonlar_3;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lutfen bir cumle giriniz: ");
        string cumle = Console.ReadLine();
        string sesli_harfler = "aeıioöuü";
        ArrayList sesliHarfler = new ArrayList();

        for(int i = 0; i <cumle.Length; i++)
        {
            if(sesli_harfler.Contains(cumle[i]))
            {
                sesliHarfler.Add(cumle[i]);
            }
        }

        foreach (var item in sesliHarfler)
        {
            Console.WriteLine(item);
        }
    }
}
