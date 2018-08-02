using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_P2_Employees
{
    class SalesPerson : Employee
    {

        public int SalesNumber { get; set; }


        public SalesPerson()
        {
            Console.WriteLine(" Default ctor SalesPerson ( child class )  ");
        }
        
        // As a general rule, all subclasses should explicitly call an appropriate base class constructor.
        public SalesPerson(string fullName, int age, int empID, float currPay, string ssn, int numbOfSales) : base(fullName, age, empID, currPay, ssn)
        {
            
            // This belongs with us!
            SalesNumber = numbOfSales;
        }

        public void method()
        {
          //  base.SocialSecurityNumber = 22;
        }

    }

    sealed class PTSalesPerson : SalesPerson
    {
        public PTSalesPerson(string fullName, int age, int empID, float currPay, string ssn, int numbOfSales) : base(fullName, age, empID, currPay, ssn, numbOfSales)
        {
            Console.WriteLine(" 6 agrs ctor Part Time sales person ");
        }
        // Assume other members here...
    }

    //public class PTPTSalesPerson : PTSalesPerson
    //{

    //}
}
