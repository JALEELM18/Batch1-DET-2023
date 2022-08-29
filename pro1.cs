using Batch1_DET_2023;

using ConsoleAppDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2023
{
    internal class pro1
    {
        /*public static void Main()
         {
             Manager m = new Manager(4671, "Karthika", new DateOnly(2005, 5, 10), "techtrng", 10);  //default constructor
             Console.WriteLine(m.Print());

             Manager m1 = new Manager(2345, "Jeeva", new DateOnly(2010, 1, 14), "PEMS", 450);
             Console.WriteLine(m1.Print());

             Emp e1 = new Emp(1, "Jiyana", new DateOnly(2020, 1, 5));
             Console.WriteLine(e1.Print());

        }
        public static void Main()
        {
           /* try
            {
                /*Emp m = new Manager(4671, "Karthika", new DateTime(2005, 5, 10), "techtrng", 10);  //default constructor
                                                                                                   // Console.WriteLine(m.Print());

                Emp m1 = new Manager(2345, "Jeeva", new DateTime(2010, 1, 14), "PEMS", 450);
                // Console.WriteLine(m1.Print());  //base class ref can point to derived object

                Emp e1 = new Emp(1, "Jiyana", new DateTime(2020, 1, 5));
                //Console.WriteLine(e1.Print());*/

        /*  Console.WriteLine("enter empid b.w 1001 - 25000");
          int id = Convert.ToInt32(Console.ReadLine());
          if (id < 1001 || id > 25000)
              throw new InvalidEmpIdException("Entered empid is not in the range...");

          Console.WriteLine("enter emp name");
          string name = Console.ReadLine();

          Console.WriteLine("enter doj");
          DateTime doj = DateTime.Parse(Console.ReadLine());

          Emp e2 = new(id, name, doj);


          /*List<Emp> list = new List<Emp>();
          list.Add(m);
          list.Add(m1);
          list.Add(e1);
          foreach (Emp x in list)
              Console.WriteLine(x.Print());*/

        /* catch (InvalidEmpIdException e)
         {
             Console.WriteLine(e.Message);
         }


     }*/
        /* public static void Main()
         {
             CompanyManager m = new CompanyManager { Name = "Balaji", Surname = "R", Phone = "987456321" };
             Company company = new Company { Name = "SSL", Address = "Global ", Manager = m, Phone = "987456321", Website = "sonata-software.com" };
             Console.WriteLine(company.Print());
         }*/


        //dog and cat
        //public static void Main()
        //{
        //    List<Animal> sound = new List<Animal>();
        //    sound.Add(new Dog());
        //    sound.Add(new cat());

        //    foreach (Animal a in sound)
        //        Console.WriteLine(a.sound());

        //}
        //ageperson
        //public class TestPerson
        //{
        //    public static void Main()
        //    {
        //        try
        //        {
        //            Person t = new Person("Virat", "Kohli", "viratkohli@gmail.com", new DateOnly(1972, 05, 06));
        //            int byear = t.BirthYear();
        //            if (byear < 1900 || byear > 2022)
        //            {
        //                throw new InvalidBirthYearException("ENTER VALID BIRTH YEAR");
        //            }
        //            string r = t.GetSunSign();
        //            string s = t.ChineseZodiac();
        //            string w = t.IsAdult();
        //            string b = t.BDayStatus();
        //            string u = t.DefaultUsername();
        //            string n = t.GetInfo();
        //            Console.WriteLine($"NAME = {n}");
        //            Console.WriteLine($"Sun Sign = {r}");
        //            Console.WriteLine($"Chinese Zodiac = {s}");
        //            Console.WriteLine($"Age Status = {w}");
        //            Console.WriteLine($"Birthday Status = {b}");
        //            Console.WriteLine($"Default Username = {u}");
        //        }
        //        catch (InvalidBirthYearException e)
        //        {
        //            Console.WriteLine(e.Message);
        //        }
        //        catch (Exception m)
        //        {
        //            Console.WriteLine(m.Message);
        //        }
        //    }
        //}
        public static Student Student { get; private set; }

        public static void Main()
        {
            ScienceStudent Student = new ScienceStudent { regno = 18, Name = "Jaleel" };
            ScienceStudent sciencesubject = new ScienceStudent { physics = 54, chemistry = 75, maths = 45 };
            CommerceStudent Commercessubject = new CommerceStudent { economices = 44, accounts = 82, banking = 44 };

            Console.WriteLine(sciencesubject.GetAvgMarks());
            Console.WriteLine(Commercessubject.GetAvgMarks());
        }

    }

}

