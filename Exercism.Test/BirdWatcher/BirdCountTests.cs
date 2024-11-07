using Exercism.BirdWatcher;

namespace Exercism.Test.BirdWatcher;

[TestClass]
public class BirdCountTests
{
    [TestMethod]
    public void LastWeek_returns_array_of_last_7_elements()
    {
        int[] expected = [0, 2, 5, 3, 7, 8, 4];
        CollectionAssert.AreEqual(expected, BirdCount.LastWeek());
    }
    
    [TestMethod]
    public void Today_returns_last_element_of_array()
    {
        var birdCount = new BirdCount([1, 2, 3, 4, 5]);
        Assert.AreEqual(5, birdCount.Today());
    }
    
    [TestMethod]
    public void IncrementTodaysCount_increments_last_element_of_array()
    {
        var birdCount = new BirdCount([1, 2, 3, 4, 5]);
        birdCount.IncrementTodaysCount();
        Assert.AreEqual(6, birdCount.Today());
    }
    
    [TestMethod]
    public void HasDayWithoutBirds_returns_true_if_array_contains_zero()
    {
        var birdCount = new BirdCount([1, 2, 3, 0, 5]);
        Assert.IsTrue(birdCount.HasDayWithoutBirds());
    }
    
    [TestMethod]
    public void HasDayWithoutBirds_returns_false_if_array_does_not_contain_zero()
    {
        var birdCount = new BirdCount([1, 2, 3, 4, 5]);
        Assert.IsFalse(birdCount.HasDayWithoutBirds());
    }
    
    [TestMethod]
    public void CountForFirstDays_returns_sum_of_first_n_elements()
    {
        var birdCount = new BirdCount([1, 2, 3, 4, 5]);
        Assert.AreEqual(6, birdCount.CountForFirstDays(3));
    }
    
    [TestMethod]
    public void BusyDays_returns_number_of_days_where_bird_count_is_greater_than_or_equal_to_5()
    {
        var birdCount = new BirdCount([1, 2, 3, 4, 5, 6, 7, 8, 9]);
        Assert.AreEqual(5, birdCount.BusyDays());
    }
}