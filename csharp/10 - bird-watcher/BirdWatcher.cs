using System;

class BirdCount
{
    private int[] birdsPerDay;
    private static int[] birdsLastWeek = {0, 2, 5, 3, 7, 8, 4};

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => birdsLastWeek;
    

    public int Today() => birdsPerDay[^1];


    public void IncrementTodaysCount() => birdsPerDay[^1]++;

    public bool HasDayWithoutBirds() => birdsPerDay.Contains(0);

    public int CountForFirstDays(int numberOfDays)
    {
        int birdsForFirstDays = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            birdsForFirstDays += birdsPerDay[i];
        }
        return birdsForFirstDays;
    }

    public int BusyDays()
    {
        int busyDaysCount = 0;
        for (int i = 0; i < birdsPerDay.Length; i++)
        {
            if (birdsPerDay[i] >= 5)
            {
                busyDaysCount += 1;
            }
        }
        return busyDaysCount;
    }
}
