using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Tasks_C_.Model;
internal class StringIsUpper
{
    public bool IsUpperCase( string text)
    {
        var isUpper=false;
        string newText = text.ToUpper();
        if (text == newText)
            isUpper = true;
        return isUpper;

    }

}
