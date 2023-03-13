public class ChecklistGoal: Goal
{
    private int _timesCompleted = 0;

    private int _individualCompletionPointValue;

    private int _completedPointValue;

    private int _individualCompletionsToFullyComplete;



    public ChecklistGoal(string goalName, string goalDescription, int individualCompletionPointValue, int completedPointValue, int individualCompletionsToFullyComplete): base(goalName, goalDescription)
    {
        _individualCompletionPointValue = individualCompletionPointValue;
        _completedPointValue = completedPointValue;
        _individualCompletionsToFullyComplete = individualCompletionsToFullyComplete;
        _goalType = "Checklist";
    }

    public ChecklistGoal()
    {
        _goalType = "Checklist";
    }



    public override int RecordEvent()
    {
        if (_timesCompleted == _individualCompletionsToFullyComplete)
        {
            return 0;
        }
        if (_timesCompleted + 1 == _individualCompletionsToFullyComplete)
        {
            _timesCompleted++;
            return _individualCompletionPointValue + _completedPointValue;
        }
        else
        {
            _timesCompleted++;
            return _individualCompletionPointValue;
        }
    }

    public override bool IsCompleted()
    {
        if (_timesCompleted >= _individualCompletionsToFullyComplete)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"{_goalType}~`~{_goalName}~`~{_goalDescription}~`~{_timesCompleted}~`~{_individualCompletionPointValue}~`~{_completedPointValue}~`~{_individualCompletionsToFullyComplete}";
    }

    public override string GetDisplayString()
    {
        if (!IsCompleted())
        {
            return $"[ ] {_goalName} ({_goalDescription}) -- Currently completed: {_timesCompleted}/{_individualCompletionsToFullyComplete}";
        }
        else
        {
            return $"[x] {_goalName} ({_goalDescription}) -- Currently completed: {_timesCompleted}/{_individualCompletionsToFullyComplete}";
        }
    }

    public override void CreateGoal(string goalStringRepresentation)
    {
        string[] goalInformation = goalStringRepresentation.Split("~`~");
        _goalName = goalInformation[1];
        _goalDescription = goalInformation[2];
        _timesCompleted = int.Parse(goalInformation[3]);
        _individualCompletionPointValue = int.Parse(goalInformation[4]);
        _completedPointValue = int.Parse(goalInformation[5]);
        _individualCompletionsToFullyComplete = int.Parse(goalInformation[6]);
    }
}