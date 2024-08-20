namespace DesignPatterns.ChainOfResponsibility;

public sealed class AuthenticationMiddleware : Middleware
{
    public override Task Invoke()
    {
        // If is unauthorized, return early an authorization error.
        return Next();
    }
}