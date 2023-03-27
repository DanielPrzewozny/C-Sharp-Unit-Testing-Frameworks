using Tasks._1___IPValidator;
using Tasks._2___TheOldestOne;
using Tasks._3___DateRange;

namespace Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Sample1:\n");
        //IPCheckerSample.CheckIp();

        //Console.WriteLine("\n-------------\n\nSample2:\n");
        //TheOldestUserSample.DisplayTheOldestUser();

        Console.WriteLine("\n-------------\n\nSample3:\n");
        var rangeA = new DateTimeRange() { Start = new DateTime(2020, 12, 1), End = new DateTime(2020, 12, 15) };
        var rangeB = new DateTimeRange() { Start = new DateTime(2020, 1, 1), End = new DateTime(2020, 1, 15) };
        var rangeC = new DateTimeRange() { Start = new DateTime(2020, 5, 1), End = new DateTime(2020, 5, 15) };
        var result = rangeA.Add(rangeB);
        result = rangeA.Add(rangeC);
    }
}
