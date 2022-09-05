using Batch1_DET_2023.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Batch1_DET_2023
{
    internal class storedproefm
    {
        public static void Main()
        {
            //Getalldetails();
            //Getalldetails();
            ////Getalldetailssp();
            //GetEmpsDetailsByEmpno();

            insertnameinsp();
        }
        //private static void Getalldetailssp()
        //{
        //    var ctx = new sqlContext();
        //    var employees = ctx.Emps.FromSqlRaw("GetAllEmpsDetails");
        //    foreach (var e in employees)
        //    {
        //        Console.WriteLine(e.Ename);
        //    }

        //private static void GetEmpsDetailsByEmpno()
        //{
        //    var ctx = new sqlContext();
        //    var employees = ctx.Emps.FromSqlRaw($"GetEmpsDetailsByEmpno @p0", 7782).ToList();
        //    foreach (var e in employees)
        //    {
        //        Console.WriteLine(e.Ename);
        //    }

        //    }

        //    private static void Getalldetails()
        //{
        //    var ctx = new sqlContext();
        //    var Value = 2356;
        //    int employee = ctx.Database.ExecuteSqlRaw("removeemployeedetails @p0", Value);
        //    Console.WriteLine($"No Of Rows Affected {employee}");
        //}

        //private static void updatenamesp()
        //{
        //    var ctx = new sqlContext();
        //    try
        //    {
        //        var id = 7499;
        //        string newName = "yash";
        //        int employee = ctx.Database.ExecuteSqlRaw("changethename @p0,@p1", id, newName);
        //        Console.WriteLine(employee);
        //    }

        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }

        //}

        private static void insertnameinsp()
        {
            var ctx = new sqlContext();
            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@empno",
                            SqlDbType =  System.Data.SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 1060
                        },

                         new SqlParameter() {
                            ParameterName = "@empname",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "sabyata"},

                          new SqlParameter() {
                            ParameterName = "@job",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "Manager"},

                          new SqlParameter() {
                            ParameterName = "@mgr",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "7839"},

                           new SqlParameter() {
                            ParameterName = "@hire",
                            SqlDbType =  System.Data.
                            SqlDbType.Date,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "10/11/2020"},

                            new SqlParameter() {
                            ParameterName = "@sal",
                            SqlDbType =  System.Data.
                            SqlDbType.Decimal,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 400000},

                             new SqlParameter() {
                            ParameterName = "@comm",
                            SqlDbType =  System.Data.
                            SqlDbType.Decimal,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 30},

                              new SqlParameter() {
                            ParameterName = "@deptno",
                            SqlDbType =  System.Data.
                            SqlDbType.Decimal,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 20},

                       };

            try
            {
                var result = ctx.Database.ExecuteSqlRaw("AddEmployee @empno, @empname, @job, @mgr, @hire, @sal, @comm, @deptno", param);
                Console.WriteLine("added");
            }
            catch (Exception ex)
            {

                throw;
            }


            Console.WriteLine("update successful");

        }



    }
}
