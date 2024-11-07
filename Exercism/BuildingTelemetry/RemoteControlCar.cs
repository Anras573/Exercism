namespace Exercism.BuildingTelemetry;

public class RemoteControlCar
{
    private int _batteryPercentage = 100;
    private int _distanceDrivenInMeters = 0;
    private string[] _sponsors = Array.Empty<string>();
    private int _latestSerialNum = 0;

    public void Drive()
    {
        if (_batteryPercentage <= 0) return;
        
        _batteryPercentage -= 10;
        _distanceDrivenInMeters += 2;
    }

    public void SetSponsors(params string[] sponsors) => _sponsors = sponsors;

    public string DisplaySponsor(int sponsorNum)
    {
        if (sponsorNum < 0 || sponsorNum >= _sponsors.Length)
        {
            return "No sponsor found";
        }
        return _sponsors[sponsorNum];
    }

    public bool GetTelemetryData(ref int serialNum, out int batteryPercentage, out int distanceDrivenInMeters)
    {
        var hasTelemetryData = serialNum >= _latestSerialNum;
        
        if (!hasTelemetryData)
        {
            serialNum = _latestSerialNum;
            batteryPercentage = -1;
            distanceDrivenInMeters = -1;

            return false;
        }
        
        _latestSerialNum = serialNum;
        batteryPercentage = _batteryPercentage;
        distanceDrivenInMeters = _distanceDrivenInMeters;

        return true;
    }

    public static RemoteControlCar Buy() => new();
}