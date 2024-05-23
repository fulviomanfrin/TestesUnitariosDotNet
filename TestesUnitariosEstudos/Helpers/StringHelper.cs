namespace TestesUnitariosEstudos.Helpers;

public class StringHelper
{
    public int CountCharacters(string text)
    {
        var result = text.Count();
        return result;
    }

    public string GetFirstWordBeforeSpace(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return "";
        }

        int firstSpaceIndex = text.IndexOf(' ');

        if (firstSpaceIndex == -1)
        {
            return text;
        }
        else
        {
            return text.Substring(0, firstSpaceIndex);
        }
    }

    public int CountWords(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return 0;
        }

        string[] words = text.Split(new char[] {' ', '.', ',', '!', '?', ';', ':', '\t', '\n', '\r'},
            StringSplitOptions.RemoveEmptyEntries);

        return words.Length;
    }

    public string JoinWords(string word1, string word2)
    {
        if (string.IsNullOrWhiteSpace(word1))
        {
            return word2 ?? "";
        }

        if (string.IsNullOrWhiteSpace(word2))
        {
            return word1;
        }

        return word1 + " " + word2;
    }

    public List<string> ReturnListOfStrings(string text)
    {
        var list = new List<string>();

        if (string.IsNullOrWhiteSpace(text))
        {
            return list;
        }

        string[] words = text.Split(new char[] {' ', ',', '.', '!', '?', ';', ':', '\t', '\n', '\r'},
            StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            list.Add(word);
        }

        return list;
    }
}