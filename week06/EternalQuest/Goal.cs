using System;


public abstract class Goal
{
    protected string _name;
    protected int _points;
    protected bool _isCompleted;

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
        _isCompleted = false;
    }

    public abstract void RecordEvent();
    public abstract string GetStatus();
    public abstract int GetPoints();
    public string GetName() { return _name; }
    public bool IsCompleted() { return _isCompleted; }
}
