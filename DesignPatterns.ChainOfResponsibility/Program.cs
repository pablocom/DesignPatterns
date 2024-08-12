using DesignPatterns.ChainOfResponsibility;

var chain = new ThrottlingMiddleware();
chain.UseNext(new LoggingMiddleware())
    .UseNext(new AuthenticationMiddleware());

for (int i = 0; i < 11; i++)
{
    await chain.Invoke();
}
