namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List Initializer
            List<Employee> employees = new List<Employee>()
          {
              new OnContractEmployee() { Id=101, Name="Ajay",  ContractDate = DateTime.Now,Duration=19, Charges=10000},
              new PayrollEmployee() { Id=102, Name="Deepak",  JoiningDate =  DateTime.Parse("01/12/2020"),Exp=10, BasicSalary=10000},
             new OnContractEmployee() { Id=103, Name="Ajay",  ContractDate = DateTime.Now,Duration=19, Charges=10000},
             new PayrollEmployee() { Id=104, Name="Deepak",  JoiningDate =  DateTime.Parse("01/12/2020"),Exp=10, BasicSalary=10000}
 };
            Employee employee;
            try
            {
                Console.WriteLine("What type of Employee");
                int ch = byte.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            employee = new OnContractEmployee();
                            employee.GetDetails();
                            employees.Add(employee);
                            break;
                        }
                    case 2:
                        {
                            employee = new PayrollEmployee();
                            employee.GetDetails();
                            employees.Add(employee);
                            break;
                        }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                Console.WriteLine("List of Employees");
                for (int i = 0; i < employees.Count; i++)
                {
                    if (employees[i].GetType() == typeof(OnContractEmployee))
                        employees[i] = (OnContractEmployee)employees[i];
                    else if (employees[i].GetType() == typeof(PayrollEmployee))
                        employees[i] = (PayrollEmployee)employees[i];

                    employees[i].DisplayDetails();
                }

                Console.WriteLine("TOTAL NUMBER OF EMOLOYEES " +
                    employees.Count);
            }
            
    }
}
