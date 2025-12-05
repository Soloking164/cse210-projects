using System;


public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints) : base(name, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        _currentCount++;
        if (_currentCount >= _targetCount)
        {
            _isCompleted = true;
        }
    }

    public override string GetStatus()
    {
        return $"Completed {_currentCount}/{_targetCount} times";
    }

    public override int GetPoints()
    {
        int points = _points * _currentCount;
        if (_isCompleted)
        {
            points += _bonusPoints;
        }
        return points;
    }
}
