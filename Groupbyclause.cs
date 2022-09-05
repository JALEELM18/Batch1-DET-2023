using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2023
{
    internal class Groupbyclause
    {
        //private static void String_Groupby()
        //{
        //List<string> list4 = new List<string>() { "basket", "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };
        //var wordGroups = list4.GroupBy(x => x[0]).Select
        //    (y => new { FirstLetter = y.Key, Words = y });
        //foreach (var group in wordGroups)
        //{
        //    Console.WriteLine("Words that starts with the" + " letter '{0}': ", group.FirstLetter);

        //    foreach (var word in group.Words)
        //    {
        //        Console.WriteLine(word);

        //    }
        //    Console.WriteLine();
        //}



        private static void String_Groupby()
        {
            List<string> list4 = new List<string>() { "basket", "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };
            var wordGroups = list4.GroupBy(x => x[0]).Select
                (y => new { lengthofwords = y.Key, Words = y });
            foreach (var group in wordGroups)
            {
                Console.WriteLine("Words that starts with the" + " letter '{0}': ", group.lengthofwords);

                foreach (var word in group.Words)
                {
                    Console.WriteLine(word);

                }
                Console.WriteLine();
            }


        }

        public static void Main()
        {
            String_Groupby();
        }

    }
}



    
                  

