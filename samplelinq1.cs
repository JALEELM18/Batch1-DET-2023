using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2023
{
    internal class samplelinq1
    {
        private static void Main()
        {
            //     int[] numbers = { 7, 9, 5 };

            //     var result = numbers.OrderBy(x => x);

            //     Console.WriteLine("Ordered list of numbers:");
            //     foreach (int number in result)
            //         Console.WriteLine(number);
            // }

            //        var dates = new DateTime[] {
            //    new DateTime(2015, 2, 15),
            //    new DateTime(2015, 3, 25),
            //    new DateTime(2015, 1, 5)
            //};

            //        var result = dates.OrderBy(d => d);

            //        Console.WriteLine("Ordered list of dates:");
            //        foreach (DateTime dt in result)
            //            Console.WriteLine(dt.ToString("yyyy/MM/dd"));


            //string[] names = { "Ned", "Ben", "Susan" };

            //var result = names.OrderByDescending(n => n);

            //Console.WriteLine("Descending ordered list of names:");
            //foreach (string name in result)
            //    Console.WriteLine(name);

            //char[] characters = { 's', 'a', 'm', 'p', 'l', 'e' };

            //var result = characters.Reverse();

            //Console.WriteLine("Characters in reverse order:");
            //foreach (char character in result)
            //    Console.WriteLine(character);

            //string[] capitals = { "Berlin", "Paris", "Madrid", "Tokyo", "London",
            //              "Athens", "Beijing", "Seoul" };

            //var result = capitals.OrderBy(c => c.Length).ThenBy(c => c);

            //Console.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
            //foreach (string capital in result)
            //    Console.WriteLine(capital);

            //        var dates = new DateTime[] {
            //    new DateTime(2015, 3, 1),
            //    new DateTime(2014, 7, 1),
            //    new DateTime(2013, 5, 1),
            //    new DateTime(2015, 1, 1),
            //    new DateTime(2015, 7, 1)
            //};

            //        var result = dates.OrderByDescending(d => d.Year).ThenByDescending(d => d.Month);

            //        Console.WriteLine("List of dates first ordered by year descending, and then by month descending:");
            //        foreach (DateTime dt in result)
            //            Console.WriteLine(dt.ToString("yyyy/MM/dd"));



            //SKIP EXAMPLE

            //string[] words = { "learning", "c#", "is", "difficult", "for", "me" };

            //var result = words.Skip(3);

            //Console.WriteLine("Skips the first 3 words:");
            //foreach (string word in result)
            //    Console.WriteLine(word);



            // SKIP WHILE EXAMPLE

            //string[] words = { "one", "two", "three", "four", "five", "six" };

            //var result = words.SkipWhile(w => w.Length == 3);

            //Console.WriteLine("Skips words while the condition is met:");
            //foreach (string word in result)
            //    Console.WriteLine(word);



            //TAKE EXAMPLE

            //int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            //var result = numbers.Take(5);

            //Console.WriteLine("Takes the first 5 numbers only:");
            //foreach (int number in result)
            //    Console.WriteLine(number);


            //TALE WHILE EXAMPLE

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = numbers.TakeWhile(n => n < 5);

            //Console.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
            //foreach (int number in result)
            //    Console.WriteLine(number);



            //AGGREATION

            //SIMPLE

            //var numbers = new int[] { 1, 2, 3, 4, 5 };

            //var result = numbers.Aggregate((a, b) => a * b);

            //Console.WriteLine("Aggregated numbers by multiplication:");
            //Console.WriteLine(result);

            //AVERAGE

            //int[] numbers = { 50, 100, 110, 120 };

            //var result = numbers.Average();

            //Console.WriteLine("Average is:");
            //Console.WriteLine(result);


            //COUNT

            //string[] names = { "yash", "Abhilash", "Jaleel", "Alexa", "Rocket", "Bharath" };

            //var result = names.Count();

            //Console.WriteLine("Counting names gives:");
            //Console.WriteLine(result);

            //LONGCOUNT

            //var largeArr = Enumerable.Range(0, Int32.MaxValue).Concat(Enumerable.Range(0, 5));

            //Int64 result = largeArr.LongCount();

            //Console.WriteLine("Counting largeArr elements:");
            //Console.WriteLine(result);


            //MAXIMUM

            //int[] numbers = { 2, 8, 5, 6, 1 };

            //var result = numbers.Max();

            //Console.WriteLine("Highest number is:");
            //Console.WriteLine(result);

            //MINIMUM

            //int[] numbers = { 2, 8, 5, 6, 1 };

            //var result = numbers.Min();

            //Console.WriteLine("Highest number is:");
            //Console.WriteLine(result);


            //SUM

            //int[] numbers = { 2, 8, 5, 6, 1 };

            //var result = numbers.Sum();

            //Console.WriteLine("Highest number is:");
            //Console.WriteLine(result);


            //ELEMENTS EXAMPLES

            //ELEMENTS AT

            //string[] words = { "One", "Two", "Three" };

            //var result = words.ElementAt(2);

            //Console.WriteLine("Element at index 1 in the array is:");
            //Console.WriteLine(result);


            //ELEMENTS AT OR DEFAULT
            //string[] colors = { "Red", "Green", "Blue" };

            //var resultIndex1 = colors.ElementAtOrDefault(1);

            //var resultIndex10 = colors.ElementAtOrDefault(10);

            //Console.WriteLine("Element at index 1 in the array contains:");
            //Console.WriteLine(resultIndex1);

            //Console.WriteLine("Element at index 10 in the array does not exist:");
            //Console.WriteLine(resultIndex10 == null);


            //FIRST(SIMPLE)

            //string[] fruits = { "Banana", "Apple", "Orange" };

            //var result = fruits.First();

            //Console.WriteLine("First element in the array is:");
            //Console.WriteLine(result);


            //FIRST(CONDITIONAL)


            //string[] countries = { "Denmark", "Sweden", "Norway" };

            //var result = countries.First(c => c.Length == 6);

            //Console.WriteLine("First element with a length of 6 characters:");
            //Console.WriteLine(result);


            //FIRST OR DEFAULT

            //string[] countries = { "Denmark", "Sweden", "Norway" };
            //string[] empty = { };

            //var result = countries.FirstOrDefault();

            //var resultEmpty = empty.FirstOrDefault();

            //Console.WriteLine("First element in the countries array contains:");
            //Console.WriteLine(result);

            //Console.WriteLine("First element in the empty array does not exist:");
            //Console.WriteLine(resultEmpty == null);


            //LAST

            int[] numbers = { 7, 3, 5, 1 };

            var result = numbers.Last();

            Console.WriteLine("Last number in array is:");
            Console.WriteLine(result);


            //LAST OR DEFAULT


            //string[] words = { "one", "two", "three" };
            //string[] empty = { };

            //var result = words.LastOrDefault();

            //var resultEmpty = empty.LastOrDefault();

            //Console.WriteLine("Last element in the words array contains:");
            //Console.WriteLine(result);

            //Console.WriteLine("Last element in the empty array does not exist:");
            //Console.WriteLine(resultEmpty == null);


            //LAST CONDITIONAL

            //string[] words = { "one", "two", "three" };

            //var result = words.LastOrDefault(w => w.Length == 3);

            //var resultNoMatch = words.LastOrDefault(w => w.Length == 2);

            //Console.WriteLine("Last element in the words array having a length of 3:");
            //Console.WriteLine(result);

            //Console.WriteLine("Last element in the empty array having a length of 2 does not exist:");
            //Console.WriteLine(resultNoMatch == null);


            //SINGLE

            //string[] names1 = { "Peter" };
            //string[] names3 = { "Peter", "Joe", "Wilma" };
            //string[] empty = { };

            //var result1 = names1.Single();

            //Console.WriteLine("The only name in the array is:");
            //Console.WriteLine(result1);

            //try
            //{
            //    // This will throw an exception because array contains no elements
            //    var resultEmpty = empty.Single();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //try
            //{
            //    // This will throw an exception as well because array contains more than one element
            //    var result3 = names3.Single();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            //SINGLE DEFAULT

            //string[] names1 = { "Peter" };
            //string[] names3 = { "Peter", "Joe", "Wilma" };
            //string[] empty = { };

            //var result1 = names1.SingleOrDefault();

            //var resultEmpty = empty.SingleOrDefault();

            //Console.WriteLine("The only name in the array is:");
            //Console.WriteLine(result1);

            //Console.WriteLine("As array is empty, SingleOrDefault yields null:");
            //Console.WriteLine(resultEmpty == null);

            //try
            //{
            //    // This will throw an exception as well because array contains more than one element
            //    var result3 = names3.SingleOrDefault();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}


            //QUANTIFIERS

            //ALL

            //string[] names = { "Bob", "Ned", "Amy", "Bill" };

            //var result = names.All(n => n.StartsWith("B"));

            //Console.WriteLine("Does all of the names start with the letter 'B':");
            //Console.WriteLine(result);


            //ANY

            //string[] names = { "Bob", "Ned", "Amy", "Bill" };

            //var result = names.Any(n => n.StartsWith("B"));

            //Console.WriteLine("Does all of the names start with the letter 'B':");
            //Console.WriteLine(result);

            //contains

            //int[] numbers = { 1, 3, 5, 7, 9 };

            //var result = numbers.Contains(5);

            //Console.WriteLine("sequence contains the value 5:");
            //Console.WriteLine(result);

            //SET EXAMPLE

            //DISTINCT

            //int[] numbers = { 1, 2, 2, 3, 5, 6, 6, 6, 8, 9 };

            //var result = numbers.Distinct();

            //Console.WriteLine("Distinct removes duplicate elements:");
            //foreach (int number in result)
            //    Console.WriteLine(number);

            //EXPECT

            //int[] numbers1 = { 1, 2, 3 };
            //int[] numbers2 = { 3, 4, 5 };

            //var result = numbers1.Except(numbers2);

            //Console.WriteLine("Except creates a single sequence from numbers1 and removes the duplicates found in numbers2:");
            //foreach (int number in result)
            //    Console.WriteLine(number);


            //INTERSECT

            //int[] numbers1 = { 1, 2, 3 };
            //int[] numbers2 = { 3, 4, 5 };

            //var result = numbers1.Intersect(numbers2);

            //Console.WriteLine("Intersect creates a single sequence with only the duplicates:");
            //foreach (int number in result)
            //    Console.WriteLine(number);


            //UNION

            //int[] numbers1 = { 1, 2, 3 };
            //int[] numbers2 = { 3, 4, 5 };

            //var result = numbers1.Union(numbers2);

            //Console.WriteLine("Union creates a single sequence and eliminates the duplicates:");
            //foreach (int number in result)
            //    Console.WriteLine(number);

        }

    }

}