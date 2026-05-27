namespace PersonalRegister2026VT
{
    internal class Employee
    {
        public string Name { get; }
        public uint Salary { get; set; }

        public SalaryLevel SalaryLevel => Salary < 25000 ? SalaryLevel.Junior : SalaryLevel.Senior;
        //public SalaryLevel SalaryLevel
        //{
        //    get
        //    {
        //        if (Salary < 25000)
        //            return SalaryLevel.Junior;
        //        else
        //            return SalaryLevel.Senior;
        //    }
        //}

        public Employee(string name, uint salary)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(name); 
            Name = name;
            Salary = salary; 
        }

        public override string ToString()
        {
            return $"Name: {Name} Salary: {Salary} Salary level: {SalaryLevel}";
        }
    }
}
