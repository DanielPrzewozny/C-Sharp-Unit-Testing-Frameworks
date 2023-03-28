using Tasks._3___DateRange;

namespace xUnitTests;

public class DateTimeRange_xUnit_Test
{
    [Theory]
    [MemberData(nameof(IsValidData_AddRanges))]
    public void AddRanges(DateTimeRange rangeA, DateTimeRange rangeB, DateTimeRange[]? ranges)
    {
        var arrayofRanges = rangeA.Add(rangeB);

        Assert.True(arrayofRanges.All(rengeElem => ranges.Any(elem => 
            elem.Start == rengeElem.Start 
            && elem.End == rengeElem.End)) 
            && arrayofRanges.Count() == ranges?.Count());
    }

    [Theory]
    [MemberData(nameof(IsValidData_RangeContainsAnotherRange))]
    public void RangeContainsAnotherRange(DateTimeRange rangeA, DateTimeRange rangeB, bool expectedResult)
    {
        var isValid = rangeA.Contains(rangeB);

        Assert.Equal(isValid, expectedResult);
    }

    public static IEnumerable<object[]> IsValidData_AddRanges
    {
        get
        {
            var data = new List<object[]>();
            data.Add(new object[3]{new DateTimeRange() { Start = new DateTime(2020, 12, 1), End = new DateTime(2020, 12, 15) },
                        new DateTimeRange() { Start = new DateTime(2020, 1, 1), End = new DateTime(2020, 1, 15) },
                        new DateTimeRange[2]
                        {
                            new DateTimeRange() { Start = new DateTime(2020, 12, 1), End = new DateTime(2020, 12, 15) },
                           new DateTimeRange() { Start = new DateTime(2020, 1, 1), End = new DateTime(2020, 1, 15) }
                        }
            });

            return data;
        }
    }

    public static IEnumerable<object[]> IsValidData_RangeContainsAnotherRange
    {
        get
        {
            var data = new List<object[]>();
            data.Add(new object[3]{new DateTimeRange() { Start = new DateTime(2020, 12, 1), End = new DateTime(2020, 12, 15) },
                        new DateTimeRange() { Start = new DateTime(2020, 12, 5), End = new DateTime(2020, 12, 10) },
                        true
            });
            data.Add(new object[3]{new DateTimeRange() { Start = new DateTime(2020, 12, 1), End = new DateTime(2020, 12, 15) },
                        new DateTimeRange() { Start = new DateTime(2021, 12, 5), End = new DateTime(2021, 12, 10) },
                        false
            });

            return data;
        }
    }
}
