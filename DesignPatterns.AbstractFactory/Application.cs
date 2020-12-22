namespace DesignPatterns.AbstractFactory
{
    public class Application
    {
        private readonly IUIFactory uiFactory;

        public Application(IUIFactory uiFactory)
        {
            this.uiFactory = uiFactory;
        }

        public void BuildUserInterface()
        {
            uiFactory.CreateButton().Paint();
            uiFactory.CreateCheckBox().Paint();
        }
    }
}