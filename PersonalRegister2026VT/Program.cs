using PersonalRegister2026VT.Abstractions;
using PersonalRegister2026VT.Helpers;

namespace PersonalRegister2026VT
{
    internal class Program
    {
        private static IPayroll _payroll = new Payroll();
        private static IUI _ui = new ConsoleUI(); 
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
                string input = _ui.GetInput(); 

                switch (input)
                {
                    case MenuHelpers.Add:
                        AddEmployee();
                        break;
                    case MenuHelpers.Print:
                        PrintEmployees();
                        break;
                    case MenuHelpers.Quit:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

            } while (true);

        }

        private static void AddEmployee()
        {
            string name = Util.AskForString("Name");
            uint salary = Util.AskForUInt("Salary"); 
            _payroll.AddEmployee(name, salary);
        }

        private static void PrintEmployees()
        {
            // List<Employee> employees = payroll.GetEmployees();

            foreach (Employee employee in _payroll.GetEmployees())
            {
                _ui.Print(employee.ToString());
            }
        }

        private static void ShowMainMenu()
        {
            Console.WriteLine($"{MenuHelpers.Add}.Add{Environment.NewLine}" +
                $"{MenuHelpers.Print}.Print{Environment.NewLine}" +
                $"{MenuHelpers.Quit}.Exit");
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
