namespace metodlar_ders3;
class Program
{
    static void Main(string[] args)
    {
        //rekursif - oz yinelemeli
        // 3^4
        int result = 1;
        for (int i = 1; i < 5; i++)
        {
            result *= 3;
        }
        Console.WriteLine(result);

        Islemler instance = new();
        Console.WriteLine(instance.Expo(3,4));

        //Extension metad
        string ifade = "Fatih Calik";
        bool sonuc = ifade.CheckSpaces();
        Console.WriteLine(sonuc);
        if(sonuc)
        {
            Console.WriteLine(ifade.removeWhiteSpaces());
        }
        Console.WriteLine(ifade.makeUpperCase());
        Console.WriteLine(ifade.makeLowerCase());

        int[] dizi = {9,3,6,2,1,5,0};
        dizi.listSort();
        dizi.writeList();
        
    }
}
public class Islemler
{
    public int Expo(int sayi, int us)
    {
        if(us<2)
            return sayi;
        return Expo(sayi,us-1)*sayi;
    }
    //Expo(3,4)
    //Expo(3,3)*3
    //Expo(3,2)*3*3
    //Expo(3,1)*3*3*3
    //3*3*3*3
}
public static class Extension
{
    public static bool CheckSpaces(this string param)
    {
        return param.Contains(" ");
    }
    public static string removeWhiteSpaces(this string param)
    {
        string[] dizi = param.Split();
        return string.Join("",dizi);
    }
    public static string makeUpperCase(this string param)
    {
        return param.ToUpper();
    }
    public static string makeLowerCase(this string param)
    {
        return param.ToLower();
    }
    public static int[] listSort(this int[] liste)
    {
        Array.Sort(liste);
        return liste; 
    }
    public static void writeList(this int[] param)
    {
        foreach(int item in param)
        Console.Write(item);
    }
}
