using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_P2_Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");

            //SalesPerson fred = new SalesPerson();
            //fred.Age = 31;
            //fred.Name = "Fred";
            //fred.SalesNumber = 50;

            #region base keyword in C#

            // Assume Manager has a constructor matching this signature:
            // (string fullName, int age, int empID,
            // float currPay, string ssn, int numbOfOpts)
            //Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);

            #endregion

            #region protected keyword

            //// Error! Can't access protected data from client code.
            //Employee emp = new Employee();
            //emp.empName = "Fred";

            #endregion



            Console.ReadLine();
        }
    }
}
