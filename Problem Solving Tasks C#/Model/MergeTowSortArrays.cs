using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Tasks_C_.Model;
internal class MergeTowSortArrays
{
    public int[] MergeArrays(int[] arr1, int[] arr2)
    {
        var list = new List<int>();
        foreach(int i in arr1) 
            list.Add(i);
        foreach (int i in arr2)
            list.Add(i);
        list.Sort();
        return list.ToArray();
    }
    public void PrintMergeArray(int[] MergeArr)
    {
        foreach (int i in MergeArr)
            Console.WriteLine(i);

    }
}
