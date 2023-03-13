public abstract class Goal
{
    protected string _goalName;

    protected string _goalDescription;

    protected string _goalType;



    protected Goal(string goalName, string goalDescription)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
    }

    protected Goal()
    {
        
    }




    public abstract int RecordEvent();

    public abstract bool IsCompleted();

    public abstract string GetStringRepresentation();

    public abstract string GetDisplayString();

    public string GetGoalName()
    {
        return _goalName;
    }

    public abstract void CreateGoal(string goalStringRepresentation);
}