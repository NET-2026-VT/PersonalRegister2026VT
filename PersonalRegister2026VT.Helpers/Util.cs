namespace PersonalRegister2026VT.Helpers
{
    public static class Util
    {
        public static string AskForString(string prompt)
        {
            string answer;
            bool success = false;
            do
            {
                Console.Write($"{prompt}: ");
                answer = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(answer))
                    Console.WriteLine($"You must enter a valid {prompt}");
                else
                    success = true;

            } while (!success);

            return answer; 
        }
    }
}
