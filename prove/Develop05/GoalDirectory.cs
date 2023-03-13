public class GoalDirectory
{
    private int _totalPoints = 0;

    private List<Goal> _goals = new List<Goal>();



    public void LoadFromFile(string fileName)
    {
        string[] goalText = System.IO.File.ReadAllLines(fileName);
        bool firstLoop = true;
        foreach (string goalTextRepresentation in goalText)
        {
            string[] goalInformation = goalTextRepresentation.Split("~`~");
            string goalType = goalInformation[0];

            if (firstLoop)
            {
                firstLoop = false;
                _totalPoints = int.Parse(goalTextRepresentation);
            }

            if (goalType == "Simple")
            {
                SimpleGoal simpleGoal = new SimpleGoal();
                simpleGoal.CreateGoal(goalTextRepresentation);
                _goals.Add(simpleGoal);
            }
            else if (goalType == "Checklist")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal();
                checklistGoal.CreateGoal(goalTextRepresentation);
                _goals.Add(checklistGoal);
            }
            else if (goalType == "Eternal")
            {
                EternalGoal eternalGoal = new EternalGoal();
                eternalGoal.CreateGoal(goalTextRepresentation);
                _goals.Add(eternalGoal);
            }
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter file = new StreamWriter(fileName))
        {
            file.WriteLine(_totalPoints);
            foreach (Goal goal in _goals)
            {
                file.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public int GetPointTotal()
    {
        return _totalPoints;
    }

    public void UpdatePointTotal(int points)
    {
        _totalPoints += points;
    }
}