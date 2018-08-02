using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_P2_Employees
{
    partial class Employee
    {
        public class BenefitPackage
        {
            public enum BenefitPackageLevel
            {
                Standard, Gold, Platinum
            }
            // Assume we have other members that represent
            // dental/health benefits, and so on.
            public double ComputePayDeduction()
            {
                return 125.0;
            }
        }
    }
}
