using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class PayrollEmployee : Employee
    {
        public DateTime JoiningDate { get; set; }
        public int Exp { get; set; }
        public double BasicSalary { get; set; }
        public double DA { get; set; }
        public double HRA { get; set; }
        public double PF { get; set; }
        public double NetSalary { get; set; }
        public PayrollEmployee() : base() { }
        public PayrollEmployee(int id, string name,
            string reportingManager,
            DateTime joiningDate,
            int exp,
            double basicSalary) :
            base(id, name, reportingManager)
        {
            JoiningDate = joiningDate;
            Exp = exp;
            BasicSalary = basicSalary;
            CalculateNetSalary();
        }
        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("enter JoiningDate");
            JoiningDate = DateTime.Now;
            Console.WriteLine("enter Exp");
            Exp = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter BasicSalary");
            BasicSalary = double.Parse(Console.ReadLine());
            CalculateNetSalary();
        }
        public override void DisplayDetails()
        {
            Console.WriteLine("PAYROLL EMPLOYEE\n*****************************");
            base.DisplayDetails();

            Console.WriteLine("JoiningDate is " + JoiningDate);
            Console.WriteLine("Exp is " + Exp);
            Console.WriteLine("BasicSalary is  " + BasicSalary);
            Console.WriteLine("DA is " + DA);
            Console.WriteLine("HRA is " + HRA);
            Console.WriteLine("PF is " + PF);
            Console.WriteLine("NET SALARY IS " + NetSalary);
        }
        void CalculateNetSalary()
        {
            if (Exp >= 10)
            {
                DA = .01 * BasicSalary;
                HRA = .85 * BasicSalary;
                PF = 6200;
            }
            else if (Exp > 7 && Exp < 10)
            {
                DA = .75 * BasicSalary;
                HRA = .85 * BasicSalary;
                PF = 6200;
            }
            NetSalary = (DA + HRA + BasicSalary) - PF;
        }
    }

}