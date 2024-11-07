namespace Exercism.LuciansLusciousLasagna;

public class Lasagna
{
    public int ExpectedMinutesInOven() => 40;
    public int RemainingMinutesInOven(int elapsed) => ExpectedMinutesInOven() - elapsed;
    public int PreparationTimeInMinutes(int layers) => layers * 2;
    public int ElapsedTimeInMinutes(int layers, int timeInOven) => timeInOven + PreparationTimeInMinutes(layers);
}