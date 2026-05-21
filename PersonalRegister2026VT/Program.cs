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

            Console.ReadKey();
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
