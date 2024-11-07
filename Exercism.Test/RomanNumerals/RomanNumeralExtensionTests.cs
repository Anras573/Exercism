using Exercism.RomanNumerals;

namespace Exercism.Test.RomanNumerals;

[TestClass]
public class RomanNumeralExtensionTests
{
    [TestMethod]
    [DataRow(1, "I")]
    [DataRow(2, "II")]
    [DataRow(3, "III")]
    [DataRow(4, "IV")]
    [DataRow(5, "V")]
    [DataRow(6, "VI")]
    [DataRow(9, "IX")]
    [DataRow(27, "XXVII")]
    [DataRow(48, "XLVIII")]
    [DataRow(59, "LIX")]
    [DataRow(93, "XCIII")]
    [DataRow(141, "CXLI")]
    [DataRow(163, "CLXIII")]
    [DataRow(402, "CDII")]
    [DataRow(575, "DLXXV")]
    [DataRow(911, "CMXI")]
    [DataRow(1024, "MXXIV")]
    [DataRow(3000, "MMM")]
    public void ToRoman(int value, string expected)
    {
        Assert.AreEqual(expected, value.ToRoman());
    }
}