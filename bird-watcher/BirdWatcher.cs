using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => [0, 2, 5, 3, 7, 8, 4];

    public int Today() => birdsPerDay[6];

    public void IncrementTodaysCount() => birdsPerDay[6]++;

    public bool HasDayWithoutBirds()
    {
        foreach (int dayCount in birdsPerDay)
        {
            if (dayCount == 0)
            {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int tally = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            tally += birdsPerDay[i];
        }
        return tally;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        foreach (int dayCount in birdsPerDay)
        {
            if (dayCount >= 5)
            {
                busyDays++;
            }
        }
        return busyDays;
    }
}
