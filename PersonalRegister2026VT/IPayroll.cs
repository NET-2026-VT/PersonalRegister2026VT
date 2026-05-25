namespace PersonalRegister2026VT
{
    internal interface IPayroll
    {
        void AddEmployee(Employee emp);
        void AddEmployee(string name, uint salary);
        IReadOnlyList<Employee> GetEmployees();
    }
}