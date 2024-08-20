namespace DesignPatterns.AbstractFactory
{
    public interface IUiFactory
    {
        IButton CreateButton();
        ICheckBox CreateCheckBox();
    }
}