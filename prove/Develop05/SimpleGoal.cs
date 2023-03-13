public class SimpleGoal: Goal
{
    private bool _goalCompleted = false;

    private int _pointValue;

    



    public SimpleGoal(string goalName, string goalDescription, int pointValue): base(goalName, goalDescription)
    {
        _pointValue = pointValue;
        _goalType = "Simple";
    }

    public SimpleGoal()
    {
        _goalType = "Simple";
    }



    public override int RecordEvent()
    {
        if (!_goalCompleted)
        {
            _goalCompleted = true;
            return _pointValue;
        }
        else
        {
            return 0;
        }
    }

    public override bool IsCompleted()
    {
        return _goalCompleted;
    }

    public override string GetStringRepresentation()
    {
        return $"{_goalType}~`~{_goalName}~`~{_goalDescription}~`~{_pointValue}~`~{_goalCompleted}";
    }

    public override string GetDisplayString()
    {
        if (!_goalCompleted)
        {
            return $"[ ] {_goalName} ({_goalDescription})";
        }
        else
        {
            return $"[x] {_goalName} ({_goalDescription})";
        }
    }

    public override void CreateGoal(string goalStringRepresentation)
    {
        string[] goalInformation = goalStringRepresentation.Split("~`~");
        _goalName = goalInformation[1];
        _goalDescription = goalInformation[2];
        _pointValue = int.Parse(goalInformation[3]);
        _goalCompleted = bool.Parse(goalInformation[4]);
    }
}