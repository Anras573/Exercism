using Sut = Exercism.HelloWorld.HelloWorld;

namespace Exercism.Test.HelloWorld;

[TestClass]
public class HelloWorldTests
{
    [TestMethod]
    public void HelloWorldTest()
    {
        Assert.AreEqual("Hello, World!", Sut.Hello());
    }
}