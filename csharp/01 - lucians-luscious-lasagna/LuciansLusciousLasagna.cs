using System.Timers;

class Lasagna
{
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int ElapsedTime) => ExpectedMinutesInOven() - ElapsedTime;


    public int PreparationTimeInMinutes(int Layers) => 2 * Layers;

    public int ElapsedTimeInMinutes(int Layers, int ElapsedTime) => PreparationTimeInMinutes(Layers) + ElapsedTime;

}
