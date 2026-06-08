using PersonalRegister2026VT.Abstractions;
using PersonalRegister2026VT.Helpers;
using PersonalRegister2026VT.UI;

namespace PersonalRegister2026VT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPayroll payroll = new Payroll();
            IUI ui = new ConsoleUI();

            var res = Util.AskForString("Test", ui, s =>
            {
                //..
                //..
                //..
                return s.Length > 5;
            });

            var res2 = Util.AskForString("trsfd", ui);

            var res3 = Util.AskForUInt("", ui, min:  3, max: 6);
            Main main = new Main(ui, payroll);
            main.Run(); 
        }

        
    }
}
