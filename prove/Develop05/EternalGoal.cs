public class EternalGoal: Goal
{
    private int _timesCompleted = 0;

    private int _pointValuePerCompletion;



    public EternalGoal(string goalName, string goalDescription, int pointValuePerCompletion): base(goalName, goalDescription)
    {
        _pointValuePerCompletion = pointValuePerCompletion;
        _goalType = "Eternal";
    }

    public EternalGoal()
    {
        _goalType = "Eternal";
    }


    
    public override int RecordEvent()
    {
        _timesCompleted++;
        return _pointValuePerCompletion;
    }

    public override bool IsCompleted()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{_goalType}~`~{_goalName}~`~{_goalDescription}~`~{_pointValuePerCompletion}~`~{_timesCompleted}";
    }

    public override string GetDisplayString()
    {
        return $"[ ] {_goalName} ({_goalDescription}) -- Currently completed: {_timesCompleted}/\u221E";
    }

    public override void CreateGoal(string goalStringRepresentation)
    {
        string[] goalInformation = goalStringRepresentation.Split("~`~");
        _goalName = goalInformation[1];
        _goalDescription = goalInformation[2];
        _pointValuePerCompletion = int.Parse(goalInformation[3]);
        _timesCompleted = int.Parse(goalInformation[4]);
    }
}