using System;

public class Cycling : Activity
{
    private double _averageSpeedInKph;

    public Cycling(string date, int lengthInMinutes, double averageSpeedInKph) 
        : base(date, lengthInMinutes)
    {
        _averageSpeedInKph = averageSpeedInKph;
    }

    public override double GetDistance()
    {
        return (_averageSpeedInKph * GetLengthInMinutes()) / 60;
    }

    public override double GetSpeed()
    {
        return _averageSpeedInKph;
    }

    public override double GetPace()
    {
        return 60 / _averageSpeedInKph;
    }
}
