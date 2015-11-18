using System;

class StringsAndObjects
{
    static void Main()
    {
        string firstWord = "Hello";
        string secondWord = "World";
        object firstSentence = firstWord + ", " + secondWord + "!";
        Console.WriteLine(firstSentence);
        string secondSentence = (string)firstSentence;
        Console.WriteLine(secondSentence);
    }
}