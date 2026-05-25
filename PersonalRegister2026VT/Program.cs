using PersonalRegister2026VT.Helpers;

namespace PersonalRegister2026VT
{
    internal class Program
    {
        private static Payroll _payroll = new Payroll();
        static void Main(string[] args)
        {
            #region reference_type_demo
            //Payroll payroll = new Payroll();
            //Employee emp = new Employee("Kalle", 25000);
            //payroll.AddEmployee(emp);

            //var employees = payroll.GetEmployees();

            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine($"Name: {employee.Name} Salary: {employee.Salary}");
            //}

            //employees.Add(emp);

            //List<Employee> employees2 = payroll.GetEmployees();

            //foreach (Employee employee in employees2)
            //{
            //    Console.WriteLine($"Name: {employee.Name} Salary: {employee.Salary}");
            //}

            //Console.ReadLine();
            #endregion



            SeedData();
            do
            {
                ShowMainMenu();
                string input = Console.ReadLine() ?? string.Empty;

                switch (input)
                {
                    case "1":
                        AddEmployee();
                        break;
                    case "2":
                        PrintEmployees();
                        break;
                    case "Q":
                        break;
                    default:
                        break;
                }

            } while (true);

        }

        private static void AddEmployee()
        {
            string name = Util.AskForString("Name");
            _payroll.AddEmployee(name, 10);
        }

        private static void PrintEmployees()
        {
            // List<Employee> employees = payroll.GetEmployees();

            foreach (Employee employee in _payroll.GetEmployees())
            {
                Console.WriteLine(employee);
            }
        }

        private static void ShowMainMenu()
        {
            Console.WriteLine($"1.Add{Environment.NewLine}2.Print{Environment.NewLine}Q.Exit");
        }

        private static void SeedData()
        {
            _payroll.AddEmployee("Nisse", 30000);
            _payroll.AddEmployee("Anna", 35000);
            _payroll.AddEmployee("Stig", 40000);
            _payroll.AddEmployee("Stina", 45000);
            _payroll.AddEmployee("Anders", 50000);
            _payroll.AddEmployee("Åsa", 55000);
        }
    }
}
