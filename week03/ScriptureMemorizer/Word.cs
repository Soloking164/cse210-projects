using System; 

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void SetHidden(bool hidden)
    {
        _isHidden = hidden;
    }

        public bool GetHidden()
    {
        return _isHidden;
    }


    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}

