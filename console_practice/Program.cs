namespace console_practice;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Isminizi Giriniz: ");
        string name = Console.ReadLine();
        Console.WriteLine("Soadinizi Giriniz: ");
        string surname = Console.ReadLine();

        Console.WriteLine("Merhaba " + name + " " + surname);
    }
}
