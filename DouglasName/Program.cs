using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DouglasName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Lines in each letter
            for(int i = 0; i < 8; i++)
            {   
                if(i == 0 || i == 7)
                {
                    Console.WriteLine("DDDDD");
                } else if(i == 1 || i == 6)
                {
                    Console.WriteLine("D    D");
                } else if (i == 2 || i == 5)
                {
                    Console.WriteLine("D     D");
                } else if (i == 3 || i == 4)
                {
                    Console.WriteLine("D      D");
                } 
            }
            ReadKey();
            //2. Number of letters
        }
    }
}
