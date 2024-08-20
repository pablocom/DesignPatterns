namespace DesignPatterns.ChainOfResponsibility;

public sealed class LoggingMiddleware : Middleware
{
    public override Task Invoke()
    {
        Console.WriteLine("Executing middleware pipeline");
        return Next();
    }
}