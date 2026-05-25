namespace PersonalRegister2026VT
{
    internal class Employee
    {
        public string Name { get; }
        public int Salary { get; set; }

        public Employee(string name, int salary)
        {
            //Validate
            Name = name;
            Salary = salary; 
        }

        public override string ToString()
        {
            return $"Name: {Name} Salary: {Salary}";
        }
    }
}
