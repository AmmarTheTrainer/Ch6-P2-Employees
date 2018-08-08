﻿using System;
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

            #region Has-a model ( containment or delegation model )


            //Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            //double cost = chucky.GetBenefitCost();

            //Console.WriteLine(" here is the benefits of emp =  " + cost);

            #endregion

            #region Understanding Nested Type Definitions

            //Employee emp = new Employee();

            //emp.empBenefits = new BenefitPackage();


            Employee.BenefitPackage bnftp = new Employee.BenefitPackage();

            Employee.BenefitPackage.BenefitPackageLevel pl = new Employee.BenefitPackage.BenefitPackageLevel();

            pl = Employee.BenefitPackage.BenefitPackageLevel.Platinum;




            #endregion

            #region The Third Pillar of OOP: C# Ploymporhic Support

            //// Give each employee a bonus?
            //Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            //chucky.GiveBonus(300);
            //chucky.DisplayStats();
            //Console.WriteLine();




            #endregion

            #region The virtual and override keywords

            //// A better bonus system!
            //Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            //chucky.GiveBonus(300);
            //chucky.DisplayStats();

            //Console.WriteLine();

            //SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
            //fran.GiveBonus(200);
            //fran.DisplayStats();

            #endregion

            #region Understanding Abstract Classes

            //// What exactly does this mean?
            
            //Employee X = new Employee();

            #endregion



            Console.ReadLine();
        }
    }
}
