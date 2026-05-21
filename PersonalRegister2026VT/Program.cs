namespace PersonalRegister2026VT
{
    internal class Program
    {
        private static Payroll payroll = new Payroll();
        static void Main(string[] args)
        {
            //Employee emp = new Employee("Kalle", 25000);
            //Payroll payroll = new Payroll();
            SeedData();
            do
            {
                ShowMainMenu();
                string input = Console.ReadLine() ?? string.Empty;

                switch (input)
                {
                    case "1":
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

        private static void PrintEmployees()
        {
            List<Employee> employees = payroll.GetEmployees();
            
            foreach(Employee employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name} Salary: {employee.Salary}");
            }
        }

        private static void ShowMainMenu()
        {
            Console.WriteLine($"1.Add{Environment.NewLine}2.Print{Environment.NewLine}Q.Exit");
        }

        private static void SeedData()
        {
            payroll.AddEmployee("Nisse", 30000);
            payroll.AddEmployee("Anna", 35000);
            payroll.AddEmployee("Stig", 40000);
            payroll.AddEmployee("Stina", 45000);
            payroll.AddEmployee("Anders", 50000);
            payroll.AddEmployee("Åsa", 55000);
        }
    }
}
