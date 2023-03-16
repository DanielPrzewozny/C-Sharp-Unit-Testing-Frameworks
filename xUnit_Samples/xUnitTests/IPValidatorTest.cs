using System.Net.Sockets;
using Tasks._1___IPValidator;

namespace xUnitTests;

public class IPValidatorTest
{
    [Theory]
    [InlineData("192.168.8.56", true)]
    [InlineData("192.168.8.56.13.13.13", false)]
    [InlineData("This!", false)]
    public void IsIPv4(string input, bool expectedResult)
    {
        //Act
        var isValid = input.SpecifyKindOfIPAddress() == AddressFamily.InterNetwork;

        //Assert
        Assert.Equal(expectedResult, isValid);
    }

    [Theory]
    [InlineData("2001:0db8:85a3:0000:0000:8a2e:0370:7334", true)]
    [InlineData("192.168.8.56.13.13.13", false)]
    [InlineData("This!", false)]
    public void IsIPv6(string input, bool expectedResult)
    {
        //Act
        var isValid = input.SpecifyKindOfIPAddress() == AddressFamily.InterNetworkV6;

        //Assert
        Assert.Equal(expectedResult, isValid);
    }
}