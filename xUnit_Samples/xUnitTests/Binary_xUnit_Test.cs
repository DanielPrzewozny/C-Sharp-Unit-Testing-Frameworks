using Tasks._4___BinaryGap;

namespace xUnitTests;

public class Binary_xUnit_Test
{
    [Theory]
    [InlineData(8833, 6, true)] //10001010000001
    [InlineData(4368, 4, true)] //1000100010000
    [InlineData(260, 6, false)] //100000100
    public void CalculateMaxBinaryGap(int input, int maxGap, bool expectedResult)
    {
        //Act
        var maxBinaryGap = BinaryExtensions.GetMaxBinaryGap(input);

        //Assert
        Assert.Equal(maxBinaryGap == maxGap, expectedResult);
    }

    [Theory]
    [InlineData(8833, "10001010000001", true)]
    [InlineData(4368, "1000100010000", true)]
    [InlineData(260, "100000101", false)]
    public void GetBinaryFormatTest(int input, string binaryFormat, bool expectedResult)
    {
        //Act
        var result = BinaryExtensions.GetBinaryFormat(input);

        //Assert
        Assert.Equal(result == binaryFormat, expectedResult);
    }
}
