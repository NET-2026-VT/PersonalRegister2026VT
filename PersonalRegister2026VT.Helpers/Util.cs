using PersonalRegister2026VT.Abstractions;
using System.Formats.Asn1;

namespace PersonalRegister2026VT.Helpers
{
    public static class Util
    {
        public static string AskForString(string prompt, IUI ui, Predicate<string>? validate = null )
        {
            string answer;
            bool success = false;
            do
            {
                ui.Print($"{prompt}: ");
                answer = ui.GetInput();

                if (string.IsNullOrWhiteSpace(answer))
                    ui.Print($"You must enter a valid {prompt}");
                if(validate != null && !validate(answer))
                {
                    ui.Print($"You must enter a valid {prompt}");
                }
                else
                    success = true;

            } while (!success);

            return answer; 
        }

        public static uint AskForUInt(string prompt, IUI ui, uint? min = null, uint? max = null)
        {
            return uint.Parse(AskForString(prompt, ui, (input) =>
            {
                if (!uint.TryParse(input, out uint result))
                    return false;

                if(min.HasValue && result < min.Value)
                    return false;

                if (max.HasValue && result > max.Value)
                    return false;

                return true;
            }));
        }
    }
}
