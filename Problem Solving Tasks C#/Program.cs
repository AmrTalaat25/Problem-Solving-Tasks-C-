using Problem_Solving_Tasks_C_.Class;
using Problem_Solving_Tasks_C_.Model;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        RemoveTimeFromDate removeTimeFromDate = new RemoveTimeFromDate();
        string lomgtime = "Friday May 2, 7pm";
        Console.WriteLine(removeTimeFromDate.ShortenToDate(lomgtime));

    }
}