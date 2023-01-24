string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue)
            result += $"{newValue}";
        else
            result += $"{text[i]}";
    }
    return result;
}

string textNew = Replace(text, ' ', '|');
Console.WriteLine(textNew);
Console.WriteLine();
textNew = Replace(textNew, 'к', 'К');
Console.WriteLine(textNew);
Console.WriteLine();
textNew = Replace(textNew, 'С', 'с');
Console.WriteLine(textNew);
Console.WriteLine();