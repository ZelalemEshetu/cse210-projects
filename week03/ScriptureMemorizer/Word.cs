public class Word
{
    private string _text;
    private bool _isHidden;

    // Constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Optional: Reveal the word
    public void Reveal()
    {
        _isHidden = false;
    }

    // Check if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Display word or underscores if hidden
    public override string ToString()
    {
        if (_isHidden)
        {
            // Keep punctuation visible
            string hiddenText = "";
            foreach (char c in _text)
            {
                hiddenText += char.IsLetter(c) ? "_" : c;
            }
            return hiddenText;
        }
        return _text;
    }
}
