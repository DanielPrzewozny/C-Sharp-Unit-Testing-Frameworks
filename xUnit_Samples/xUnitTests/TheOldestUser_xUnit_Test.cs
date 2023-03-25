using Tasks._2___TheOldestOne;
using xUnitTests.xUnitHelpers;

namespace xUnitTests;

public class TheOldestUser_xUnit_Test
{
    [Theory]
    [JsonDataFromFile<User>(filePath: "JsonData/users.json", expectedResult: 82)]
    public void CanGetTheOldestUserOnTheList(List<User> data, int expectedResult)
    {
        //Act
        var isValid = data.GetTheOldestOne()?.GetUserAge();

        //Assert
        Assert.Equal(expectedResult, isValid);
    }
}