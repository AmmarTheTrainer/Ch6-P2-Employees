using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch6_P2_Employees
{
    partial class Employee
    {
        //// Field data.
        //private string empName;
        //private int empID;
        //private float currPay;
        //private int empAge;
        //private string empSSN; // Read Only

        // Derived classes can now directly access this information.
        protected string empName;
        protected int empID;
        protected float currPay;
        protected int empAge;
        protected string empSSN; // read only

        // Contain a BenefitPackage object.
        protected BenefitPackage empBenefits = new BenefitPackage();

        // Expose certain benefit behaviors of object.
        public double GetBenefitCost()
        {
            return empBenefits.ComputePayDeduction();
        }
        // Expose object through a custom property.
        public BenefitPackage Benefits
        {
            get { return empBenefits; }
            set { empBenefits = value; }
        }

        #region Constructors


        // Constructors.
        public Employee()
        {
            Console.WriteLine(" Default ctor Employee ( parent class )  ");
        }
        public Employee(string name, int id, float pay) : this(name, 0, id, pay){}
        public Employee(string name, int age, int id, float pay)
        {
            Console.WriteLine(" 4 arguement constructor base class ");
            empName = name;
            empID = id;
            empAge = age;
            currPay = pay;
        }

        //public Employee(string name, int age, int id, float pay, string ssn)
        //{
        //    Name = name;
        //    Age = age;
        //    ID = id;
        //    Pay = pay;
        //    // OOPS! This is no longer possible if the property is read only.
        //    //SocialSecurityNumber = ssn;
        //}

        // Add to the Employee base class.
        public Employee(string name, int age, int id, float pay, string ssn) : this(name, age, id, pay)
        {
            Console.WriteLine(" 5 argument constructor base class ");
            empSSN = ssn;
        }

        #endregion

        #region Properties


        // Properties!
        public int Age
        {
            get { return empAge; }
            set => empAge = value;
        }
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                else
                    empName = value;
            }
        }
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        public string SocialSecurityNumber
        {
            get { return empSSN; }
        }

        #endregion

        // Accessor (get method).
        public string GetName()
        {
            return empName;
        }
        // Mutator (set method).
        public void SetName(string name)
        {
            // Do a check on incoming value
            // before making assignment.
            if (name.Length > 15)
                Console.WriteLine("Error! Name length exceeds 15 characters!");
            else
                empName = name;
        }


        // Methods.
        public void GiveBonus(float amount)
        {
            Pay += amount;
            //currPay += amount; // Not recommended
        }
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Age: {0}", empAge);
            Console.WriteLine("Pay: {0}", currPay);
        }
    }
}
