using Exercism.SqueakyClean;

namespace Exercism.Test.SqueakyClean;

[TestClass]
public class IdentifierTests
{
    [TestMethod]
    [DataRow("", "")]
    [DataRow("my   Id", "my___Id")]
    [DataRow("my\0Id", "myCTRLId")]
    [DataRow("à-ḃç", "àḂç")]
    [DataRow("1😀2😀3😀", "")]
    [DataRow("MyΟβιεγτFinder", "MyΟFinder")]
    public void Clean(string input, string expected)
    {
        var result = Identifier.Clean(input);
        Assert.AreEqual(expected, result);
    }
}