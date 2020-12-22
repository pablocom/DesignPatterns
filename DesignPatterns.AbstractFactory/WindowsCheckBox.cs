using System;

namespace DesignPatterns.AbstractFactory
{
    public class WindowsCheckBox : ICheckBox
    {
        public void Paint()
        {
            Console.WriteLine("Windows checkbox");
        }
    }
}