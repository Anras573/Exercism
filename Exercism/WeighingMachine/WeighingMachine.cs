namespace Exercism.WeighingMachine;

public class WeighingMachine(int precision)
{
    public int Precision { get; } = precision;

    private double _weight;
    public double Weight
    {
        get => _weight;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Weight cannot be negative");
            }
            
            _weight = value;
        }
    }

    public string DisplayWeight
    {
        get
        {
            var displayWeight = Math.Round(Weight - TareAdjustment, Precision);
            return $"{displayWeight.ToString("F" + Precision)} kg";
        }
    }

    public double TareAdjustment { get; set; } = 5;
}