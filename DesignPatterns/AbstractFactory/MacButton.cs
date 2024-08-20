using System;

namespace DesignPatterns.AbstractFactory
{
    public class MacButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("iOS button");
        }
    }
}