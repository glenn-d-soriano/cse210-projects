using System;

public class Cycling : Activity
{
    public double Speed { get; set; }

    public Cycling(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        Speed = speed;
    }

    public override double GetDistance()
    {
        return (Speed * Minutes) / 60;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;  // Pace = 60 / speed
    }

    public override string GetDistanceUnits() { return "miles"; }
    public override string GetSpeedUnits() { return "mph"; }
    public override string GetPaceUnits() { return "min per mile"; }
}   
