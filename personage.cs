﻿using Batch1_DET_2023;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_Batch1_DET_2022
{
    internal class AgeHandling
    {
        static void Main()
        {
            Console.WriteLine("Enter Age in Numbers:");
            int age = Convert.ToInt32(Console.ReadLine());
            try
            {

                if (age > 120)
                {
                    throw new ageexception("Enter Age within 120:");
                }
                else
                {
                    Console.WriteLine($"Age is {age}");
                }

            }
            catch (ageexception i)
            {
                Console.WriteLine(i.Message);


            }
            
        }
    }
}