public class Entry
{
    public string _dateMade;
    public string _prompt;
    public string _entry;


    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_dateMade}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine(_entry);
    }
}