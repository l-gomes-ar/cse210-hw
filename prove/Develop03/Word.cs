public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool isHidden()
    {
        if (_isHidden)
        {
            return true;
        } 
        else 
        {
            return false;
        }
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string text = "";
            foreach (char c in _text)
            {
                if (Char.IsLetter(c))
                {
                    text += '_';
                }
                else
                {
                    text += c;
                }
            }
            
            return text;
        }
        else
        {
            return $"{_text}";
        }
    }

}