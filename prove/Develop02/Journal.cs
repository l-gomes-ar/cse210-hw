using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        // Adds entry to journal
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        // Use each entry.Display() method to display all entries.
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        // Saves all entries in journal to a file
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        // Loads and stores all entries in a file in new journal
        // Empty current entries in Journal
        _entries.Clear();

        string [] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            // Create new instance of entry
            Entry entry = new Entry();

            // Store parts in entry
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            
            // Save entry in journal
            AddEntry(entry);
        }

    }
}