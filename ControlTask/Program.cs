string[] StringCheckerForThreeSymb(string[] words)
{

    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length > 3)
        {
            words[i] = String.Empty;
        }
    }
    return words;
}
