using PersonalRegister2026VT.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalRegister2026VT.UI
{
    public class MockUI : IUI
    {
        public string GetInput()
        {
            return "1";
        }

        public void Print(string message)
        {
            
        }
    }
}
