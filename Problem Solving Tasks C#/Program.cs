using Problem_Solving_Tasks_C_.Class;
using Problem_Solving_Tasks_C_.Model;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        RemoveTimeFromDate removeTimeFromDate = new RemoveTimeFromDate();
        StringSpacesRemover stringSpacesRemover = new StringSpacesRemover();
        string lomgtime = "Friday May 2, 7pm";
        string anyString = "8 j 8   mBliB8g  imjB8B8  jl  B";
        Console.WriteLine(removeTimeFromDate.ShortenToDate(lomgtime));
        Console.WriteLine(stringSpacesRemover.NoSpace(anyString));

    }
}