using System;

namespace DesignPatterns.AbstractFactory
{
    public class MacCheckBox : ICheckBox
    {
        public void Paint()
        {
            Console.WriteLine("iOS checkbox");
        }
    }
}