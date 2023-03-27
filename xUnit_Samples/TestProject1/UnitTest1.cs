using System;
using System.Collections;
using System.Linq;
using Tasks._3___DateRange;

namespace TestProject1;

public class Tests
{
    //[SetUp]
    //public void Setup()
    //{
    //}

    //[Test]
    //public void Test1()
    //{
    //    Assert.Pass();
    //}

    [Theory]
    [TestCaseSource(nameof(IsValidData))]
    public void AddTest(DateTimeRange rangeA, DateTimeRange rangeB, DateTimeRange[]? ranges)
    {
        
        Assert.True(arrayofRanges.All(rengeElem => ranges.Any(elem => elem.Start == rengeElem.Start && elem.End == rengeElem.End))); //true
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