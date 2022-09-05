using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Batch1_DET_2023.EmployeeLink;

namespace Batch1_DET_2023
{
    internal class EmployeeLink
    {
        public class Employeelink
        {
            public Employeelink()
            {

            }

            public Employeelink(int id, string name, string dept)
            {
                this.ID = id;
                this.Name = name;
                this.Dept = dept;

            }
            public int ID { get; set; }
            public string Name { get; set; }
            public string Dept { get; set; }

            private static List<Employeelink> GetListofEmployees()
            {
                List<Employeelink> emps = new List<Employeelink>();
                emps.Add(new Employeelink(1, "John", "Training"));
                emps.Add(new Employeelink(2, "Mark", "Finance"));
                emps.Add(new Employeelink(3, "Peter", "Technical"));
                emps.Add(new Employeelink(4, "Bob", "Technical"));
                emps.Add(new Employeelink(5, "Robert", "Finance"));
                emps.Add(new Employeelink(6, "Jason", "Training"));

                return emps;
            }

            private static void SampleEmployeeList()
            {
                List<Employeelink> emps = GetListofEmployees();
                var emp_query = from employee in emps
                                select employee;

                foreach (var item in emp_query)
                {
                    Console.WriteLine("Name is " + item.Name + "and dept is " + item.Dept);

                }

            }

            public static void Main()
            {
                SampleEmployeeList();
            }

        }


    }
}
