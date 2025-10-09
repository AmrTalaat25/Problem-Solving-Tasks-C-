using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Tasks_C_.Model;
internal class RemoveTimeFromDate
{
    //"Friday May 2, 7pm"
    public string ShortenToDate(string longDate)
    {
       var strs= longDate.Split(',');
        return strs[0];

    }
}
