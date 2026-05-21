namespace PersonalRegister2026VT
{
    internal class Payroll
    {
        private List<Employee> _employees;

        public Payroll()
        {
            _employees = new List<Employee>(); 
        }
        public void AddEmployee(string name, int salary)
        {
            Employee employee = new Employee(name, salary);
            _employees.Add(employee); 
        }

        public List<Employee> GetEmployees()
        {
            //ToDo: Fix this, not a good way to do it
            return _employees; 
        }
    }
}
