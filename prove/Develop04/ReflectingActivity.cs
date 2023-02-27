public class ReflectingActivity : MindfulnessActivity
{
    private List<string> _prompts = new List<string> 
    { 
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _reflectiveQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private string[] _promptsBackup;

    private string[] _reflectiveQuestionsBackup;   

    public ReflectingActivity()
    {
        _activityName = "Reflecting Activity";
        _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _promptsBackup = _prompts.ToArray();
        _reflectiveQuestionsBackup = _reflectiveQuestions.ToArray();
    }

    public void StartActivity()
    {
        Console.Write(GetFormatedStartMessage() + " (in intervals of 15) ");
        _timeForActivity = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("GetReady...");
        PauseAnimation(5);

        Console.WriteLine("Consider the following prompt:\n");

        string randomPrompt = RandomItemSelection(_promptsBackup, _prompts);

        Console.WriteLine($"--- {randomPrompt} ---\n");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        PauseCountDown(5, "You may begin in: ");
        DateTime activityEndTime = DateTime.Now.AddSeconds(_timeForActivity);
        Console.Clear();

        string randomReflectiveQuestion;

        while (DateTime.Now < activityEndTime)
        {
            randomReflectiveQuestion = RandomItemSelection(_reflectiveQuestionsBackup, _reflectiveQuestions);
            PauseAnimation(15, $"{randomReflectiveQuestion} ");
        }

        Console.WriteLine("\nWell Done!");
        PauseAnimation(5);
        Console.WriteLine($"You have completed another {_timeForActivity} seconds of the {_activityName}.");
        PauseAnimation(5);
        


    }
}