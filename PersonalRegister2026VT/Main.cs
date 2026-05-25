using PersonalRegister2026VT.Abstractions;
using PersonalRegister2026VT.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalRegister2026VT
{
    internal class Main
    {
        private IUI _ui;
        private IPayroll _payroll;

        public Main(IUI ui, IPayroll payroll)
        {
            _ui = ui;
            _payroll = payroll;
        }

        public void Run()
        {

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

        private void AddEmployee()
        {
            string name = Util.AskForString("Name", _ui);
            uint salary = Util.AskForUInt("Salary", _ui);
            _payroll.AddEmployee(name, salary);
        }

        private void PrintEmployees()
        {
            // List<Employee> employees = payroll.GetEmployees();

            foreach (Employee employee in _payroll.GetEmployees())
            {
                _ui.Print(employee.ToString());
            }
        }

        private void ShowMainMenu()
        {
            Console.WriteLine($"{MenuHelpers.Add}.Add{Environment.NewLine}" +
                $"{MenuHelpers.Print}.Print{Environment.NewLine}" +
                $"{MenuHelpers.Quit}.Exit");
        }

        private void SeedData()
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
