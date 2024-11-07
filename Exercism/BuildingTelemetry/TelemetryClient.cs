namespace Exercism.BuildingTelemetry;

public class TelemetryClient(RemoteControlCar car)
{
    public string GetBatteryUsagePerMeter(int serialNum)
    {
        var noData = !car
            .GetTelemetryData(ref serialNum, out var batteryPercentage, out var distanceDrivenInMeters)
                     || distanceDrivenInMeters == 0;
        
        if (noData) return "no data";
        
        var usagePerMeter = (100 - batteryPercentage) / distanceDrivenInMeters;
        
        return $"usage-per-meter={usagePerMeter}";
    }
}