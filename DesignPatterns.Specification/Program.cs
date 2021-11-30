using System;

namespace DesignPatterns.Specification
{
    class Program
    {
        static void Main(string[] args)
        {
            var flight = new Flight(new DateTime(2021, 1, 1, 3, 4, 5), new DateTime(2021, 1, 1));
        }
    }
}
