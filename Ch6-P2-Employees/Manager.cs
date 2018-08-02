using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_P2_Employees
{
    class Manager : Employee
    {
        public int StockOptions { get; set; }
        public Manager()
        {
            Console.WriteLine(" Default Constructor Manager ( child class )  ");
        }

        public Manager(string fullName, int age, int empID,float currPay, string ssn, int numbOfOpts) : base(fullName, age, empID, currPay, ssn)
        {
            // This property is defined by the Manager class.
            StockOptions = numbOfOpts;
        }

        //public Manager(string fullName, int age, int empID,float currPay, string ssn, int numbOfOpts)
        //{
        //    Console.WriteLine(" 6 Arguement ctor , manager class ( child ) ");
        //    // This property is defined by the Manager class.
        //    StockOptions = numbOfOpts;
        //    // Assign incoming parameters using the
        //    // inherited properties of the parent class.
        //    ID = empID;
        //    Age = age;
        //    Name = fullName;
        //    Pay = currPay;
        //    // OOPS! This would be a compiler error,
        //    // if the SSN property were read-only!

        //    //SocialSecurityNumber = ssn;
        //}
    }
}
