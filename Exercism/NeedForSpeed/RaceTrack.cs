namespace Exercism.NeedForSpeed;

public class RaceTrack(int distance)
{
    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (car.DistanceDriven() < distance && !car.BatteryDrained())
        {
            car.Drive();
        }

        return car.DistanceDriven() >= distance;
    }
}