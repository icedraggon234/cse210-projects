using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();
        
        string menuChoice = "";

        while (!new string[] {"quit", "4"}.Contains(menuChoice.ToLower()))
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            menuChoice = Console.ReadLine();
            Console.Clear();

            if (new string[] {"1", "breathing activity", "start breathing activity"}.Contains(menuChoice.ToLower()))
            {
                breathingActivity.StartActivity();
            }
            else if (new string[] {"2", "reflecting activity", "start reflecting activity"}.Contains(menuChoice.ToLower()))
            {
                reflectingActivity.StartActivity();
            }
            else if (new string[] {"3", "listing activity", "start listing activity"}.Contains(menuChoice.ToLower()))
            {
                listingActivity.StartActivity();
            }
            
        }

    }
}


