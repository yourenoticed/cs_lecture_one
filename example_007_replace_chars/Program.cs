string ReplaceChars (string text, char oldVal, char newVal)
{
    string result = string.Empty;
    foreach (char c in text)
    {
        if (c != oldVal)
        {
            result = $"{result}{c}";
        }
        else
        {
            result = $"{result}{newVal}";
        }
    }
    return result;
} 

string text = "I fucked your mommas mouth you sucker";
System.Console.WriteLine(ReplaceChars(text: text, 'u', '*'));