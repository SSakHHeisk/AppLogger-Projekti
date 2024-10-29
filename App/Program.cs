using AppLogger;

namespace App;

class Program
{
    static void Main(string[] args)
    {
        const string text = "Moi_kaikki_tyypit";

        Console.WriteLine("Raaka teksti: " + text);
        Console.Write("Muutettu teksti: ");
        Logger.Log(text);
    }
}
