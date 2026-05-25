using PersonalRegister2026VT.Abstractions;
using System.Formats.Asn1;

namespace PersonalRegister2026VT.Helpers
{
    public static class Util
    {
        public static string AskForString(string prompt, IUI ui )
        {
            string answer;
            bool success = false;
            do
            {
                ui.Print($"{prompt}: ");
                answer = ui.GetInput();

                if (string.IsNullOrWhiteSpace(answer))
                    ui.Print($"You must enter a valid {prompt}");
                else
                    success = true;

            } while (!success);

            return answer; 
        }

        public static uint AskForUInt(string prompt, IUI ui)
        {
            do
            {
                string input = AskForString(prompt, ui);

                if(uint.TryParse(input, out uint result))
                {                    
                    return result;
                }
                else
                {
                    //Write error message if something goes wrong
                    ui.Print($"Not a valid {prompt}");
                }

            } while (true);
        }
    }
}
