using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Tasks_C_.Model;
internal class Smallest_Int_InArray
{
    public int FindSmallestInt(int[] Numbers)
    {
        int small = Numbers[0];
        for (int i = 0; i < Numbers.Length; i++) 
        { 
            if (Numbers[i] < small)
                small = Numbers[i];
            
        }
        return small;

    }
}
