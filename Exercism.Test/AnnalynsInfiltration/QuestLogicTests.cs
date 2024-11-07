using Exercism.AnnalynsInfiltration;

namespace Exercism.Test.AnnalynsInfiltration;

[TestClass]
public class QuestLogicTests
{
    [TestMethod]
    public void CanFastAttack()
    {
        Assert.IsTrue(QuestLogic.CanFastAttack(false));
        Assert.IsFalse(QuestLogic.CanFastAttack(true));
    }
    
    [TestMethod]
    public void CanSpy()
    {
        // If any of the three are awake, you can spy
        Assert.IsTrue(QuestLogic.CanSpy(false, false, true));
        Assert.IsTrue(QuestLogic.CanSpy(true, false, false));
        Assert.IsTrue(QuestLogic.CanSpy(false, true, false));
        Assert.IsTrue(QuestLogic.CanSpy(true, true, true));
        
        // If none of the three are awake, you can't spy
        Assert.IsFalse(QuestLogic.CanSpy(false, false, false));
    }
    
    [TestMethod]
    public void CanSignalPrisoner()
    {
        Assert.IsTrue(QuestLogic.CanSignalPrisoner(false, true));
        Assert.IsFalse(QuestLogic.CanSignalPrisoner(true, false));
        Assert.IsFalse(QuestLogic.CanSignalPrisoner(false, false));
        Assert.IsFalse(QuestLogic.CanSignalPrisoner(true, true));
    }

    [TestMethod]
    public void CanFreePrisoner()
    {
        // As long as the archer is awake, you can't free the prisoner
        Assert.IsFalse(QuestLogic.CanFreePrisoner(false, true, true, false));
        Assert.IsFalse(QuestLogic.CanFreePrisoner(false, true, true, true));
        Assert.IsFalse(QuestLogic.CanFreePrisoner(false, true, false, false));
        
        // If the dog is present, you can free the prisoner
        Assert.IsTrue(QuestLogic.CanFreePrisoner(false, false, false, true));
        Assert.IsTrue(QuestLogic.CanFreePrisoner(false, false, true, true));
        Assert.IsTrue(QuestLogic.CanFreePrisoner(true, false, true, true));
        
        // If the prisoner is awake, you can free the prisoner
        Assert.IsTrue(QuestLogic.CanFreePrisoner(false, false, true, false));
        Assert.IsTrue(QuestLogic.CanFreePrisoner(false, false, true, true));
        Assert.IsFalse(QuestLogic.CanFreePrisoner(false, false, false, false));
        
        // As long as the knight is awake, you can't free the prisoner
        Assert.IsFalse(QuestLogic.CanFreePrisoner(true, false, true, false));
        Assert.IsFalse(QuestLogic.CanFreePrisoner(true, false, false, false));
        
    }
}