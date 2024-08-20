namespace DesignPatterns.ChainOfResponsibility;

public abstract class Middleware
{
    private Middleware? _next;
    
    public Middleware UseNext(Middleware handler)
    {
        _next = handler;
        return _next;
    }

    public abstract Task Invoke();

    protected async Task Next()
    {
        if (_next is null)
            return;
        
        await _next.Invoke();
    }
}