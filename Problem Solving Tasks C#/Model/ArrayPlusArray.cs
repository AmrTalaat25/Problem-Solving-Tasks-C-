using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Tasks_C_.Model;
internal class ArrayPlusArray
{
    public  int SumTowArray(int[] arr1, int[] arr2)
    {
        var sumarr1 = arr1.Sum();
        var sumarr2 = arr2.Sum();
        return sumarr1 + sumarr2;
    }
}
