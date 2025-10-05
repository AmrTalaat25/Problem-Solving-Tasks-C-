using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Tasks_C_.Model;
public class ConvertToNegative
{
    public int MakeNegative(int number)
    {
        if (number > 0)
            return number * -1;

        else
            return number;

    }
}
