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

        #region Constructors




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
        #endregion

        public void method()
        {
          //  base.SocialSecurityNumber = 22;
        }


        // A salesperson's bonus is influenced by the number of sales.
        public sealed override void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if (SalesNumber >= 0 && SalesNumber <= 100)
                salesBonus = 10;
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                    salesBonus = 15;
                else
                    salesBonus = 20;
            }
            base.GiveBonus(amount * salesBonus); // call to base class function with same name
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
        }
    }
    //public class PTPTSalesPerson : PTSalesPerson
    //{

    //}
}
