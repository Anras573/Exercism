namespace Exercism.NeedForSpeed;

public class RemoteControlCar(int speed, int batteryDrain)
{
    private int _distanceDriven = 0;
    private int _batteryPercentage = 100;

    public bool BatteryDrained() => _batteryPercentage < batteryDrain;

    public int DistanceDriven() => _distanceDriven;

    public void Drive()
    {
        if (BatteryDrained()) return;
        
        _distanceDriven += speed;
        _batteryPercentage -= batteryDrain;
    }

    public static RemoteControlCar Nitro() => new (50, 4);
}