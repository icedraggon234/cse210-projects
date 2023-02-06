public class Journal 
{
    public List<Entry> _entries = new List<Entry>();


    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }


    public void DisplayEntries()
    {
        // Instead of just running the .Display method for each entry this makes a menu system which displays 3 entries at a time 
        // and lets the user choose which page of 3 entires to show
        int pages = _entries.Count / 3;
        if (_entries.Count % 3 > 0)
        {
            ++pages;
        }

        int page = 1;
        string pageNavigation;
        do
        {
            int timesLooped = 1; 
            foreach (Entry entry in _entries)
            {
                // this determines what entries to show based on the current page number
                if (timesLooped > (page - 1) * 3 && timesLooped <= page * 3)
                {
                    entry.DisplayEntry();
                    Console.WriteLine("\n\n");
                }
                timesLooped++;
            }
            
            // this lets the user change the page number and exit the menu when they would like to
            Console.WriteLine($"Page {page} of {pages}.");
            Console.WriteLine("Type next for next page, prev for previous page, pg # for page #, and exit to exit.");
            pageNavigation = Console.ReadLine();

            if (pageNavigation.ToLower() == "next")
            {
                page++;
            }
            else if (pageNavigation.ToLower() == "prev" || pageNavigation.ToLower() == "previous")
            {
                page--;
            }
            else if (pageNavigation.ToLower().Contains("pg") || pageNavigation.ToLower().Contains("page"))
            {
                string[] parts = pageNavigation.Split();
                page = int.Parse(parts[1]);
            }

            Console.Clear();
        } while (pageNavigation.ToLower() != "exit");
        
    }


    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._dateMade}~{entry._prompt}~{entry._entry}");
            }
        }
    }



    public void LoadFromFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            Entry entry = new Entry();
            entry._dateMade = parts[0];
            entry._prompt = parts[1];
            entry._entry = parts[2];
            AddEntry(entry);
        }
    }


}