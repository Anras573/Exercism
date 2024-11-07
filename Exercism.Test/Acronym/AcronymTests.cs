using Sut = Exercism.Acronym.Acronym;

namespace Exercism.Test.Acronym;

[TestClass]
public class AcronymTests
{
    [TestMethod]
    [DataRow("Portable Network Graphics", "PNG")]
    [DataRow("Ruby on Rails", "ROR")]
    [DataRow("Liquid-crystal display", "LCD")]
    [DataRow("Thank George It's Friday!", "TGIF")]
    [DataRow("The Road _Not_ Taken", "TRNT")]
    public void Abbreviate(string phrase, string expected)
    {
        var result = Sut.Abbreviate(phrase);
        Assert.AreEqual(expected, result);
    }
}