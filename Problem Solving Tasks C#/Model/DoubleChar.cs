namespace Problem_Solving_Tasks_C_.Model;
internal class DoubleChar
{
    public string DoubleString(string str)
    {
        char[] chars = str.ToCharArray();
        var list = new List<string>();  
        for(int i  = 0; i < chars.Length; i++)
        {
            list.Add(char.ToString(chars[i]));
            list.Add(char.ToString(chars[i]));
        }
        return string.Join("", list.ToArray());
    }

}
