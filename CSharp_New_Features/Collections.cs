using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAndCSharp_Features
{
    public class Collections
    {
        
        //Collection Expression - In Preview
        static int[] values1 = [1, 2, 3];
        static int[] values2 = [4, 5, 6];

        int[] values = [.. values1, .. values2];
       public int[] readValues()
        {
            foreach(int value in values)
            {
                Console.WriteLine($"{value}");
            }
            return values;
        }


    }
}
