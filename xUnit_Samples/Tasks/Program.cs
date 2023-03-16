using Tasks._1___IPValidator;
using Tasks._2___TheOldestOne;

namespace Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sample1:\n");
        IPCheckerSample.CheckIp();

        Console.WriteLine("\n-------------\n\nSample2:\n");
        TheOldestUserSample.DisplayTheOldestUser();
    }
}
