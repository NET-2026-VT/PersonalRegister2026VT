using PersonalRegister2026VT.Abstractions;

namespace PersonalRegister2026VT.UI
{
    public class ConsoleUI : IUI
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }

        public string GetInput()
        {
            return Console.ReadLine() ?? string.Empty;
        }
    }
}
