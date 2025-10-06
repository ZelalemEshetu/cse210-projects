using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private static Random _random = new Random(); // reuse the same Random instance

    // Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    // Display the scripture with current hidden/visible words
    public void Display()
    {
        Console.WriteLine(_reference.GetReference());
        Console.WriteLine();

        foreach (var word in _words)
        {
            Console.Write(word + " ");
        }

        int remaining = _words.FindAll(w => !w.IsHidden()).Count;
        Console.WriteLine($"\n\nWords left to memorize: {remaining}");
    }

    // Hide only visible words (improved random logic)
    public bool HideRandomWords(int count)
    {
        var visibleWords = _words.FindAll(w => !w.IsHidden());
        if (visibleWords.Count == 0)
            return false;

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }

        return true;
    }

    // Check if all words are hidden
    public bool AllHidden()
    {
        return _words.TrueForAll(w => w.IsHidden());
    }
}
