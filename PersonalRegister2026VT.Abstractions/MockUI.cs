using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalRegister2026VT.Abstractions
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
