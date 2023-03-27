using System.Collections;
using System.Collections.Generic;
using Tasks._3___DateRange;

namespace xUnitTests;

public class DateTimeRange_xUnit_Test
{
    [Theory]
    [MemberData(nameof(IsValidData))]
    public void AddRanges(DateTimeRange rangeA, DateTimeRange rangeB, DateTimeRange[]? ranges)
    {
        var arrayofRanges = rangeA.Add(rangeB);

        Assert.True(arrayofRanges.All(rengeElem => ranges.Any(elem => 
            elem.Start == rengeElem.Start 
            && elem.End == rengeElem.End)));
    }

    public static IEnumerable<object[]> IsValidData
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
}
