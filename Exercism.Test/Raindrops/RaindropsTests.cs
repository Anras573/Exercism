using Sut = Exercism.Raindrops.Raindrops;

namespace Exercism.Test.Raindrops;

[TestClass]
public class RaindropsTests
{
    [TestMethod]
    [DataRow(1, "1")]
    [DataRow(3, "Pling")]
    [DataRow(5, "Plang")]
    [DataRow(7, "Plong")]
    [DataRow(6, "Pling")]
    [DataRow(8, "8")]
    [DataRow(9, "Pling")]
    [DataRow(10, "Plang")]
    [DataRow(14, "Plong")]
    [DataRow(15, "PlingPlang")]
    [DataRow(21, "PlingPlong")]
    [DataRow(25, "Plang")]
    [DataRow(27, "Pling")]
    [DataRow(35, "PlangPlong")]
    [DataRow(49, "Plong")]
    [DataRow(52, "52")]
    [DataRow(105, "PlingPlangPlong")]
    public void Test(int number, string expected)
    {
        Assert.AreEqual(expected, Sut.Convert(number));
    }
}