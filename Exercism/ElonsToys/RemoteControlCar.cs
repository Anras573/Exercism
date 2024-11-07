namespace Exercism.ElonsToys;

public class RemoteControlCar
{
    private int _batteryPercentage = 100;
    private int _distanceDrivenInMeters = 0;
    
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {_distanceDrivenInMeters} meters";

    public string BatteryDisplay()
    {
        return _batteryPercentage == 0
            ? "Battery empty"
            : $"Battery at {_batteryPercentage}%";
    }

    public void Drive()
    {
        if (_batteryPercentage == 0) return;
        
        _distanceDrivenInMeters += 20;
        _batteryPercentage--;
    }
}