namespace PersonalRegister2026VT
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public Employee(string name, int salary)
        {
            //Validate
            Name = name;
            Salary = salary; 
        }
    }
}
