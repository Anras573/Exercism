using Exercism.NeedForSpeed;

namespace Exercism.Test.NeedForSpeed;

[TestClass]
public class RaceTrackTests
{
    [TestMethod]
    public void TryFinishTrack_returns_true_when_car_finishes_track()
    {
        var car = new RemoteControlCar(10, 2);
        var track = new RaceTrack(100);

        var result = track.TryFinishTrack(car);

        Assert.IsTrue(result);
    }
    
    [TestMethod]
    public void TryFinishTrack_returns_false_when_car_does_not_finish_track()
    {
        var car = new RemoteControlCar(10, 20);
        var track = new RaceTrack(500);

        var result = track.TryFinishTrack(car);

        Assert.IsFalse(result);
    }
}