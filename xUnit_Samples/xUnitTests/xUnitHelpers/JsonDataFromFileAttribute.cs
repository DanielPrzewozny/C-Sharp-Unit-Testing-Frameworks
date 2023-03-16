using Newtonsoft.Json;
using System.Reflection;
using Xunit.Sdk;

namespace xUnitTests.xUnitHelpers;
public class JsonDataFromFileAttribute<T> : DataAttribute
    where T : class
{
    private readonly string _filePath;
    private readonly object _result;

    public JsonDataFromFileAttribute(string filePath, object expectedResult)
    {
        _filePath = filePath;
        _result = expectedResult;
    }

    /// <inheritDoc />
    public override IEnumerable<object[]> GetData(MethodInfo testMethod)
    {
        if (testMethod == null) { throw new ArgumentNullException(nameof(testMethod)); }

        var path = Path.IsPathRooted(_filePath)
            ? _filePath
            : Path.GetRelativePath(Directory.GetCurrentDirectory(), _filePath);

        if (!File.Exists(path))
            throw new ArgumentException($"Could not find file at path: {path}");

        return new List<object[]>()
        {
            new object[]
            {
                JsonConvert.DeserializeObject<List<T>>(File.ReadAllText(path)),
                _result
            }
        };
    }
}