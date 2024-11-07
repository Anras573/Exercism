using Sut = Exercism.ReverseString.ReverseString;

namespace Exercism.Test.ReverseString;

[TestClass]
public class ReverseStringTests
{
    [TestMethod]
    [DataRow("hello", "olleh")]
    [DataRow("world", "dlrow")]
    [DataRow("racecar", "racecar")]
    [DataRow("stressed", "desserts")]
    [DataRow("strops", "sports")]
    public void Reverse_reverses_a_string(string input, string expected)
    {
        Assert.AreEqual(expected, Sut.Reverse(input));
    }
}