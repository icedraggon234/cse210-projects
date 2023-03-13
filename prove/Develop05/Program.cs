using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        GoalDirectory goalDirectory = new GoalDirectory();

        string menuChoice = "";

        while (!new string[] {"quit", "6"}.Contains(menuChoice.ToLower()))
        {
            Console.Clear();

            Console.WriteLine($"You have {goalDirectory.GetPointTotal()} points.\n");

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            menuChoice = Console.ReadLine();

            if (new string[] {"1", "create new goal"}.Contains(menuChoice.ToLower()))
            {
                Console.Clear();

                Console.WriteLine("The types of goals are:");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string goalChoice = Console.ReadLine();
                Console.WriteLine();

                if (new string[] {"1", "simple goal", "simple"}.Contains(goalChoice.ToLower()))
                {
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string goalDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int pointValue = int.Parse(Console.ReadLine());

                    goalDirectory.AddGoal(new SimpleGoal(goalName, goalDescription, pointValue));
                }
                else if (new string[] {"2", "eternal goal", "eternal"}.Contains(goalChoice.ToLower()))
                {
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string goalDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int pointValue = int.Parse(Console.ReadLine());

                    goalDirectory.AddGoal(new EternalGoal(goalName, goalDescription, pointValue));
                }
                else if (new string[] {"3", "checklist goal", "checklist"}.Contains(goalChoice.ToLower()))
                {
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string goalDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int individualCompletionPointValue = int.Parse(Console.ReadLine());
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int individualCompletionsToFullyComplete = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int completedPointValue = int.Parse(Console.ReadLine());

                    goalDirectory.AddGoal(new ChecklistGoal(goalName, goalDescription, individualCompletionPointValue, completedPointValue, individualCompletionsToFullyComplete));
                }
            }
            else if (new string[] {"2", "list goals"}.Contains(menuChoice.ToLower()))
            {
                string pageNavigation = "";
                int pageNumber = 1;
                int pageCount = goalDirectory.GetGoals().Count / 5;

                if (goalDirectory.GetGoals().Count % 5 > 0)
                {
                    pageCount++;
                }

                while (!new string[] {"quit", "exit"}.Contains(pageNavigation.ToLower()))
                {
                    int goalNumber = 1;   
                    Console.Clear();

                    foreach (Goal goal in goalDirectory.GetGoals())
                    {
                        if (goalNumber > (pageNumber-1) * 5 && goalNumber <= pageNumber * 5)
                        {
                            Console.WriteLine($"{goalNumber}. {goal.GetDisplayString()}");
                        }

                        goalNumber++;
                    }



                    Console.WriteLine($"\nPage {pageNumber} of {pageCount}");
                    Console.WriteLine("Enter 'next' to go to the next page, 'prev' to go back a page, 'pg #' to go to pg #, and exit to leave:");
                    pageNavigation = Console.ReadLine();

                    if (pageNavigation.ToLower() == "next")
                    {
                        pageNumber++;
                    }
                    else if (pageNavigation.ToLower() == "prev")
                    {
                        pageNumber--;
                    }
                    else if (new string[] {"page", "pg"}.Contains(pageNavigation.Split()[0].ToLower()))
                    {
                        pageNumber = int.Parse(pageNavigation.Split()[1]);
                    }
                }
            }
            else if (new string[] {"3", "save goals"}.Contains(menuChoice.ToLower()))
            {
                Console.WriteLine("\n What is the filename for the goal file? ");
                string filename = Console.ReadLine();

                if (filename.Length < 5)
                {
                    filename += ".txt";
                }
                else if (filename.Substring(filename.Length-4) != ".txt")
                {
                    filename += ".txt";
                }

                goalDirectory.SaveToFile(filename);
            }
            else if (new string[] {"4", "load goals"}.Contains(menuChoice.ToLower()))
            {
                Console.WriteLine("\n What is the filename for the goal file? ");
                string filename = Console.ReadLine();

                if (filename.Length < 5)
                {
                    filename += ".txt";
                }
                else if (filename.Substring(filename.Length-4) != ".txt")
                {
                    filename += ".txt";
                }

                goalDirectory.LoadFromFile(filename);
            }
            else if (new string[] {"5", "record event"}.Contains(menuChoice.ToLower()))
            {
                string pageNavigation = "";
                int pageNumber = 1;
                int pageCount = goalDirectory.GetGoals().Count / 5;
                int goalSelection;

                if (goalDirectory.GetGoals().Count % 5 > 0)
                {
                    pageCount++;
                }

                while (!new string[] {"exit", "quit"}.Contains(pageNavigation.ToLower()))
                {
                    Console.Clear();
                    int goalNumber = 1;

                    foreach (Goal goal in goalDirectory.GetGoals())
                    {
                        if (goalNumber > (pageNumber-1) * 5 && goalNumber <= pageNumber * 5)
                        {
                            Console.WriteLine($"{goalNumber}. {goal.GetGoalName()}");
                        }

                        goalNumber++;
                    }

                    Console.WriteLine($"Page {pageNumber} of {pageCount}");
                    Console.WriteLine("Enter 'next' to go to the next page, 'prev' to go back a page, 'pg #' to go to pg #, and exit to leave");
                    Console.WriteLine("Enter '#' to update the coresponding goal:");
                    pageNavigation = Console.ReadLine();

                    if (int.TryParse(pageNavigation, out goalSelection))
                    {
                        goalDirectory.UpdatePointTotal(goalDirectory.GetGoals()[goalSelection-1].RecordEvent());
                        break;
                    }
                    else if (pageNavigation.ToLower() == "next")
                    {
                        pageNumber++;
                    }
                    else if (pageNavigation.ToLower() == "prev")
                    {
                        pageNumber--;
                    }
                    else if (new string[] {"pg", "page"}.Contains(pageNavigation.Split()[0].ToLower()))
                    {
                        pageNumber = int.Parse(pageNavigation.Split()[1]);
                    }
                }
            }
        }
    }
}