using Exercism.TracksOnTracksOnTracks;

namespace Exercism.Test.TracksOnTracksOnTracks;

[TestClass]
public class LanguagesTests
{
    [TestMethod]
    public void NewList_ReturnsEmptyList()
    {
        var list = Languages.NewList();
        
        Assert.IsNotNull(list);
        Assert.AreEqual(0, list.Count);
    }
    
    [TestMethod]
    public void GetExistingLanguages_ReturnsListOfLanguages()
    {
        var list = Languages.GetExistingLanguages();
        
        Assert.IsNotNull(list);
        Assert.AreEqual(3, list.Count);
        Assert.IsTrue(list.Contains("C#"));
        Assert.IsTrue(list.Contains("Clojure"));
        Assert.IsTrue(list.Contains("Elm"));
    }
    
    [TestMethod]
    public void AddLanguage_AddsLanguageToList()
    {
        var list = new List<string> { "C#", "Clojure" };
        
        var updatedList = Languages.AddLanguage(list, "Elm");
        
        Assert.IsNotNull(updatedList);
        Assert.AreEqual(3, updatedList.Count);
        Assert.IsTrue(updatedList.Contains("C#"));
        Assert.IsTrue(updatedList.Contains("Clojure"));
        Assert.IsTrue(updatedList.Contains("Elm"));
    }
    
    [TestMethod]
    public void CountLanguages_ReturnsNumberOfLanguages()
    {
        var list = new List<string> { "C#", "Clojure", "Elm" };
        
        var count = Languages.CountLanguages(list);
        
        Assert.AreEqual(3, count);
    }
    
    [TestMethod]
    public void HasLanguage_ReturnsTrueIfLanguageExists()
    {
        var list = new List<string> { "C#", "Clojure", "Elm" };
        
        var hasLanguage = Languages.HasLanguage(list, "C#");
        
        Assert.IsTrue(hasLanguage);
    }
    
    [TestMethod]
    public void HasLanguage_ReturnsFalseIfLanguageDoesNotExist()
    {
        var list = new List<string> { "C#", "Clojure", "Elm" };
        
        var hasLanguage = Languages.HasLanguage(list, "F#");
        
        Assert.IsFalse(hasLanguage);
    }
    
    [TestMethod]
    public void ReverseList_ReturnsReversedListOfLanguages()
    {
        var list = new List<string> { "C#", "Clojure", "Elm" };
        
        var reversedList = Languages.ReverseList(list);
        
        Assert.IsNotNull(reversedList);
        Assert.AreEqual(3, reversedList.Count);
        Assert.AreEqual("Elm", reversedList[0]);
        Assert.AreEqual("Clojure", reversedList[1]);
        Assert.AreEqual("C#", reversedList[2]);
        
        // Ensure original list is not modified
        Assert.AreEqual(3, list.Count);
        Assert.AreEqual("C#", list[0]);
        Assert.AreEqual("Clojure", list[1]);
        Assert.AreEqual("Elm", list[2]);
    }
    
    [TestMethod]
    public void IsExciting_ReturnsTrueIfFirstLanguageIsCSharp()
    {
        var list = new List<string> { "C#", "Clojure", "Elm" };
        
        var isExciting = Languages.IsExciting(list);
        
        Assert.IsTrue(isExciting);
    }
    
    [TestMethod]
    public void IsExciting_ReturnsTrueIfSecondLanguageIsCSharp()
    {
        var list = new List<string> { "Clojure", "C#", "Elm" };
        
        var isExciting = Languages.IsExciting(list);
        
        Assert.IsTrue(isExciting);
    }
    
    [TestMethod]
    public void IsExciting_ReturnsFalseIfNoLanguages()
    {
        var list = new List<string>();
        
        var isExciting = Languages.IsExciting(list);
        
        Assert.IsFalse(isExciting);
    }
    
    [TestMethod]
    public void IsExciting_ReturnsFalseIfFirstLanguageIsNotCSharp()
    {
        var list = new List<string> { "Clojure", "Elm" };
        
        var isExciting = Languages.IsExciting(list);
        
        Assert.IsFalse(isExciting);
    }
    
    [TestMethod]
    public void IsExciting_ReturnsFalseIfMoreThanThreeLanguages()
    {
        var list = new List<string> { "Clojure", "C#", "Elm", "F#" };
        
        var isExciting = Languages.IsExciting(list);
        
        Assert.IsFalse(isExciting);
    }
    
    [TestMethod]
    public void RemoveLanguage_RemovesLanguageFromList()
    {
        var list = new List<string> { "C#", "Clojure", "Elm" };
        
        var updatedList = Languages.RemoveLanguage(list, "Clojure");
        
        Assert.IsNotNull(updatedList);
        Assert.AreEqual(2, updatedList.Count);
        Assert.IsTrue(updatedList.Contains("C#"));
        Assert.IsTrue(updatedList.Contains("Elm"));
        
        // Ensure original list is not modified
        Assert.AreEqual(3, list.Count);
        Assert.IsTrue(list.Contains("C#"));
        Assert.IsTrue(list.Contains("Clojure"));
        Assert.IsTrue(list.Contains("Elm"));
    }
    
    [TestMethod]
    public void IsUnique_ReturnsTrueIfAllLanguagesAreUnique()
    {
        var list = new List<string> { "C#", "Clojure", "Elm" };
        
        var isUnique = Languages.IsUnique(list);
        
        Assert.IsTrue(isUnique);
    }
    
    [TestMethod]
    public void IsUnique_ReturnsFalseIfDuplicateLanguages()
    {
        var list = new List<string> { "C#", "Clojure", "C#", "Elm" };
        
        var isUnique = Languages.IsUnique(list);
        
        Assert.IsFalse(isUnique);
    }
}