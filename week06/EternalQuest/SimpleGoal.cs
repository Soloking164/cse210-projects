using System;


public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
        }
    }

    public override string GetStatus()
    {
        return _isCompleted ? "[X]" : "[ ]";
    }

    public override int GetPoints()
    {
        return _isCompleted ? _points : 0;
    }
}
