public class Scripture
{
    private Reference _reference = new Reference("", 1, 1);
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
    }

    public void HideRandomWords(int numberToHide)
    { 
    }

    public string GetDisplayText()
    {
        return "";
    }

    private bool IsCompletelyHidden()
    {
        return false;
    }
}