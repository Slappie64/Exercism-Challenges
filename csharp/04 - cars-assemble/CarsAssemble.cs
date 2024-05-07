using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        switch (speed)
        {
            case 0:
                return 0.00;
                break;
            case 1: case 2: case 3: case 4:
                return 1.00;
                break;
            case 5: case 6: case 7: case 8:
                return 0.90;
                break;
            case 9:
                return 0.80;
                break;
            case 10:
                return 0.77;
                break;
            default:
                return 0;
                break;
        }
    }
    
    public static double ProductionRatePerHour(int speed) => ((double)221 * speed)*SuccessRate(speed)

    public static int WorkingItemsPerMinute(int speed) => (int)(ProductionRatePerHour(speed))/60;

}