using System;

public class Swimming : Activity
{
    public int Laps { get; set; }

    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return (Laps * 50 / 1000.0); 
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60;
    }

    public override double GetPace()
    {
        return Minutes / GetDistance();  // Pace = time / distance
    }

    // Get units for swimming (km, kph, and min per km)
    public override string GetDistanceUnits() { return "km"; }
    public override string GetSpeedUnits() { return "kph"; }
    public override string GetPaceUnits() { return "min per km"; }        
}   