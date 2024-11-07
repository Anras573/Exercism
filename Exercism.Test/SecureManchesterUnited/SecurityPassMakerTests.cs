using Exercism.SecureManchesterUnited;

namespace Exercism.Test.SecureManchesterUnited;

[TestClass]
public class SecurityPassMakerTests
{
    [TestMethod]
    [DynamicData(nameof(StaffMembers), DynamicDataSourceType.Method)]
    public void GetDisplayName_ShouldReturnTitle_WhenStaff(Staff staff)
    {
        var expected = staff.Title;
        var actual = new SecurityPassMaker().GetDisplayName(staff);
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    [DynamicData(nameof(SecurityMembers), DynamicDataSourceType.Method)]
    public void GetDisplayName_ShouldReturnTitle_WhenSecurity(Security staff)
    {
        var expected = staff.Title;
        var actual = new SecurityPassMaker().GetDisplayName(staff);
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    [DynamicData(nameof(SecurityPriorityMembers), DynamicDataSourceType.Method)]
    public void GetDisplayName_ShouldReturnTitle_WhenSecurityPriority(Security security)
    {
        var expected = $"{security.Title} Priority Personnel";
        var actual = new SecurityPassMaker().GetDisplayName(security);
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    [DynamicData(nameof(TooImportantForSecurityPass), DynamicDataSourceType.Method)]
    public void GetDisplayName_ShouldReturnTooImportant_WhenManagerOrChairman(TeamSupport support)
    {
        const string expected = "Too Important for a Security Pass";
        var actual = new SecurityPassMaker().GetDisplayName(support);
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    [DynamicData(nameof(AllMembers), DynamicDataSourceType.Method)]
    public void GetDisplayName_ShouldReturnTitle_WhenAllMembers(TeamSupport support, string expected)
    {
        var actual = support.Title;
        Assert.AreEqual(expected, actual);
    }
    
    public static IEnumerable<object[]> StaffMembers()
    {
        yield return [new OffensiveCoach()];
        yield return [new GoalKeepingCoach()];
        yield return [new Physio()];
    }
    
    public static IEnumerable<object[]> SecurityPriorityMembers()
    {
        yield return [new Security()];
    }
    
    public static IEnumerable<object[]> SecurityMembers()
    {
        yield return [new SecurityJunior()];
        yield return [new SecurityIntern()];
        yield return [new PoliceLiaison()];
    }
    
    public static IEnumerable<object[]> TooImportantForSecurityPass()
    {
        yield return [new Manager()];
        yield return [new Chairman()];
    }
    
    public static IEnumerable<object[]> AllMembers()
    {
        yield return [new OffensiveCoach(), "Offensive Coach"];
        yield return [new GoalKeepingCoach(), "Goal Keeping Coach"];
        yield return [new Physio(), "The Physio"];
        yield return [new Security(), "Security Team Member"];
        yield return [new SecurityJunior(), "Security Junior"];
        yield return [new SecurityIntern(), "Security Intern"];
        yield return [new PoliceLiaison(), "Police Liaison Officer"];
        yield return [new Manager(), "The Manager"];
        yield return [new Chairman(), "The Chairman"];
    }
}