using Batch1_DET_2023.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2023
{
    internal class Databasefirst
    {


        public static void Main()
        {
            //GetAllEmp();
            //Console.ReadLine();
        }

        //private static void GetAllEmp()
        //{
        //    var ctx = new sqlContext();
        //    var emps = ctx.Emps.Where(e => e.Empno == 7499).SingleOrDefault();
        //    Console.WriteLine(emps.Ename + "   " + emps.Sal + "  " + emps.Job);

        //    //foreach (var emp in emps)
        //    //    Console.WriteLine(emp.Ename + " " + emp.Sal);

        //}

        private static void AddNewEmployee()

        {
            var ctx = new sqlContext();
            try
            {
                Emp employee = new Emp();
                employee.Empno = 9999;
                employee.Ename = "Jaleel M";
                employee.Sal = 100000;
                employee.Deptno = 40;
                employee.Job = "Trainee";
                ctx.Add(employee);
                ctx.SaveChanges();
                Console.WriteLine("New Employee Added");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }


        }
    }
}
