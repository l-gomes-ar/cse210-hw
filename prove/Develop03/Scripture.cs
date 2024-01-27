public class Scripture
{
    private Reference _reference = new Reference("", 0, 0, 0);
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] textArray = text.Split(' ');

        foreach (string s in textArray)
        {
            Word word = new Word(s);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random randInt = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int index;
            do 
            {
                index = randInt.Next(_words.Count);
            } while (_words[index].isHidden());

            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string text = $"{_reference.GetDisplayText()} => ";
        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        return text;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.isHidden())
            {
                return false;
            }
        }
        return true;
    }
}