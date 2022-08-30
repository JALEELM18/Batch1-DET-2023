using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2023
{
    internal class csfeatures
    {
        public static void Main()
        //{
        //    Action<string> action = (string name) => { Console.WriteLine($"Hi {name}" + $" Type is {typeof(Action)}"); };

        //    Action<string, string> action1 = (string s1, string s2) => { Console.WriteLine($"Hi {s1}, " + $"you said {s2}"); };

        //    //action.Invoke("Ananya");
        //    //action1.Invoke("Ananya", "am in Blr");

        //}
        {
            Func<int, int, long> multiply = (x, y) =>
            {
                return x * y;
            };
        long result = multiply(100, 100);
            Console.WriteLine(result);
        }
    }    
}
