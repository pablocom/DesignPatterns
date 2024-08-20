namespace DesignPatterns.ChainOfResponsibility;

public sealed class ThrottlingMiddleware : Middleware
{
    private const int MaxCalls = 10;
    
    private int _callsCount;
    
    public override Task Invoke()
    {
        _callsCount++;

        if (_callsCount > MaxCalls)
            throw new Exception("Your request has been throttled due to too many attempts.");
        
        return Next();
    }
}