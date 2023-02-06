public class PromptGenerator
{
    public List<string> prompts = new List<string>
    {
        
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "What was your biggest challenge today?",
    "What do you feel proud about accomplishing today?",
    "What made you feel grateful today?",
    "What made you laugh today?",
    "What made you think today?"
    };
    
    Random randomGenerator = new Random();

    public string GetPrompt()
    {
        string prompt = prompts[randomGenerator.Next(prompts.Count)];
        return prompt;
    }

    
}