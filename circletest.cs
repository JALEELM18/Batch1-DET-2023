using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Batch1_DET_2023.Class1;

namespace Batch1_DET_2023
{
    internal class circletest
    {
        public static void Main()
        {
            circle ob = new circle(53);
            double result = ob.areaofcircle();
            Console.WriteLine(result);
        }
    }
}
    
