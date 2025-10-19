using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Tasks_C_.Model;
internal class AvarageInArray
{
    public double FindAverage(double[] array)
    {
        double sum = 0;

        for (int i = 0; i < array.Length; i++) 
        {
            sum += array[i];
        
        }
        
        return sum / array.Length;
    }

}
