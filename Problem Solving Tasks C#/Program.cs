using Problem_Solving_Tasks_C_.Class;
using Problem_Solving_Tasks_C_.Model;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        MergeTowSortArrays mergeTowSortArrays = new MergeTowSortArrays();
        int[] arr1 = {1, 2, 3, 4, 5}; 
        int[] arr2 = {7, 8, 6, 9, 10};
        var MergeArr = mergeTowSortArrays.MergeArrays(arr1, arr2);
        mergeTowSortArrays.PrintMergeArray(MergeArr);









    }
}