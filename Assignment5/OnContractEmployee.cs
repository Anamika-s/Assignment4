using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class OnContractEmployee : Employee
    {
        public DateTime ContractDate { get; set; }
        public int Duration { get; set; }
        public int Charges { get; set; }
        public OnContractEmployee() : base() { }
        public OnContractEmployee(int id, string name,
            string reportingManager,
            DateTime contractDate,
            int duration,
            int charges) :
            base(id, name, reportingManager)
        {
            ContractDate = contractDate;
            Duration = duration;
            Charges = charges;
        }
        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("enter ContractDate");
            ContractDate = DateTime.Now;
            Console.WriteLine("enter duration");
            Duration = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter charges");
            Charges = byte.Parse(Console.ReadLine());
        }
        public override void DisplayDetails()
        {

            Console.WriteLine("ONCONTRACT EMPLOYEE\n*****************************");
            base.DisplayDetails();
            Console.WriteLine("ContractDate is " + ContractDate);
            Console.WriteLine("Duration is " + Duration);
            Console.WriteLine("Charges are  " + Charges);
        }
    }
}

