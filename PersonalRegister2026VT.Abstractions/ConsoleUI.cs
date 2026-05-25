namespace PersonalRegister2026VT.Abstractions
{
    public class ConsoleUI
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
