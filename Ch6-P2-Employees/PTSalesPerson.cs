using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_P2_Employees
{
    sealed class PTSalesPerson : SalesPerson
    {
        public PTSalesPerson(string fullName, int age, int empID, float currPay, string ssn, int numbOfSales) : base(fullName, age, empID, currPay, ssn, numbOfSales)
        {
            //Console.WriteLine(" 6 agrs ctor Part Time sales person ");
        }
        // Assume other members here...

        //public override void GiveBonus(float amount)
        //{
        //    base.GiveBonus(amount);
        //}
    }
}
