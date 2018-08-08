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

        #region Constructors


        public Manager()
        {
            //Console.WriteLine(" Default Constructor Manager ( child class )  ");
        }

        public Manager(string fullName, int age, int empID,float currPay, string ssn, int numbOfOpts) : base(fullName, age, empID, currPay, ssn)
        {
            //Console.WriteLine(" 6 arguement Constructor Manager ( child class )  ");
            // This property is defined by the Manager class.
            StockOptions = numbOfOpts;
        }
        #endregion

        public override void GiveBonus(float amount)
        {
            Console.WriteLine(" GiveBonus - overriden method in Manager Class ");
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions += r.Next(500);
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of Stock Options: {0}", StockOptions);
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
