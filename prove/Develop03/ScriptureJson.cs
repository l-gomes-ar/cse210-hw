// Create ScriptureJson model for reading the json file as taught on
// https://learn.microsoft.com/en-us/answers/questions/699941/read-and-process-json-file-with-c
public class ScriptureJson
{
    public string book { get; set; }
    public int chapter { get; set; }
    public int startVerse { get; set; }
    public int endVerse { get; set; }
    public string scripture { get; set; }
}