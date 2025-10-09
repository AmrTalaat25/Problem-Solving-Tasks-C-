using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Tasks_C_.Model;
internal class StringSpacesRemover
{
    public  string NoSpace(string input)
    {
        var newString = input.Split(" ");
        return string.Join("",newString);
    }
}
