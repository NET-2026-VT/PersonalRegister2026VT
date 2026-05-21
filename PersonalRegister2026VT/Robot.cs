namespace PersonalRegister2026VT
{
    internal class Robot
    {
        private string _name;

        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                    _age = 0;
                else
                _age = value;
            }
        }

        //public int Salary { get; private set; }
        public int Salary { get;}


        public Robot(string name, int age, int salary)
        {
            _name = name;
            Age = age;
            Salary = salary; 
        }

        public void SetSalary(int salary)
        {
            //Salary = salary; 
        }

        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            //Validation
            _name = name;
        }
    }
}