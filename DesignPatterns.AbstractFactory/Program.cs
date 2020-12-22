using System;
using System.Runtime.InteropServices;

namespace DesignPatterns.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Application application;
            
            if (IsWindows())
                application = new Application(new WindowsFactory());
            else if (IsMacOS())
                application = new Application(new MacFactory());
            else
                throw new SystemException("Not supported OS for UI");
            
            application.BuildUserInterface();
        }
        
        private static bool IsWindows() =>
            RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

        private static bool IsMacOS() =>
            RuntimeInformation.IsOSPlatform(OSPlatform.OSX);

        private static bool IsLinux() =>
            RuntimeInformation.IsOSPlatform(OSPlatform.Linux);
    }
}