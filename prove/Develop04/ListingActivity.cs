public class ListingActivity : MindfulnessActivity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private string[] _promptsBackup;



    public ListingActivity()
    {
        _activityName = "Listing Activity";
        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _promptsBackup = _prompts.ToArray();
    }



    public void StartActivity()
    {
        Random random = new Random();

        Console.Write(GetFormatedStartMessage() + " ");
        _timeForActivity = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("GetReady...");
        PauseAnimation(5);

        string randomPrompt = RandomItemSelection(_promptsBackup, _prompts);

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"\n--- {randomPrompt} ---\n");
        PauseCountDown(5, "You may begin in: ");
        Console.WriteLine();

        DateTime activityEndTime = DateTime.Now.AddSeconds(_timeForActivity);

        int itemsListed = 0; 

        while (DateTime.Now < activityEndTime)
        {
            string item = Console.ReadLine();

            if (item != "")
            {
                itemsListed++;
            }
        }

        Console.WriteLine($"You listed {itemsListed} items!");
        PauseAnimation(5, "\nWell done!\n");
        PauseAnimation(5, $"You have completed another {_timeForActivity} seconds of the {_activityName}.\n");
    }
}