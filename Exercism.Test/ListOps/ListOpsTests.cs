using Sut = Exercism.ListOps.ListOps;

namespace Exercism.Test.ListOps;

[TestClass]
public class ListOpsTests
{
    [TestMethod]
    public void Length_of_empty_list_is_zero()
    {
        var list = new List<int>();
        Assert.AreEqual(0, Sut.Length(list));
    }
    
    [TestMethod]
    public void Length_of_non_empty_list()
    {
        var list = new List<int> { 1, 2, 3 };
        Assert.AreEqual(3, Sut.Length(list));
    }
    
    [TestMethod]
    public void Reverse_of_empty_list_is_empty()
    {
        var list = new List<int>();
        CollectionAssert.AreEqual(new List<int>(), Sut.Reverse(list));
    }
    
    [TestMethod]
    public void Reverse_of_non_empty_list()
    {
        var list = new List<int> { 1, 2, 3 };
        CollectionAssert.AreEqual(new List<int> { 3, 2, 1 }, Sut.Reverse(list));
    }
    
    [TestMethod]
    public void Map_of_empty_list_is_empty()
    {
        var list = new List<int>();
        CollectionAssert.AreEqual(new List<int>(), Sut.Map(list, x => x + 1));
    }
    
    [TestMethod]
    public void Map_of_non_empty_list()
    {
        var list = new List<int> { 1, 3, 5 };
        CollectionAssert.AreEqual(new List<int> { 2, 4, 6 }, Sut.Map(list, x => x + 1));
    }
    
    [TestMethod]
    public void Filter_of_empty_list_is_empty()
    {
        var list = new List<int>();
        CollectionAssert.AreEqual(new List<int>(), Sut.Filter(list, x => x % 2 == 1));
    }
    
    [TestMethod]
    public void Filter_of_non_empty_list()
    {
        var list = new List<int> { 1, 2, 3, 4, 5 };
        CollectionAssert.AreEqual(new List<int> { 1, 3, 5 }, Sut.Filter(list, x => x % 2 == 1));
    }
    
    [TestMethod]
    public void Foldl_of_empty_list_is_start()
    {
        var list = new List<int>();
        Assert.AreEqual(2, Sut.Foldl(list, 2, (x, y) => x * y));
    }
    
    [TestMethod]
    public void Foldl_of_non_empty_list()
    {
        var list = new List<int> { 1, 2, 3, 4 };
        Assert.AreEqual(24, Sut.Foldl(list, 1, (x, y) => x * y));
    }
    
    [TestMethod]
    public void Foldr_of_empty_list_is_start()
    {
        var list = new List<int>();
        Assert.AreEqual(2, Sut.Foldr(list, 2, (x, y) => x * y));
    }
    
    [TestMethod]
    public void Foldr_of_non_empty_list()
    {
        var list = new List<int> { 1, 2, 3, 4 };
        Assert.AreEqual(24, Sut.Foldr(list, 1, (x, y) => x * y));
    }
    
    [TestMethod]
    public void Foldr_of_non_empty_list2()
    {
        var list = new List<int> { 2, 5 };
        Assert.AreEqual(2, Sut.Foldr(list, 5, (x, y) => x / y));
    }
    
    [TestMethod]
    public void Concat_of_empty_list_is_empty()
    {
        var list = new List<List<int>>();
        CollectionAssert.AreEqual(new List<int>(), Sut.Concat(list));
    }
    
    [TestMethod]
    public void Concat_of_non_empty_list()
    {
        var list = new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 3 }, new List<int> { 4, 5 } };
        CollectionAssert.AreEqual(new List<int> { 1, 2, 3, 4, 5 }, Sut.Concat(list));
    }
    
    [TestMethod]
    public void Append_of_empty_lists_is_empty()
    {
        var left = new List<int>();
        var right = new List<int>();
        CollectionAssert.AreEqual(new List<int>(), Sut.Append(left, right));
    }
    
    [TestMethod]
    public void Append_of_empty_list_to_non_empty_list()
    {
        var left = new List<int> { 1, 2, 3 };
        var right = new List<int>();
        CollectionAssert.AreEqual(new List<int> { 1, 2, 3 }, Sut.Append(left, right));
    }
    
    [TestMethod]
    public void Append_of_non_empty_list_to_empty_list()
    {
        var left = new List<int>();
        var right = new List<int> { 4, 5, 6 };
        CollectionAssert.AreEqual(new List<int> { 4, 5, 6 }, Sut.Append(left, right));
    }
    
    [TestMethod]
    public void Append_of_non_empty_lists()
    {
        var left = new List<int> { 1, 2 };
        var right = new List<int> { 3, 4, 5 };
        CollectionAssert.AreEqual(new List<int> { 1, 2, 3, 4, 5 }, Sut.Append(left, right));
    }
}