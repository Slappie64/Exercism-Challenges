using System;
using System.Linq;

class BirdCount
{
    private int[] birdsPerDay;
    

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() 
    {
        int[] _lastWeek = {0, 2, 5, 3, 7, 8, 4};
        return _lastWeek;
    }

    public int Today() => birdsPerDay[^1];

    public void IncrementTodaysCount() => birdsPerDay[^1] += 1;

    public bool HasDayWithoutBirds() => birdsPerDay.Contains(0);


    public int CountForFirstDays(int numberOfDays)
    {
        int birdSum = 0;
        for (int day = 0; day < numberOfDays; day++)
        {
            birdSum += birdsPerDay[day];
        }
        return birdSum;
    }

    public int BusyDays() => birdsPerDay.Count(day => day >= 5);
}