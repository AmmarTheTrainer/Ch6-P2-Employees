using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_P2_Employees
{
    class SalesPerson : Employee
    {
        public SalesPerson()
        {
            Console.WriteLine(" Default ctor SalesPerson ( child class )  ");
        }
        public int SalesNumber { get; set; }

    }
}
