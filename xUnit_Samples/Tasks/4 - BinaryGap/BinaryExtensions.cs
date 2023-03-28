using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tasks._4___BinaryGap;

public static class BinaryExtensions
{
    public static string GetBinaryFormat(int number)
        => string.Join("", GetListOfBits(number).ToArray().Reverse());

    public static List<int> GetListOfBits(int number)
    {
        var binary = new List<int>();
        do
        {
            binary.Add(number % 2 == 0 ? 0 : 1);
            number = (int)(number / 2);
        } while (number != 0);
        return binary;
    }

    public static int GetMaxBinaryGap(int number)
    {
        var listOfBits = GetListOfBits(number);
        var zeroGaps = new List<int>();
        var counter = 0;
        foreach (var bit in listOfBits)
        {
            if (bit == 0)
                ++counter;
            else if (counter != 0)
            {
                zeroGaps.Add(counter);
                counter = 0;
            }
        }
        return zeroGaps.Max();
    }
}
