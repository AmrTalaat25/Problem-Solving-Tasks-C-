using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving_Tasks_C_.Model;
internal class ASCIICode
{
    public void Upper()
    {
        Console.WriteLine(" UpperChar From A to Z and ASCII Code : ");
        for (char c = 'A'; c <= 'Z'; c++)
        {
            Console.WriteLine(c + "  --> " + (int)c);
        }
    }
    public void Lower()
    {
        Console.WriteLine(" LowerChar From a to z and ASCII Code : ");
        for (char c = 'a'; c <= 'z'; c++)
        {
            Console.WriteLine(c + "  --> " + (int)c);
        }
    }
    public void Number()
    {
        Console.WriteLine(" Number From 1 to 9 and ASCII Code : ");
        for (char c = '1'; c <= '9'; c++)
        {
            Console.WriteLine(c + "  --> " + (int)c);
        }
    }
    public void SpecialChar()
    {
        Console.WriteLine(" SpecialChar From ! to / and ASCII Code : ");
        for (char c = '!'; c <= '/'; c++)
        {
            Console.WriteLine(c + "  --> " + (int)c);
        }
    }
}
