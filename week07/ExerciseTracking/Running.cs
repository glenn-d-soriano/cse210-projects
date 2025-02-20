using System;

public class Running : Activity
{
    public double Distance { get; set; } 
    
    public Running(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60;  // Speed = distance / time * 60
    }

    public override double GetPace()
    {
        return Minutes / GetDistance();  // Pace = time / distance
    }

    // Get units for running (miles, mph, and min per mile)
    public override string GetDistanceUnits() { return "miles"; }
    public override string GetSpeedUnits() { return "mph"; }
    public override string GetPaceUnits() { return "min per mile"; }
} 