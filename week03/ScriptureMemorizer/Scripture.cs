using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.WriteLine(_reference.ToString());
        foreach (var word in _words)
        {
            Console.Write(word + " ");
        }

        int remaining = _words.FindAll(w => !w.IsHidden()).Count;
        Console.WriteLine($"\n\nWords left to memorize: {remaining}");
    }

    // Hide only words that are not already hidden
    public bool HideRandomWords(int count)
    {
        var visibleWords = _words.FindAll(w => !w.IsHidden());
        if (visibleWords.Count == 0)
            return false;

        Random rnd = new Random();
        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = rnd.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
        return true;
    }

    public bool AllHidden()
    {
        return _words.TrueForAll(w => w.IsHidden());
    }
}
