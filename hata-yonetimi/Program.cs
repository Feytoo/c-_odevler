namespace hata_yonetimi;
class Program
{
    static void Main(string[] args)
    {
        //try
        //{
        //    Console.WriteLine("Bir sayi giriniz: ");
        //    int sayi = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Girdiginiz sayi: "+ sayi);
        //}
        //catch(Exception ex)
        //{
        //    Console.WriteLine("HATA! : "+ ex.Message.ToString());
        //}
        //finally
        //{
        //    Console.WriteLine("İslem tamamlandi!");
        //}

        try
        {
            //int a = int.Parse(null);
            //int a = int.Parse("test");
            int a = int.Parse("-20000000000");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Bos deger girdiniz!");
            Console.WriteLine(ex);
        }
        catch(FormatException ex)
        {
            Console.WriteLine("Yanlis ver tipi girdiniz!");
            Console.WriteLine(ex);
        }
        catch(OverflowException ex)
        {
            Console.WriteLine("Cok kucuk ya da cok buyuk deger girdiniz!");
            Console.WriteLine(ex);
        }
        finally
        {
            Console.WriteLine("Islem basariyla tamamlandi!");
        }
    }
}
