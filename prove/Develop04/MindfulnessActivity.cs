public class MindfulnessActivity
{
    protected int _timeForActivity;
    protected string _activityName;
    protected string _activityDescription;



    protected void PauseCountDown(int time, string pauseMessage = "")
    {
        Console.Write(pauseMessage);
        for (; time != 0; time--)
        {
            Console.Write(time);
            Thread.Sleep(1000);
            
            foreach (char i in time.ToString())
            {
                Console.Write("\b \b");
            }
        }
        Console.WriteLine();
    }

    protected void PauseAnimation(int time, string pauseMessage = "")
    {
        Console.Write(pauseMessage);
        for (; time != 0; time--)
        {
            Console.Write(".");
            Thread.Sleep(333);
            Console.Write("\b \b");

            Console.Write("o");
            Thread.Sleep(333);
            Console.Write("\b \b");

            Console.Write("O");
            Thread.Sleep(333);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    protected string GetFormatedStartMessage()
    {
        return $"Welcome to the {_activityName}.\n\n{_activityDescription}\n\nHow long, in seconds, would you like for your session?";
    }

    protected string RandomItemSelection(string[] backUp, List<string> list)
    {
        Random random = new Random();

        if (list.Count <= 0)
        {
            list.AddRange(backUp);
        }

        int randomSelectedIndex = random.Next(list.Count);
        string randomSelection = list[randomSelectedIndex];
        list.RemoveAt(randomSelectedIndex);

        return randomSelection;
    }
}