namespace DesignPatterns.AbstractFactory
{
    public interface IUIFactory
    {
        IButton CreateButton();
        ICheckBox CreateCheckBox();
    }
}