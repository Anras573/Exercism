namespace Exercism.CarsAssemble;

public static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        return speed switch
        {
            0 => 0.0,
            >= 1 and <= 4 => 1.0,
            >= 5 and <= 8 => 0.9,
            9 => 0.8,
            10 => 0.77,
            _ => 0.0
        };
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        const int carsPerHour = 221;
        return speed * carsPerHour * SuccessRate(speed);
    }
    
    public static int WorkingItemsPerMinute(int speed) => (int)(ProductionRatePerHour(speed) / 60);
}