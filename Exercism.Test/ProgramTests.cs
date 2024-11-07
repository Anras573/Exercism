using System.Text;

namespace Exercism.Test;

[TestClass]
public class ProgramTests
{
    /// <summary>
    /// We expect the output of the program to be "Hello, World!".
    /// So we will test if the output contains "Hello, World!" by redirecting the output to a string builder
    /// and then comparing the result with the expected output.
    /// </summary>
    [TestMethod]
    public void Program_OutputContainsHelloWorld()
    {
        var sb = new StringBuilder();
        Console.SetOut(new StringWriter(sb));

        Program.Main(Array.Empty<string>());
        
        var result = sb.ToString().Trim();
        Assert.AreEqual("Hello, World!", result);
    }
}