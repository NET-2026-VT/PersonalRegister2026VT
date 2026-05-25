namespace PersonalRegister2026VT
{
    internal class Payroll
    {
        private List<Employee> _employees;

        public Payroll()
        {
            _employees = new List<Employee>(); 
        }
        public void AddEmployee(string name, uint salary)
        {
            Employee employee = new Employee(name, salary);
            _employees.Add(employee); 
        }
        internal void AddEmployee(Employee emp)
        {
            _employees.Add(emp);
        }

        public IReadOnlyList<Employee> GetEmployees()
        {
            return _employees.AsReadOnly(); 
        }

    }
}
