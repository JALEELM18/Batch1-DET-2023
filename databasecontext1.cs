using Batch1_DET_2023.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2023
{
    internal class databasecontext1
    {
        public static void Main()
        {
            updateEmployee();
        }
        //private static void AddNewEmployee()

        //{
        //    var ctx = new sqlContext();
        //    try
        //    {
        //        Emp employee = new Emp();
        //        employee.Empno = 3090;
        //        employee.Ename = "Jaleel M";
        //        employee.Sal = 10000;
        //        employee.Deptno = 30;
        //        employee.Job = "Trainee";
        //        ctx.Add(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine("New Employee Added");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }

        private static void updateEmployee()

        {
            var ctx = new sqlContext();
            try
            {
                Emp employee = new Emp();
                employee.Empno = 7782;
                employee.Ename = "virat";
                employee.Deptno = 30;
                ctx.Update(employee);
                ctx.SaveChanges();
                Console.WriteLine("Employee updated");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }



        }
    }
}

