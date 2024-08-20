using System;

namespace DesignPatterns.AbstractFactory
{
    public class WindowsButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Windows button");
        }
    }
}