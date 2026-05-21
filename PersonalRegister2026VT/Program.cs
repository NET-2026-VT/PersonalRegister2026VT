namespace PersonalRegister2026VT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee("Kalle", 25000);
            Payroll payroll = new Payroll();

            payroll.AddEmployee("Nisse", 30000); 
        }
    }
}
