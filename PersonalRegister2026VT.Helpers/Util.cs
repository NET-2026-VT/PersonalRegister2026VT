using System.Formats.Asn1;

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

        public static uint AskForUInt(string prompt)
        {
            do
            {
                string input = AskForString(prompt);

                if(uint.TryParse(input, out uint result))
                {                    
                    return result;
                }
                else
                {
                    //Write error message if something goes wrong
                    Console.WriteLine($"Not a valid {prompt}");
                }

            } while (true);
        }
    }
}
