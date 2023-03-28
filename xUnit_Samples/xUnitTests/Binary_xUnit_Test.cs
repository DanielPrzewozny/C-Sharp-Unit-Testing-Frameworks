using Tasks._4___BinaryGap;

namespace xUnitTests;

public class Binary_xUnit_Test
{
    [Theory]
    [InlineData(8833, 6, true)]
    [InlineData(4368, 4, true)]
    [InlineData(260, 6, false)]
    public void CalculateMaxBinaryGap(int input, int maxGap, bool expectedResult)
    {
        //Act
        var maxBinaryGap = BinaryExtensions.GetMaxBinaryGap(input);

        //Assert
        Assert.Equal(maxBinaryGap == maxGap, expectedResult);
    }
}
