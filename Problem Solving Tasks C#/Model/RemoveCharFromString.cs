using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Tasks_C_.Model;
internal class RemoveCharFromString
{
    public string Remove_char(string s)
    {
        var newString = s.Substring(1,s.Length-2);
        return newString;
    }
}
