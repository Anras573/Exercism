using Exercism.FootballMatchReports;

namespace Exercism.Test.FootballMatchReports;

[TestClass]
public class PlayAnalyzerTests
{
    [TestMethod]
    [DataRow(1, "goalie")]
    [DataRow(2, "left back")]
    [DataRow(3, "center back")]
    [DataRow(4, "center back")]
    [DataRow(5, "right back")]
    [DataRow(6, "midfielder")]
    [DataRow(7, "midfielder")]
    [DataRow(8, "midfielder")]
    [DataRow(9, "left wing")]
    [DataRow(10, "striker")]
    [DataRow(11, "right wing")]
    public void AnalyzeOnField_ShirtNumber_ReturnsPosition(int shirtNum, string expected)
    {
        Assert.AreEqual(expected, PlayAnalyzer.AnalyzeOnField(shirtNum));
    }
    
    [TestMethod]
    [DataRow(0)]
    [DataRow(12)]
    public void AnalyzeOnField_InvalidShirtNumber_ThrowsArgumentOutOfRangeException(int shirtNum)
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => PlayAnalyzer.AnalyzeOnField(shirtNum));
    }
    
    [TestMethod]
    [DataRow("The match has been cancelled due to heavy rain.")]
    [DataRow("The match has been cancelled due to a waterlogged pitch.")]
    [DataRow("The match has been cancelled due to a fire in the stadium.")]
    public void AnalyzeOffField_Announcement_ReturnsAnnouncement(string announcement)
    {
        Assert.AreEqual(announcement, PlayAnalyzer.AnalyzeOffField(announcement));
    }
    
    [TestMethod]
    [DataRow(100, "There are 100 supporters at the match.")]
    [DataRow(1, "There are 1 supporters at the match.")]
    [DataRow(0, "There are 0 supporters at the match.")]
    public void AnalyzeOffField_Supporters_ReturnsSupporters(int supporters, string expected)
    {
        Assert.AreEqual(expected, PlayAnalyzer.AnalyzeOffField(supporters));
    }
    
    [TestMethod]
    public void AnalyzeOffField_InvalidReport_ThrowsArgumentException()
    {
        Assert.ThrowsException<ArgumentException>(() => PlayAnalyzer.AnalyzeOffField(new object()));
    }
    
    [TestMethod]
    public void AnalyzeOffField_Foul_ReturnsFoulDescription()
    {
        var foul = new Foul();
        Assert.AreEqual("The referee deemed a foul.", PlayAnalyzer.AnalyzeOffField(foul));
    }
    
    [TestMethod]
    public void AnalyzeOffField_Injury_ReturnsInjuryDescription()
    {
        var injury = new Injury(10);
        Assert.AreEqual("Oh no! Player 10 is injured. Medics are on the field.", PlayAnalyzer.AnalyzeOffField(injury));
    }
    
    [TestMethod]
    public void AnalyzeOffField_Incident_ReturnsIncidentDescription()
    {
        var incident = new Incident();
        Assert.AreEqual("An incident happened.", PlayAnalyzer.AnalyzeOffField(incident));
    }
    
    [TestMethod]
    public void AnalyzeOffField_Manager_ReturnsManagerName()
    {
        var manager = new Manager("Pep Guardiola", null);
        Assert.AreEqual("Pep Guardiola", PlayAnalyzer.AnalyzeOffField(manager));
    }
    
    [TestMethod]
    public void AnalyzeOffField_ManagerWithClub_ReturnsManagerNameAndClub()
    {
        var manager = new Manager("Pep Guardiola", "Manchester City");
        Assert.AreEqual("Pep Guardiola (Manchester City)", PlayAnalyzer.AnalyzeOffField(manager));
    }
}