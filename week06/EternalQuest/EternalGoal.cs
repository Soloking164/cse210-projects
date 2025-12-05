using System;


public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        // No implementation needed
    }

    public override string GetStatus()
    {
        return "[ ]";
    }

    public override int GetPoints()
    {
        return _points;
    }
}
