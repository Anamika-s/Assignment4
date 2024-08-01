using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ReportingManager;
        public Employee() { }
        public Employee(int id, string name,
            string ReportingManager)
        {
            this.Id = id;
            this.Name = name;
            this.ReportingManager = ReportingManager;
        }
        public virtual void GetDetails()
        {
            Console.WriteLine("enter id");
            Id = byte.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            Name = Console.ReadLine();
            Console.WriteLine("enter ReportingManager");
            ReportingManager = Console.ReadLine();
        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine("ID is " + Id);
            Console.WriteLine("name is " + Name);
            Console.WriteLine("ReportingManager is " + ReportingManager);
        }
    }
}
