public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity()
    {
        _activityName = "Breathing Activity";
        _activityDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void StartActivity()
    {
        Console.Write(GetFormatedStartMessage() + " (in intervals of 10) ");
        _timeForActivity = int.Parse(Console.ReadLine());
        Console.Clear();
        
        Console.WriteLine("GetReady...");
        PauseAnimation(5);

        DateTime activityEndTime = DateTime.Now.AddSeconds(_timeForActivity);

        while (DateTime.Now < activityEndTime)
        {
            Console.Clear();
            PauseCountDown(6, "Breathe in...");
            PauseCountDown(4, "Breathe out...");
        }

        Console.Clear();
        Console.WriteLine("Well Done!");
        PauseAnimation(5);
        Console.WriteLine($"You have completed another {_timeForActivity} seconds of the {_activityName}.");
        PauseAnimation(5);
    }
}
