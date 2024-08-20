namespace DesignPatterns.AbstractFactory;

public class Application
{
    private readonly IUiFactory _uiFactory;

    public Application(IUiFactory uiFactory)
    {
        this._uiFactory = uiFactory;
    }

    public void BuildUserInterface()
    {
        _uiFactory.CreateButton().Paint();
        _uiFactory.CreateCheckBox().Paint();
    }
}