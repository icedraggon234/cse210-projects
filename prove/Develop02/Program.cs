using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();




        string optionSelected;

        Console.WriteLine("Welcome to the journal program, for all your journaling needs.");
        do
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Add entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal contents to file");
            Console.WriteLine("4. Load journal contents from file");
            Console.WriteLine("5. Quit");
            Console.Write("Type your option here: ");
            optionSelected = Console.ReadLine();
            Console.Clear();

            if (new string[] {"1", "add entry"}.Contains(optionSelected.ToLower()))
            {
                string prompt = promptGenerator.GetPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                Entry entry = new Entry();
                entry._entry = response;
                entry._prompt = prompt;
                DateTime currentDate = DateTime.Now;
                entry._dateMade = currentDate.ToShortDateString();
                journal.AddEntry(entry);
            }

            if (new string[] {"2", "display journal"}.Contains(optionSelected.ToLower()))
            {
                journal.DisplayEntries();
            }

            if (new string[] {"3", "save journal contents to file"}.Contains(optionSelected.ToLower()))
            {
                Console.Write("Enter file name to save to: ");
                journal.SaveToFile(Console.ReadLine());
            }

            if (new string[] {"4", "load journal contents from file"}.Contains(optionSelected.ToLower()))
            {
                Console.Write("Enter file name to load from: ");
                journal.LoadFromFile(Console.ReadLine());
            }


            Console.Clear();

        } while (! new string[] {"5", "quit"}.Contains(optionSelected.ToLower()));  
    }

    
}