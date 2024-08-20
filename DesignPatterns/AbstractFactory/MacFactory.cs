namespace DesignPatterns.AbstractFactory
{
    public class MacFactory : IUiFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new MacCheckBox();
        }
    }
}