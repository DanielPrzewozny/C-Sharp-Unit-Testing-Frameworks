using Tasks._1___IPValidator;
using Tasks._2___TheOldestOne;
using Tasks._3___DateRange;
using Tasks._4___BinaryGap;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sample1: Try to recognize the IP address.\n");
        IPCheckerSample.CheckIp();

        Console.WriteLine("\n-------------\n\nSample2: Get the oldest user on the list.\n");
        TheOldestUserSample.DisplayTheOldestUser();

        Console.WriteLine("\n-------------\n\nSample3: DateTime range operations.\n");
        var rangeA = new DateTimeRange() { Start = new DateTime(2020, 12, 1), End = new DateTime(2020, 12, 15) };
        var rangeB = new DateTimeRange() { Start = new DateTime(2020, 1, 1), End = new DateTime(2020, 1, 15) };
        var rangeC = new DateTimeRange() { Start = new DateTime(2020, 5, 1), End = new DateTime(2020, 5, 15) };
        var ranges = rangeA.Add(rangeB);
        ranges = rangeA.Add(rangeC);
        int i = 0;
        foreach (var range in ranges)
            Console.WriteLine($"[{i++}]: Start: {range.Start}, End: {range.End}");

        Console.WriteLine("\n-------------\n\nSample4: Convert the number to binary format and then calculate max zero gap.\n");
        var numbers = new [] { 8833, 4368, 260 };
        foreach (var num in numbers)
            Console.WriteLine(num + ": " + BinaryExtensions.GetBinaryFormat(num) + ", max zero gap: " + BinaryExtensions.GetMaxBinaryGap(num));
    }
}
