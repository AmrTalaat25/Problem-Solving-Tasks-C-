using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Problem_Solving_Tasks_C_.Model;
internal class ReverseString
{
    #region Method one 
    public string ReverseOne(string str) 
    {
        var reverses= str.Reverse();
        return string.Join("", reverses);

    
    
    }
    #endregion


    #region Method Tow
    public string ReverseTow(string str)
    {
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);

    }
    #endregion


    #region Method Three
    public string ReverseThree(string str)
    {

        var chars = str.Select(c => c.ToString()).ToArray();

        var str2 = chars.Reverse();
        return string.Join("", str2);


    }
    #endregion
}
