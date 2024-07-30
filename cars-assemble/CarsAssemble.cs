using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed) => speed switch
    {
        0 => 0.00,
        >= 1 and <= 4 => 1.00,
        >= 5 and <= 8 => 0.90,
        9 => 0.80,
        10 => 0.77
    };
    
    public static double ProductionRatePerHour(int speed) => 221 * speed * AssemblyLine.SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => (int)Math.Floor(AssemblyLine.ProductionRatePerHour(speed) / 60);
}
