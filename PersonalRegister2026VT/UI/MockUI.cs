using PersonalRegister2026VT.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalRegister2026VT.UI
{
    public class MockUI : IUI
    {
        public string SetInput { private get; set; } = "1"; 
        public string GetInput()
        {
            return SetInput;
        }

        public void Print(string message)
        {
            
        }
    }
}
