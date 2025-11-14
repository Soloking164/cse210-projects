using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count)
    {
        var random = new Random();
        for (int i = 0; i < count; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].SetHidden(true);
        }
    }

    public bool AreAllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.GetHidden())
            {
                return false;
            }
        }
        return true;
    }

    
    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.ConvertAll(w => w.GetDisplayText()));
        return $"{_reference.GetReferenceText()}\n{scriptureText}";
    }
}
