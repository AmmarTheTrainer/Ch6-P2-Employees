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

            #region Has-a model ( containment or delegation model )


            //Console.WriteLine("  hello ");

            //Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            //double cost = chucky.GetBenefitCost();

            //Console.WriteLine(" here is the benefits of emp =  " + cost);

            #endregion

            #region Understanding Nested Type Definitions

            //Employee emp = new Employee();

            //emp.empBenefits = new BenefitPackage();


            //Employee.BenefitPackage bnftp = new Employee.BenefitPackage();

            //Employee.BenefitPackage.BenefitPackageLevel pl = new Employee.BenefitPackage.BenefitPackageLevel();

            //pl = Employee.BenefitPackage.BenefitPackageLevel.Platinum;




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

<<<<<<< HEAD

=======
            #region Base Class/Derived Class Casting Rules

            CastingExamples();

            #endregion

            #region The C# as keyword

            //TheCSharpAsKeyword(); // The C# as keyword

            #endregion

            //TheCSharpIsKeyword(); // The C# is keyword
>>>>>>> a701c27e51bcbd8cf4b1b023e5c026f419057ed8

            Console.ReadLine();
        }

        private static void TheCSharpIsKeyword()
        {
            //GivePromotion()
        }

        private static void TheCSharpAsKeyword()
        {
            //// Ack! You can't cast frank to a Hexagon, but this compiles fine!
            //object frank = new Manager();
            //Hexagon hex = (Hexagon)frank;

            //// Catch a possible invalid cast.
            //object frank = new Manager();
            //Hexagon hex;
            //try
            //{
            //    hex = (Hexagon)frank;
            //}
            //catch (InvalidCastException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            // Use "as" to test compatibility.
            object[] things = new object[4];
            things[0] = new Hexagon();
            things[1] = false;
            things[2] = new Manager();
            things[3] = "Last thing";

            foreach (object item in things)
            {
                Hexagon h = item as Hexagon;
                if (h == null)
                    Console.WriteLine("Item is not a hexagon");
                else
                {
                    h.Draw();
                }
            }


        }

        private static void GivePromotion(Employee emp)
        {
            //// Increase pay...
            //// Give new parking space in company garage...
            //Console.WriteLine("{0} was promoted!   > Type = {1}", emp.Name , emp.GetType().Name);

            //Console.WriteLine("{0} was promoted!", emp.Name);
            //if (emp is SalesPerson)
            //{
            //    Console.WriteLine("{0} made {1} sale(s)!", emp.Name, ((SalesPerson)emp).SalesNumber);
            //    Console.WriteLine();
            //}
            //if (emp is Manager)
            //{
            //    Console.WriteLine("{0} had {1} stock options...", emp.Name, ((Manager)emp).StockOptions);
            //    Console.WriteLine();
            //}

            #region C# 7 new feature added with is keyword

            //Console.WriteLine("{0} was promoted!", emp.Name);
            ////Check if is SalesPerson, assign to variable s
            //if (emp is SalesPerson s)
            //{
            //    Console.WriteLine("{    0} made {1} sale(s)!", emp.Name, s.SalesNumber);
            //    Console.WriteLine();
            //}
            ////Check if is Manager, if it is, assign to variable m
            //if (emp is Manager m)
            //{
            //    Console.WriteLine("{0} had {1} stock options...", emp.Name, m.StockOptions);
            //    Console.WriteLine();
            //}

            #endregion


            #region Pattern matching revisited ( new )

            Console.WriteLine("{0} was promoted!", emp.Name);
            switch (emp)
            {
                //case SalesPerson s:
                //    Console.WriteLine("{0} made {1} sale(s)!", emp.Name, s.SalesNumber);
                //    break;

                case SalesPerson s when s.SalesNumber > 3:
                    Console.WriteLine("{0} made {1} sale(s)!", emp.Name, s.SalesNumber);
                    break;

                case Manager m:
                    Console.WriteLine("{0} had {1} stock options...", emp.Name, m.StockOptions);
                    break;

                case Intern _: break;
            }
            Console.WriteLine();

            #endregion
        }

        private static void CastingExamples()
        {
            // A Manager "is-a" System.Object, so we can
            // store a Manager reference in an object variable just fine.

            object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);

            GivePromotion((Manager)frank);

            // A Manager "is-an" Employee too.
            Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);
            GivePromotion(moonUnit);

            // A PTSalesPerson "is-a" SalesPerson.
            SalesPerson jill = new PTSalesPerson("Jill", 834, 3002, 100000, "111-12-1119", 90);
            GivePromotion(jill);

        }
    }
}
