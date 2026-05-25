using PersonalRegister2026VT.Abstractions;
using PersonalRegister2026VT.Helpers;

namespace PersonalRegister2026VT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPayroll payroll = new Payroll();
            IUI ui = new ConsoleUI();
            Main main = new Main(ui, payroll);
            main.Run(); 
        }

        
    }
}
