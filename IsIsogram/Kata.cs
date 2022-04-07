namespace CodeWarsTasks;

public class Kata
{
    public static bool IsIsogram(string str)
    {
        if (str == string.Empty)
            return true;
        for (int i = 0; i < str.Length; i++)
        {
            for (int j = 0; j < str.Length; j++)
            {
                if (i != j)
                {
                    if (Char.ToLower(str[i]).Equals(Char.ToLower(str[j])))
                        return false;
                }
            }
        }

        return true;
    }
}