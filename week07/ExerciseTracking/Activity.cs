using System;

public class Activity
{
    public DateTime Date { get; set; }
    public int Minutes { get; set; }
    public Activity(DateTime date, int minutes)
    {
        Date = date;
        Minutes = minutes;
    }

    public virtual double GetDistance ()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")} {this.GetType().Name} ({Minutes} min) - " +
               $"Distance: {GetDistance():0.0} {GetDistanceUnits()}, " +
               $"Speed: {GetSpeed():0.0} {GetSpeedUnits()}, " +
               $"Pace: {GetPace():0.0} {GetPaceUnits()}";
    }

    // Helper methods to get units for distance, speed, and pace
    public virtual string GetDistanceUnits() { return ""; }
    public virtual string GetSpeedUnits() { return ""; }
    public virtual string GetPaceUnits() { return ""; }
}
