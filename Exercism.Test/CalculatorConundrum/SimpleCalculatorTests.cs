using Exercism.CalculatorConundrum;

namespace Exercism.Test.CalculatorConundrum;

[TestClass]
public class SimpleCalculatorTests
{
    [TestMethod]
    public void Addition()
    {
        Assert.AreEqual("1 + 2 = 3", SimpleCalculator.Calculate(1, 2, "+"));
    }
    
    [TestMethod]
    public void Multiplication()
    {
        Assert.AreEqual("1 * 2 = 2", SimpleCalculator.Calculate(1, 2, "*"));
    }
    
    [TestMethod]
    public void Division()
    {
        Assert.AreEqual("1 / 2 = 0", SimpleCalculator.Calculate(1, 2, "/"));
    }
    
    [TestMethod]
    public void DivisionByZero()
    {
        Assert.AreEqual("Division by zero is not allowed.", SimpleCalculator.Calculate(1, 0, "/"));
    }
    
    [TestMethod]
    public void InvalidOperation()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => SimpleCalculator.Calculate(1, 2, "-"));
    }
    
    [TestMethod]
    public void NullOperation()
    {
        Assert.ThrowsException<ArgumentNullException>(() => SimpleCalculator.Calculate(1, 2, null!));
    }
    
    [TestMethod]
    public void EmptyOperation()
    {
        Assert.ThrowsException<ArgumentException>(() => SimpleCalculator.Calculate(1, 2, ""));
    }
}