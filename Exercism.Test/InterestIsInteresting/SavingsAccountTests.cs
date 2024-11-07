using Exercism.InterestIsInteresting;

namespace Exercism.Test.InterestIsInteresting;

[TestClass]
public class SavingsAccountTests
{
    [TestMethod]
    [DataRow(0, 0.5f)]
    [DataRow(999, 0.5f)]
    [DataRow(1000, 1.621f)]
    [DataRow(4999, 1.621f)]
    [DataRow(5000, 2.475f)]
    [DataRow(999999, 2.475f)]
    [DataRow(-1, 3.213f)]
    [DataRow(-1000, 3.213f)]
    public void InterestRate_returns_interest_rate(int balance, float expected)
    {
        Assert.AreEqual(expected, SavingsAccount.InterestRate(balance));
    }
    
    [TestMethod]
    public void Interest_returns_interest()
    {
        Assert.AreEqual(1.00375m, SavingsAccount.Interest(200.75m));
    }
    
    [TestMethod]
    public void AnnualBalanceUpdate_returns_updated_balance()
    {
        Assert.AreEqual(201.75375m, SavingsAccount.AnnualBalanceUpdate(200.75m));
    }
    
    [TestMethod]
    public void YearsBeforeDesiredBalance_returns_years_to_reach_target_balance()
    {
        Assert.AreEqual(14, SavingsAccount.YearsBeforeDesiredBalance(200.75m, 214.88m));
    }
}